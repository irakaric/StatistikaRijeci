using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatistikaRijeci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Dictionary<string, int> rijecnik = new Dictionary<string, int>();

            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                string line = textBox1.Lines[i].ToUpper();
                string[] rijeci = line.Split();

                foreach (string rijec in rijeci)
                {
                    if (rijecnik.ContainsKey(rijec) == true)
                    {
                        rijecnik[rijec]++;
                    }
                    else
                    {
                        rijecnik.Add(rijec, 1);
                    }
                }



            }

            var newList = rijecnik.OrderByDescending(x => x.Value).ToList();
            textBox2.Text = "Word   -   Number" + Environment.NewLine;
            textBox2.Text += "---------------------------------------------------" + Environment.NewLine;
            textBox2.Text += Environment.NewLine;

            foreach (KeyValuePair<string, int> pair in newList)
            {
                string par = $"{pair.Key} - {pair.Value}";
                textBox2.Text += par + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
