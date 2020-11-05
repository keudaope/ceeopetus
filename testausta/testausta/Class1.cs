using System;
using System.Collections.Generic;
using System.Text;

namespace testausta
{
    public class Kirjasto
    {
        private string nimi;
        private string kuvaus;
        private int sivut;
        private int erapaiva;
        public Kirjasto()
        {
            nimi = "";
            kuvaus = "";
            sivut = 0;
            erapaiva = 0;
        }
        public Kirjasto(string unimi, string ukuvaus, int usivut, int uerapaiva)
        {
            nimi = unimi;
            kuvaus = ukuvaus;
            sivut = usivut;
            erapaiva = uerapaiva;
        }
        public string Nimi
        {
            set
            {
                nimi = value;
            }
            get
            {
                return nimi;
            }
        }
        public string Kuvaus
        {
            set
            {
                kuvaus = value;
            }
            get
            {
                return kuvaus;
            }
        }
        public int Sivut
        {
            set
            {
                sivut = value;
            }
            get
            {
                return sivut;
            }
        }
        public int Erapaiva
        {
            set
            {
                erapaiva = value;
            }
            get
            {
                return erapaiva;
            }
        }
    }
}
