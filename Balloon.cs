using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_question_one1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example.
            //int green = 1;
            //int purple = 9;
            //int sumA = 0;
            //int sumB = 0;
            //int ans1 = 0;
            //int ans2 = 0;
            //int total = 0;
            //int[] A = new int[10] { 0, 0, 0, 0, 1 ,0, 0, 0, 0, 0 };
            //int[] B = new int[10] { 1, 0, 0, 1, 0, 1, 1, 0, 1, 0 };
            //for (int i = 0; i < A.Length; i++)
            //{
            //    sumA += A[i];
            //}
            //for (int j = 0; j < B.Length; j++)
            //{
            //    sumB += B[j];
            //}
            ////
            //int small_value
            //if (sumA < sumB)
            //{

            //    ans1 = sumA * purple;

            //}
            //else
            //{
            //    ans2 = sumB * purple;
            //}
            //if (sumA > sumB)
            //{

            //    ans1 = sumA * green;

            //}
            //else
            //{
            //    ans2 = sumB * green;
            //}
            //total = ans1 + ans2;
            ////Console.WriteLine("");
            //Console.WriteLine("Total cost for balloon is : " + total);
            #endregion


            #region
            int ans1 = 0;
            int ans2 = 0;
            int sumA = 0;
            int sumB = 0;
            Console.WriteLine("Enter the number of Test Cases :");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Enter the green Balloon value : ");
                int green = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the purple Balloon value :");
                int purple = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the count of participants :");
                int participants = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("If a participant win Enter 1 or lose enter 0.");
                for (int j = 1; j <= participants; j++)
                {
                    Console.WriteLine("Enter the mark for participant {0} :", j);
                    Console.WriteLine("Enter the A value : ");
                    int A = Convert.ToInt32(Console.ReadLine());
                    sumA += A;
                    Console.WriteLine("Enter the B value : ");
                    int B = Convert.ToInt32(Console.ReadLine());
                    sumB += B;
                }
                int small_value = small(green, purple);
                int large_value = large(green, purple);

                if (sumA < sumB)
                {

                    ans1 = sumA * large_value;

                }
                else
                {
                    ans2 = sumB * large_value;
                }
                if (sumA > sumB)
                {

                    ans1 = sumA * small_value;

                }
                else
                {
                    ans2 = sumB * small_value;
                }
                int total = ans1 + ans2;
                Console.WriteLine(sumA);
                Console.WriteLine(sumB);
                Console.WriteLine(large_value);
                Console.WriteLine(small_value);

                Console.WriteLine(total);
            }
            #endregion

            //Console.WriteLine("enter the tests: ");
            //int t = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the count");
            //int participant = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the green color ballon value :");
            //int green = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the purple color balloon value :");
            //int purple = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(balloon(participant,green,purple));

        }


        public static int small(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int large(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //public static int balloon(int n,int green,int purple)
        //{
        //    int sumA = 0;
        //    int sumB = 0;
        //    int ans1 = 0;
        //    int ans2 = 0;
        //    int total = 0;
        //    int[] myarray = new int[n];
        //    int[] myarray1 = new int[n];
        //    //for (int i = 0; i < t; i++)
        //    //{
        //        for (int j = 1; j <= myarray.Length; j++)
        //        {
        //            Console.WriteLine("If a participant win Enter 1 or lose enter 0.");
        //            Console.WriteLine("Enter the mark for participant {0} :", j);
        //            Console.WriteLine("Enter the A value : ");
        //            j = Convert.ToInt32(Console.ReadLine());
        //            sumA += myarray[j];
                   
        //        }
        //        for (int k = 1; k <= myarray1.Length; k++)
        //        {
        //            Console.WriteLine("Enter the green Balloon value : ");
        //            int green_balloon = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Enter the purple Balloon value :");
        //            int purple_balloon = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Enter the count of participants :");
        //            int participants = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("If a participant win Enter 1 or lose enter 0.");

        //            Console.WriteLine("Enter the mark for participant {0} :", k);
        //            Console.WriteLine("Enter the A value : ");
        //            k = Convert.ToInt32(Console.ReadLine());
        //            sumB += myarray[k];
        //        }
        //    //}
        //    int small_value=small(green,purple);
        //    if (sumA < sumB)
        //    {

        //        ans1 = sumA * purple;

        //    }
        //    else
        //    {
        //        ans2 = sumB * purple;
        //    }
        //    if (sumA > sumB)
        //    {

        //        ans1 = sumA * green;

        //    }
        //    else
        //    {
        //        ans2 = sumB * green;
        //    }
        //    total = ans1 + ans2;
        //    //Console.WriteLine("");
        //    Console.WriteLine("Total cost for balloon is : " + total);
        //    return 0;
        //}











    }
}
