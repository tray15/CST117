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
            pb_circle_blue.Visible = false;
            pb_circle_red.Visible = false;
            pb_square_blue.Visible = false;
            pb_square_red.Visible = false;
            pb_triangle_blue.Visible = false;
            pb_triangle_red.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void b_show_Click(object sender, EventArgs e)
        {
            string shapeName;
            if (cb_name.Checked) {
                l_name.Visible = true;
                if (lb_shape.SelectedIndex != -1)
                {
                    shapeName = lb_shape.SelectedItem.ToString();
                    switch (shapeName)
                    {
                        case "Circle":
                            l_name.Text = "Circle";
                            break;
                        case "Square":
                            l_name.Text = "Square";
                            break;
                        case "Triangle":
                            l_name.Text = "Triangle";
                            break;
                    }
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
            if (lb_shape.SelectedIndex == 0 && rb_blue.Checked)
            {
                pb_circle_blue.Visible = true;
                pb_circle_red.Visible = false;
                pb_square_blue.Visible = false;
                pb_square_red.Visible = false;
                pb_triangle_blue.Visible = false;
                pb_triangle_red.Visible = false;
            }
            if (lb_shape.SelectedIndex == 0 && rb_red.Checked)
            {
                pb_circle_blue.Visible = false;
                pb_circle_red.Visible = true;
                pb_square_blue.Visible = false;
                pb_square_red.Visible = false;
                pb_triangle_blue.Visible = false;
                pb_triangle_red.Visible = false;
            }
            if (lb_shape.SelectedIndex == 1 && rb_blue.Checked)
            {
                pb_circle_blue.Visible = false;
                pb_circle_red.Visible = false;
                pb_square_blue.Visible = true;
                pb_square_red.Visible = false;
                pb_triangle_blue.Visible = false;
                pb_triangle_red.Visible = false;
            }
            if (lb_shape.SelectedIndex == 1 && rb_red.Checked)
            {
                pb_circle_blue.Visible = false;
                pb_circle_red.Visible = false;
                pb_square_blue.Visible = false;
                pb_square_red.Visible = true;
                pb_triangle_blue.Visible = false;
                pb_triangle_red.Visible = false;
            }
            if (lb_shape.SelectedIndex == 2 && rb_blue.Checked)
            {
                pb_circle_blue.Visible = false;
                pb_circle_red.Visible = false;
                pb_square_blue.Visible = false;
                pb_square_red.Visible = false;
                pb_triangle_blue.Visible = true;
                pb_triangle_red.Visible = false;
            }
            if (lb_shape.SelectedIndex == 2 && rb_red.Checked)
            {
                pb_circle_blue.Visible = false;
                pb_circle_red.Visible = false;
                pb_square_blue.Visible = false;
                pb_square_red.Visible = false;
                pb_triangle_blue.Visible = false;
                pb_triangle_red.Visible = true;
            }
        }
    }
}
