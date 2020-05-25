using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string readin;
            readin=Console.ReadLine();
            int objectNumber;
            objectNumber = Int32.Parse(readin);
            int isPrimeNumber(int x) {

                int i;
                for (i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    { break; }
                }
                if (i == x)
                    return 1;
                else
                    return 0;
            };
            int disp(int x) {
                if (isPrimeNumber(x) == 1)

                {
                    Console.WriteLine(x);
                    return 0;
                }

                else
                {
                    int prime;
                    for (prime = 2; prime <= x; prime++)
                    {if(isPrimeNumber(prime)==1&&x%prime==0)
                        { Console.WriteLine(prime);
                            x = x / prime;
                            prime = 1;
                            if (x == 1) { return 0; };   
                        }
                    }
                }
                return 0;


            }
            disp(objectNumber);
            readin = Console.ReadLine();
        }
    }
}
