using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            InplaceReverse(5);
        }
        public static void InplaceReverse(int n)
        {
            int[] a = new int[n];
            int length = a.Length - 1;
            Console.WriteLine(" order: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n / 2; i++)
            {
                int temp = a[i];
                a[i] = a[length];
                a[length] = temp;
                
                length--;


            }
            Console.WriteLine("reversed array");


            for (int j = 0; j < a.Length; j++)
            {

                Console.WriteLine(a[j]);

            }
        }
    }
}
