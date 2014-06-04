using Bierplicatie2._0.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bierplicatie2._0
{
    public partial class Hoofdscherm : Form
    {
        public int status = 1;
        /*
         * Status bit..
         * status 1 = normaal invoer scherm
         * status 2 = gasten invoer scherm
         * status 3 = kratten invoer scherm
         * */

        private List<Label> labels = new List<Label>();
        private InvullenNaamVelden invullen = new InvullenNaamVelden();
        private List<Label> invoerNamenLabels;
        private List<Label> invoerHoeveelhedenLabels;
        private List<string> personen;
        public bierKlasse hoofdklasse;

        public Hoofdscherm(List<string> personen)
        {
            InitializeComponent();
            this.personen = personen;
            regelOpmaakForm(personen);
            regelInhoudVeldenMetNamen(personen);

            hoofdklasse = new bierKlasse(personen);

            regelInhoudAantallen();
        }

        #region vulNaamSchermen

        private void regelInhoudVeldenMetNamen(List<string> personen)
        {
            if (invoerNamenLabels == null)
            {
                invoerNamenLabels = maakListLabelsNamen(personen);
            }
            List<string> goedGevuldeList = invullen.terugGevenNamenMakkelijk(personen, status);
            LabelsEindelijkVullenMetNaam(goedGevuldeList);
        }

        private void regelInhoudVeldenMetNamen(List<string> personen, int statusVerandering)
        {
            status = statusVerandering;
            if (invoerNamenLabels == null)
            {
                invoerNamenLabels = maakListLabelsNamen(personen);
            }
            List<string> goedGevuldeList = invullen.terugGevenNamenMakkelijk(personen, status);
            LabelsEindelijkVullenMetNaam(goedGevuldeList);
        }

        private void LabelsEindelijkVullenMetNaam(List<string> goedGevuldeList)
        {
            int i = 0;
            foreach (Label labelVoorNaam in invoerNamenLabels)
            {
                try
                {
                    labelVoorNaam.Text = goedGevuldeList[i];
                    i++;
                }
                catch
                {
                    labelVoorNaam.Text = "";
                }
            }
        }

        private List<Label> maakListLabelsNamen(List<string> personen)
        {
            List<Label> labelsMetNamen = new List<Label>();
            switch (personen.Count)
            {
                case 5:
                    labelsMetNamen.Add(label1);
                    labelsMetNamen.Add(label2);
                    labelsMetNamen.Add(label3);
                    labelsMetNamen.Add(label4);
                    labelsMetNamen.Add(label5);
                    labelsMetNamen.Add(label8);
                    labelsMetNamen.Add(label9);
                    labelsMetNamen.Add(label10);
                    break;

                case 6:
                    labelsMetNamen.Add(label1);
                    labelsMetNamen.Add(label2);
                    labelsMetNamen.Add(label3);
                    labelsMetNamen.Add(label4);
                    labelsMetNamen.Add(label5);
                    labelsMetNamen.Add(label6);
                    labelsMetNamen.Add(label8);
                    labelsMetNamen.Add(label9);
                    labelsMetNamen.Add(label10);
                    break;

                case 7:
                    labelsMetNamen.Add(label1);
                    labelsMetNamen.Add(label2);
                    labelsMetNamen.Add(label3);
                    labelsMetNamen.Add(label4);
                    labelsMetNamen.Add(label5);
                    labelsMetNamen.Add(label6);
                    labelsMetNamen.Add(label7);
                    labelsMetNamen.Add(label8);
                    labelsMetNamen.Add(label9);
                    labelsMetNamen.Add(label10);
                    break;

                default:
                    break;
            }

            return labelsMetNamen;
        }

        #endregion vulNaamSchermen

        #region opmaak

        private void regelOpmaakForm(List<string> personen)
        {
            maakListLabels();
            List<int> locaties = uitlezenVeldenScherm(personen);
            plaatsenLabels(locaties);
        }

        private void plaatsenLabels(List<int> locaties)
        {
            int doortellen = 0;
            foreach (Label label in labels)
            {
                label.Location = new Point(locaties[doortellen], locaties[doortellen + 1]);
                doortellen = doortellen + 2;
            }
        }

        private void maakListLabels()
        {
            labels.Add(label1);
            labels.Add(label1Aantal);
            labels.Add(label2);
            labels.Add(label2Aantal);
            labels.Add(label3);
            labels.Add(label3Aantal);
            labels.Add(label4);
            labels.Add(label4Aantal);
            labels.Add(label5);
            labels.Add(label5Aantal);
            labels.Add(label6);
            labels.Add(label6Aantal);
            labels.Add(label7);
            labels.Add(label7Aantal);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label10Aantal);
        }

        private List<int> uitlezenVeldenScherm(List<string> personen)
        {
            List<int> locatiesOpInt = new List<int>();
            switch (personen.Count)
            {
                case 5:
                    string locatie5personen = @"C:/bierplicatie/config/locatieLabels5personen.txt";
                    locatiesOpInt = lezerVoorLocatie(locatie5personen);
                    break;

                case 6:
                    string locatie6personen = @"C:/bierplicatie/config/locatieLabels6personen.txt";
                    locatiesOpInt = lezerVoorLocatie(locatie6personen);
                    break;

                case 7:
                    string locatie7personen = @"C:/bierplicatie/config/locatieLabels7personen.txt";
                    locatiesOpInt = lezerVoorLocatie(locatie7personen);
                    break;

                default:
                    MessageBox.Show("Er zijn meer als 7 of minder als 5 ingevuld. Dit klopt niet!!!");
                    Application.Exit();
                    break;
            }

            return locatiesOpInt;
        }

        private List<int> lezerVoorLocatie(string locatie)
        {
            List<string> locatiesOpÉénRegelInString = new List<string>();
            List<int> locatiesLosInInt = new List<int>();
            StreamReader locatielezer = new StreamReader(locatie);
            string ingelezenRegel;
            while ((ingelezenRegel = locatielezer.ReadLine()) != null)
            {
                locatiesOpÉénRegelInString.Add(ingelezenRegel);
            }
            //nu locaties splitten op x en y en in een list van intergers zetten
            foreach (string regelInList in locatiesOpÉénRegelInString)
            {
                string[] gesplitst = regelInList.Split(' ');
                locatiesLosInInt.Add(Int32.Parse(gesplitst[0]));
                locatiesLosInInt.Add(Int32.Parse(gesplitst[1]));
            }
            locatielezer.Close();
            return locatiesLosInInt;
        }

        #endregion opmaak

        #region Invoer

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.NumPad1:
                    invoerKey1();
                    break;

                case Keys.NumPad2:
                    break;

                case Keys.NumPad3:
                    break;

                case Keys.NumPad4:
                    break;

                case Keys.NumPad5:
                    break;

                case Keys.NumPad6:
                    invoerKey6();
                    break;

                case Keys.NumPad7:
                    invoerKey7();
                    break;

                case Keys.NumPad8:
                    invoerKey8();
                    break;

                case Keys.NumPad9:
                    invoerKey9();
                    break;

                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void invoerKey1()
        {
            biertjeAangeslagen(0);
        }


        private void biertjeAangeslagen(int wie)
        {
            int nieuwewaarde = hoofdklasse.optellenBierPunten(wie, 1);
            invoerHoeveelhedenLabels[wie].Text = "" + nieuwewaarde;
            kleuren();
        }

        private void kleuren()
        {
            foreach (Label label in invoerHoeveelhedenLabels)
            {
                String hoeveelheid = label.Text;
                int aantal = Convert.ToInt32(hoeveelheid);
                if(aantal >= 0)
                {
                    label.ForeColor = Color.White;
                }
                else
                {
                    label.ForeColor = Color.Red;
                }
            }
        
        }

        private void invoerKey6()
        {
            switch (personen.Count)
            {
                case 5:
                    if (status == 1)
                    {
                        regelInhoudVeldenMetNamen(personen, 2);
                    }
                    else if (status == 2)
                    {
                        regelInhoudVeldenMetNamen(personen, 1);
                    }
                    break;

                case 6:
                    break;

                default:
                    break;
            }
        }

        private void invoerKey7()
        {
            switch (personen.Count)
            {
                case 5:
                    if (status == 1)
                    {
                        regelInhoudVeldenMetNamen(personen, 3);
                    }
                    else if (status == 3)
                    {
                        regelInhoudVeldenMetNamen(personen, 1);
                    }
                    break;

                case 6:
                    if (status == 1)
                    {
                        regelInhoudVeldenMetNamen(personen, 2);
                    }
                    else if (status == 2)
                    {
                        regelInhoudVeldenMetNamen(personen, 1);
                    }
                    break;

                default:
                    break;
            }
        }

        private void invoerKey8()
        {
            switch (personen.Count)
            {
                case 5:

                    break;

                case 6:
                    if (status == 1)
                    {
                        regelInhoudVeldenMetNamen(personen, 3);
                    }
                    else if (status == 3)
                    {
                        regelInhoudVeldenMetNamen(personen, 1);
                    }
                    break;

                case 7:
                    if (status == 1)
                    {
                        regelInhoudVeldenMetNamen(personen, 2);
                    }
                    else if (status == 2)
                    {
                        regelInhoudVeldenMetNamen(personen, 1);
                    }
                    break;

                default:
                    break;
            }
        }

        private void invoerKey9()
        {
            switch (personen.Count)
            {
                case 5:

                    break;

                case 6:

                    break;

                case 7:
                    if (status == 1)
                    {
                        regelInhoudVeldenMetNamen(personen, 3);
                    }
                    else if (status == 3)
                    {
                        regelInhoudVeldenMetNamen(personen, 1);
                    }
                    break;

                default:
                    break;
            }
        }

        #endregion Invoer

        #region vullenAantallenBier

        private void regelInhoudAantallen()
        {
            if (invoerHoeveelhedenLabels == null)
            {
                invoerHoeveelhedenLabels = maakListLabelsMetAantallenPersonen();
            }
            List<int> goedGevuldeList = hoofdklasse.leesBierpunten();
            //LabelsEindelijkVullenMetNaam(goedGevuldeList);
            LabelsEindelijkVullenMetHoeveelheid(goedGevuldeList);
        }

        private void LabelsEindelijkVullenMetHoeveelheid(List<int> goedGevuldeList)
        {
            int i = 0;
            foreach (Label label in invoerHoeveelhedenLabels)
            {
                label.Text = goedGevuldeList[i].ToString();
                i++;
            }
            kleuren();
        }

        private List<Label> maakListLabelsMetAantallenPersonen()
        {
            List<Label> teruggeeflist = new List<Label>();
            switch (personen.Count)
            {
                case 5:
                    teruggeeflist.Add(label1Aantal);
                    teruggeeflist.Add(label2Aantal);
                    teruggeeflist.Add(label3Aantal);
                    teruggeeflist.Add(label4Aantal);
                    teruggeeflist.Add(label5Aantal);

                    break;

                case 6:
                    teruggeeflist.Add(label1Aantal);
                    teruggeeflist.Add(label2Aantal);
                    teruggeeflist.Add(label3Aantal);
                    teruggeeflist.Add(label4Aantal);
                    teruggeeflist.Add(label5Aantal);
                    teruggeeflist.Add(label6Aantal);

                    break;

                case 7:
                    teruggeeflist.Add(label1Aantal);
                    teruggeeflist.Add(label2Aantal);
                    teruggeeflist.Add(label3Aantal);
                    teruggeeflist.Add(label4Aantal);
                    teruggeeflist.Add(label5Aantal);
                    teruggeeflist.Add(label6Aantal);
                    teruggeeflist.Add(label7Aantal);
                    break;

                default:
                    break;
            }
            return teruggeeflist;
        }

        #endregion vullenAantallenBier
    }
}