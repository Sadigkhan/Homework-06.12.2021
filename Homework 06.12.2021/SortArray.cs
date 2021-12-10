using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class SortArray
    {
        public void Getmin(int[] array)
        {
            
            int min=array[0];
            
           
            foreach(int i in array)
            {
                if (i < min) { min = i; }
               
            }
            int index=Array.IndexOf(array, min);
            Console.WriteLine($"Daxil edilmis coxlugun en kicik elementinin indeksi:{index}");
            Console.WriteLine($"Daxil edilmis Coxlugun en kicik elementi:{min}");
          
            
            
            
        }

        
    }
}
