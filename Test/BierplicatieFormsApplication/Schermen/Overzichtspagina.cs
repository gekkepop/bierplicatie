using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BierplicatieFormsApplication
{
    public partial class Overzichtspagina : Form
    {
        public Overzichtspagina()
        {
            InitializeComponent();
        }

        private void Overzichtspagina_Load(object sender, EventArgs e)
        {
            statiegeldVeldenVullen();
            tabellenVullen();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.NumPad1)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
            }
            else if (keyData == Keys.NumPad2)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
            }
            else if (keyData == Keys.NumPad3)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
            }
            else if (keyData == Keys.NumPad4)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
            }
            else if (keyData == Keys.NumPad5)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
            }
            else if (keyData == Keys.NumPad6)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void statiegeldVeldenVullen()
        {
            UitleesApparaat opvragen = new UitleesApparaat();

            string statiegeldSilkeInText, statiegeldNickInText, statiegeldDanielInText, statiegeldEmmaInText, statiegeldIngelizeInText;

            statiegeldSilkeInText = opvragen.statiegeldUitrekenen("Silke");
            statiegeldSilke.Text = (@"€ " + statiegeldSilkeInText + "0");
            statiegeldNickInText = opvragen.statiegeldUitrekenen("Nick");
            statiegeldNick.Text = (@"€ " + statiegeldNickInText + "0");
            statiegeldDanielInText = opvragen.statiegeldUitrekenen("Daniel");
            statiegeldDaniel.Text = (@"€ " + statiegeldDanielInText + "0");
            statiegeldEmmaInText = opvragen.statiegeldUitrekenen("Emma");
            statiegeldEmma.Text = (@"€ " + statiegeldEmmaInText + "0");
            statiegeldIngelizeInText = opvragen.statiegeldUitrekenen("IngeLize");
            statiegeldIngelize.Text = (@"€ " + statiegeldIngelizeInText + "0");

            double statiegeldSilkeInDouble = Convert.ToDouble(statiegeldSilkeInText);
            double statiegeldNickInDouble = Convert.ToDouble(statiegeldNickInText);
            double statiegeldDanielInDouble = Convert.ToDouble(statiegeldDanielInText);
            double statiegeldEmmaInDouble = Convert.ToDouble(statiegeldEmmaInText);
            double statiegeldIngelizeInDouble = Convert.ToDouble(statiegeldIngelizeInText);

            double statiegeldTotaal = statiegeldSilkeInDouble + statiegeldNickInDouble + statiegeldDanielInDouble + statiegeldEmmaInDouble + statiegeldIngelizeInDouble;

            statiegeldTotaalSilkePagina.Text = (@"€ " + Convert.ToString(statiegeldTotaal) + "0");
            statiegeldTotaalNickPagina.Text = (@"€ " + Convert.ToString(statiegeldTotaal) + "0");
            statiegeldTotaalDanielPagina.Text = (@"€ " + Convert.ToString(statiegeldTotaal) + "0");
            statiegeldTotaalEmmaPagina.Text = (@"€ " + Convert.ToString(statiegeldTotaal) + "0");
            statiegeldTotaalIngelizePagina.Text = (@"€ " + Convert.ToString(statiegeldTotaal) + "0");
        }

        private void tabellenVullen()
        {
            UitleesApparaat opvragen = new UitleesApparaat();

            List<string> danielZijnBierVanAfgelopenWeekPerDag;
            List<string> silkeZijnBierVanAfgelopenWeekPerDag;
            List<string> nickZijnBierVanAfgelopenWeekPerDag;
            List<string> emmaZijnBierVanAfgelopenWeekPerDag;
            List<string> ingelizeZijnBierVanAfgelopenWeekPerDag;

            danielZijnBierVanAfgelopenWeekPerDag = opvragen.uitrekenen("Daniel");
            silkeZijnBierVanAfgelopenWeekPerDag = opvragen.uitrekenen("Silke");
            nickZijnBierVanAfgelopenWeekPerDag = opvragen.uitrekenen("Nick");
            emmaZijnBierVanAfgelopenWeekPerDag = opvragen.uitrekenen("Emma");
            ingelizeZijnBierVanAfgelopenWeekPerDag = opvragen.uitrekenen("IngeLize");

            SilkeChart.Series.Add("henk");
        }
    }
}