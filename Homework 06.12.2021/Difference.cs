using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class Difference
    {
        public void Diff(int[] arr)
        {
            int sum3reqemli = 0;
            int sumdiger = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] / 100 > 0 && arr[i] / 1000 == 0)
                {
                    sum3reqemli += arr[i];
                }
                else 
                {
                    sumdiger += arr[i];
                }
                
            }
            Console.WriteLine(sum3reqemli - sumdiger);

        }
    }
}
