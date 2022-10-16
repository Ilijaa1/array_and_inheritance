using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_and_inheritance.Nasledjivanje
{
    public class Djak : Osoba
    {
        private double prosecnaOcena;
        public Djak(string ime, string prezime, string jmbg, double prosecnaOcena)
        :base(ime, prezime, jmbg)
        {
            if (prosecnaOcena >= 1 && prosecnaOcena <= 5)
            {
                this.prosecnaOcena = prosecnaOcena;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }
        public override void ispis()
        {
            base.ispis();
            Console.WriteLine($"Prosecna ocena: {prosecnaOcena} ");
        }
    }
}
