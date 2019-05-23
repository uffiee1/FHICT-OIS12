using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class BattleSim : Form
    {
        Random rnd = new Random();
        Spelers Ranger = new Spelers(100, Spelers.Type.Ranger);
        Spelers Warrior = new Spelers(100, Spelers.Type.Warrior);
        public BattleSim()
        {
            InitializeComponent();
        }

        private void CheckEndGame()
        {
            if (Ranger.HitPoints <= 0 || Warrior.HitPoints <= 0)
            {
                MessageBox.Show("end game");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLeft.Text = Warrior.HitPoints.ToString();
            lblRight.Text = Ranger.HitPoints.ToString();
        }

        private void BtnAttackLeft_Click(object sender, EventArgs e)
        {
            int damage = rnd.Next(0, 30);

            if (damage <= 0)
            {
                MessageBox.Show("Helaas, De hit was Mis!");
            }
            else if (damage >= 25)
            {
                MessageBox.Show("Geweldig! Dat was Critical Hit!");
            }
            Warrior.ApplyDamage(Warrior, damage);
            lblRight.Text = Warrior.HitPoints.ToString();

            BtnAttackLeft.Enabled = false;
            BtnAttackRight.Enabled = true;
            CheckEndGame();
            lblText.Text = "Well Done, De Beurt is nu bij PLAYER 2!";
        }

        private void BtnAttackRight_Click(object sender, EventArgs e)
        {

            int damage = rnd.Next(0, 30);

            if (damage <= 0)
            {
                MessageBox.Show("Helaas, De hit was Mis!");
            }
            else if (damage >= 25)
            {
                MessageBox.Show("Geweldig! Dat was Critical Hit!");
            }
            Ranger.ApplyDamage(Ranger, damage);
            lblLeft.Text = Ranger.HitPoints.ToString();

            BtnAttackLeft.Enabled = true;
            BtnAttackRight.Enabled = false;
            CheckEndGame();
            lblText.Text = "Well Done, De Beurt is nu bij PLAYER 1!";


        }
    }
}
