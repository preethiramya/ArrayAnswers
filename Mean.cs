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
           
            Console.WriteLine(Mean());
           

        }
         public static double Mean()
        {
            int[] a = new int[] { 1, 2, 5 };
            int count = 0;
            double mean = 0;
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count++;
                sum = sum + a[i];
                mean = sum / count;
            }

            return mean;
        }
    }
}