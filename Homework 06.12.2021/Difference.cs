﻿using System;
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
            int sum2reqemli = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] / 100 > 0 && arr[i] / 1000 == 0)
                {
                    sum3reqemli += arr[i];
                }
                if (arr[i] / 10 > 0 && arr[i] / 100 == 0)
                {
                    sum2reqemli += arr[i];
                }
                
            }
            Console.WriteLine(sum3reqemli - sum2reqemli);

        }
    }
}
