using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindValueReturnIndex(10));
           
        }
         public static int FindValueReturnIndex(int n)
        {
            //bool flag = true;
            int x;
            int[] a = new int[] { 1, 2, 5, 4, 9, 12, 6 };
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] == n)
                {
                    x = i + 1;
                    return x;

                }

            }
            return -1;

        }
    }
}