using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*

Tee graafinen käyttöliittymä ohjelmalle, missä lasketaan huoneen pinta-ala ja tilavuus.
Lomakkeella syötetään huoneen mitat (leveys, pituus ja korkeus), jonkajälkeen laske –nappia painettaessa saadaan selville
huoneen pinta-ala ja tilavuus. 
 */


namespace KoeTeht10
{
    public partial class KoeTeht10 : Form
    {
        public  KoeTeht10()
        {
            InitializeComponent();
           
        }
        double tilavuus = 0, pinta_ala = 0, leveys = 0, pituus = 0, korkeus = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Painike_Laske_Click(object sender, EventArgs e)
        {
            Tulokset.Items.Clear();
            try
            {
                leveys = Convert.ToDouble(TekstiBoxi_Leveys.Text);
                pituus = Convert.ToDouble(TekstiBoxi_Pituus.Text);
                korkeus = Convert.ToDouble(TekstiBoxi_Korkeus.Text);

            }
            catch
            {
                leveys = 0.0; pituus = 0.0; korkeus = 0.0;
            }

            pinta_ala = pituus * korkeus; //siis neliössä 
            tilavuus = pituus * leveys * korkeus;

            Tulokset.Items.Add(string.Format("Huoneen tilavuus:{0}", tilavuus));
            Tulokset.Items.Add(string.Format("Huoneen Pinta-ala:{0}", pinta_ala));
            
        }

        private void TextiBoxi_Pituus_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextiBoxi_Korkeus_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
