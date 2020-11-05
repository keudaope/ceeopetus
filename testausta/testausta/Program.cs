using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
namespace testausta
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirjasto Remes01 = new Kirjasto("Ruttokellot", "Poliisipsykologi Johanna Vahtera joutuu tulikasteeseen, josta alkaa Suomen rikoshistorian suurin poliisioperaatio - ja Johannan elämän pahin painajainen. Filmiohjaaja Otso Vaismaa saa tarjouksen: 800 000 markkaa oudon työtehtävän suorittamisesta. Suostuessaan tarjoukseen hän tekee virheen, josta tulee kärsimään koko Suomen kansa. Miljoonat suomalaiset heräävät myöhäissyksyn yönä keskelle painajaista. Kirkonkellot kumuavat yössä. Ylimääräiset uutiset kiirivät eetteriin. Alkaa suora lähetys helvetistä.", 488, 30);
            Console.WriteLine(Remes01.Nimi);
            Console.WriteLine(Remes01.Kuvaus);
            Console.WriteLine(Remes01.Sivut);
            Console.WriteLine(Remes01.Erapaiva);
            Kirjasto Remes02 = new Kirjasto();
            Remes02.Nimi = "Uhrilento";
            Remes02.Kuvaus = "Aivotutkijana työskentelevä Antti Kaira on menossa naimisiin morsiamensa Tiinan kanssa ja odottaa tätä palaavaksi lennolta Nizzasta. TV-uutisessa ilmoitetaan kuitenkin koneen katoamisesta ja sen hylky löydetään. Antti matkustaa Etelä-Eurooppaan selvittämään, mitä koneessa oikeasti tapahtui. Hän saa lopulta tietää jotain selittämätöntä.";
            Remes02.Sivut = 438;
            Remes02.Erapaiva = 30;
            Console.WriteLine("\n"+Remes02.Nimi);
            Console.WriteLine(Remes02.Kuvaus);
            Console.WriteLine(Remes02.Sivut);
            Console.WriteLine(Remes02.Erapaiva);
        }
    }
}
