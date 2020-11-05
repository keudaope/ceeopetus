using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Tehtavat1
    {
        // Tehtävät 1 - 1. tehtävä
        public static void laskeYhteen(int luku1, int luku2)
        {
            int summa = luku1 + luku2;
            Console.WriteLine("Lukujen {0} ja {1} summa on {2}", luku1, luku2, summa);
        }
        // Tehtävät 1 - 2. tehtävä
        public static void fahrenheiteiksi(int celsius)
        {
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(celsius + " Celsiusastetta on " + fahrenheit + " fahrenheitia");
        }
        // Tehtävät 1 - 3. tehtävä
        public static void peruslaskut(int luku1, int luku2)
        {
            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;
            double osamaara = (double)luku1 / luku2;
            Console.WriteLine("Lukujen {0} ja {1}", luku1, luku2);
            Console.WriteLine("Summa on " + summa);
            Console.WriteLine("Erotus on " + erotus);
            Console.WriteLine("Tulo on " + tulo);
            Console.WriteLine("Osamäärä on " + osamaara);
        }
    }
}
