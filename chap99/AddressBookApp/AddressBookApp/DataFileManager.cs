using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{
    class DataFileManager
    {
        // 텍스트 파일에서 저장된 주소록을 불러온다(로드)
        const string dataFileName = "address.dat";

        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; //데이터파일

            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)); // Open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                // temp 잘라서 listResult 할당
                var splits = temp.Split("|"); // |가 있을때마다 자름
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });// 자른 데이터들을 차례대로 삽입
            }
            sr.Close();

            return listResult;
        }

        public void WriteData(List<AddressInfo> list)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; //데이터파일

            //주소록을 다시 파일에 씀
            var sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}
