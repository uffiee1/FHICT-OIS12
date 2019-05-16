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

        private void btnStortenLinks_Click(object sender, EventArgs e)
        {
            decimal euro = Convert.ToDecimal(txtbxEuroLinks.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCentLinks.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroLinks.Text);

            decimal nieuwbedrag = bedrag + HuidigeBedrag;
            lblEuroLinks.Text = nieuwbedrag.ToString();
        }

        private void btnOpnemenLinks_Click(object sender, EventArgs e)
        {
            decimal euro = Convert.ToDecimal(txtbxEuroLinks.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCentLinks.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroLinks.Text);

            decimal nieuwbedrag = HuidigeBedrag - bedrag;
            lblEuroLinks.Text = nieuwbedrag.ToString();
        }

        private void btnStortenRechts_Click(object sender, EventArgs e)
        {
            decimal euro = Convert.ToDecimal(txtbxEuroRechts.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCentRechts.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroRechts.Text);

            decimal nieuwbedrag = bedrag + HuidigeBedrag;
            lblEuroRechts.Text = nieuwbedrag.ToString();
        }

        private void btnOpnemenRechts_Click(object sender, EventArgs e)
        {
            decimal euro = Convert.ToDecimal(txtbxEuroRechts.Text);
            decimal centen = Convert.ToDecimal(txtbxEuroCentRechts.Text) / 100;
            decimal bedrag = euro + centen;

            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroRechts.Text);

            decimal nieuwbedrag = HuidigeBedrag - bedrag;
            lblEuroRechts.Text = nieuwbedrag.ToString();
        }

        private void btnNaarRechts_Click(object sender, EventArgs e)
        {
            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroLinks.Text);
            decimal bedrag = Convert.ToDecimal(lblEuroRechts.Text);
            decimal NieuweBedrag = HuidigeBedrag + bedrag; 

            lblEuroRechts.Text = NieuweBedrag.ToString();

            double OudeBedrag = 0.00;
            lblEuroLinks.Text = OudeBedrag.ToString();

        }

        private void btnNaarLinks_Click(object sender, EventArgs e)
        {
            decimal HuidigeBedrag = Convert.ToDecimal(lblEuroRechts.Text);
            decimal bedrag = Convert.ToDecimal(lblEuroLinks.Text);
            decimal NieuweBedrag = HuidigeBedrag + bedrag;

            lblEuroLinks.Text = NieuweBedrag.ToString();
            double OudeBedrag = 0.00;
            lblEuroRechts.Text = OudeBedrag.ToString();
        }
    }
}