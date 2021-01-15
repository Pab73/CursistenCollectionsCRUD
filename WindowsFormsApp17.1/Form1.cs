﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cursist cursist = new Cursist();
        List<string> overzicht = new List<string>();
        List<string> lijstStudenten = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void Wegschrijven()
        {
            lbCursisten.DataSource = null;
            lbCursisten.DataSource = overzicht;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoorNaam.Text) || string.IsNullOrEmpty(txtFamilieNaam.Text))
            {
                MessageBox.Show("Naam en Voornaam moeten ingevuld worden. ", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cursist.VoorNaam = txtVoorNaam.Text;
                cursist.FamilieNaam = txtFamilieNaam.Text;
                overzicht.Add($"{cursist.VoorNaam} {cursist.FamilieNaam}. ");
                Wegschrijven();
                ClearTxtBoxes();
            }
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ClearTxtBoxes()
        {
            txtVoorNaam.Text = "";
            txtFamilieNaam.Text = "";
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            ClearTxtBoxes();
            overzicht.Remove((string)lbCursisten.SelectedItem);
            Wegschrijven();
        }
    }
}