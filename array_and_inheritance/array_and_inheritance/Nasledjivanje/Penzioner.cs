using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_and_inheritance.Nasledjivanje
{
    public class Penzioner : Osoba
    {
        private double penzija;

        public Penzioner(string ime, string prezime, string jmbg, double penzija)
        :base(ime, prezime, jmbg)
        {
            if (penzija > 0)
            {
                this.penzija = penzija;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        public void ispis()
        {
            base.ispis();
            Console.WriteLine($"Penzija je {penzija}");
        }
    }
}
