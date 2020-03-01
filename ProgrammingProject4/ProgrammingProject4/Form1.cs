using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var board = new int[3, 3];
            var labels = new Label[9]
            {
                label1, //  [0,0] upper left
                label2, //  [0,1] upper mid
                label3, //  [0,2] upper right
                label4, //  [1,0] mid left
                label5, //  [1,1] mid mid
                label6, //  [1,2] mid right
                label7, //  [2,0] lower left
                label8, //  [2,1] lower mid
                label9  //  [2,2] lower right
            };
            int labelsIndex = 0;

            var xo = new string[3, 3];

            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var value = r.Next(0, 2);
                    board[i, j] = value;
                    xo[i, j] = Convert.ToString(board[i, j]);
                    xo[i, j] = xo[i, j].Replace('0', 'O').Replace('1', 'X');
                    labels[labelsIndex++].Text = xo[i, j];
                    if (checkWin() == -1)
                    {
                        label10.Text = "Draw. Nobody won.";
                    }
                    if (checkWin() == 0) {
                        label10.Text = "Os won!";
                    } 
                    if (checkWin() == 1) {
                        label10.Text = "Xs won!";
                    }
                }
            }

           int checkWin()
           {
                for (var x = 0; x < 3; x++)
                {
                    if (board[x, 0] == board[x, 1] && board[x, 0] == board[x, 2])
                    {
                        return board[x, 0];
                    }
                }
                for (var y = 0; y < 3; y++)
                {
                    if (board[0, y] == board[1, y] && board[0, y] == board[2, y])
                    {
                        return board[0, y];
                    }
                }
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2,2])
                {
                    return board[1, 1];
                }
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    return board[1, 1];
                }
                else return -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
