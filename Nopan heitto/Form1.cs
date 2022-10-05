using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopan_heitto
{
    public partial class Form1 : Form
    {
        int luku1 = 0;
        int luku2 = 0;

        bool noppa1Heitetty = false;
        bool noppa2Heitetty = false;
        
        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPlayer1Roll_Click(object sender, EventArgs e)
        {

            noppa1Heitetty = true;

            Random rng = new Random();

            luku1 = rng.Next(1,7);

            labelPlayer1.Text = luku1.ToString();

            buttonPlayer1Roll.Enabled = false;

            // otetaan talteen, että pelaaja 1 on heittänyt nopan

            // jos pelaaja 2 on heittänyt nopan, tarkistetaan voittaja

            if (noppa2Heitetty == true)
            {
                checkWinner();
                
            }

        }

        private void buttonPlayer2Roll_Click(object sender, EventArgs e)
        {
            noppa2Heitetty = true;

            Random rng = new Random();

            luku2 = rng.Next(1, 7);

            labelPlayer2.Text = luku2.ToString();

            buttonPlayer2Roll.Enabled = false;

            // otetaan talteen, että pelaaja 2 on heittänyt nopan

            // jos pelaaja 1 on heittänyt nopan, tarkistetaan voittaja
            if (noppa1Heitetty == true)
            {
                checkWinner();
            }            

        }

        private void checkWinner()
        {
            if (luku1 > luku2)
            {
                labelWinner.Text = "Pelaaja 1 voitti";
            }
            if (luku1 < luku2)
            {
                labelWinner.Text = "Pelaaja 2 voitti";
            }

        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            // resetointi

            noppa1Heitetty = false;
            noppa2Heitetty = false;

            buttonPlayer1Roll.Enabled = true;
            buttonPlayer2Roll.Enabled = true;

            luku1 = 0;
            luku2 = 0;

            labelPlayer1.Text = luku1.ToString();
            labelPlayer2.Text = luku2.ToString();
            labelWinner.Text = "";
        }
    }
}
