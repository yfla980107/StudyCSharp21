
namespace UsingControlsApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.Chkltalic = new System.Windows.Forms.CheckBox();
            this.CboFont = new System.Windows.Forms.ComboBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBar = new System.Windows.Forms.GroupBox();
            this.TrbHandle = new System.Windows.Forms.TrackBar();
            this.PrdDisplay = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.GrpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtResult);
            this.groupBox1.Controls.Add(this.Chkltalic);
            this.groupBox1.Controls.Add(this.CboFont);
            this.groupBox1.Controls.Add(this.ChkBold);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox ";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(14, 63);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(388, 21);
            this.TxtResult.TabIndex = 7;
            // 
            // Chkltalic
            // 
            this.Chkltalic.AutoSize = true;
            this.Chkltalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Chkltalic.Location = new System.Drawing.Point(342, 30);
            this.Chkltalic.Name = "Chkltalic";
            this.Chkltalic.Size = new System.Drawing.Size(60, 16);
            this.Chkltalic.TabIndex = 6;
            this.Chkltalic.Text = "이탤릭";
            this.Chkltalic.UseVisualStyleBackColor = true;
            this.Chkltalic.CheckedChanged += new System.EventHandler(this.Chkltalic_CheckedChanged);
            // 
            // CboFont
            // 
            this.CboFont.FormattingEnabled = true;
            this.CboFont.Location = new System.Drawing.Point(55, 28);
            this.CboFont.Name = "CboFont";
            this.CboFont.Size = new System.Drawing.Size(218, 20);
            this.CboFont.TabIndex = 5;
            this.CboFont.SelectedIndexChanged += new System.EventHandler(this.CboFont_SelectedIndexChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkBold.Location = new System.Drawing.Point(286, 30);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(50, 16);
            this.ChkBold.TabIndex = 4;
            this.ChkBold.Text = "굶게";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Font :";
            // 
            // GrpBar
            // 
            this.GrpBar.Controls.Add(this.PrdDisplay);
            this.GrpBar.Controls.Add(this.TrbHandle);
            this.GrpBar.Location = new System.Drawing.Point(13, 116);
            this.GrpBar.Name = "GrpBar";
            this.GrpBar.Size = new System.Drawing.Size(420, 116);
            this.GrpBar.TabIndex = 1;
            this.GrpBar.TabStop = false;
            this.GrpBar.Text = "TrackBar _ProgressBar";
            // 
            // TrbHandle
            // 
            this.TrbHandle.Location = new System.Drawing.Point(13, 22);
            this.TrbHandle.Maximum = 20;
            this.TrbHandle.Name = "TrbHandle";
            this.TrbHandle.Size = new System.Drawing.Size(388, 45);
            this.TrbHandle.TabIndex = 0;
            this.TrbHandle.Scroll += new System.EventHandler(this.TrbHandle_Scroll);
            // 
            // PrdDisplay
            // 
            this.PrdDisplay.Location = new System.Drawing.Point(13, 73);
            this.PrdDisplay.Maximum = 20;
            this.PrdDisplay.Name = "PrdDisplay";
            this.PrdDisplay.Size = new System.Drawing.Size(388, 23);
            this.PrdDisplay.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 335);
            this.Controls.Add(this.GrpBar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Using Control App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpBar.ResumeLayout(false);
            this.GrpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox Chkltalic;
        private System.Windows.Forms.ComboBox CboFont;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpBar;
        private System.Windows.Forms.ProgressBar PrdDisplay;
        private System.Windows.Forms.TrackBar TrbHandle;
    }
}

