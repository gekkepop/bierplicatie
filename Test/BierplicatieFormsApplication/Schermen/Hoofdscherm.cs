using Bierplicatie;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

/*--------------------------------------------------------------------
 * ONTHOUDEN!!!!
 * string bierhaler = opslaan.berekenenNieuweBierHaler();
 * MessageBox.Show("De bierhaler van deze keer is:" + bierhaler, "halen", MessageBoxButtons.OK);
 * */

namespace BierplicatieFormsApplication
{
    public partial class Hoofdscherm : Form
    {
        private OpslagApparaat opslaan = new OpslagApparaat();
        private formNaamWeergave weergaveNaam = new formNaamWeergave();
        //OverzichtPagina mijnOverzichtPagina = new OverzichtPagina();
        //weg gehaald, omdat anders met het wegklikken van de form dit object neit meer bestaat..

        private int aantalBierSilke, aantalBierNick, aantalBierDaniel, aantalBierIngelize, aantalBierEmma;

        //Form1 Gastenscherm = new Form1();

        private bool gasten;
        private bool invoer;

        public Hoofdscherm()
        {
            aantalBierDaniel = opslaan.aftrekkenBierpuntenDaniel(0);
            aantalBierSilke = opslaan.aftrekkenBierpuntenSilke(0);
            aantalBierNick = opslaan.aftrekkenBierpuntenNick(0);
            aantalBierIngelize = opslaan.aftrekkenBierpuntenIngeLize(0);
            aantalBierEmma = opslaan.aftrekkenBierpuntenEmma(0);

            InitializeComponent();

            //opslaan.berekenenHuidigAantalBier();
            silkeBierpuntenLabel.Text = aantalBierSilke.ToString();
            Kleuren(aantalBierSilke, "Silke");

            nickBierpuntenLabel.Text = aantalBierNick.ToString();
            Kleuren(aantalBierNick, "Nick");

            danielBierpuntenLabel.Text = aantalBierDaniel.ToString();
            Kleuren(aantalBierDaniel, "Daniel");

            emmaBierpuntenLabel.Text = aantalBierEmma.ToString();
            Kleuren(aantalBierEmma, "Emma");

            ingelizeBierpuntenLabel.Text = aantalBierIngelize.ToString();
            Kleuren(aantalBierIngelize, "Ingelize");

            OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
            OvergeblevenBierLabel.ForeColor = Color.White;

            /*
             * Open een thread, zodat die in het RAM blijft!!
             * */
            ThreadStart job = new ThreadStart(ThreadJob);
            Thread thread = new Thread(job);
            thread.Start();
        }

