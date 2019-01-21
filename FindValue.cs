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
           
             Console.WriteLine(FindValue(10));
            
        }
         public static bool FindValue(int n)
        {
            bool flag = true;
            int[] a = new int[] { 1, 2, 5, 4, 9, 12, 4 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    return flag;
                }

            }
            return false;
        }
    }
}