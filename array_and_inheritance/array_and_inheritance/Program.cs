using System;
using array_and_inheritance.DNKLanac;
using array_and_inheritance.Autobus;
using array_and_inheritance.Nasledjivanje;

namespace Ilija
{
    public class Program
    {
        static void Main(string[] args)
        {

            var DNKLanac = new DNKLanac(8);
            DNKLanac.Dodavanje_Karika('A');
            DNKLanac.Dodavanje_Karika('C');
            DNKLanac.Dodavanje_Karika('C');
            DNKLanac.Dodavanje_Karika('G');
            DNKLanac.Dodavanje_Karika('T');
            DNKLanac.Dodavanje_Karika('T');
            DNKLanac.Dodavanje_Karika('T');
            DNKLanac.Dodavanje_Karika('T');
            DNKLanac.ispis();
            Console.WriteLine("\n");
            Console.WriteLine("Obrnuto");
            DNKLanac.ispis2();
            Console.WriteLine("\n");

            // zadatak autobus
            var autobus = new Autobus();
            Console.WriteLine(" ");
            autobus.uvodjenje_putnika(0);
            autobus.uvodjenje_putnika(19);
            autobus.uvodjenje_putnika(49);
            Console.WriteLine(" ");
            Console.WriteLine(autobus.brojZauzetih());
            Console.WriteLine(autobus.brojSlobodnih());
            autobus.ispis();
            autobus.status();

            // zadatak nasledjivanje
            var osoba = new Osoba("Ilija", "Pavlovic", "02323423423");
            osoba.ispis();

            var djak = new Djak("Ilija", "Pavlovic", "02323423423", 4.83);
            djak.ispis();

            var penzioner = new Penzioner("Marko", "Petrovic", "34834983091823", 75000);
            penzioner.ispis();
        }
    }
}
