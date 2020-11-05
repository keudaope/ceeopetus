using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Tehtavat2
    {
        // Tehtävät 2 - 4. tehtävä
        public static double senteiksi(int tuumat)
        {
            return tuumat * 2.54;
        }
        // Tehtävät 2 - 3. tehtävä
        public static void onkoValissa(int luku1, int ala, int yla)
        {
            if (ala < luku1 && luku1 < yla)
            {
                Console.WriteLine(luku1 + " on lukujen " + ala + " ja " + yla + "välissä");
            }
            else
            {
                Console.WriteLine(luku1 + " ei ole lukujen " + ala + " ja " + yla + " välissä");
            }
        }
        // Tehtävät 2 - 1. tehtävä
        public static bool onkoSamat(int luku1, int luku2)
        {
            if (luku1 == luku2)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return luku1 == luku2;
        }
        
        // Tehtävät 2 - 2. tehtävä
        public static int jakoj(int luku1, int luku2)
        {
            int jako = luku1 % luku2;
            return jako;
            //return luku1 % luku2;
        }
    }
}
