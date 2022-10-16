using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_and_inheritance.Nasledjivanje
{
    public class Osoba
    {
        private string ime;
        private string prezime;
        private string jmbg;

        public Osoba()
        {
            ime = "N";
            prezime = "N";
        }
        public Osoba(string ime, string prezime, string jmbg)
        {
            if (ime != null && prezime!=null)
            {
                this.ime = ime;
                this.prezime = prezime;
            }
            this.jmbg = jmbg;
        }

        public virtual void ispis()
        {
            Console.WriteLine($"{ime} {prezime} {jmbg}");
        }
        
    }
}
