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

              Console.WriteLine("Length: " + LengthOfInteger());
            
        }
        public static int LengthOfInteger()
        {
            int count = 0;
            int[] a = new int[] { 1, 2, 5, 7, 9, 4, 6, 9, 10 };
            // Console.WriteLine("Enter the elements");
            foreach (var length in a)
            {

                count++;
            }

            return count;

        }
    }
}

