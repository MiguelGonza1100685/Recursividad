using System;

namespace Recursividad_interativa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el numero");
            int x, fact = 1, count = 0;
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                count = count + 1;
                fact = fact * count;


            }
            Console.WriteLine("El factorial es: " + fact);

            int c = 1, s = 0;

            while (c <= 50)
            {
                if (c % 2 !=0)
                {

                    s += c;

                }
                c += 1;


            }
            Console.WriteLine($"La suma de los numeros es {s}");


            Console.WriteLine("Ingrese el primer numero");
            int N1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo Numero");
            int N2 = Int32.Parse(Console.ReadLine());

            int a = Math.Max(N1, N2);
            int b = Math.Min(N1, N2);
            int r;

            do
            {
                r = b;
                b = a % b;
                a = r;



            } while (b != 0);
            Console.WriteLine("El Gcd es:" + N1 + "y" + N2 + " es " + r);




        }
    }
}
