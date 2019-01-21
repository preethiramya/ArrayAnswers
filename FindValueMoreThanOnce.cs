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

            //  Console.WriteLine("Length: " + LengthOfInteger());
            // Console.WriteLine(FindValue(10));
            // Console.WriteLine(FindValueReturnIndex(10));
            // Console.WriteLine(FindValueMoreThanOnce(12));
            // Console.WriteLine(ReturnNumberOfTimes(4));
            // Console.WriteLine("Index is: "+ReturnTheIndicesOfLocation(4));
            // Console.WriteLine(SumOfArray());
            Console.WriteLine(Mean());

        }
        public static bool FindValueMoreThanOnce(int n)
        {
            int count = 0;
            bool flag = true;
            // int x;
            int[] a = new int[] { 1, 2, 5, 4, 9, 12, 6, 4, 12, 12 };
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] == n)
                {
                    count++;
                    if (count > 1)
                    {
                        return flag;
                    }


                }

            }
            return false;
            
        }
    }
}