using System;

namespace ObjektivneOrientovaneProgramovani
{
    partial class hadani
    {
        private int maxh;
        private int odpoved;
        private int hadaniPocet;
        private int hadaneCislo;

        public hadani(int maxh)
        {
            this.maxh = maxh;
            Random generator = new Random();
            hadaneCislo = generator.Next(1, maxh + 1);
        }

        public bool uhadl()
        {
            Console.WriteLine("Jaké číslo myslíš?: ");
            odpoved = int.Parse(Console.ReadLine());
            hadaniPocet++;
            return odpoved == hadaneCislo;
        }

        public string pomoc()
        {
            if (odpoved > hadaneCislo)
            {
                return "Uber";
            }
            else if (odpoved < hadaneCislo)
            {
                return "Přidej";
            }
            else
            {
                return "Uhodl jsi!";
            }
        }

        public int pocetHadani()
        {
            return hadaniPocet;
        }
    }
}