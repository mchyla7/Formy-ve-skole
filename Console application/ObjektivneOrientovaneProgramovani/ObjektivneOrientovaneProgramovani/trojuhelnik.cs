using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjektivneOrientovaneProgramovani
{
    class trojuhelnik
    {
        public static int pocetInstanci;
        public double stranaA; // Přidám před to public a proměnná je dostupná z jiného 
        public double stranaB;
        public double stranaC;

        public trojuhelnik()
        {
            pocetInstanci++;
        }

        public trojuhelnik(double a, double b, double c)
        {
            this.stranaA = a;
            this.stranaB = b;
            this.stranaC = c;
            pocetInstanci++;
        }

        public double obvod() // double - vrací číslo => return obvod
        {
            double obvod = this.stranaA + this.stranaB + this.stranaC;
            return obvod;
        }

        public void vypisStrany() // void - void nic nevrácí
        {
            Console.WriteLine("Strana A je {0}, strana B je {1}, strana C je {2}", this.stranaA, this.stranaB, this.stranaC);
        }
    }
}
