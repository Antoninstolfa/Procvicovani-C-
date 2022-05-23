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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pocitadloL = 0, MinCislo = int.MaxValue;
                int soucin = 1, MaxCislo = int.MinValue;
                int cifernySoucetMax = 0;
                int[] pole = new int[textBox1.Lines.Count()];
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    pole[i] = Convert.ToInt32(textBox1.Lines[i]);
                }
                foreach (int cislo in pole)
                {
                    if (cislo % 2 != 0)
                    {
                        pocitadloL++;
                    }
                    if (cislo < MinCislo)
                    {
                        MinCislo = cislo;
                    }
                    if (cislo >= 5 && cislo < 20)
                    {
                        soucin *= cislo;
                    }
                    if (cislo > MaxCislo)
                    {
                        MaxCislo = cislo;
                    }
                }
                while (MaxCislo != 0)
                {
                    cifernySoucetMax += MaxCislo % 10;
                    MaxCislo = MaxCislo / 10;
                }
                PocetLichychLabel.Text = pocitadloL.ToString();
                MinCisloLabel.Text = MinCislo.ToString();
                if (soucin > 1)
                {
                    soucinCiselLabel.Text = soucin.ToString();
                }
                else
                {
                    soucinCiselLabel.Text = "0";
                }
                cifernySoucetMaxLabel.Text = cifernySoucetMax.ToString();
            }
            catch
            {
                MessageBox.Show("Zadejte pouze čísla!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
    }
}
