using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
Tee Windows –tyylinen ohjelma (graafinen käyttöliittymä), jossa tehdään
valuuttamuunnos. Käyttäjä syöttää halutun euromäärän, jonka jälkeen valitaan,
mihin valuuttaan nähden muutos tehdään esim.: kruunut, ruplat tai US –dollari.
Tulos näkyy ikkunassa, kun painetaan muunna -nappia. 
 */
/*
Lisää tehtävän 11 tai 12 ohjelmaan menu–valikko, tip-tool sekä pop-up–menu. 
 */
namespace KoeTehtävä11
{
    public partial class Form1 : Form
    {
        string Teksti;
        double valuutta, eur;
        double kurssi, kurssi_kruunut, kurssi_ruplat, kurssi_dollari;
        
        public Form1()
        {
           
            kurssi_kruunut = 8.331806;
            kurssi_ruplat = 40.178750;
            kurssi_dollari = 1.307608;
            InitializeComponent();

            ToolTip buttonToolTip = new ToolTip();
            buttonToolTip.ToolTipTitle = ":D Vinkki";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;
            buttonToolTip.SetToolTip(Painike_Muunna, "Paina minua muuntaaksesi eurot halutuksi valuutaksi!");
            buttonToolTip.SetToolTip(määräEURO, "Iske € määrä tähän");
            buttonToolTip.SetToolTip(groupBox1, "Valitse mihin valuutta muunnetaan");
            
        }
      

        public void Paivita()
        {
            Muunnos.Items.Clear();
            
            try
            {
                eur = Convert.ToDouble(määräEURO.Text);
            }
            catch
            {
                eur = 0;
                MessageBox.Show("Syötä oikea arvo € kentään", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (Painike_kruunu.Checked == true)
            {
                kurssi = kurssi_kruunut;
                Teksti = "Kruunua:";
            }
            else if (Painike_ruplat.Checked == true)
            {
                kurssi = kurssi_ruplat;
                Teksti = "Ruplaa:";
            }
            else
            {
                kurssi = kurssi_dollari;
                Teksti = "Dollaria:";
            }


            valuutta = eur * kurssi;

            Muunnos.Items.Add(string.Format("{0}", Teksti));
            Muunnos.Items.Add(string.Format("{0:0.000}", valuutta));



        }


        public void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void Painike_Muunna_Click(object sender, EventArgs e)
        {
            Paivita();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
           
        }
    }
}
