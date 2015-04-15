using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bierplicatie2._0.code
{
    public class bierKlasse
    {
        //test

        private List<string> namen = new List<string>();
        private List<persoon> personen = new List<persoon>();
        private Muziek muziek = new Muziek();

        public bierKlasse(List<string> namen)
        {
            this.namen = namen;

            maakListPersonen();
        }

        private void maakListPersonen()
        {
            foreach (string naam in namen)
            {
                personen.Add(new persoon(naam, muziek));
            }
        }

        public List<int> leesBierpunten()
        {
            List<int> returnListMetBierpunten = new List<int>();
            foreach (persoon person in personen)
            {
                returnListMetBierpunten.Add(person.Bierpunten);
            }
            return returnListMetBierpunten;
        }

        public int optellenBierPunten(int persoonInList, int aantal)
        {
            return personen[persoonInList].aantalbierAftellen(aantal);
        }

        internal int optellenBierPuntenGast(int wie, int p)
        {
            return personen[wie].aantalbierAftellenGast(p);
        }

        internal int optellenKrat(int wie, int aantal)
        {
            return personen[wie].kratAanslaan(aantal);
        }
    }
}