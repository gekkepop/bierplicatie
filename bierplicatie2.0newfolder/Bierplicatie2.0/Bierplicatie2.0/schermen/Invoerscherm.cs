﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bierplicatie2._0.code;

namespace Bierplicatie2._0.schermen
{
    public partial class Invoerscherm : Form
    {
        private List<string> personen;
        public bierKlasse hoofdklasse;
        private List<Label> groepsnamen;

        public Invoerscherm(List<string> personen)
        {
            InitializeComponent();
            this.personen = personen;
            groepsnamen = vulVoornamenList(personen);

            regelInhoudVeldenMetNamen(personen);
        }

        private List<Label> vulVoornamenList(List<string> personen)
        {
            List<Label> groepsnamenLijst = new List<Label>();
            // ophalen nu alle labels van de form.. Daar ben ik gebleven..
            //foreach(Label label in this.

            throw new NotImplementedException();
        }

        private void regelInhoudVeldenMetNamen(List<string> personen)
        {
            throw new NotImplementedException();
        }

        #region troep

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        #endregion troep
    }
}