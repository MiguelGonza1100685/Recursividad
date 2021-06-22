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
            Console.WriteLine(Fact_T(11, 1).ToString());
            Console.WriteLine(Sum_T(11, 2).ToString());

        }

        private static long Sum_T(int v1, int v2)
        {

            if (v1 == 0)
            {

                return v2;


            }
            else
            {
                return Sum_T(v1 - 1, v1 + v2);
            }



        }

        private static long Fact_T(int v1, int v2)
        {
            if (v1 == 0)
            {

                return v2;


            }
            else
            {

                return Fact_T(v1 - 1, v1 * v2);

            }





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
