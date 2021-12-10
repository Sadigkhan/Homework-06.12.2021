using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class Compile
    {
        public void Compiler(int[] arr3)
        {

            int[] array1 = { 1, 7, 3, 4, 2 };
            int[] array2 = { 5, 9, 8, 6, 10 };
            int[] array3 = new int[array1.Length + array2.Length];                       
            for (int j = 0, i = 0; i < array3.Length; i++)
            {
                if (i < array1.Length)
                {
                    array3[i] = array1[i];
                }
                if (i == array1.Length || i > array1.Length)
                {
                    array3[i] = array2[j];
                    j++;
                }
            }
            foreach (int element in array3)
            {
            }
            Console.WriteLine($"Iki arrayin birlesmesinden yaranmis array:{string.Join(" ", array3)}");
            foreach (int item in array3)
            {
                Console.WriteLine($"On elementli arrayin elementlerinin sondan evvele dogru yazilisi:{string.Join(" ", array3.Reverse())}");
                break;
            }
            Array.Sort(array3);
            Array.Reverse(array3);
            foreach (int deyer in array3)
            {
            }
            Console.WriteLine($"Elde olumus coxlugun azalan sira ile yazilisi:{string.Join(" ", array3)}");
           
            
        }



    }
}

