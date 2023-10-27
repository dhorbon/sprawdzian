using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    internal class Pracownik
    {
        public string Imie, Nazwisko, DataRozpoczecia, DataZakonczenia;
        public int status; //0 - przed praca, 1 - pracuje, 2 - skonczyl prace

        public Pracownik(string name, string surname)
        {
            Imie = name;
            Nazwisko = surname;
            DataRozpoczecia = "";
            DataZakonczenia = "";
            status = 0;
        }

        public void Dane()
        {
            Console.Write($"{Imie} {Nazwisko} {DataRozpoczecia} {DataZakonczenia} ");

            switch (status)
            {
                case 0:
                    Console.Write("Przed pracą\n");
                    break;
                case 1:
                    Console.Write("Pracuje\n");
                    break;
                case 2:
                    Console.Write("Skończył pracę\n");
                    break;
            }
        }

        public void StartPracy()
        {
            status = 1;
            DataRozpoczecia = DateTime.Now.ToString();
        }

        public void StopPracy()
        {
            status = 2;
            DataZakonczenia= DateTime.Now.ToString();
        }
    }
}
