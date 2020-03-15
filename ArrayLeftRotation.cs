using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public static class Solution
    {
        
        static int[] rotLeft(int[] a, int d)
        {
            int[] newArray = new int[a.Length];
            int index = 0;
            for (int i = d; i < a.Length; i++)
            {
                newArray[index++]= a[i];
            }
            for (int i = 0; i < d; i++)
            {
                newArray[index++] = a[i];
            }
            return newArray;
        }

        static int[] rotLeftOld(int[] a, int d)
        {
            var arrLength = a.Length - 1;
            int temp = 0;
            for (int i = 0; i < d; i++)
            {
                temp = a[0];
                for (int arr = 0; arr < arrLength; arr++)
                {
                    a[arr] = a[arr + 1];
                }
                a[arrLength] = temp;
            }
            return a;
        }
        public static void Main()
        {            

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
