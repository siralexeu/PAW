using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Eq_gr2 
{
    public partial class FormEq : Form 
    {
        public FormEq() 
        {
            InitializeComponent();
            Toate = new Control[] 
            { 
                                    lblX1, tbX1R, lblX1Plus, tbX1i, lbli1,
                                    lblX2, tbX2R, lblX2Plus, tbX2i, lbli2,
             };
            foreach(Control crt in Toate) crt.Visible = false;
        }
        Control[] Toate;

        private void btnSolve_Click(object sender, EventArgs e) 
        {
            double delta = 0;
            double a = double.Parse(tbA.Text);
            double b = double.Parse(tbB.Text);
            double c = double.Parse(tbC.Text);
            delta = b * b - 4 * a * c;
            //ecuatie grad 1
            if (a == 0) {
                tbMes.Text = "\r\nEcuatie de grad 1";
                tbX1R.Visible = true; lblX1.Visible = true;
                tbX1R.Text = (-c / b).ToString("f3");
            }
            else {
                //Ecuatie de grad 2
                delta = b * b - 4 * a * c;
                if (delta >= 0){
                    tbMes.Text = "\r\nEcuatie de grad 2 cu radacini reale";
                    tbX1R.Visible = true; lblX1.Visible = true;
                    tbX2R.Visible = true; lblX2.Visible = true;
                    tbX1R.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString("f3");
                    tbX2R.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString("f3");
                }
                else
                {
                    tbMes.Text = "\r\nEcuatie de grad 2, cu radacini complexe";
                    foreach (Control crt in Toate) crt.Visible = true;
                    tbX1R.Text = ((-b) / (2 * a)).ToString("f3");
                    tbX2R.Text = ((-b) / (2 * a)).ToString("f3");
                    tbX1i.Text = (Math.Sqrt(-delta) / (2 * a)).ToString("f3");
                    tbX2i.Text = (-Math.Sqrt(-delta) / (2 * a)).ToString("f3");
                }
           
            }
        }

        private void tbA_TextChanged(object sender, EventArgs e) 
        {
            foreach (Control crt in Toate) crt.Visible = true;
        }
    }
}
