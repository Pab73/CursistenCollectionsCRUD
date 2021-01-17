using System;
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

        List<string> overzicht = new List<string>();

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
                Cursist cursist = new Cursist(txtVoorNaam.Text, txtFamilieNaam.Text);

                overzicht.Add($"{cursist.Naam}. ");
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
            Cursist cursist = new Cursist(txtVoorNaam.Text = "", txtFamilieNaam.Text = "");
        }
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            string volledigeNaam;
            volledigeNaam = (string)lbCursisten.SelectedItem;
            string[] deelVanNaam = volledigeNaam.Split(' ');
            for (int i = 1; i < deelVanNaam.Length; i++)
            {
                txtVoorNaam.Text = deelVanNaam[0];
                txtFamilieNaam.Text += deelVanNaam[i] + " ";
            }

            DialogResult dialogResult = MessageBox.Show($"Verwijderen van {lbCursisten.SelectedItem}. ", "Verwijderen. ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                ClearTxtBoxes();
                overzicht.Remove((string)lbCursisten.SelectedItem);
                Wegschrijven();
            }
            else if (dialogResult == DialogResult.No)
            {
                ClearTxtBoxes();
            }
        }
    }
}
