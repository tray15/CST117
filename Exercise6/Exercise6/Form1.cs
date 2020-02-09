using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            b_restart.Enabled = false;
        }

        int clickCounter = 0;


        private void b_roll_Click(object sender, EventArgs e)
        {
            int sides = new Random().Next(4, 21);
            var rng = new Random();

            var die1 = new Dice(sides, rng);
            var die2 = new Dice(sides, rng);

            int roll1 = die1.rollDie();
            int roll2 = die2.rollDie();

            label1.Text = roll1.ToString();
            label2.Text = roll2.ToString();

            clickCounter++;

            if (roll1 == 1 && roll2 == 1)
            {
                label3.Text = "It took " + clickCounter + " roll(s) to get snake eyes!";
                b_restart.Enabled = true;
                b_roll.Enabled = false;
            }

        }

        class Dice
        {
            private int sides;
            private Random random;

            public Dice(int sides, Random rng)
            {
                this.sides = sides;
                this.random = rng;
            }

            public int rollDie()
            {
                return this.random.Next(1, this.sides + 1);
            }
        }

        private void b_restart_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            label2.Text = "2";
            label3.Text = "";
            b_roll.Enabled = true;
            b_restart.Enabled = false;
            clickCounter = 0;
        }
    }
}
