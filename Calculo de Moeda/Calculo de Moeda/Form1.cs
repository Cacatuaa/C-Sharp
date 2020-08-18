using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Moeda
{
    public partial class Form1 : Form
    {
        float um = 0, cinco = 0, dez = 0, vinteecinco = 0, cinquenta = 0, umreal = 0, total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "0";
            lbl_5.Text = "0";
            lbl_10.Text = "0";
            lbl_25.Text = "0";
            lbl_50.Text = "0";
            lbl_1real.Text = "0";
            lbl_rs1.Text = "0";
            lbl_rs5.Text = "0";
            lbl_rs10.Text = "0";
            lbl_rs25.Text = "0";
            lbl_rs50.Text = "0";
            lbl_rs1real.Text = "0";
            lbl_total.Text = "0";
            lbl_rstotal.Text = "0";
            lbl_1percent.Text = "0%";
            lbl_5percent.Text = "0%";
            lbl_10percent.Text = "0%";
            lbl_25percent.Text = "0%";
            lbl_50percent.Text = "0%";
            lbl_1realpercent.Text = "0%";
            um = 0;
            cinco = 0;
            dez = 0;
            vinteecinco = 0;
            cinquenta = 0;
            umreal = 0;
            total = 0;

        }

        private void labels()
        {
            total = um + cinco + dez + vinteecinco + cinquenta + umreal;
            lbl_1.Text = Convert.ToString(um);
            lbl_rs1.Text = Convert.ToString(um * 0.01);
            lbl_5.Text = Convert.ToString(cinco);
            lbl_rs5.Text = Convert.ToString(cinco * 0.05);
            lbl_10.Text = Convert.ToString(dez);
            lbl_rs10.Text = Convert.ToString(dez * 0.1);
            lbl_25.Text = Convert.ToString(vinteecinco);
            lbl_rs25.Text = Convert.ToString(vinteecinco * 0.25);
            lbl_50.Text = Convert.ToString(cinquenta);
            lbl_rs50.Text = Convert.ToString(cinquenta * 0.5);
            lbl_1real.Text = Convert.ToString(umreal);
            lbl_rs1real.Text = Convert.ToString(umreal);
            lbl_total.Text = Convert.ToString(total);
            lbl_rstotal.Text = Convert.ToString((um * 0.01) + (cinco * 0.05) + (dez * 0.1) + (vinteecinco * 0.25) + (cinquenta * 0.5) + umreal);
            lbl_1percent.Text = Convert.ToString((um/total) * 100) + "%";
            lbl_5percent.Text = Convert.ToString((cinco / total) * 100) + "%";
            lbl_10percent.Text = Convert.ToString((dez / total)) + "%";
            lbl_25percent.Text = Convert.ToString((vinteecinco / total)) + "%";
            lbl_50percent.Text = Convert.ToString((cinquenta / total)) + "%";
            lbl_1realpercent.Text = Convert.ToString((umreal / total)) + "%";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (rbtn_mais.Checked == true)
            {
                if (rbtn_1.Checked == true)
                {
                    um++;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco++;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez++;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco++;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta++;
                }
                else
                {
                    umreal++;
                }
            }
            else
            {
                if (rbtn_1.Checked == true)
                {
                    um--;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco--;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez--;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco--;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta--;
                }
                else
                {
                    umreal--;
                }
            }
            labels();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (rbtn_mais.Checked == true)
            {
                if (rbtn_1.Checked == true)
                {
                    um = um + 5;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco + 5;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez + 5;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco + 5;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta + 5;
                }
                else
                {
                    umreal = umreal + 5;
                }
            }
            else
            {
                if (rbtn_1.Checked == true)
                {
                    um = um - 5;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco - 5;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez - 5;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco - 5;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta - 5;
                }
                else
                {
                    umreal = umreal - 5;
                }
            }
            labels();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            if (rbtn_mais.Checked == true)
            {
                if (rbtn_1.Checked == true)
                {
                    um = um + 10;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco + 10;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez + 10;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco + 10;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta + 10;
                }
                else
                {
                    umreal = umreal + 10;
                }
            }
            else
            {
                if (rbtn_1.Checked == true)
                {
                    um = um - 10;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco - 10;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez - 10;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco - 10;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta - 10;
                }
                else
                {
                    umreal = umreal - 10;
                }
            }
            labels();
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            if (rbtn_mais.Checked == true)
            {
                if (rbtn_1.Checked == true)
                {
                    um = um + 50;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco + 50;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez + 50;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco + 50;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta + 50;
                }
                else
                {
                    umreal = umreal + 50;
                }
            }
            else
            {
                if (rbtn_1.Checked == true)
                {
                    um = um - 50;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco - 50;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez - 50;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco - 50;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta - 50;
                }
                else
                {
                    umreal = umreal - 50;
                }
            }
            labels();
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            if (rbtn_mais.Checked == true)
            {
                if (rbtn_1.Checked == true)
                {
                    um = um + 100;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco + 100;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez + 100;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco + 100;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta + 100;
                }
                else
                {
                    umreal = umreal + 100;
                }
            }
            else
            {
                if (rbtn_1.Checked == true)
                {
                    um = um - 100;
                }
                else if (rbtn_5.Checked == true)
                {
                    cinco = cinco - 100;
                }
                else if (rbtn_10.Checked == true)
                {
                    dez = dez - 100;
                }
                else if (rbtn_25.Checked == true)
                {
                    vinteecinco = vinteecinco - 100;
                }
                else if (rbtn_50.Checked == true)
                {
                    cinquenta = cinquenta - 100;
                }
                else
                {
                    umreal = umreal - 100;
                }
            }
            labels();
        }
    }
}

