using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            limit=Console.Read();
            if (limit <= 0)
            {
                Console.WriteLine("Invalid input");//输入的int必须为正
            }
            int square(int x)
            {

                int sq;
                int[] primes;
                primes = new int [65536];
                for (sq = 0; sq <= x / 2; sq++)
                {
                    if (sq * sq == x) { return sq; }
                    else if (sq * sq < x&&(sq+1)*(sq+1)>x){ return sq; }
                    else if (sq * sq > x) { return sq - 1; }


                }
                return 0;
            }
            for(int i = 2; i < square(limit); i++)
            {
                primes[i-2]
            }

        }`
    }
}
