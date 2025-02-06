using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjektivneOrientovaneProgramovani
{
    class Program
    {
        static void Main(string[] args)
        {
            trojuhelnikMainProgram();
        }

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

    // Vytvořte třídu pocetZnaku
    // Vytvořte metodu Pocet
    // Metoda vrátí počet znaků v parametru, který obsahuje text
    // Přetěžte metodu aby vrátila počet znaků v parametru, který obsahuje desetiné číslo

    // Pocet("abc") vrátí: 3
    // Pocet(1.56) vratí: 4

    class pocetZnaku
    {
        public static int Pocet(string a)
        {
            return a.Length;
        }
    }

    class pracovnik
    {
        public static void databazePracovniku()
        {
            Console.WriteLine("Zadej počet zaměstnanců: ");
            int pocetZamestnancu = int.Parse(Console.ReadLine());
            List<pracovnik> lide = new List<pracovnik>();

            for (int i = 1; i <= pocetZamestnancu; i++) ;
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
                else if (vyber == "¨3")
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
}
