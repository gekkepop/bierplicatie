using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bierplicatie2._0.code
{
    internal class persoon
    {
        private maakTXTFile maakTXTFile = new maakTXTFile();
        private string defaultLocatieBierpunten = @"C:\bierplicatie\Bierpunten\";
        private string defaultLocatieAantal = @"C:\bierplicatie\AantalVanHuisgenoten\";
        private string defaultLocatieStatiegeld = @"C:\bierplicatie\statiegeld\";
        private string defaultLocatieAantalGast = @"C:\bierplicatie\AantalVanGasten\";

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

        public int aantalbierAftellen(int aantal)
        {
            string locatie = defaultLocatieBierpunten + naam;
            string locatieAantal = defaultLocatieAantal + naam;
            maakTXTFile.wegSchrijven(locatieAantal, -aantal);

            return maakTXTFile.wegSchrijven(locatie, aantal);
        }

        public void bierpuntenOptellen()
        {
        }

        public void statiegeldOptellen()
        {
        }

        internal int aantalbierAftellenGast(int aantal)
        {
            string locatie = defaultLocatieBierpunten + naam;
            string locatieAantal = defaultLocatieAantalGast + naam;
            maakTXTFile.wegSchrijven(locatieAantal, -aantal);

            return maakTXTFile.wegSchrijven(locatie, aantal);
        }

        internal int kratAanslaan(int aantal)
        {
            string locatie = defaultLocatieBierpunten + naam;
            string locatieAantal = defaultLocatieStatiegeld + naam;
            maakTXTFile.wegSchrijvenDouble(locatieAantal, 3.90);

            return maakTXTFile.wegSchrijven(locatie, aantal);
        }
    }
}