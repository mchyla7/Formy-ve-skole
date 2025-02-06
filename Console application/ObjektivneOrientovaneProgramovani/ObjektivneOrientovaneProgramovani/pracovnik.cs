using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjektivneOrientovaneProgramovani
{
    // Vytvořte třídu pracovník
    // Atributy: jmeno, prijmeni, datum-narozeni, datum-nastupu

    class pracovnik
    {
        string jmeno;
        string prijmeni;
        string datumNarozeni;
        string datumNastupu;

        public pracovnik()
        {
        }

        public pracovnik(string jmeno, string prijmeni, string datumNarozeni, string datumNastupu)
        {
            // TODO: Complete member initialization
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.datumNastupu = datumNastupu;
        }

        public void Vypis()
        {
            Console.WriteLine("Jméno: {0}, Příjmení: {1}, Datum narození: {2}, Datum nástupu: {3}", jmeno, prijmeni, datumNarozeni, datumNastupu);
        }


    }
}
