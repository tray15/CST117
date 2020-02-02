using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void openFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                string text = File.ReadAllText(textBox1.Text);
                textBox2.Text = text;

                textBox3.Text = text.ToLower();

                string[] words = text.Split(' ');

                Array.Sort(words);
                
                textBox4.Text = "First word: " + words.First() + " | | " + "Last word: " + words.Last();

                string longest = "";
                
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > longest.Length)
                    {
                        longest = words[i];
                    }
                }

                int highestVowelCount = 0;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                for (int i = 0; i < words.Length; i++)
                {
                    int vowelCount = 0;
                    string word = words[i];

                    foreach (var vowel in vowels)
                    {
                        if (word.Contains(vowel))
                        {
                            vowelCount++;
                        }
                        if (highestVowelCount < vowelCount)
                        {
                            highestVowelCount = i;
                            longest = word;
                        }
                    }
                }
                textBox5.Text = longest;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] results = {textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };

            System.IO.File.WriteAllLines(@"C:\Users\Public\results.txt", results);
        }
    }
}
