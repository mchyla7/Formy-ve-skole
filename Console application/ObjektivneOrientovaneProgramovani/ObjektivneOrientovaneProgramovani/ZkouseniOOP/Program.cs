using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZkouseniOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej druh zkoušení 1.sčítání, 2.odčítání, 3.násobení: ");
            int druhZkouseni = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej kladnou maximální hodnotu pro generované operandy: ");
            int maxHodnota = int.Parse(Console.ReadLine());

            Console.WriteLine("Počet zkoušení: ");
            int pocetZkouseni = int.Parse(Console.ReadLine());

            zkouseni zkouseni = new zkouseni(druhZkouseni, maxHodnota, pocetZkouseni);
            zkouseni.generujPriklady();
            zkouseni.Statisitka();

        }
    }
}