        //Deze thread is er dus alleen maar om in het ram te blijven.. Dan blijft die in ieder geval wat doen!
        private static void ThreadJob()
        {
            while (true)
            {
                Thread.Sleep(100);
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            /*opslaan.aftrekkenBierpuntenSilke(1);
            opslaan.aftrekkenBierpuntenNick(1);
            opslaan.aftrekkenBierpuntenDaniel(1);
            opslaan.aftrekkenBierpuntenEmma(1);
            opslaan.aftrekkenBierpuntenIngeLize(1);
            opslaan.optellenAantalBierSilke(1);
            opslaan.optellenAantalBierNick(1);
            opslaan.optellenAantalBierIngeLize(1);
            opslaan.optellenAantalBierEmma(1);
            opslaan.optellenAantalBierDaniel(1);
            opslaan.optellenStatiegeldSilke(1);
            opslaan.optellenStatiegeldDaniel(1);
            opslaan.optellenStatiegeldNick(1);
            opslaan.optellenStatiegeldEmma(1);
            opslaan.optellenStatiegeldIngeLize(1);*/
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        #region invoer
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.NumPad1:

                    if (gasten != true && invoer != true)
                    {
                        int i = opslaan.aftrekkenBierpuntenSilke(1);
                        silkeBierpuntenLabel.Text = i.ToString();
                        opslaan.optellenAantalBierSilke(1);
                        Kleuren(i, "Silke");
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer != true)
                    {
                        opslaan.optellenBierGastenSilke(1);
                        int i = opslaan.aftrekkenBierpuntenSilke(1);
                        silkeBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Silke");
                        gasten = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten != true && invoer == true)
                    {
                        int i = opslaan.aftrekkenBierpuntenSilke(-24);
                        opslaan.optellenStatiegeldSilke(1);
                        silkeBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Silke");
                        invoer = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer == true)
                    {
                        MessageBox.Show("Waarde voor invoer en voor gasten is tegelijk true, pas dit aan!", "Error", MessageBoxButtons.OK);
                    }
                    break;

                case Keys.NumPad2:
                    if (gasten != true && invoer != true)
                    {
                        int i = opslaan.aftrekkenBierpuntenNick(1);
                        opslaan.optellenAantalBierNick(1);
                        //nickBierPuntenText.Refresh();
                        nickBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Nick");
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer != true)
                    {
                        opslaan.optellenBierGastenNick(1);
                        int i = opslaan.aftrekkenBierpuntenNick(1);
                        nickBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Nick");
                        gasten = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten != true && invoer == true)
                    {
                        int i = opslaan.aftrekkenBierpuntenNick(-24);
                        opslaan.optellenStatiegeldNick(1);
                        nickBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Nick");
                        invoer = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer == true)
                    {
                        MessageBox.Show("Waarde voor invoer en voor gasten is tegelijk true, pas dit aan!", "Error", MessageBoxButtons.OK);
                    }
                    break;

                case Keys.NumPad3:
                    if (gasten != true && invoer != true)
                    {
                        int i = opslaan.aftrekkenBierpuntenDaniel(1);
                        danielBierpuntenLabel.Text = i.ToString();
                        opslaan.optellenAantalBierDaniel(1);
                        Kleuren(i, "Daniel");
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer != true)
                    {
                        opslaan.optellenBierGastenDaniel(1);
                        int i = opslaan.aftrekkenBierpuntenDaniel(1);
                        danielBierpuntenLabel.Text = i.ToString();
                        //opslaan.optellenAantalBierDaniel(1);
                        Kleuren(i, "Daniel");
                        gasten = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten != true && invoer == true)
                    {
                        int i = opslaan.aftrekkenBierpuntenDaniel(-24);
                        opslaan.optellenStatiegeldDaniel(1);
                        danielBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Daniel");
                        invoer = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer == true)
                    {
                        MessageBox.Show("Waarde voor invoer en voor gasten is tegelijk true, pas dit aan!", "Error", MessageBoxButtons.OK);
                    }
                    break;

                case Keys.NumPad4:
                    if (gasten != true && invoer != true)
                    {
                        opslaan.optellenAantalBierEmma(1);
                        int i = opslaan.aftrekkenBierpuntenEmma(1);
                        emmaBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Emma");
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer != true)
                    {
                        opslaan.optellenBierGastenEmma(1);
                        int i = opslaan.aftrekkenBierpuntenEmma(1);
                        emmaBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Emma");
                        gasten = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten != true && invoer == true)
                    {
                        int i = opslaan.aftrekkenBierpuntenEmma(-24);
                        opslaan.optellenStatiegeldEmma(1);
                        emmaBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Emma");
                        invoer = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer == true)
                    {
                        MessageBox.Show("Waarde voor invoer en voor gasten is tegelijk true, pas dit aan!", "Error", MessageBoxButtons.OK);
                    }
                    break;

                case Keys.NumPad5:
                    if (gasten != true && invoer != true)
                    {
                        int i = opslaan.aftrekkenBierpuntenIngeLize(1);
                        ingelizeBierpuntenLabel.Text = i.ToString();
                        opslaan.optellenAantalBierIngeLize(1);
                        Kleuren(i, "Ingelize");
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer != true)
                    {
                        opslaan.optellenBierGastenIngelize(1);
                        int i = opslaan.aftrekkenBierpuntenIngeLize(1);
                        ingelizeBierpuntenLabel.Text = i.ToString();
                        //opslaan.optellenAantalBierIngeLize(1);
                        Kleuren(i, "Ingelize");
                        gasten = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten != true && invoer == true)
                    {
                        int i = opslaan.aftrekkenBierpuntenIngeLize(-24);
                        opslaan.optellenStatiegeldIngeLize(1);

                        ingelizeBierpuntenLabel.Text = i.ToString();
                        Kleuren(i, "Ingelize");
                        invoer = false;
                        algemeneTekst();
                        OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                    }
                    else if (gasten == true && invoer == true)
                    {
                        MessageBox.Show("Waarde voor invoer en voor gasten is tegelijk true, pas dit aan!", "Error", MessageBoxButtons.OK);
                    }
                    break;

                case Keys.NumPad6:
                    if (invoer == false)
                    {
                        if (gasten == true)
                        {
                            gasten = false;
                            algemeneTekst();
                            OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                        }
                        else
                        {
                            gasten = true;
                            veranderingGastScherm();
                            OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                        }
                    }
                    break;

                case Keys.NumPad7:

                    if (gasten == false)
                    {
                        if (invoer == true)
                        {
                            invoer = false;
                            algemeneTekst();
                            OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                        }
                        else
                        {
                            invoer = true;
                            veranderingInvoerScherm();
                            OvergeblevenBierLabel.Text = opslaan.berekenenHuidigAantalBier().ToString();
                        }
                    }
                    break;

                case Keys.PageUp:
                    Overzichtspagina hetOverzicht = new Overzichtspagina();
                    hetOverzicht.Show();
                    break;

                default:
                    if (true)
                    {
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion invoer

        private void algemeneTekst()
        {
            labelSilkeWatVoor.Text = weergaveNaam.labelSilkeWatVoorHoofd;
            labelNickWatVoor.Text = weergaveNaam.labelNickWatVoorHoofd;
            labelDanielWatVoor.Text = weergaveNaam.labelDanielWatVoorHoofd;
            labelEmmaWatVoor.Text = weergaveNaam.labelEmmaWatVoorHoofd;
            labelIngelizeWatVoor.Text = weergaveNaam.labelIngelizeWatVoorHoofd;
            labelGastenWatVoor.Text = weergaveNaam.labelGastenWatVoorHoofd;
            labelInvoerWatVoor.Text = weergaveNaam.labelInvoerWatVoorHoofd;
            labelAantalOvergeblevenBier.Text = weergaveNaam.labelAantalOvergeblevenBierHoofd;
        }

        private void veranderingGastScherm()
        {
            labelSilkeWatVoor.Text = weergaveNaam.labelSilkeWatVoorGast;
            labelNickWatVoor.Text = weergaveNaam.labelNickWatVoorGast;
            labelDanielWatVoor.Text = weergaveNaam.labelDanielWatVoorGast;
            labelEmmaWatVoor.Text = weergaveNaam.labelEmmaWatVoorGast;
            labelIngelizeWatVoor.Text = weergaveNaam.labelIngelizeWatVoorGast;
            labelGastenWatVoor.Text = weergaveNaam.labelGastenWatVoorGast;
            labelInvoerWatVoor.Text = "";
        }

        private void veranderingInvoerScherm()
        {
            labelSilkeWatVoor.Text = weergaveNaam.labelSilkeWatVoorInvoer;
            labelNickWatVoor.Text = weergaveNaam.labelNickWatVoorInvoer;
            labelDanielWatVoor.Text = weergaveNaam.labelDanielWatVoorInvoer;
            labelEmmaWatVoor.Text = weergaveNaam.labelEmmaWatVoorInvoer;
            labelIngelizeWatVoor.Text = weergaveNaam.labelIngelizeWatVoorInvoer;
            labelGastenWatVoor.Text = "";
            labelInvoerWatVoor.Text = weergaveNaam.labelInvoerWatVoorInvoer;
        }

        private void Kleuren(int bierpunten, string labelNaam)
        {
            if (bierpunten < 0)
            {
                if (labelNaam == "Silke")
                {
                    silkeBierpuntenLabel.ForeColor = Color.Red;
                }
                else if (labelNaam == "Daniel")
                {
                    danielBierpuntenLabel.ForeColor = Color.Red;
                }
                else if (labelNaam == "Nick")
                {
                    nickBierpuntenLabel.ForeColor = Color.Red;
                }
                else if (labelNaam == "Emma")
                {
                    emmaBierpuntenLabel.ForeColor = Color.Red;
                }
                else if (labelNaam == "Ingelize")
                {
                    ingelizeBierpuntenLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                if (labelNaam == "Silke")
                {
                    silkeBierpuntenLabel.ForeColor = Color.White;
                }
                else if (labelNaam == "Daniel")
                {
                    danielBierpuntenLabel.ForeColor = Color.White;
                }
                else if (labelNaam == "Nick")
                {
                    nickBierpuntenLabel.ForeColor = Color.White;
                }
                else if (labelNaam == "Emma")
                {
                    emmaBierpuntenLabel.ForeColor = Color.White;
                }
                else if (labelNaam == "Ingelize")
                {
                    ingelizeBierpuntenLabel.ForeColor = Color.White;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            algemeneTekst();
        }

        private void danielBierPuntenText_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelSilkeWatVoor_Click(object sender, EventArgs e)
        {
        }

        private void labelInvoerWatVoor_Click(object sender, EventArgs e)
        {
        }
    }
}