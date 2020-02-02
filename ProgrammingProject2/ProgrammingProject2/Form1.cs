using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            l_name.Visible = false;
            l_color.Visible = false;
            pb_circle_blue.Visible = false;
            pb_circle_red.Visible = false;
            pb_square_blue.Visible = false;
            pb_square_red.Visible = false;
            pb_triangle_blue.Visible = false;
            pb_triangle_red.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void b_show_Click(object sender, EventArgs e)
        {
            if (cb_name.Checked) {
                l_name.Visible = true;
                if (lb_shape.SelectedIndex != -1)
                {
                    l_name.Text = lb_shape.SelectedItem.ToString();
                }
            } else
            {
                l_name.Visible = false;
            }

            if (cb_color.Checked)
            {
                l_color.Visible = true;
                if (rb_blue.Checked)
                {
                    l_color.Text = "Blue";
                }
                if (rb_red.Checked)
                {
                    l_color.Text = "Red";
                }
            }
            else
            {
                l_color.Visible = false;
            }
            if (lb_shape.SelectedIndex == 0)
            {
                pb_circle_blue.Visible = rb_blue.Checked;
                pb_circle_red.Visible = rb_red.Checked;
            }
            else if (lb_shape.SelectedIndex == 1)
            {
                pb_square_blue.Visible = rb_blue.Checked;
                pb_square_red.Visible = rb_red.Checked;
            }
            else if (lb_shape.SelectedIndex == 2)
            {
                pb_triangle_blue.Visible = rb_blue.Checked;
                pb_triangle_red.Visible = rb_red.Checked;
            }
        }
    }
}
