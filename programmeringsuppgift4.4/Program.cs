using System;

namespace inlämningsuppgift4_4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool avsluta == false
                while(avsluta==true)
            {
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("Skriv siffran av alternativet för sig själv");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.ReadLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. avsluta programmet");

            int svar = int.Parse(Console.ReadLine());
                if (svar == 3)
                {
                    avsluta = true;
                }
                else
                Console.WriteLine("skriv första talet");
                int tal1 == int.Parse(Console.ReadLine());
                Console.WriteLine("skriv andra talet");
                int tal2 = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    mattesvar = tal1 - tal2;
                }
                else if (svar == 2) {
                    mattesvar = tal1 / tal2;
                }

                else
                







            }
        }
    }
}
