using System;
using System.Collections.Generic;

namespace ObjektivneOrientovaneProgramovani
{
    class Program
    {
        public static void trojuhelnikMainProgram()
        {
            trojuhelnik trojl1 = new trojuhelnik();
            trojuhelnik trojl2 = new trojuhelnik(58, 55, 59);

            Console.WriteLine("Počet trojuhelníku: " + trojuhelnik.pocetInstanci);

            trojl1.stranaA = 10;
            trojl1.stranaB = 30;
            trojl1.stranaC = 40;

            Console.Write("Obvod je " + trojl1.obvod());
            trojl1.vypisStrany();
        }

        public static void obdelnikMainProgram()
        {
            obdelnik obdelka = new obdelnik(12, 52, "cm");
        }
    }

    class scitani1
    {
        public int Secti(int a, int b)
        {
            return a + b;
        }
        public double Secti(double a, double b)
        {
            return a + b;
        }
        public string Secti(string a, string b)
        {
            return a + b;
        }

        public static void Scitani()
        {
            scitani1 scitani = new scitani1();
            Console.WriteLine(scitani.Secti("a", "abcd"));
            Console.ReadLine();
        }
    }

    class pocetZnaku
    {
        public static int Pocet(string a)
        {
            return a.Length;
        }
    }

    partial class pracovnik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string DatumNarozeni { get; set; }
        public string DatumNastupu { get; set; }

        public pracovnik(string jmeno, string prijmeni, string datumNarozeni, string datumNastupu)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            DatumNastupu = datumNastupu;
        }

        public void Vypis()
        {
            Console.WriteLine($"{Jmeno} {Prijmeni}, narozen {DatumNarozeni}, nastoupil {DatumNastupu}");
        }

        public static void databazePracovniku()
        {
            Console.WriteLine("Zadej počet zaměstnanců: ");
            int pocetZamestnancu = int.Parse(Console.ReadLine());
            List<pracovnik> lide = new List<pracovnik>();

            for (int i = 1; i <= pocetZamestnancu; i++)
            {
                Console.WriteLine("Zadejte jméno: ");
                string jmeno = Console.ReadLine();
                Console.WriteLine("Zadejte příjmení: ");
                string prijmeni = Console.ReadLine();
                Console.WriteLine("Zadejte datumNarozeni: ");
                string datumNarozeni = Console.ReadLine();
                Console.WriteLine("Zadejte datumNastupu: ");
                string datumNastupu = Console.ReadLine();

                pracovnik prac = new pracovnik(jmeno, prijmeni, datumNarozeni, datumNastupu);
                lide.Add(prac);
            }

            while (true)
            {
                Console.WriteLine("1. Výstup, 2. Přidat, 3. Konec");
                string vyber = Console.ReadLine();
                if (vyber == "1")
                {
                    foreach (pracovnik osoba in lide)
                    {
                        osoba.Vypis();
                    }
                    Console.WriteLine();
                }
                else if (vyber == "2")
                {
                    Console.WriteLine("Zadejte jméno: ");
                    string jmeno1 = Console.ReadLine();
                    Console.WriteLine("Zadejte příjmení: ");
                    string prijmeni2 = Console.ReadLine();
                    Console.WriteLine("Zadejte datumNarozeni: ");
                    string datumNarozeni3 = Console.ReadLine();
                    Console.WriteLine("Zadejte datumNastupu: ");
                    string datumNastupu4 = Console.ReadLine();

                    pracovnik prac1 = new pracovnik(jmeno1, prijmeni2, datumNarozeni3, datumNastupu4);
                    lide.Add(prac1);
                }
                else if (vyber == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Špatná hodnota");
                    Console.ReadLine();
                }
            }
        }
    }

    partial class hadani
    {
        private int maxH;
        private int pokusy;
        private int cislo;

        public hadani(int maxH)
        {
            this.maxH = maxH;
            this.pokusy = 0;
            this.cislo = new Random().Next(1, maxH + 1);
        }

        public bool uhadl()
        {
            Console.WriteLine("Hádej číslo: ");
            int hadaneCislo = int.Parse(Console.ReadLine());
            pokusy++;
            return hadaneCislo == cislo;
        }

        public string pomoc()
        {
            return $"Hádané číslo je mezi 1 a {maxH}.";
        }

        public int pocetHadani()
        {
            return pokusy;
        }

        static void Main(string[] args)
        {
            hadani1();
        }

        static void hadani1()
        {
            int maxH = 100;
            hadani hadani = new hadani(maxH);
            while (true)
            {
                if (hadani.uhadl())
                {
                    Console.WriteLine(hadani.pomoc());
                    Console.WriteLine($"\n Počet pokusů {hadani.pocetHadani()}");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine(hadani.pomoc());
                    Console.WriteLine();
                }
            }
        }
    }
}