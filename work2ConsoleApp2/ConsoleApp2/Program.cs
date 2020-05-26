using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 2, 4 ,0};
            int count=0,size=array.Length;
            int maxium=0, minium=65536;

            for(count=0;count<size;count++)
            { 
                if (array[count] > maxium)
                {   maxium = array[count];
                        
                }
                if (array[count] < minium)
                {
                    minium = array[count];
                }
              
            }
            Console.WriteLine(maxium);
            Console.WriteLine(minium);
            Console.WriteLine(maxium);
        }
    }
}
