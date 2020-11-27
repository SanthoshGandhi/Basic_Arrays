using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_products1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a =new int[] {6,7,3,2,1};
            Console.WriteLine(indexArray(a));
        }
        public static int[] arrayint(int maxArraysize, int maxvalue)
        {
            int minarrayvalue=0;
            int maxvaluerange=0;
            Random random = new Random();
            int arraysize = random.Next(2, maxArraysize);
            int[] myarray = new int[arraysize];
            for (int i = 0; i < arraysize; i++)
            {
                myarray[i] = random.Next(minarrayvalue, maxvaluerange);
            }
            return myarray;
        }
        public static int mainArray(int[] MA)
        {
            int maxproduct = 0;
            for (int i = 0; i < MA.Length; i++)
            {
                for (int j = 0;j < MA.Length; j++)
                {
                    if (i != j)
                    {
                        if (MA[i] * MA[j] > maxproduct)
                        {
                            maxproduct = MA[i] * MA[j];
                        }
                    }
                }
            }
            return maxproduct;
        }
        public static int indexArray(int[] MA)
        {
            int largeproduct=0 ;
            int large=0;
            int SecondLarge = 0;
            int maxindex1 = 0;
            //int maxindex2 = -1;
            //int maxproduct = 0;
            for (int i = 0; i < MA.Length; i++)
            {
                if (MA[i]>large)
                {
                    large = MA[i];
                    maxindex1 = i;
                }
            }
            for (int j = 0; j < MA.Length; j++)
            {

                if (j != maxindex1)
                {
                    //largeproduct = large * MA[j];
                    if (MA[j] > SecondLarge)
                    {
                        SecondLarge = MA[j];
                    }
                }
                largeproduct = SecondLarge * large;
            }
            return largeproduct;
        }
    }
}
