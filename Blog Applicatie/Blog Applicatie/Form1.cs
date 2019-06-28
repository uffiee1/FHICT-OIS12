using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog_Applicatie
{
    public partial class Form1 : Form
    {
        Gebruiker User1 = new Gebruiker(Gebruiker.Type.User1);
        Gebruiker User2 = new Gebruiker(Gebruiker.Type.User2);
        Gebruiker User3 = new Gebruiker(Gebruiker.Type.User3);
        Gebruiker User4 = new Gebruiker(Gebruiker.Type.User4);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (this.txbText.Text != "" && this.txbTitle.Text != "" && this.cbxAuthor.Text != "")
            {
                listBox1.Items.Add(this.txbTitle.Text + "\t" + this.txbText.Text + "\t\t" + this.cbxAuthor.Text + "\t\t" + DateTime.Now);

                this.txbText.Clear();
                this.txbTitle.Clear();
                this.txbTitle.Focus();
            }
            else
            {
                MessageBox.Show("You have left a field empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txbText.Clear();
            this.txbTitle.Clear();
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            List<Gebruiker> list = new List<Gebruiker>();
            list.Add(new Gebruiker() { Gebruikersaam = "Jean de Bonheu", Naam = "Jan" });
            list.Add(new Gebruiker() { Gebruikersaam = "Bea_for_president", Naam = "Bea" });
            list.Add(new Gebruiker() { Gebruikersaam = "Cora2001", Naam = "Cora" });
            list.Add(new Gebruiker() { Gebruikersaam = "Ufuk11", Naam = "Ufuk" });

            Gebruiker.DataSource = list;
            
        }
    }
}
