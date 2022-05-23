using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkoly_na_procvičování
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LawnGreen;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gold;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.LawnGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.LawnGreen;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Gold;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rng = new Random();
            double cislo;
            for (int N = (int)numericUpDown1.Value; N > 0;N--)
            {
                cislo = rng.Next(-5, 20);
                listBox1.Items.Add(cislo);
                if(cislo > 2 && cislo <=5)
                {
                    MessageBox.Show("Číslo v intervalu (2,5> bylo nalezeno", "Konec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rng = new Random();
            double cislo;
            bool konec = false;
            for (int N = (int)numericUpDown1.Value; N > 0 && konec != true; N--)
            {
                cislo = rng.Next(-5, 20);
                listBox1.Items.Add(cislo);
                if (cislo > 2 && cislo <= 5)
                {
                    MessageBox.Show("Číslo v intervalu (2,5> bylo nalezeno", "Konec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    konec = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rng = new Random();
            double cislo;
            bool konec = false;
            int N = (int)numericUpDown1.Value;
            while(N > 0 && konec != true)
            {
                cislo = rng.Next(-5, 20);
                listBox1.Items.Add(cislo);
                if (cislo > 2 && cislo <= 5)
                {
                    MessageBox.Show("Číslo v intervalu (2,5> bylo nalezeno", "Konec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    konec = true;
                }
                N--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rng = new Random();
            double cislo;
            bool konec = false;
            int N = (int)numericUpDown1.Value;
            do
            {
                cislo = rng.Next(-5, 20);
                listBox1.Items.Add(cislo);
                if (cislo > 2 && cislo <= 5)
                {
                    MessageBox.Show("Číslo v intervalu (2,5> bylo nalezeno", "Konec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    konec = true;
                }
                N--;
            } while (N > 0 && konec != true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
