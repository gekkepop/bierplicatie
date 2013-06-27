using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BierplicatieFormsApplication;


namespace Bierplicatie
{
    class MaakTXTFile
    {

        public MaakTXTFile()
        {
        }

        public int bestandCheck(string waarIsHetBestand)
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
                StreamReader frank = new StreamReader(@"C:\Bierplicatie\Config\DatumTijd.txt");

                string datum = frank.ReadLine();
                frank.Close();
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
                    int waarde;
                    try
                    {
                        waarde = Convert.ToInt32(laatstewaarde);
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

    }
}
