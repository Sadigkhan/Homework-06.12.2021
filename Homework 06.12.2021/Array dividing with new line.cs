using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class Array_dividing_with_new_line
    {
        public void Devide(int[] arr)
        {
            int[] mainarr = { 1, 32, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 5, 0, 21, 212, 2321, 21, 12, 4, 5, 6, 3, 2, 4, 2, 2, 1, 2, 3, 4, 5, 6, 7, 543, 123, 512, 98765, 23, 3, 2, 34, 5, 43 };
            int i, j = 0, k = 0,  n = mainarr.Length;

            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
          
            Console.WriteLine($"Daxil olunmus coxluqdadki element sayi:{n}");
            

            for (i = 0; i < n; i++)
            {

                if (mainarr[i] % 2 == 0)
                {
                    arr2[j] = mainarr[i];
                    j++;
                }
                else
                {
                    arr3[k] = mainarr[i];
                    k++;
                }
                
            }

            Console.Write("\nCut elementler : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nTek elementler :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }




            int min = mainarr[0];
            foreach (int reqemmin in mainarr)
            {
                if (reqemmin <= min) { min = reqemmin; }

            }
            Console.Write("\nDaxil edilmis coxlugun en kicik elementi :\n");
            Console.Write("{0} ", min);

            int max = mainarr[0];
            foreach (int reqemmax in mainarr)
            {
                if(reqemmax >= max) { max = reqemmax; }
            }

            Console.Write("\nDaxil edilmis coxlugun en boyuk elementi :\n");
            Console.Write("{0} ", max);
        }
    }
}
