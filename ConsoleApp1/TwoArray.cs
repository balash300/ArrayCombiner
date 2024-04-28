using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Sorting;

namespace ConsoleApp1
{
    internal class TwoArray
    {
        public static void MergeTwoArray(int[] arr1, int[] arr2)
        {
            int a = 0, b = 0;

            for (int i = 0; i < arr1.Length; i++) if (arr1[i] % 2 == 1) a++;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == 0) ;
                else if (arr2[i] % 2 == 0) a++;
            }

            int[] lastArray = new int[a];

            for (int i = 0; i < arr1.Length; i++) 
                if (arr1[i] % 2 == 1) 
                { 
                    lastArray[b] = arr1[i];
                    b++; 
                };
            for (int i = 0; i < arr2.Length; i++)
                if (arr2[i] == 0);
                else if (arr2[i] % 2 == 0)
                {
                    lastArray[b] = arr2[i];
                    b++;
                }

            Ascending(lastArray);

            foreach (int item in lastArray) Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
