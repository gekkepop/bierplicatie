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
                System.DateTime laatsteGeschreven;
                laatsteGeschreven = File.GetLastWriteTime(waarIsHetBestand);
                StreamReader datumLezer = new StreamReader(@"C:\Bierplicatie\Config\DatumTijd.txt");

                string datum = datumLezer.ReadLine();
                datumLezer.Close();
                DateTime opstarttijd = Convert.ToDateTime(datum);

                if (opstarttijd > laatsteGeschreven)
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
                return -999;
            }
        }

        public double bestandCheckDouble(string waarIsHetBestand)
        {
            if (!File.Exists(waarIsHetBestand))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(waarIsHetBestand));
                FileStream bierStroom = File.Create(waarIsHetBestand);
                bierStroom.Close();
                return -999;
            }
            else
            {
                System.DateTime laatsteGeschreven;
                laatsteGeschreven = File.GetLastWriteTime(waarIsHetBestand);
                StreamReader tijdLezer = new StreamReader(@"C:\bierplicatie\Config\DatumTijd.txt");

                string datum = tijdLezer.ReadLine();
                tijdLezer.Close();
                DateTime opstarttijd = Convert.ToDateTime(datum);

                if (opstarttijd > laatsteGeschreven)
                {
                    StreamReader oudeWaardeVullen = new StreamReader(waarIsHetBestand);
                    List<string> oudewaardes = new List<string>();
                    string regel;
                    while ((regel = oudeWaardeVullen.ReadLine()) != null)
                    {
                        oudewaardes.Add(regel);
                    }
                    oudeWaardeVullen.Close();
                    string laatstewaarde = oudewaardes[(oudewaardes.Count - 2)];
                    double waarde;
                    try
                    {
                        //waarde = Convert.ToInt32(laatstewaarde);
                        waarde = Convert.ToDouble(laatstewaarde);
                        //File.Delete(waarIsHetBestand);

                        //FileStream create = File.Create(waarIsHetBestand);

                        //create.Close();

                        return waarde;
                    }
                    catch
                    {
                        MessageBox.Show(@"Kon waarde uit oude bestand niet lezen, heb je in de tekstbestanden gezeten?", "parse error", MessageBoxButtons.OK);
                        return -9999;
                    }
                }
                return -999;
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
                return -9999;
            }
        }
    }
}