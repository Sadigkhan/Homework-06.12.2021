using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class Word_counter
    {
        public void Say(string[]sentence)
        {
            string cumle;
            int say = 0;
            string result=String.Empty;
            Console.Write("Cumlenizi daxil edin  : ");
            cumle = Console.ReadLine();
            string[] soz = cumle.Split(' ');            
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] != result)
                {
                    say++;
                }
            }
            Console.WriteLine($"Daxil edilmis cumledeki soz sayi:{say}");
        }
    }
}
