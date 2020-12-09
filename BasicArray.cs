using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //one Dimension Array or 1D array
            int[] sample = new int[5] { 1, 2, 3, 4, 5 };
            int sum = 0;
            string x = "";
            for (int i = 0; i < sample.Length; i++)
            {
                sum += sample[i];
                x += sample[i] + "\t";
            }
            Console.WriteLine("array elements : "+x);
            Console.WriteLine(string.Format("the sum of the arrays are:{0}",sum));

            //Two Dimension Array or 2D array
            int[,] sample1 = new int[2, 5] { { 1, 1, 1, 1, 1 }, {1, 1, 1, 1, 1} };
            int sum1 = 0;
            string x1 = "";
            for (int i = 0; i < sample1.GetLength(0); i++)
            {
                for (int j = 0; j < sample1.GetLength(1); j++)
                {
                    sum1 += sample1[i, j];
                    x1 += sample1[i, j] + "\t";
                }    
            }
            Console.WriteLine("array elements :" + x1);
            Console.WriteLine(string.Format("the sumz of the array are:{0}", sum1));

            
            //Jagged Array
            
            int[][] sample2 = new int[3][];
            sample2[0] = new int[4] { 1, 2, 3, 4 };
            sample2[1] = new int[3] { 5, 6, 7 };
            sample2[2] = new int[2] {8,9};
            
            int sum2 = 0;
            string x2 = "";
            for (int i = 0; i < sample2.Length; i++)
            {
                for (int j = 0; j < sample2[i].Length; j++)
                {
                    sum2 += sample2[i][j];
                    x2 += sample2[i][j]+"\t";
                }
                x2 += "\n";
            }
            Console.WriteLine("arrage elements :"+x2);
            Console.WriteLine(string.Format("the sum of arrays are : {0}",sum2));


        }
    }
}
