using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    internal class ZakladPracy
    {
        public string Nazwa;
        public List<Pracownik> Pracownicy = new List<Pracownik>();

        public ZakladPracy(string name)
        {
            Nazwa = name;
        }

        public void WyswietlWszystkich()
        {
            for(int i = 0; i < Pracownicy.Count; i++)
            {
                Pracownicy[i].Dane();
            }
        }

        public void WyswietlZakonczonych()
        {
            for (int i = 0; i < Pracownicy.Count; i++)
            {
                if (Pracownicy[i].status == 2)
                {
                    Pracownicy[i].Dane();
                }
            }
        }
    }
}
