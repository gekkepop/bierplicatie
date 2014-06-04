using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bierplicatie2._0.code
{
    class persoon
    {
        maakTXTFile maakTXTFile = new maakTXTFile();
        string defaultLocatieBierpunten = @"C:\bierplicatie\Bierpunten\";
        string defaultLocatieAantal = @"C:\bierplicatie\AantalVanHuisgenoten\";
        string defaultLocatieStatiegeld = @"C:\bierplicatie\statiegeld\";

        public string naam;

        private int bierpunten;

        public int Bierpunten
        {
            get
            {
                if (this.bierpunten == 0)
                {
                    bierpunten = maakTXTFile.bestandCheck(defaultLocatieBierpunten + naam);
                    return bierpunten;
                }
                else
                {
                    return maakTXTFile.bestandCheck(defaultLocatieBierpunten + naam);
                }
            }
        }

        private int aantalbier;

        public int Aantalbier
        {
            get { return maakTXTFile.bestandCheck(defaultLocatieAantal + naam); }
        }

        private double statiegeld;

        public double Statiegeld
        {
            get { return maakTXTFile.bestandCheckDouble(defaultLocatieStatiegeld + naam); }
        }

        public persoon(string naam)
        {
            this.naam = naam;
        }

        public void aantalbierOptellen()
        {
        }

        public void bierpuntenOptellen()
        {
        }

        public void statiegeldOptellen()
        {
        }
    }
}
