using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BierplicatieFormsApplication
{
    class UitleesApparaat
    {
        
        StreamReader aantalBierLezer;
        StreamReader statiegeldLezer;

        private List<string> uitLezen = new List<string>();
        private List<string> BierTellerWeek = new List<string>();
        private List<string> statiegeldPersoon = new List<string>();

        public List<String> uitrekenen(string naam)
        {
            //eerst weer even de doorgeef list leeg maken
            BierTellerWeek.Clear();
            uitLezen.Clear();
            bool geenbier = false;
            if (naam == "Emma" || naam == "IngeLize")
            {
                try
                {
                    aantalBierLezer = new StreamReader(@"C:\bierplicatie\AantalVanHuisgenoten\" + naam + "HaarAantalBier.txt");
                }
                catch
                {
                    geenbier = true;
                }
            }
            else
            {
                try
                {
                    aantalBierLezer = new StreamReader(@"C:\bierplicatie\AantalVanHuisgenoten\" + naam + "ZeAantalBier.txt");
                }
                catch
                {
                    geenbier = true;
                }
            }

            string regel;
            if (geenbier == false)
            {
                while ((regel = aantalBierLezer.ReadLine()) != null)
                {
                    uitLezen.Add(regel);
                }
                aantalBierLezer.Dispose();
                DateTime vandaag = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                System.TimeSpan week = new TimeSpan(7, 0, 0, 0);
                vandaag = vandaag.Subtract(week);
                string doorGeefDatum = vandaag.ToString();
                string[] split = doorGeefDatum.Split(new Char[] { ' ' });

                doorGeefDatum = split[0];
                DateTime datumVorigeWeek = Convert.ToDateTime(doorGeefDatum);
                DateTime huidigeDatum = datumVorigeWeek.AddDays(7);
                int u = uitLezen.Count - 1;
                bool eersteDezeDag = true;

                while (datumVorigeWeek <= huidigeDatum)
                {
                    if (uitLezen[u].Contains(doorGeefDatum))
                    {
                        if (eersteDezeDag == true)
                        {
                            //MessageBox.Show("Aantal bier: " + uitLezen[u + 2]);

                            if (BierTellerWeek.Count() == 0)
                            {
                                if (uitLezen.Count <= 5)
                                {
                                    BierTellerWeek.Add(uitLezen[u + 2]);
                                }
                                else
                                {
                                    int huidigeWaarde = Convert.ToInt32(uitLezen[u + 2]);

                                    DateTime doorgeefDatumEigenlijk = Convert.ToDateTime(doorGeefDatum);

                                    string[] splitten = doorgeefDatumEigenlijk.ToString().Split(new Char[] { ' ' });
                                    int x = 0;

                                    while (!uitLezen[x].Contains(splitten[0]))
                                    {
                                        x++;
                                    }

                                    int vorigeWaarde = Convert.ToInt32(uitLezen[x - 2]);

                                    BierTellerWeek.Add(Convert.ToString(huidigeWaarde - vorigeWaarde));

                                    eersteDezeDag = false;
                                }
                            }
                            else
                            {
                                //int huidigbier;
                                int huidigeWaarde = Convert.ToInt32(uitLezen[u + 2]);

                                DateTime doorgeefDatumEigenlijk = Convert.ToDateTime(doorGeefDatum);

                                string[] splitten = doorgeefDatumEigenlijk.ToString().Split(new Char[] { ' ' });
                                int x = 0;

                                while (!uitLezen[x].Contains(splitten[0]))
                                {
                                    x++;
                                }

                                int vorigeWaarde = Convert.ToInt32(uitLezen[x - 2]);

                                BierTellerWeek.Add(Convert.ToString(huidigeWaarde - vorigeWaarde));

                                eersteDezeDag = false;
                            }
                        }

                    }
                    u = u - 1; //This is where the magic happends! ;)
                    if (u == 0)
                    {
                        datumVorigeWeek = datumVorigeWeek.AddDays(1);

                        doorGeefDatum = datumVorigeWeek.ToString();
                        split = doorGeefDatum.Split(new Char[] { ' ' });
                        doorGeefDatum = split[0];
                        u = uitLezen.Count - 1; //en we beginnen weer vanaf vooraf aan!

                        if (eersteDezeDag == true)
                        {
                            BierTellerWeek.Add("0");
                        }
                        eersteDezeDag = true;
                    }
                }
            }
            else
            {
                BierTellerWeek.Add("0");
            }

            return BierTellerWeek;
            
        }

        public string statiegeldUitrekenen(string naam)
        {
            bool uitlezen = true;
            try
            {
                statiegeldLezer = new StreamReader(@"C:\bierplicatie\Statiegeld\" + naam + "ZijnStatiegeld.txt");
            }
            catch
            {
                uitlezen = false;
            }
            
            string regel;
            try
            {
                while ((regel = statiegeldLezer.ReadLine()) != null)
                {
                    statiegeldPersoon.Add(regel);
                }
            }
            catch
            {
                uitlezen = false;
            }


            if (uitlezen == false)
            {
                return "0,0";
            }
            else
            {
                return statiegeldPersoon[statiegeldPersoon.Count - 2];
            }
        }
    }
}