using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tehtavat1.laskeYhteen(7,5);
            Tehtavat1.fahrenheiteiksi(10);
            Tehtavat1.peruslaskut(7, 5);
            int jakojaannos = Tehtavat2.jakoj(7, 5);
            Console.WriteLine("Jakojäännös on {0}", jakojaannos);
            bool samat = Tehtavat2.onkoSamat(2, 2);
            Console.WriteLine("Luvut ovat samat " + samat);
            double sentit = Tehtavat2.senteiksi(10);
            Console.WriteLine("Sentit: " + sentit);
            Tehtavat2.onkoValissa(5, 3, 7);
        }
    }
}
