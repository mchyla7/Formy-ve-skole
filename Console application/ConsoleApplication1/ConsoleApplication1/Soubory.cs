using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Soubory
    {
        public static void cteniZeSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";

            string t = File.ReadAllText(cesta);
            Console.WriteLine(t);
            Console.ReadLine();
        }

        public static void cteniZeSouboruDoPole()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";

            string[] soubor = File.ReadAllLines(cesta);

            foreach (string radek in soubor)
            {
                Console.WriteLine(radek);
            }
            Console.ReadLine();
        }

        // Máme textový soubor na každém řádku je jedna hodnota
        // V souboru můžou být i nečíselné hodnoty
        // Program načte hodnoty ze souboru do pole
        // Hodnoty převede na čísla a zobrazí součet průměr a minimum
        // Hodnoty seřadí a vypíše

        public static void TextakSTextemACisly()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cisla.txt";
            string[] soubor = File.ReadAllLines(cesta);
            double[] cisla = new Double[soubor.Length];
            double cislo;
            int i = 0;

            foreach (string radek in soubor)
            {
                if (double.TryParse(radek, out cislo))
                {
                    cisla[i] = cislo;
                    i++;
                }
            }

            Array.Resize(ref cisla, i);

            Console.WriteLine("Součet:  {0}", cisla.Sum());
            Console.WriteLine("Průměr: {0}", cisla.Average()); // Formátování s 2 desetinnými místy
            Console.WriteLine("Minimum: {0}", cisla.Min());
            Console.ReadLine();
        }


        // Data: text cislo
        // Program zobrazí hodnoty z druhého sloupce
        // Pokud tabulka obsahuje v druhém sloupci nečíselnou hodnotu, program to oznámí a ukončí
        // Program zobrazí součet čísel a maximum z číselných hodnot

        public static void TextCislo()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CSharp-ve-skole\\Martin\\CSharp-ve-skole\\Main\\Vedlejší soubory\\Tabulka.txt";
            string[] soubor = File.ReadAllLines(cesta);
            double soucet = 0;
            double max = double.MinValue;
            double cislo;

            foreach (string radek in soubor)
            {
                if (!double.TryParse(radek.Substring(radek.IndexOf(' ') + 1), out cislo))
                {
                    Console.Write("Chyba v datech!");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(cislo);
                if (cislo > max)
                {
                    max = cislo;
                }
            }
            Console.WriteLine("\nSoučet " + soucet);
            Console.WriteLine("\nMaximum " + max);
            Console.ReadLine();
        }

        public static void ulozenidoSouboru()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tabulka.txt";
            Console.Write("Zadejte text: ");
            string text = Console.ReadLine();
            File.WriteAllText(cesta, text);
        }
    }

}
