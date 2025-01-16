using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class listy
    {
        public static void list()
        { 
            // Vytvoření listu (Vylepšení / Rozšíření pole)
            List<string> seznamFilmu = new List<string>();
            seznamFilmu.Add("Hobbit");
            seznamFilmu.Add("Hulk");
            seznamFilmu.Add("Fast");
            seznamFilmu.Add("Need for Speed");

            foreach (string film in seznamFilmu) //Výpis členů listu
                Console.ReadLine();

            Console.WriteLine("Počet prvků: {0}", seznamFilmu.Count);
            Console.WriteLine();
            Console.ReadLine();

            seznamFilmu.Remove(seznamFilmu[1]); // Odstranění prvku
            seznamFilmu.Remove("Hulk"); // Odstranění všech prvků s hodnotou "Hulk"
            seznamFilmu[0] = "Hulk"; // Změna hodnoty

            seznamFilmu.Sort(); // Seřazení
            Console.WriteLine("\n\nVýpis seřazených prvků");
            for (int i = 0; i < seznamFilmu.Count; i++)
            {
                Console.WriteLine(seznamFilmu[i]);
            }
            seznamFilmu.Clear(); // Vymazání celého seznamu
        }

        public static void listik()
        {
            string[] poleStringu = { "Pondělí", "Ůterý", "Středa", "Čtvrtek", "Pátek" };

            List<string> pracovniDny = new List<string>(poleStringu); // Poté se vytvoří list a vloží se hodnoty z pole
            foreach (string den in pracovniDny)
            {
                Console.WriteLine(den);
            }
            Console.ReadLine();
        }

        // Vytvořte program který do kolekce list vygeneruje n náhodných čísel
        // metoda čísla seřadí a vypíše

        public static void CislaList()
        {
            int pocetCisel = 10;
            List<int> cisla = new List<int>();

            Random generator = new Random();
            for (int i = 1; i <= pocetCisel; i++)
                cisla.Add(generator.Next(-100, 101));

            cisla.Sort();

            foreach (int x in cisla)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
