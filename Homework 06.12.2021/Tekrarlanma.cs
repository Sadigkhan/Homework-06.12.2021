using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class Tekrarlanma
    {
        public void Say(string[] sentence)
        {
            string cumle;
            Console.Write("Cumlenizi daxil edin: ");
            cumle = Console.ReadLine();
            string soz;           
            Console.WriteLine("Axtarilacaq sozu daxil edin: ");
            soz = Console.ReadLine();
            int counter = 0;
            string lower = cumle.ToLower();
            string upper = cumle.ToUpper();

            string[] soz1 = lower.Split(' ');
            string[] soz2 = upper.Split(' ');
            

            for (int i = 0; i < soz1.Length; i++)
            {
                  
                
                if (soz1[i] == soz)
                {
                   counter++;
                }
                if (soz2[i]==soz)
                {
                    counter++;
                }
            }
           
                

            
            Console.WriteLine($"Axtarilan sozun cumle daxilinde islenme sayi:{counter}");
                
                
                

                
            
            
        }
    }
}
