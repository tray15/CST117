namespace ProgrammingProject2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_shape = new System.Windows.Forms.ListBox();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.gb_color = new System.Windows.Forms.GroupBox();
            this.gb_details = new System.Windows.Forms.GroupBox();
            this.cb_color = new System.Windows.Forms.CheckBox();
            this.cb_name = new System.Windows.Forms.CheckBox();
            this.l_name = new System.Windows.Forms.Label();
            this.l_color = new System.Windows.Forms.Label();
            this.b_show = new System.Windows.Forms.Button();
            this.pb_circle_red = new System.Windows.Forms.PictureBox();
            this.pb_circle_blue = new System.Windows.Forms.PictureBox();
            this.pb_square_red = new System.Windows.Forms.PictureBox();
            this.pb_square_blue = new System.Windows.Forms.PictureBox();
            this.pb_triangle_red = new System.Windows.Forms.PictureBox();
            this.pb_triangle_blue = new System.Windows.Forms.PictureBox();
            this.gb_color.SuspendLayout();
            this.gb_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_circle_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_circle_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_square_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_square_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_triangle_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_triangle_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a shape";
            // 
            // lb_shape
            // 
            this.lb_shape.FormattingEnabled = true;
            this.lb_shape.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Triangle"});
            this.lb_shape.Location = new System.Drawing.Point(41, 56);
            this.lb_shape.Name = "lb_shape";
            this.lb_shape.Size = new System.Drawing.Size(120, 43);
            this.lb_shape.TabIndex = 1;
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.Location = new System.Drawing.Point(6, 24);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(45, 17);
            this.rb_red.TabIndex = 2;
            this.rb_red.TabStop = true;
            this.rb_red.Text = "Red";
            this.rb_red.UseVisualStyleBackColor = true;
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Location = new System.Drawing.Point(6, 47);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(46, 17);
            this.rb_blue.TabIndex = 3;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Blue";
            this.rb_blue.UseVisualStyleBackColor = true;
            // 
            // gb_color
            // 
            this.gb_color.Controls.Add(this.rb_red);
            this.gb_color.Controls.Add(this.rb_blue);
            this.gb_color.Location = new System.Drawing.Point(41, 105);
            this.gb_color.Name = "gb_color";
            this.gb_color.Size = new System.Drawing.Size(186, 76);
            this.gb_color.TabIndex = 4;
            this.gb_color.TabStop = false;
            this.gb_color.Text = "Select color";
            // 
            // gb_details
            // 
            this.gb_details.Controls.Add(this.cb_color);
            this.gb_details.Controls.Add(this.cb_name);
            this.gb_details.Location = new System.Drawing.Point(41, 187);
            this.gb_details.Name = "gb_details";
            this.gb_details.Size = new System.Drawing.Size(186, 71);
            this.gb_details.TabIndex = 5;
            this.gb_details.TabStop = false;
            this.gb_details.Text = "Select details";
            // 
            // cb_color
            // 
            this.cb_color.AutoSize = true;
            this.cb_color.Location = new System.Drawing.Point(6, 44);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(50, 17);
            this.cb_color.TabIndex = 1;
            this.cb_color.Text = "Color";
            this.cb_color.UseVisualStyleBackColor = true;
            // 
            // cb_name
            // 
            this.cb_name.AutoSize = true;
            this.cb_name.Location = new System.Drawing.Point(7, 20);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(54, 17);
            this.cb_name.TabIndex = 0;
            this.cb_name.Text = "Name";
            this.cb_name.UseVisualStyleBackColor = true;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(386, 297);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(35, 13);
            this.l_name.TabIndex = 7;
            this.l_name.Text = "label2";
            // 
            // l_color
            // 
            this.l_color.AutoSize = true;
            this.l_color.Location = new System.Drawing.Point(386, 328);
            this.l_color.Name = "l_color";
            this.l_color.Size = new System.Drawing.Size(35, 13);
            this.l_color.TabIndex = 8;
            this.l_color.Text = "label3";
            // 
            // b_show
            // 
            this.b_show.Location = new System.Drawing.Point(121, 298);
            this.b_show.Name = "b_show";
            this.b_show.Size = new System.Drawing.Size(106, 43);
            this.b_show.TabIndex = 9;
            this.b_show.Text = "Show";
            this.b_show.UseVisualStyleBackColor = true;
            this.b_show.Click += new System.EventHandler(this.b_show_Click);
            // 
            // pb_circle_red
            // 
            this.pb_circle_red.Image = global::ProgrammingProject2.Properties.Resources.circle_red;
            this.pb_circle_red.Location = new System.Drawing.Point(291, 56);
            this.pb_circle_red.Name = "pb_circle_red";
            this.pb_circle_red.Size = new System.Drawing.Size(230, 230);
            this.pb_circle_red.TabIndex = 6;
            this.pb_circle_red.TabStop = false;
            // 
            // pb_circle_blue
            // 
            this.pb_circle_blue.Image = global::ProgrammingProject2.Properties.Resources.circle_blue;
            this.pb_circle_blue.Location = new System.Drawing.Point(291, 56);
            this.pb_circle_blue.Name = "pb_circle_blue";
            this.pb_circle_blue.Size = new System.Drawing.Size(230, 230);
            this.pb_circle_blue.TabIndex = 10;
            this.pb_circle_blue.TabStop = false;
            // 
            // pb_square_red
            // 
            this.pb_square_red.Image = global::ProgrammingProject2.Properties.Resources.square_red;
            this.pb_square_red.Location = new System.Drawing.Point(291, 56);
            this.pb_square_red.Name = "pb_square_red";
            this.pb_square_red.Size = new System.Drawing.Size(230, 230);
            this.pb_square_red.TabIndex = 11;
            this.pb_square_red.TabStop = false;
            // 
            // pb_square_blue
            // 
            this.pb_square_blue.Image = global::ProgrammingProject2.Properties.Resources.square_blue;
            this.pb_square_blue.Location = new System.Drawing.Point(291, 56);
            this.pb_square_blue.Name = "pb_square_blue";
            this.pb_square_blue.Size = new System.Drawing.Size(230, 230);
            this.pb_square_blue.TabIndex = 12;
            this.pb_square_blue.TabStop = false;
            // 
            // pb_triangle_red
            // 
            this.pb_triangle_red.Image = global::ProgrammingProject2.Properties.Resources.triangle_red;
            this.pb_triangle_red.Location = new System.Drawing.Point(291, 56);
            this.pb_triangle_red.Name = "pb_triangle_red";
            this.pb_triangle_red.Size = new System.Drawing.Size(230, 230);
            this.pb_triangle_red.TabIndex = 13;
            this.pb_triangle_red.TabStop = false;
            // 
            // pb_triangle_blue
            // 
            this.pb_triangle_blue.Image = global::ProgrammingProject2.Properties.Resources.triangle_blue;
            this.pb_triangle_blue.Location = new System.Drawing.Point(291, 56);
            this.pb_triangle_blue.Name = "pb_triangle_blue";
            this.pb_triangle_blue.Size = new System.Drawing.Size(230, 230);
            this.pb_triangle_blue.TabIndex = 14;
            this.pb_triangle_blue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 378);
            this.Controls.Add(this.pb_triangle_blue);
            this.Controls.Add(this.pb_triangle_red);
            this.Controls.Add(this.pb_square_blue);
            this.Controls.Add(this.pb_square_red);
            this.Controls.Add(this.pb_circle_blue);
            this.Controls.Add(this.b_show);
            this.Controls.Add(this.l_color);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.pb_circle_red);
            this.Controls.Add(this.gb_details);
            this.Controls.Add(this.gb_color);
            this.Controls.Add(this.lb_shape);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_color.ResumeLayout(false);
            this.gb_color.PerformLayout();
            this.gb_details.ResumeLayout(false);
            this.gb_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_circle_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_circle_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_square_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_square_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_triangle_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_triangle_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_shape;
        private System.Windows.Forms.RadioButton rb_red;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.GroupBox gb_color;
        private System.Windows.Forms.GroupBox gb_details;
        private System.Windows.Forms.CheckBox cb_color;
        private System.Windows.Forms.CheckBox cb_name;
        private System.Windows.Forms.PictureBox pb_circle_red;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_color;
        private System.Windows.Forms.Button b_show;
        private System.Windows.Forms.PictureBox pb_circle_blue;
        private System.Windows.Forms.PictureBox pb_square_red;
        private System.Windows.Forms.PictureBox pb_square_blue;
        private System.Windows.Forms.PictureBox pb_triangle_red;
        private System.Windows.Forms.PictureBox pb_triangle_blue;
    }
}

