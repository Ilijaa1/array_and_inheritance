using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_and_inheritance.DNKLanac
{
    public class DNKLanac
    {
        public char[] niz_karika;
        public int trenutno_karika;
        public DNKLanac(int max_duzina)
        {
            trenutno_karika = 0;
            if (max_duzina <= 0)
            {
                niz_karika = new char[256];
            }
            else
            {
                niz_karika = new char[max_duzina];
            }
        }
        public void Dodavanje_Karika(char karika)
        { 
            int brojac = 0;
            if ((karika == 'A' || karika == 'C' || karika == 'G' || karika == 'T')
                && niz_karika.Length>trenutno_karika)
            {
                niz_karika[trenutno_karika] = karika;
                trenutno_karika++;
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }
        public int Broj_A()
        {
            int brojac = 0;
            for (int i = 0; i < niz_karika.Length; i++)
            {
                if (niz_karika[i] == 'A')
                {
                    brojac++;
                }
            }
            return brojac;
        }
        public int Trenutno()
        {
            return trenutno_karika;
        }
        public int Maksimalni()
        {
            return niz_karika.Length;
        }
        public int BrojNepopunjenih()
        {
            return niz_karika.Length - trenutno_karika;
        }
        public void ispis()
        {
            for (int i = 0; i < niz_karika.Length; i++)
            {
                Console.Write($"{niz_karika[i]} ");
            }
        }
        public void ispis2()
        {
            for (int i = niz_karika.Length - 1; i >= 0; i--)
            {
                Console.Write($"{niz_karika[i]} ");
            }
        }
    }
}
