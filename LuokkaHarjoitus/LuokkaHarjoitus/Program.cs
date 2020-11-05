using System;

namespace LuokkaHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Pankkitili jyrintili = 
                new Pankkitili();
            jyrintili.Tulosta();
            Pankkitili eijantili = 
                new Pankkitili("Eija Lumme", 
                "FI112233-445566", 1450);
            eijantili.Tulosta();
            jyrintili.Omistaja = "Jyri Lindroos";
            jyrintili.Tilinro = "FI223344-556611";
            jyrintili.Saldo = 50.32;
            jyrintili.Tulosta();
            jyrintili.Talleta(10.43);
            jyrintili.Tulosta();
            jyrintili.Nosta(50);
            jyrintili.Nosta(50);
            /*Kirjasto ikiyo = new Kirjasto();
            Console.WriteLine(ikiyo.Nimi);
            ikiyo.Nimi = "ikiyö";
            Console.WriteLine(ikiyo.Nimi);
            Kirjasto csharp = new Kirjasto("C#:n perusteet", "M.Smith", 488);
            Console.WriteLine(csharp.Nimi + " " + csharp.Kirjailija + " " + csharp.Sivumaara);
            csharp.Sivumaara = 498;
            Console.WriteLine(csharp.Nimi + " " + csharp.Kirjailija + " " + csharp.Sivumaara);*Console.WriteLine("Uusi saldo on: " + saldo)*/


        }
    }
}
