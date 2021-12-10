using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    public class Quvvet
    {
        public void Quvvetitap(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0");
            } 
            while (n%2==0)
            {
                n = n / 2;
            }
            if(n==1)
            {
                Console.WriteLine("Quvvetidir");
               
            }
            else { Console.WriteLine("Quvveti deyil"); }
            
                

            


        }
    }
}
