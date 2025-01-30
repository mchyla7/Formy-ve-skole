using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class praceSDatumy
    {
        public static void test()
        {
        DateTime nyni = DateTime.Now;

            int den = nyni.Day;
            int mesic = nyni.Month;
            int rok = nyni.Year;
            int hodina = nyni.Hour;
            int minuta = nyni.Minute;
            int sekudna = nyni.Second;

        }

        public static void konkretniDen()
        {
            Console.Write("Zadej datum ve formátu: r,m,d: ");
            string datum = Console.ReadLine();

            DateTime datumm = Convert.ToDateTime(datum);
            // DateTime datum = DateTime.Parse(datum);
            Console.WriteLine("Datum {0}: ", datumm.ToLongDateString());
            Console.ReadLine();
        }

        // Program načte datum zakázky a zkontroluje že datum je pozdější než současné

        public static void zakazka()
        {
            Console.Write("Zadej datum ve formátu: r,m,d: ");
            string datum = Console.ReadLine();

            DateTime datumm = DateTime.Today;

            //if (zakazka < dnes)
            //{
            //    Console.WriteLine("Termín je zadaný v minulosti");
            //}



        }
    }
}
