using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> outerList = new List<List<int>>
            {   new List<int>(){3},
                new List<int>(){11, 2, 4},
                new List<int>(){4,5, 6},
                new List<int>(){10,8 ,-12}
            };
            //var data = outerList.Count();
            //DateTime time = DateTime.ParseExact();

            Console.WriteLine(diagonalDifference(outerList));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sizes = arr[0][0];
            int pointerL = 0;
            int pointerR = sizes - 1;
            int diagonalValue = 0;
            int secDiagonalValue = 0;

            for (int i = 1; i < arr[0][0] + 1; i++)
            {
                diagonalValue += arr[i][pointerL];
                secDiagonalValue += arr[i][pointerR];

                pointerL++;
                pointerR--;
            }

            int result = Math.Abs(diagonalValue - secDiagonalValue);

            return result;
        }
    }
}
