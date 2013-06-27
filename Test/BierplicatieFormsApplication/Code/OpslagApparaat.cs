using BierplicatieFormsApplication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bierplicatie
{
    public class OpslagApparaat
    {
        public OpslagApparaat()
        {
        }

        private int bierpuntenSilke, bierpuntenNick, bierpuntenDaniel, bierpuntenEmma, bierpuntenIngeLize;
        private int aantalBierSilke, aantalBierNick, aantalBierDaniel, aantalBierEmma, aantalBierIngeLize;
        private double statiegeldSilke, statiegeldNick, statiegeldDaniel, statiegeldEmma, statiegeldIngeLize;
        private int bierGastenSilke, bierGastenNick, bierGastenDaniel, bierGastenEmma, bierGastenIngeLize;

        //private int bierBezoeker; //wordt nog niet gebruikt, moet algemene gast worden.
        private string emmaHaarMuziekje = @"C:\Bierplicatie\Media\emma.wav";

        private string silkeZijnMuziekje = @"C:\Bierplicatie\Media\silke.wav";
        private string danielZijnMuziekje = @"C:\Bierplicatie\Media\daniel.wav";
        private string ingeLizeHaarMuziekje = @"C:\Bierplicatie\Media\ingelize.wav";
        private string nickZijnMuziekje = @"C:\Bierplicatie\Media\nick.wav";

        private MaakTXTFile bestanden = new MaakTXTFile();
        private Muziek afspelen = new Muziek();

        public int aftrekkenBierpuntenSilke(int bierpuntenSilke)
        {
            //bool bestaatSilkeZeBestand;
            int mogelijkOudeWaarde;

            string silkeZeBierLocatie;

            silkeZeBierLocatie = @"C:\Bierplicatie\Bierpunten\silkeZeBier";

            mogelijkOudeWaarde = bestanden.bestandCheck(silkeZeBierLocatie);

            if (mogelijkOudeWaarde != -999 && mogelijkOudeWaarde != -9999)
            {
                this.bierpuntenSilke = mogelijkOudeWaarde;
            }

            this.bierpuntenSilke = this.bierpuntenSilke - bierpuntenSilke;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);
                //datum = System.DateTime.Now.ToString("yyyy-MM-dd");

                StreamWriter silkeZeBierSchrijver = File.AppendText(@silkeZeBierLocatie);

                using (silkeZeBierSchrijver)
                {
                    silkeZeBierSchrijver.WriteLine("{0}", vandaag);
                    silkeZeBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek);
                    silkeZeBierSchrijver.WriteLine("{0}", this.bierpuntenSilke);
                    silkeZeBierSchrijver.WriteLine("---------------------------------------------");
                }
                silkeZeBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Silke ze bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.bierpuntenSilke;
        }

        public int aftrekkenBierpuntenNick(int bierpuntenNick)
        {
            //bool bestaatNickZeBestand;
            string nickZeBierLocatie;
            int mogelijkOudeWaarde;
            nickZeBierLocatie = @"C:\Bierplicatie\Bierpunten\nickZeBier";

            mogelijkOudeWaarde = bestanden.bestandCheck(nickZeBierLocatie);

            if (mogelijkOudeWaarde != -999 && mogelijkOudeWaarde != -9999)
            {
                this.bierpuntenNick = mogelijkOudeWaarde;
            }

            this.bierpuntenNick = this.bierpuntenNick - bierpuntenNick;

            if (mogelijkOudeWaarde != -9999)
            {
                //string datum;
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter nickZeBierSchrijver = File.AppendText(@nickZeBierLocatie);

                using (nickZeBierSchrijver)
                {
                    nickZeBierSchrijver.WriteLine("{0}", vandaag, true);
                    nickZeBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    nickZeBierSchrijver.WriteLine("{0}", this.bierpuntenNick, true);
                    nickZeBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                nickZeBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Nick ze bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.bierpuntenNick;
        }

        public int aftrekkenBierpuntenDaniel(int bierpuntenDaniel)
        {
            string danielZeBierLocatie;

            danielZeBierLocatie = @"C:\Bierplicatie\Bierpunten\danielZeBier";

            int mogelijkOudeWaarde = bestanden.bestandCheck(danielZeBierLocatie);

            if (mogelijkOudeWaarde != -999 && mogelijkOudeWaarde != -9999)
            {
                this.bierpuntenDaniel = mogelijkOudeWaarde;
            }

            this.bierpuntenDaniel = this.bierpuntenDaniel - bierpuntenDaniel;

            if (mogelijkOudeWaarde != -9999)
            {
                //string datum;
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter danielZeBierSchrijver = File.AppendText(@danielZeBierLocatie);

                using (danielZeBierSchrijver)
                {
                    danielZeBierSchrijver.WriteLine("{0}", vandaag, true);
                    danielZeBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    danielZeBierSchrijver.WriteLine("{0}", this.bierpuntenDaniel, true);
                    danielZeBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                danielZeBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Daniel ze bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.bierpuntenDaniel;
        }

        public int aftrekkenBierpuntenEmma(int bierpuntenEmma)
        {
            string emmaHaarBierLocatie;

            emmaHaarBierLocatie = @"C:\Bierplicatie\Bierpunten\emmaHaarBier";

            int mogelijkOudeWaarde = bestanden.bestandCheck(emmaHaarBierLocatie);

            if (mogelijkOudeWaarde != -999 && mogelijkOudeWaarde != -9999)
            {
                this.bierpuntenEmma = mogelijkOudeWaarde;
            }

            this.bierpuntenEmma = this.bierpuntenEmma - bierpuntenEmma;

            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter emmaHaarBierSchrijver = File.AppendText(@emmaHaarBierLocatie);

                using (emmaHaarBierSchrijver)
                {
                    emmaHaarBierSchrijver.WriteLine("{0}", vandaag, true);
                    emmaHaarBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    emmaHaarBierSchrijver.WriteLine("{0}", this.bierpuntenEmma, true);
                    emmaHaarBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                emmaHaarBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Emma haar bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.bierpuntenEmma;
        }

        public int aftrekkenBierpuntenIngeLize(int bierpuntenIngeLize)
        {
            string ingeLizeHaarBierLocatie;

            ingeLizeHaarBierLocatie = @"C:\Bierplicatie\Bierpunten\ingeLizeHaarBier";

            int mogelijkOudeWaarde = bestanden.bestandCheck(@ingeLizeHaarBierLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.bierpuntenIngeLize = mogelijkOudeWaarde;
            }

            this.bierpuntenIngeLize = this.bierpuntenIngeLize - bierpuntenIngeLize;

            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter ingeLizeHaarBierSchrijver = File.AppendText(@ingeLizeHaarBierLocatie);

                using (ingeLizeHaarBierSchrijver)
                {
                    ingeLizeHaarBierSchrijver.WriteLine("{0}", vandaag);
                    ingeLizeHaarBierSchrijver.WriteLine("{0}", vandaag.DayOfWeek);
                    ingeLizeHaarBierSchrijver.WriteLine("{0}", this.bierpuntenIngeLize);
                    ingeLizeHaarBierSchrijver.WriteLine("---------------------------------------------");
                }
                ingeLizeHaarBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan IngeLize haar bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.bierpuntenIngeLize;
        }

        public int optellenAantalBierSilke(int aantalBierSilke)
        {
            string silkeZeAantalBierLocatie;
            if (aantalBierSilke != 0)
            {
                afspelen.afspelen(silkeZijnMuziekje);
            }

            silkeZeAantalBierLocatie = @"C:\Bierplicatie\AantalVanHuisgenoten\SilkeZeAantalBier.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(silkeZeAantalBierLocatie);

            if (mogelijkOudeWaarde != -999 && mogelijkOudeWaarde != -9999)
            {
                this.aantalBierSilke = mogelijkOudeWaarde;
            }

            this.aantalBierSilke = this.aantalBierSilke + aantalBierSilke;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter silkeZeAantalBierSchrijver = File.AppendText(silkeZeAantalBierLocatie);
                using (silkeZeAantalBierSchrijver)
                {
                    silkeZeAantalBierSchrijver.WriteLine("{0}", vandaag, true);
                    silkeZeAantalBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    silkeZeAantalBierSchrijver.WriteLine("{0}", this.aantalBierSilke, true);
                    silkeZeAantalBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                silkeZeAantalBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Silke ze aantal gedronken bier bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.aantalBierSilke;
        }

        public int optellenAantalBierNick(int aantalBierNick)
        {
            string nickZeAantalBierLocatie;
            //bool bestaatNickZeAantalBierBestand;

            nickZeAantalBierLocatie = @"C:\Bierplicatie\AantalVanHuisgenoten\NickZeAantalBier.txt";
            if (aantalBierNick != 0)
            {
                afspelen.afspelen(nickZijnMuziekje);
            }

            int mogelijkOudeWaarde = bestanden.bestandCheck(nickZeAantalBierLocatie);

            if (mogelijkOudeWaarde != -999 && mogelijkOudeWaarde != -9999)
            {
                this.aantalBierNick = mogelijkOudeWaarde;
            }

            this.aantalBierNick = this.aantalBierNick + aantalBierNick;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter nickZeAantalBierSchrijver = File.AppendText(nickZeAantalBierLocatie);
                using (nickZeAantalBierSchrijver)
                {
                    nickZeAantalBierSchrijver.WriteLine("{0}", vandaag, true);
                    nickZeAantalBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    nickZeAantalBierSchrijver.WriteLine("{0}", this.aantalBierNick, true);
                    nickZeAantalBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                nickZeAantalBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Nick ze aantal gedronken bier bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.aantalBierNick;
        }

        public int optellenAantalBierDaniel(int aantalBierDaniel)
        {
            string danielZeAantalBierLocatie;
            if (aantalBierDaniel != 0)
            {
                afspelen.afspelen(danielZijnMuziekje);
            }
            danielZeAantalBierLocatie = @"C:\Bierplicatie\AantalVanHuisgenoten\DanielZeAantalBier.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(danielZeAantalBierLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.aantalBierDaniel = mogelijkOudeWaarde;
            }

            this.aantalBierDaniel = this.aantalBierDaniel + aantalBierDaniel;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter danielZeAantalBierSchrijver = File.AppendText(danielZeAantalBierLocatie);
                using (danielZeAantalBierSchrijver)
                {
                    danielZeAantalBierSchrijver.WriteLine("{0}", vandaag, true);
                    danielZeAantalBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    danielZeAantalBierSchrijver.WriteLine("{0}", this.aantalBierDaniel, true);
                    danielZeAantalBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                danielZeAantalBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Daniel ze aantal gedronken bier bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.aantalBierDaniel;
        }

        public int optellenAantalBierEmma(int aantalBierEmma)
        {
            string emmaHaarAantalBierLocatie;
            if (aantalBierEmma != 0)
            {
                afspelen.afspelen(emmaHaarMuziekje);
            }
            emmaHaarAantalBierLocatie = @"C:\Bierplicatie\AantalVanHuisgenoten\EmmaHaarAantalBier.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(emmaHaarAantalBierLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.aantalBierEmma = mogelijkOudeWaarde;
            }

            this.aantalBierEmma = this.aantalBierEmma + aantalBierEmma;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter emmaHaarAantalBierSchrijver = File.AppendText(emmaHaarAantalBierLocatie);
                using (emmaHaarAantalBierSchrijver)
                {
                    emmaHaarAantalBierSchrijver.WriteLine("{0}", vandaag, true);
                    emmaHaarAantalBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    emmaHaarAantalBierSchrijver.WriteLine("{0}", this.aantalBierEmma, true);
                    emmaHaarAantalBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                emmaHaarAantalBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Emma ze aantal gedronken bier bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.aantalBierEmma;
        }

        public int optellenAantalBierIngeLize(int aantalBierIngeLize)
        {
            string ingeLizeHaarAantalBierLocatie;
            //bool bestaatIngeLizeHaarAantalBierBestand;
            if (aantalBierIngeLize != 0)
            {
                afspelen.afspelen(ingeLizeHaarMuziekje);
            }
            ingeLizeHaarAantalBierLocatie = @"C:\Bierplicatie\AantalVanHuisgenoten\IngeLizeHaarAantalBier.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(ingeLizeHaarAantalBierLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.aantalBierIngeLize = mogelijkOudeWaarde;
            }
            this.aantalBierIngeLize = this.aantalBierIngeLize + aantalBierIngeLize;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter ingeLizeHaarAantalBierSchrijver = File.AppendText(ingeLizeHaarAantalBierLocatie);
                using (ingeLizeHaarAantalBierSchrijver)
                {
                    ingeLizeHaarAantalBierSchrijver.WriteLine("{0}", vandaag, true);
                    ingeLizeHaarAantalBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    ingeLizeHaarAantalBierSchrijver.WriteLine("{0}", this.aantalBierIngeLize, true);
                    ingeLizeHaarAantalBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                ingeLizeHaarAantalBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan IngeLize ze aantal gedronken bier bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.aantalBierIngeLize;
        }

        public double optellenStatiegeldSilke(int aantalKrattenSilke)
        {
            string SilkeZijnStatiegeldLocatie = @"C:\Bierplicatie\Statiegeld\SilkeZijnStatiegeld.txt";
            double mogelijkOudeWaarde = bestanden.bestandCheckDouble(SilkeZijnStatiegeldLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.statiegeldSilke = mogelijkOudeWaarde;
            }
            this.statiegeldSilke = this.statiegeldSilke + (aantalKrattenSilke * 3.90);
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter silkeZijnStatiegeldSchrijver = File.AppendText(SilkeZijnStatiegeldLocatie);
                using (silkeZijnStatiegeldSchrijver)
                {
                    silkeZijnStatiegeldSchrijver.WriteLine("{0}", vandaag, true);
                    silkeZijnStatiegeldSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    silkeZijnStatiegeldSchrijver.WriteLine("{0}", this.statiegeldSilke, true);
                    silkeZijnStatiegeldSchrijver.WriteLine("---------------------------------------------", true);
                }
                silkeZijnStatiegeldSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Silke zijn statiegeld locatie bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.statiegeldSilke;
        }

        public double optellenStatiegeldDaniel(int aantalKrattenDaniel)
        {
            string danielZijnStatiegeldLocatie = @"C:\Bierplicatie\Statiegeld\DanielZijnStatiegeld.txt";
            double mogelijkOudeWaarde = bestanden.bestandCheckDouble(danielZijnStatiegeldLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.statiegeldDaniel = mogelijkOudeWaarde;
            }
            this.statiegeldDaniel = this.statiegeldDaniel + (aantalKrattenDaniel * 3.90);
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter danielZijnStatiegeldSchrijver = File.AppendText(danielZijnStatiegeldLocatie);
                using (danielZijnStatiegeldSchrijver)
                {
                    danielZijnStatiegeldSchrijver.WriteLine("{0}", vandaag, true);
                    danielZijnStatiegeldSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    danielZijnStatiegeldSchrijver.WriteLine("{0}", this.statiegeldDaniel, true);
                    danielZijnStatiegeldSchrijver.WriteLine("---------------------------------------------", true);
                }
                danielZijnStatiegeldSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Daniel zijn statiegeld locatie bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.statiegeldDaniel;
        }

        public double optellenStatiegeldNick(int aantalKrattenNick)
        {
            string nickZijnStatiegeldLocatie = @"C:\Bierplicatie\Statiegeld\NickZijnStatiegeld.txt";
            double mogelijkOudeWaarde = bestanden.bestandCheckDouble(nickZijnStatiegeldLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.statiegeldNick = mogelijkOudeWaarde;
            }
            this.statiegeldNick = this.statiegeldNick + (aantalKrattenNick * 3.90);
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter nickZijnStatiegeldSchrijver = File.AppendText(nickZijnStatiegeldLocatie);
                using (nickZijnStatiegeldSchrijver)
                {
                    nickZijnStatiegeldSchrijver.WriteLine("{0}", vandaag, true);
                    nickZijnStatiegeldSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    nickZijnStatiegeldSchrijver.WriteLine("{0}", this.statiegeldNick, true);
                    nickZijnStatiegeldSchrijver.WriteLine("---------------------------------------------", true);
                }
                nickZijnStatiegeldSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Nick zijn statiegeld locatie bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.statiegeldNick;
        }

        public double optellenStatiegeldEmma(int aantalKrattenEmma)
        {
            string emmaZijnStatiegeldLocatie = @"C:\Bierplicatie\Statiegeld\EmmaZijnStatiegeld.txt";
            double mogelijkOudeWaarde = bestanden.bestandCheckDouble(emmaZijnStatiegeldLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.statiegeldEmma = mogelijkOudeWaarde;
            }
            this.statiegeldEmma = this.statiegeldEmma + (aantalKrattenEmma * 3.90);
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter emmaZijnStatiegeldSchrijver = File.AppendText(emmaZijnStatiegeldLocatie);
                using (emmaZijnStatiegeldSchrijver)
                {
                    emmaZijnStatiegeldSchrijver.WriteLine("{0}", vandaag, true);
                    emmaZijnStatiegeldSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    emmaZijnStatiegeldSchrijver.WriteLine("{0}", this.statiegeldEmma, true);
                    emmaZijnStatiegeldSchrijver.WriteLine("---------------------------------------------", true);
                }
                emmaZijnStatiegeldSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Emma haar statiegeld locatie bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.statiegeldEmma;
        }

        public double optellenStatiegeldIngeLize(int aantalKrattenIngeLize)
        {
            string ingeLizeZijnStatiegeldLocatie = @"C:\Bierplicatie\Statiegeld\IngeLizeZijnStatiegeld.txt";
            double mogelijkOudeWaarde = bestanden.bestandCheckDouble(ingeLizeZijnStatiegeldLocatie);
            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.statiegeldIngeLize = mogelijkOudeWaarde;
            }
            this.statiegeldIngeLize = this.statiegeldIngeLize + (aantalKrattenIngeLize * 3.90);
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter ingeLizeZijnStatiegeldSchrijver = File.AppendText(ingeLizeZijnStatiegeldLocatie);
                using (ingeLizeZijnStatiegeldSchrijver)
                {
                    ingeLizeZijnStatiegeldSchrijver.WriteLine("{0}", vandaag, true);
                    ingeLizeZijnStatiegeldSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    ingeLizeZijnStatiegeldSchrijver.WriteLine("{0}", this.statiegeldIngeLize, true);
                    ingeLizeZijnStatiegeldSchrijver.WriteLine("---------------------------------------------", true);
                }
                ingeLizeZijnStatiegeldSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Inge-Lize haar statiegeld locatie bestand niet aanmaken", "Error", MessageBoxButtons.OK);
            }
            return this.statiegeldIngeLize;
        }

        public int optellenBierGastenSilke(int aantalBier)
        {
            string bierGastenSilkeLocatie;
            //bool bestaatIngeLizeHaarAantalBierBestand;

            bierGastenSilkeLocatie = @"C:\Bierplicatie\AantalVanGasten\SilkeZijnGast.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(bierGastenSilkeLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.bierGastenSilke = mogelijkOudeWaarde;
            }
            this.bierGastenSilke = this.bierGastenSilke + aantalBier;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter gastenBierSchrijver = File.AppendText(bierGastenSilkeLocatie);
                using (gastenBierSchrijver)
                {
                    gastenBierSchrijver.WriteLine("{0}", vandaag, true);
                    gastenBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    gastenBierSchrijver.WriteLine("{0}", this.bierGastenSilke, true);
                    gastenBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                gastenBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Silke zijn gastaccount niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.bierGastenSilke;
        }

        public int optellenBierGastenDaniel(int aantalBier)
        {
            string bierGastenDanielLocatie;
            //bool bestaatIngeLizeHaarAantalBierBestand;

            bierGastenDanielLocatie = @"C:\Bierplicatie\AantalVanGasten\DanielZijnGast.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(bierGastenDanielLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.bierGastenDaniel = mogelijkOudeWaarde;
            }
            this.bierGastenDaniel = this.bierGastenDaniel + aantalBier;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter gastenBierSchrijver = File.AppendText(bierGastenDanielLocatie);
                using (gastenBierSchrijver)
                {
                    gastenBierSchrijver.WriteLine("{0}", vandaag, true);
                    gastenBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    gastenBierSchrijver.WriteLine("{0}", this.bierGastenDaniel, true);
                    gastenBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                gastenBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Daniel zijn gastaccount niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.bierGastenDaniel;
        }

        public int optellenBierGastenNick(int aantalBier)
        {
            string bierGastenNickLocatie;
            //bool bestaatIngeLizeHaarAantalBierBestand;

            bierGastenNickLocatie = @"C:\Bierplicatie\AantalVanGasten\NickZijnGast.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(bierGastenNickLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.bierGastenNick = mogelijkOudeWaarde;
            }
            this.bierGastenNick = this.bierGastenNick + aantalBier;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter gastenBierSchrijver = File.AppendText(bierGastenNickLocatie);
                using (gastenBierSchrijver)
                {
                    gastenBierSchrijver.WriteLine("{0}", vandaag, true);
                    gastenBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    gastenBierSchrijver.WriteLine("{0}", this.bierGastenNick, true);
                    gastenBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                gastenBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Nick zijn gastaccount niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.bierGastenNick;
        }

        public int optellenBierGastenEmma(int aantalBier)
        {
            string bierGastenEmmaLocatie;
            //bool bestaatIngeLizeHaarAantalBierBestand;

            bierGastenEmmaLocatie = @"C:\Bierplicatie\AantalVanGasten\EmmaZijnGast.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(bierGastenEmmaLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.bierGastenEmma = mogelijkOudeWaarde;
            }
            this.bierGastenEmma = this.bierGastenEmma + aantalBier;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter gastenBierSchrijver = File.AppendText(bierGastenEmmaLocatie);
                using (gastenBierSchrijver)
                {
                    gastenBierSchrijver.WriteLine("{0}", vandaag, true);
                    gastenBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    gastenBierSchrijver.WriteLine("{0}", this.bierGastenEmma, true);
                    gastenBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                gastenBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Emma zijn gastaccount niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.bierGastenEmma;
        }

        public int optellenBierGastenIngelize(int aantalBier)
        {
            string bierGastenIngelizeLocatie;
            //bool bestaatIngeLizeHaarAantalBierBestand;

            bierGastenIngelizeLocatie = @"C:\Bierplicatie\AantalVanGasten\IngelizeZijnGast.txt";

            int mogelijkOudeWaarde = bestanden.bestandCheck(bierGastenIngelizeLocatie);

            if (mogelijkOudeWaarde != -9999 && mogelijkOudeWaarde != -999)
            {
                this.bierGastenIngeLize = mogelijkOudeWaarde;
            }
            this.bierGastenIngeLize = this.bierGastenIngeLize + aantalBier;
            if (mogelijkOudeWaarde != -9999)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter gastenBierSchrijver = File.AppendText(bierGastenIngelizeLocatie);
                using (gastenBierSchrijver)
                {
                    gastenBierSchrijver.WriteLine("{0}", vandaag, true);
                    gastenBierSchrijver.WriteLine("{0}", System.DateTime.Now.DayOfWeek, true);
                    gastenBierSchrijver.WriteLine("{0}", this.bierGastenIngeLize, true);
                    gastenBierSchrijver.WriteLine("---------------------------------------------", true);
                }
                gastenBierSchrijver.Dispose();
            }
            else
            {
                MessageBox.Show("Kan Ingelize zijn gastaccount niet aanmaken", "Error", MessageBoxButtons.OK);
            }

            return this.bierGastenIngeLize;
        }

        private string tempNaam;

        public string berekenenNieuweBierHaler()
        {
            int tempValue = 10000;

            if (bierpuntenDaniel <= tempValue)
            {
                tempNaam = "Daniel";
                tempValue = bierpuntenDaniel;
            }
            if (bierpuntenEmma < tempValue)
            {
                tempNaam = "Emma";
                tempValue = bierpuntenEmma;
            }
            if (bierpuntenEmma == tempValue)
            {
                tempNaam = tempNaam + " Emma";
                //tempNaam = "Emma";
                tempValue = bierpuntenEmma;
            }
            if (bierpuntenIngeLize < tempValue)
            {
                tempNaam = "Inge-Lize";
                tempValue = bierpuntenIngeLize;
            }
            if (bierpuntenIngeLize == tempValue)
            {
                tempNaam = tempNaam + " Inge-Lize";
                tempValue = bierpuntenIngeLize;
            }
            if (bierpuntenNick < tempValue)
            {
                tempNaam = "Nick";
                tempValue = bierpuntenNick;
            }
            if (bierpuntenNick == tempValue)
            {
                tempNaam = tempNaam + " Nick";
                tempValue = bierpuntenNick;
            }
            if (bierpuntenSilke < tempValue)
            {
                tempNaam = "Silke";
                tempValue = bierpuntenSilke;
            }
            if (bierpuntenSilke == tempValue)
            {
                tempNaam = tempNaam + " Silke";
                tempValue = bierpuntenSilke;
            }

            return tempNaam;
        }

        //public StreamReader aantalBierLezer;

        public int berekenenHuidigAantalBier()
        {
            string[] namen = new string[5];
            namen[0] = "Silke";
            namen[1] = "Nick";
            namen[2] = "Daniel";
            namen[3] = "Emma";
            namen[4] = "IngeLize";

            int aantalGehaaldeBiertjes = 0;
            List<string> uitLezen = new List<string>();

            for (int i = 0; i < namen.Count(); i++)
            {
                if (File.Exists(@"C:\Bierplicatie\Statiegeld\" + namen[i] + "ZijnStatiegeld.txt"))
                {
                    StreamReader statiegeldLezer = new StreamReader(@"C:\Bierplicatie\Statiegeld\" + namen[i] + "ZijnStatiegeld.txt");
                    string regel;
                    while ((regel = statiegeldLezer.ReadLine()) != null)
                    {
                        uitLezen.Add(regel);
                    }

                    string aantalBierGehaald = (uitLezen[uitLezen.Count - 2]);
                    double extraBier = Convert.ToDouble(aantalBierGehaald);

                    extraBier = extraBier / 3.9;

                    extraBier = extraBier * 24;

                    int tellopBier = Convert.ToInt32(extraBier);

                    aantalGehaaldeBiertjes = aantalGehaaldeBiertjes + tellopBier;

                    statiegeldLezer.Dispose();
                }
                else { }
            }

            int aantalGedronken = 0;

            uitLezen.Clear();

            for (int y = 0; y < namen.Count(); y++)
            {
                if (namen[y] != "Emma" && namen[y] != "IngeLize")
                {
                    if (File.Exists(@"C:\Bierplicatie\AantalVanHuisgenoten\" + namen[y] + "ZeAantalBier.txt"))
                    {
                        StreamReader aantalBierLezer = new StreamReader(@"C:\Bierplicatie\AantalVanHuisgenoten\" + namen[y] + "ZeAantalBier.txt");

                        string regel;
                        while ((regel = aantalBierLezer.ReadLine()) != null)
                        {
                            uitLezen.Add(regel);
                        }

                        string aantalBierGedronken = (uitLezen[uitLezen.Count - 2]);

                        int vertalen = Convert.ToInt32(aantalBierGedronken);

                        aantalGedronken = aantalGedronken + vertalen;
                        aantalBierLezer.Dispose();
                    }
                    else { }
                }
                else
                {
                    if (File.Exists(@"C:\Bierplicatie\AantalVanHuisgenoten\" + namen[y] + "HaarAantalBier.txt"))
                    {
                        StreamReader aantalBierLezer = new StreamReader(@"C:\Bierplicatie\AantalVanHuisgenoten\" + namen[y] + "HaarAantalBier.txt");

                        string regel;
                        while ((regel = aantalBierLezer.ReadLine()) != null)
                        {
                            uitLezen.Add(regel);
                        }

                        string aantalBierGedronken = (uitLezen[uitLezen.Count - 2]);

                        int vertalen = Convert.ToInt32(aantalBierGedronken);

                        aantalGedronken = aantalGedronken + vertalen;
                        aantalBierLezer.Dispose();
                    }
                    else { }
                }
            }

            uitLezen.Clear();

            for (int i = 0; i < namen.Count(); i++)
            {
                if (File.Exists(@"C:\Bierplicatie\AantalVanGasten\" + namen[i] + "ZijnGast.txt"))
                {
                    StreamReader gastenLezer = new StreamReader(@"C:\Bierplicatie\AantalVanGasten\" + namen[i] + "ZijnGast.txt");
                    string regel;
                    while ((regel = gastenLezer.ReadLine()) != null)
                    {
                        uitLezen.Add(regel);
                    }

                    string aantalBierGehaald = (uitLezen[uitLezen.Count - 2]);
                    int extraBier = Convert.ToInt32(aantalBierGehaald);

                    //int tellopBier = Convert.ToInt32(extraBier);

                    aantalGedronken = aantalGedronken + extraBier;

                    gastenLezer.Dispose();
                }
                else { }
            }

            aantalGehaaldeBiertjes = aantalGehaaldeBiertjes - aantalGedronken;

            return aantalGehaaldeBiertjes;
        }
    }
}