using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZkouseniOOP
{
    class zkouseni
    {
        private int typZkouseni;
        private int maxHodnota;
        private int pocetZkouseni;
        private int celkem;
        private int PocetSpravne;
        private int PocetSpatne;

        public zkouseni(int typZkouseni, int maxHodnota, int pocetZkouseni)
        {
            this.typZkouseni = typZkouseni;
            this.maxHodnota = maxHodnota;
            this.pocetZkouseni = pocetZkouseni;
            this.celkem = 0;
            this.PocetSpravne = 0;
            this.PocetSpatne = 0;
        }

        public void generujPriklady()
        {
            Random random = new Random();

            for (int i = 0; i < pocetZkouseni; i++)
            {
                int a = random.Next(1, maxHodnota +1);
                int b = random.Next(1, maxHodnota +1);
                int vysledek = 0;
                string operace = "";

                if (typZkouseni == 1)
                {
                    vysledek = a + b;
                    operace = "+";
                }
                else if (typZkouseni == 2)
                {
                    vysledek = a - b;
                    operace = "-";
                }
                else if (typZkouseni == 3)
                {
                    vysledek = a * b;
                    operace = "*";
                }
                else
                {
                    Console.WriteLine("Neplatný druh zkoušení.");
                    return;
                }


                Console.Write("{0} {1} {2} = ",a, operace, b);
                int odpoved = int.Parse(Console.ReadLine());
                celkem++;

                if (odpoved == vysledek)
                {
                    PocetSpravne++;
                    Console.WriteLine("Spravně");
                }
                else
                {
                    PocetSpatne++;
                    Console.WriteLine("Špatně");
                }
            }
        }

        public void Statisitka()
        {
            Console.WriteLine(" ");
            Console.WriteLine("===========");
            Console.WriteLine("Správně: " + PocetSpravne);
            Console.WriteLine("Špatně: " + PocetSpatne);
            Console.WriteLine("Celkem bylo {0} příkladů", celkem);
            Console.ReadLine();
        }

    }
}
