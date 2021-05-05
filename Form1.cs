using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "αx² + βx + γ = 0";
                int a = int.Parse(alpha.Text);
                int b = int.Parse(vita.Text);
                int g = int.Parse(gama.Text);


                float x = 0;
                float x1 = 0;
                float x2 = 0;

                string _a = "";
                string _b = "";
                string _g = "";
                if (a < 0)
                {
                    _a = "(" + a + ")";
                    if (a == -1)
                    {
                        label5.Text = label5.Text.Replace("α", "-");
                    }
                    else
                    {
                        label5.Text = label5.Text.Replace("α", a.ToString());
                    }
                }
                else
                {
                    _a = a.ToString();
                    if(a == 1)
                    {
                        label5.Text = label5.Text.Replace("α", "");
                    }
                    else
                    {
                        label5.Text = label5.Text.Replace("α", a.ToString());
                    }


                }
                
                if (b < 0)
                {
                    _b = "(" + b + ")";
                    label5.Text = label5.Text.Replace("+ β", b.ToString().Replace("-", "- "));
                }
                else
                {
                    _b = b.ToString();
                    label5.Text = label5.Text.Replace("β", b.ToString());
                }
                if (g < 0)
                {
                    _g = "(" + g + ")";
                    label5.Text = label5.Text.Replace("+ γ", g.ToString().Replace("-", "- "));

                }
                else
                {
                    _g = g.ToString();
                    label5.Text = label5.Text.Replace("γ", g.ToString());
                }

                label5.Text = label5.Text.Replace(" 1x", " x");

                int D = (int)Math.Pow(b, 2) - (4 * a * g);
                label6.Text = "      Δ = " + _b + "² - 4 * " + _a + " * " + _g + "\n" + "=> Δ = " + D + "\n";
                if (D > 0)
                {
                    label6.Text = label6.Text + "=> √Δ = " + Math.Sqrt(D);
                }
                label6.Text = label6.Text + "\n\n";

                if (checkBox1.Checked == true)
                {
                    if (D > 0)
                    {
                        x1 = (float)((double)(b * (-1) + Math.Sqrt(D)) / (2 * a));
                        x2 = (float)((double)(b * (-1) - Math.Sqrt(D)) / (2 * a));
                        x1 = (float)System.Math.Round(x1, 4);
                        x2 = (float)System.Math.Round(x2, 4);
                        label6.Text = label6.Text + "x1 = (" + b * (-1) + " + " + (float)System.Math.Round(Math.Sqrt(D), 4) + ") / " + 2 * a + " => x1 = " + x1;
                        label6.Text = label6.Text + "\n";
                        label6.Text = label6.Text + "x2 = (" + b * (-1) + " - " + (float)System.Math.Round(Math.Sqrt(D), 4) + ") / " + 2 * a + " => x2 = " + x2;

                    }

                    if (D == 0)
                    {
                        x = (float)(double)((b * (-1m)) / (2m * a));
                        label6.Text = label6.Text + "x = " + x;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Invalid values. Please enter valid integers.", "Error");
            }
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
