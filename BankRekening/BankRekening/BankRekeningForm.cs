using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRekening
{
    public partial class BankRekeningForm : Form
    {
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;


        public BankRekeningForm()
        {
            InitializeComponent();
            bankrekeningLinks = new Bankrekening("Ufuk Angay");
            bankrekeningRechts = new Bankrekening("Siy Nadiroglu");
        }

        public decimal ConvertStorten(string text)
        {
            decimal euro = Convert.ToDecimal(txtbxEuro.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCent.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroLinks.Text);

            decimal nieuwbedrag = bedrag + HuidigeBedrag;
            lblEuroLinks.Text = nieuwbedrag.ToString();
            return (nieuwbedrag);
        }

        public decimal ConvertOpnemen(string harry)
        {
            decimal euro = Convert.ToDecimal(txtbxEuro.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCent.Text) / 100;
            decimal bedrag = euro + centen;

            decimal huidigeBedrag = Convert.ToDecimal(harry);

            decimal nieuwbedrag = huidigeBedrag - bedrag;
        
            return (nieuwbedrag);
        }

        public void btnStortenLinks_Click(object sender, EventArgs e)
        {
          decimal nieuwbedrag = ConvertStorten(lblEuroLinks.Text);
            lblEuroLinks.Text = nieuwbedrag.ToString();
        }

        private void btnOpnemenLinks_Click(object sender, EventArgs e)
        {
            decimal nieuwbedrag = ConvertOpnemen(lblEuroLinks.Text);
            lblEuroLinks.Text = nieuwbedrag.ToString();
        }

        private void btnStortenRechts_Click(object sender, EventArgs e)
        {
            decimal nieuwbedrag = ConvertStorten(lblEuroRechts.Text);
            lblEuroRechts.Text = nieuwbedrag.ToString();
        }

        private void btnOpnemenRechts_Click(object sender, EventArgs e)
        {
           decimal nieuwbedrag = ConvertOpnemen(lblEuroRechts.Text);
            lblEuroRechts.Text = nieuwbedrag.ToString();
        }

        private void btnNaarRechts_Click(object sender, EventArgs e)
        {

            decimal euro = Convert.ToDecimal(txtbxEuro.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCent.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroLinks.Text);
            decimal BedragRechterkant = Convert.ToDecimal(lblEuroRechts.Text);
            decimal NieuwBedragLinks = HuidigeBedrag - bedrag;

            lblEuroLinks.Text = NieuwBedragLinks.ToString();
            decimal nieuwbedragRechts = BedragRechterkant + bedrag;
            lblEuroRechts.Text = nieuwbedragRechts.ToString();
        }

        private void btnNaarLinks_Click(object sender, EventArgs e)
        {
            decimal euro = Convert.ToDecimal(txtbxEuro.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCent.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroRechts.Text);
            decimal BedragLinkerKant = Convert.ToDecimal(lblEuroLinks.Text);
            decimal NieuwBedragRechts = HuidigeBedrag - bedrag;

            lblEuroRechts.Text = NieuwBedragRechts.ToString();
            decimal nieuwbedragLinks = BedragLinkerKant + bedrag;
            lblEuroLinks.Text = nieuwbedragLinks.ToString();
        }
    }
}
