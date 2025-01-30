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
}
