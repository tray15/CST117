namespace PiCalculator
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
            this.tb_userNumber = new System.Windows.Forms.TextBox();
            this.l_answer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.l_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of terms";
            // 
            // tb_userNumber
            // 
            this.tb_userNumber.Location = new System.Drawing.Point(159, 35);
            this.tb_userNumber.Name = "tb_userNumber";
            this.tb_userNumber.Size = new System.Drawing.Size(100, 20);
            this.tb_userNumber.TabIndex = 1;
            // 
            // l_answer
            // 
            this.l_answer.AutoSize = true;
            this.l_answer.Location = new System.Drawing.Point(17, 110);
            this.l_answer.Name = "l_answer";
            this.l_answer.Size = new System.Drawing.Size(41, 13);
            this.l_answer.TabIndex = 2;
            this.l_answer.Text = "answer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_result
            // 
            this.l_result.AutoSize = true;
            this.l_result.Location = new System.Drawing.Point(15, 84);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(40, 13);
            this.l_result.TabIndex = 4;
            this.l_result.Text = "l_result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 184);
            this.Controls.Add(this.l_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_answer);
            this.Controls.Add(this.tb_userNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_userNumber;
        private System.Windows.Forms.Label l_answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_result;
    }
}

