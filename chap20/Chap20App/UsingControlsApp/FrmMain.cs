using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsingControlsApp.Properties;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        Random random = new Random(37);
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 이벤트핸들러 영역
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);
            }
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();

        }

        private void Chkltalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();

        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrdDisplay.Value = TrbHandle.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            // Modal창은 모달창이 열렸을 때 기존의 창을 사용하지 못하는 방식
            Form frm = new Form
            {
                Text = "Modal Form",
                Width = 300,
                Height = 100,
                BackColor = Color.Coral
            };
            frm.ShowDialog(); //Modal 창을 띄움
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            //Modaless창은 창이 켜 있어도 다른 작업이 가능한 방식
            Form frm = new Form
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 100,
                BackColor = Color.GreenYellow
            };
            frm.Show(); //Modaless 창을 띄움
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //Modal창 메세지박스
            MessageBox.Show(TxtResult.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void BtnAddRoot_Click(object sender, EventArgs e) // 루트 노드 생성
        {
            TrvDummy.Nodes.Add(random.Next().ToString());

            DisplayTreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e) // 상위노드에 하위노드를 생성
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();

            DisplayTreeToList();
        }

        #endregion

        #region 사용자메서드 영역
        private void ChangeFont() // 콤보박스, 체크박스 값변경으로 글자체 변경 메서드
        {
            if (CboFont.SelectedIndex < 0) return; // 콤보박스에 아무것도 선택안했으면(-1) 메서드 탈출

            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; // 0000 0001
            if (Chkltalic.Checked) style |= FontStyle.Italic; // 0000 0010
            // 0000 0001 | 0000 0010 = 0000 0011 = Bold + Italic

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        // 트리뷰 내용 리스트뷰에 표시
        private void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }

        private void DisplayTreeToList(TreeNode node)
        {
            LsvDummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath }));

            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item); //재귀호출
            }
        }
        #endregion
    }
}
