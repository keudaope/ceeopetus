using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaHarjoitus
{
    public class Pankkitili
    {
        private string omistaja;
        private string tilinro;
        private double saldo;

        public Pankkitili()
        {
            omistaja = "";
            tilinro = "";
            saldo = 0;
        }

        public Pankkitili(string uomistaja, string utilinro, double usaldo)
        {
            omistaja = uomistaja;
            tilinro = utilinro;
            saldo = usaldo;
        }

        public void Tulosta()
        {
            Console.WriteLine("Tilin omistaja: " + omistaja);
            Console.WriteLine("Tilinro: " + tilinro);
            Console.WriteLine("Saldo: " + saldo + "\n");
        }
        public string Omistaja
        {
            get
            {
                return omistaja;
            }
            set
            {
                omistaja = value;
            }
            
        }

        public string Tilinro
        {
            get
            {
                return tilinro;
            }
            set
            {
                tilinro = value;
            }

        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }

        }

        public void Talleta(double summa)
        {
            saldo += summa;
            Console.WriteLine("Uusi saldo on: " + saldo);
        }

        public void Nosta(double summa)
        {
            if(summa <= saldo)
            {
                saldo -= summa;
                Console.WriteLine("Uusi saldo on: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldosi ei riitä nostoon");
            }
        }
    }

    
}
