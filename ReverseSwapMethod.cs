using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSwapMethod
{
    class Program
    {
        public static void Printarray(int[] a)
        {

            foreach (var st in a)
            {
                Console.WriteLine(st);
            }
        }

            static void Main(string[] args)
        {
            int[] c = { 1, 2, 8, 9, 7 };
            
            var s = ReverseArray(c);

            Printarray(s);
            Console.ReadKey();
            Console.WriteLine(s);
        }
        public static int[] ReverseArray(int[] a)
        {
           
            int []b = a;
          int  length = a.Length-1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[length];
                a[length] = temp;
                
                length--;

            }
            return b;
        }
    }
}
