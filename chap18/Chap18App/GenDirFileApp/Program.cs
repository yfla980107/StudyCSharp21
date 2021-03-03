using System;
using System.IO;

namespace GenDirFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = "D:\\GitRepository\\StudyCSharp21\\SampleDir"; // 폴더/파일 생성 테스트 폴더
            string strTargetDir = "SubFolder"; //생성할 폴더명
            string strTargetFile = "readme.txt"; //생성할 파일명

            string targetPath = strDir + "\\" + strTargetDir; //SampleDir끝에 \가 존재하지 않는 경우 "\\" 필요
            //string targetPath = $"{strDir}\\{strTargetDir}"; 위 코드와 똑같은 결과 출력

            if (Directory.Exists(targetPath))
            {
                Console.WriteLine("이미 폴더가 존재합니다.");
            }
            else
            {
                Directory.CreateDirectory(targetPath); //폴더가 없으면 폴더 생성
                Console.WriteLine("폴더 생성 성공!");
            }

            targetPath += $"\\{strTargetFile}";

            if (File.Exists(targetPath))
            {
                Console.WriteLine("파일이 존재합니다.");
            }
            else
            {
                File.Create(targetPath).Close(); // 파일이 없으면 파일 생성
                Console.WriteLine("파일 생성 성공!");
            }
            
        }
    }
}
