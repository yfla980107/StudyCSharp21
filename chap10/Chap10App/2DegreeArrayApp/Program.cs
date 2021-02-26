using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DegreeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] //제일 간단한 2차원 배열 선언방법
            { { 1, 2, 3 }
           ,{ 4, 5, 6 } };
            /*arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;*/

            
            for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) 2차원 배열 행의 값
            {
                for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) 2차원 배열 열의 값
                {
                    Console.Write($"[{i}, {j}] : {arr[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
