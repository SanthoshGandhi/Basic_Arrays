using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unsorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int size = getinteger("enter the size :");
            //int N = getinteger("enter the array size:");
            //int K = getinteger("enter the K:");
            //int[] ans = copy_array(N);
            //Console.WriteLine(ans);
           
            //#region question.2.
            //for (int i = 0; i < ans.Length; i++)
            //{
            //    Console.Write(ans[i]+"\t");
            //}
            //Console.WriteLine();

            //#endregion
            
            //int k=10;
            int[] arr = { 9,3,5,7,9};
            //print_elements(arr, 6);
            //print_reverse(arr, 0,5);
            //print_odd_location(arr);
            //print_Even_location(arr);
            //start_k(arr, k);
            //copy_array(k, arr);
            //index_value(arr);
            //sub_0(arr);
            //sum_of_elements(arr);
            //sum_of_odd(arr);
            //sum_of_even(arr);
            //sum_of_odd_and_even(arr);
            //mean(arr);
            //non_zero_elements(arr);
            //positive_elements(arr);
            //negative_elements(arr);
            //pos_neg_equal(arr);
            //mean_zero_elements(arr);
            //odd_number(arr);
            //positive_number(arr);
            //perfect_square_number(arr);
            //prime_number(arr);
            array_copy(arr);




        }
        public static bool isprime(int n)
        {
            int prime_count = 0;
            for (int i = 2; i <= (n / 2); i++)
            {
                if (n % i == 0)
                {
                    prime_count++;
                }

            }
            if (prime_count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static int getinteger(string message)
        {
            Console.WriteLine("********Getting user Input*******");
            Console.WriteLine(message + " :");
            int num;
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                return getinteger("please enter the valid number :");
            }
            return num;
        }
        public static string getstring(string message)
        {
            Console.WriteLine("*********GettingInput*********");
            Console.WriteLine();
            Console.WriteLine(message + ",");
            string tempstring = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tempstring))
            {
                tempstring = getstring("Please enter valid text");

            }
            return tempstring;


        }

        public static void demo_array()
        {
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
        }

        public static void print_elements(int[] Get_array,int A)
        {
             
            string x = "";
            for (int i = 0; i < Get_array.Length; i++)
            {
                x += Get_array[i] + "\t";
            }
            Console.WriteLine("array elements :" +x);
        }

        public static void print_reverse(int[] rev_arr,int first,int last)
        {
            int temp;
            while (first < last)
            {
                temp = rev_arr[first];
                rev_arr[first] = rev_arr[last];
                rev_arr[last]=temp;
                first++;
                last--;
            }
            Console.WriteLine("the reverse elemnts are :\n");
            print_elements(rev_arr, 6);
           
        }

        public static void print_odd_location(int[] OddIndex)
        {
            for (int i = 0; i < OddIndex.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(OddIndex[i]);
                }
            }
        }

        public static void print_Even_location(int[] EvenIndex)
        {
            for (int i = 0; i < EvenIndex.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(EvenIndex[i]);
                }
            }
        }

        public static void print_k(int[] OddIndex,int k)
        {
            string x = "";
            for (int i = 0; i < k; i++)
            {
                x = x + OddIndex[i]+"\t";
            }
            Console.WriteLine(x);
        }

        public static void start_k(int[] OddIndex, int k)
        {
            string x = "";
            for (int i = k; i < OddIndex.Length; i++)
            {
                x = x + OddIndex[i] + "\t";
            }
            Console.WriteLine(x);
        }

        public static int[] N_And_k(int N, int k)
        {
            string x = "";
            int[] newarray = new int[N];
            for (int i = 0; i < newarray.Length;i++)
            {
                newarray[i] = k;
                x = x + newarray[i] + "\t";
            }
            Console.WriteLine(x);
            return newarray;
        }

        public static int[] N_elements_Q2( int n)
        {
            //string x = "";
            int[] newarray = new int[n];
            for (int i = 0; i < newarray.Length; i++)
            {
                Console.WriteLine("enter the element{0}:",i);
                newarray[i] = Convert.ToInt32(Console.ReadLine());
                //x = x + newarray[j] + "\t";
            }
            
            //Console.WriteLine(x);
            return newarray;
        }

        public static int[] m_to_n(int value,int m, int n)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int size = random.Next(2,100);
            int[] myarray = new int[size];
            for (int i = 0; i < size; i++)
            {
                myarray[i] = random.Next(0, value);
            }
            return myarray;
        }

        public static void copy_array(int size,int[] copy)
        {
            string x = "";
            int[] newarray = new int[size];
            for (int i = 0; i < newarray.Length; i++)
            {
                newarray[i] = copy[i];
                x = x + copy[i] + "\t";
                
            }
            Console.WriteLine(x);
            //Console.WriteLine(copy);            
        }

        public static void index_value(int[] array)
        {
            string x = "";
            for (int i = 0; i < array.Length; i++)
            {
                x = x + array[i] + "\t";
                Console.WriteLine("Index {0} of number is {1}", i,array[i]);
            }
            
            Console.WriteLine(x);
        }

        //public static void sub_0(int[] array)
        //{
        //    int i,j;
        //    int[] arr= array;
        //    string x = "";
        //    string y = "";
        //    for ( i = 0; i < arr.Length; i++)
        //    {
        //        x = x + arr[i]+"\t";
        //        break;
        //    }
        //    Console.WriteLine(x);
        //    for (j = 0; j < array.Length; j++)
        //    {
        //        y = y + arr[i] - array[j];
        //    }
        //}

        public static void sum_of_elements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                    sum += array[i];
            }
            Console.WriteLine(sum);
        }

        public static void sum_of_odd(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
               
                if (i % 2 != 0)
                {
                    sum += array[i];
                    
                }
            }
            Console.WriteLine(sum);
        }

        public static void sum_of_even(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (i % 2 == 0)
                {
                    sum += array[i];

                }
            }
            Console.WriteLine(sum);
        }

        public static void sum_of_odd_and_even(int[] array)
        {
            int odd = 0;
            int even = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (i % 2 != 0)
                {
                    odd += array[i];

                }
            }
            for (int j = 0; j < array.Length; j++)
            {

                if (j % 2 == 0)
                {
                    even += array[j];

                }
            }
            if (odd == even)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }

        public static void mean(int[] array)
        {
            int sum=0;
            int count = 0;
            int ans = 0;
            for (int i = 0; i < array.Length; i++)
            {
                                
                    sum += array[i];

                
                count++;
            }
            ans = sum / count;
            Console.WriteLine("the mean of array is :" +ans);
        }

        public static void non_zero_elements(int[] array)
        {
            int count=0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void positive_elements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void negative_elements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void pos_neg_equal(int[] array)
        {
            int count_positive=0;
            int count_negative = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] >= 0)
                {
                    count_positive++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < 0)
                {
                    count_negative++;
                }
            }
            if (count_positive == count_negative)
            {
                Console.WriteLine("Counts are equal.");
            }
            else
            {
                Console.WriteLine("Counts are not equal.");
            }
        }

        public static void mean_zero_elements(int[] array)
        {
            int sum = 0;
            int count = 0;
            int ans = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    sum += array[i];
                    count++;
                }

                
            }
            ans = sum/count;
            Console.WriteLine("the mean of array is :" + ans);
        }

        public static void odd_number(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("the numberr of odd number is : "+count);
        }

        public static void positive_number(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("the numberr of odd number is : " + count);
        }

        public static void perfect_square_number(int[] array)
        {
                int count = 0;
                for (int j = 1; j * j <= array.Length; j++)
                {
                    if (array[j] % j == 0 && array[j] / j == j)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
        }

        public static void prime_number(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (isprime(array[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        
        }

        //public static void array_copy(int[] array)
        //{
        //    int[] copy = array;
        //    Console.WriteLine(copy[]);

        //}
    }
}
