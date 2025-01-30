using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjektivneOrientovaneProgramovani
{
    class obdelnik
    {
        // Vytvořte třídu obdelník
        // Atributy jsou neveřejné strana A, strana B, jednotka délky
        // Konstruktor načte stranu a, stranu B a jednotku délky
        // Metoda obvod, vratí obvod
        // Metoda obsah, vratí obsah

        // Metoda strany vypíše délky stran spolu s jednotkami
        // V Mainu použijte: vytvořre 2 objekty, použijte všechny metody

        private double stranaA;
        private double stranaB;
        private string jednotka;

        public obdelnik()
        {
        }

        public obdelnik(double a, double b, string jednotka)
        {
            this.stranaA = a;
            this.stranaB = b;
            this.jednotka = jednotka;
        }

        public double obsah()
        {
            double obsah = this.stranaB * this.stranaA;
            return obsah;
        }

        public double obvod()
        {
            double obvod = (this.stranaB + this.stranaA) * 2;
            return obvod;
        }

        public void vypis() // void - void nic nevrácí
        {
            Console.WriteLine("Obvod je {0} a obsah je {1}. Použité jednotky jsou {3}", this.obvod, this.obsah, this.jednotka);
        }

    }
}
