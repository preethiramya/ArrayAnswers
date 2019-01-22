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

            Console.WriteLine(SumOfArray());
        }
         public static int SumOfArray()
        {
            int[] a = new int[] { 1, 2, 8, 5, 4, 6, 6, 4 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
    }
}