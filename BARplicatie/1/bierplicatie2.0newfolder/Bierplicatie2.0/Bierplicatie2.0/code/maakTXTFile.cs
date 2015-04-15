using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bierplicatie2._0.code
{
    internal class maakTXTFile
    {
        public maakTXTFile()
        {
        }

        public int bestandCheck(string waarIsHetBestand)
        {
            if (!File.Exists(waarIsHetBestand))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(waarIsHetBestand));
                FileStream bierStroom = File.Create(waarIsHetBestand);
                bierStroom.Close();
                return 0;
            }
            else
            {
                StreamReader oudeWaardeVullen = new StreamReader(waarIsHetBestand);
                List<string> oudewaardes = new List<string>();
                string regel;
                while ((regel = oudeWaardeVullen.ReadLine()) != null)
                {
                    oudewaardes.Add(regel);
                }
                oudeWaardeVullen.Close();
                oudeWaardeVullen.Dispose();
                string laatstewaarde;
                try
                {
                    laatstewaarde = oudewaardes[(oudewaardes.Count - 2)];
                }
                catch
                {
                    laatstewaarde = "0";
                }
                int waarde;
                try
                {
                    waarde = Convert.ToInt32(laatstewaarde);

                    return waarde;
                }
                catch
                {
                    MessageBox.Show(@"Kon waarde uit oude bestand niet lezen, heb je in de tekstbestanden gezeten?", "parse error", MessageBoxButtons.OK);
                    return -9999;
                }
            }
        }

        public double bestandCheckDouble(string waarIsHetBestand)
        {
            if (!File.Exists(waarIsHetBestand))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(waarIsHetBestand));
                FileStream bierStroom = File.Create(waarIsHetBestand);
                bierStroom.Close();
                return 0;
            }
            else
            {
                StreamReader oudeWaardeVullen = new StreamReader(waarIsHetBestand);
                List<string> oudewaardes = new List<string>();
                string regel;
                string laatstewaarde;
                while ((regel = oudeWaardeVullen.ReadLine()) != null)
                {
                    oudewaardes.Add(regel);
                }
                oudeWaardeVullen.Close();
                try
                {
                    laatstewaarde = oudewaardes[(oudewaardes.Count - 2)];
                }
                catch
                {
                    laatstewaarde = "0";
                }

                try
                {
                    double waarde = Convert.ToDouble(laatstewaarde);

                    return waarde;
                }
                catch
                {
                    MessageBox.Show(@"Kon waarde uit oude bestand niet lezen, heb je in de tekstbestanden gezeten?", "parse error", MessageBoxButtons.OK);
                    return -9999;
                }
            }
        }

        public int wegSchrijven(string waarIsHetBestand, int aantalAfschrijven)
        {
            int mogelijkOUdeWaarde = bestandCheck(waarIsHetBestand);

            if (mogelijkOUdeWaarde > -800)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter wegSchrijven = File.AppendText(waarIsHetBestand);
                int nieuweWaarde = mogelijkOUdeWaarde - aantalAfschrijven;
                using (wegSchrijven)
                {
                    wegSchrijven.WriteLine("{0}", vandaag);
                    wegSchrijven.WriteLine("{0}", System.DateTime.Now.DayOfWeek);
                    wegSchrijven.WriteLine("{0}", nieuweWaarde);
                    wegSchrijven.WriteLine("---------------------------------------------");
                }

                wegSchrijven.Dispose();

                return nieuweWaarde;
            }
            else
            {
                MessageBox.Show("Kan niet werken in bestand op locatie " + waarIsHetBestand, "ERROR", MessageBoxButtons.OK);
                return mogelijkOUdeWaarde;
            }
        }

        public void wegSchrijvenDouble(string waarIsHetBestand, double aantalAfschrijven)
        {
            double mogelijkOUdeWaarde = bestandCheckDouble(waarIsHetBestand);

            if (mogelijkOUdeWaarde > -800)
            {
                System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

                StreamWriter wegSchrijven = File.AppendText(waarIsHetBestand);
                double nieuweWaarde = mogelijkOUdeWaarde + aantalAfschrijven;
                using (wegSchrijven)
                {
                    wegSchrijven.WriteLine("{0}", vandaag);
                    wegSchrijven.WriteLine("{0}", System.DateTime.Now.DayOfWeek);
                    wegSchrijven.WriteLine("{0}", nieuweWaarde);
                    wegSchrijven.WriteLine("---------------------------------------------");
                }

                wegSchrijven.Dispose();
            }
            else
            {
                MessageBox.Show("Kan niet werken in bestand op locatie " + waarIsHetBestand, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}