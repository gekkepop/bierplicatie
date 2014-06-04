using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bierplicatie2._0.code
{
    public class bierKlasse
    {
        List<string> namen = new List<string>();
        List<persoon> personen = new List<persoon>();

        public bierKlasse(List<string> namen)
        {
            this.namen = namen;

            maakListPersonen();
        }

        private void maakListPersonen()
        {
            foreach (string naam in namen)
            {
                personen.Add(new persoon(naam));
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

    }
}
