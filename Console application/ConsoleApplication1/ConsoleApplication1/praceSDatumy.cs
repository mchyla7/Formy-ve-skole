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

            label1.Text = ("Den je " + den);

            label2.Text = ("Měsíc je " + mesic);
            label3.Text = ("Rok je " + rok);
            label4.Text = ("Hodina je " + hodina);
            label5.Text = ("Minuta je " + minuta);
            label6.Text = ("Sekund je " + sekudna);

            // Zítřejší a dnešní den

            DateTime dnes = DateTime.Now;

            label7.Text = ("Dnes je " + dnes.ToShortDateString() + ".");
            label8.Text = ("Dnes je " + dnes.ToLongDateString() + ".");

            DateTime zitra = dnes.AddDays(1);

            label9.Text = ("Dnes je " + dnes.ToShortDateString() + ".");
            label10.Text = ("Zítra bude " + zitra.ToShortDateString() + ".");

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

            if (zakazka < dnes)
            {
                Console.WriteLine("Termín je zadaný v minulosti");
            }
            else
                break;


        }
    }
}
