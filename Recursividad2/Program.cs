using System;

namespace Recursividad2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Sum(5).ToString());
            Console.WriteLine(Fact(10).ToString());
            Console.WriteLine(Mcd(5,10).ToString());


        }

        private static long Mcd(long a, long b)
        {

            if (b == 0)
            {

                return a;

            }
            else
            {


                return Mcd(b, a % b);
            }




        }

        private static long Fact(long F)
        {

            long R = 1;
            if (F > 0) 
            {

                R = F * Fact(F - 1);


            }
            return R;


        }

        private static long Sum(long S)
        {

            if (S == 1)
            {

                return S;



            }
            else 
            {

                return S + Sum(S - 1);
            }


        }
    }
}
