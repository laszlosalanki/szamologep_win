using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep_win
{
    public partial class Szamologep : Form
    {
        public Szamologep()
        {
            InitializeComponent();
        }

        string ki = "";
        double a, b;

        public void kiir(string ki) {
            eredmeny.Text = ki;
        }

        public void darabol(string ki, char x)
        {
            string[] darabok = ki.Split(x);
            a = double.Parse(darabok[0]);
            if (!ki.Contains('g'))
            {
                b = double.Parse(darabok[1]);
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "1";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "2";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "3";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "4";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "5";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "6";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "7";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "8";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "9";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "0";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "+";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "*";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void pow_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "^";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            ki = "";
            kiir(ki);
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (ki != null && 0 < ki.Length)
            {
                ki = ki.Substring(0, ki.Length - 1);
            }
            kiir(ki);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "-";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += "/";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                double gyok = Convert.ToDouble(ki);
                gyok = Math.Sqrt(gyok);
                ki = Convert.ToString(gyok);
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void sem_Click(object sender, EventArgs e)
        {
            if (ki.Length <= 77)
            {
                ki += ",";
                kiir(ki);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
            }
        }

        private void Szamologep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                if (ki.Length <= 77)
                {
                    ki += "1";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D2)
            {
                if (ki.Length <= 77)
                {
                    ki += "2";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D3)
            {
                if (ki.Length <= 77)
                {
                    ki += "3";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D4)
            {
                if (ki.Length <= 77)
                {
                    ki += "4";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D5)
            {
                if (ki.Length <= 77)
                {
                    ki += "5";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D6)
            {
                if (ki.Length <= 77)
                {
                    ki += "6";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D7)
            {
                if (ki.Length <= 77)
                {
                    ki += "7";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D9)
            {
                if (ki.Length <= 77)
                {
                    ki += "8";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.D0)
            {
                if (ki.Length <= 77)
                {
                    ki += "0";
                    kiir(ki);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Nem tudsz több karaktert beírni!");
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (ki != null && 0 < ki.Length)
                {
                    ki = ki.Substring(0, ki.Length - 1);
                }
                kiir(ki);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                eq_Click(sender, e);
            }
        }

        private void eq_Click(object sender, EventArgs e)
        {
            if (ki.Contains('+'))
            {
                darabol(ki, '+');
                double osszeg = a + b;
                ki = Convert.ToString(osszeg);
                kiir(ki);
            }
            else if (ki.Contains('-'))
            {
                darabol(ki, '-');
                double kulonbseg = a - b;
                ki = Convert.ToString(kulonbseg);
                kiir(ki);
            }
            else if (ki.Contains('*'))
            {
                darabol(ki, '*');
                double szorzat = a * b;
                ki = Convert.ToString(szorzat);
                kiir(ki);
            }
            else if (ki.Contains('/'))
            {
                darabol(ki, '/');
                double hanyados = a / b;
                ki = Convert.ToString(hanyados);
                kiir(ki);
            }
            else if (ki.Contains('^'))
            {
                darabol(ki, '^');
                double hatvany = Math.Pow(a, b);
                ki = Convert.ToString(hatvany);
                kiir(ki);
            }
        }
    }
}
