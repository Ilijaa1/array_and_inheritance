using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_and_inheritance.Autobus
{
    public class Autobus
    {
        public bool[] sedista = new bool[50];
        public int brojSedista=50;
        public Autobus()
        {
            for (int i = 0; i < 50; i++)
            {
                sedista[i] = true;
            }
        }
        public void uvodjenje_putnika(int brojSedista)
        {
            if (sedista[brojSedista])
            {
                sedista[brojSedista] = false;
            }
            else
            {
                Console.WriteLine($"Greska! Broj {brojSedista} je vec zauzeto!");
            }
        }
        public void ispis()
        {
            for (int i = 0; i < sedista.Length; i++)
            {
                Console.WriteLine(sedista[i]);
            }
        }
        public int brojZauzetih()
        {
            int brojZ = 0;
            for (int i = 0; i < sedista.Length; i++)
            {
                if (!sedista[i])
                {
                    brojZ++;
                }
            }
            return brojZ;
        }
        public int brojSlobodnih()
        {
            int brojS = 0;
            for (int i = 0; i < sedista.Length; i++)
            {
                if (sedista[i])
                {
                    brojS++;
                }
            }
            return brojS;
        }

        public void status()
        {
            for (int i = 0; i < sedista.Length; i++)
            {
                Console.WriteLine($"Sediste broj {i} i ono je {sedista[i]}");
            }
        }
    }
}
