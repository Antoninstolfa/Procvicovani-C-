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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int Min = int.MaxValue;
            int Max = int.MinValue;
            int poradiMin = 0,vyskytMin = 0;
            int poradiMax = 0, vyskytMax = 0;
            int N = (int)numericUpDown1.Value;
            int cislo, pocitadlo = 0, pocitadloPrumer = 0;
            double prumer,soucet = 0;
            Random rng = new Random();
            while(N > 0)
            {
                pocitadlo++;
                cislo = rng.Next(-15, 60);
                listBox1.Items.Add(cislo);
                if (cislo < Min)
                {
                    Min = cislo;
                    poradiMin = pocitadlo;
                    soucet += cislo;
                    vyskytMin = 0;
                    pocitadloPrumer++;
                }
                if (Min == cislo) vyskytMin++;
                if (cislo > Max)
                {
                    Max = cislo;
                    poradiMax = pocitadlo;
                    soucet += cislo;
                    vyskytMax = 0;
                    pocitadloPrumer++;
                }
                if (Max == cislo) vyskytMax++;
                N--;
            }
            prumer = soucet / pocitadloPrumer;
            prumerLabel.Text = prumer.ToString();
            MaxPosloupnosti.Text = Max.ToString();
            MinPosloupnosti.Text = Min.ToString();
            PoradiMaxLabel.Text = poradiMax.ToString();
            PoradiMinLabel.Text = poradiMin.ToString();
            PocetVyskytuMax.Text = vyskytMax.ToString();
            PocetVyskytuMin.Text = vyskytMin.ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }
    }
}
