using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();



        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        

        private void lblSuma_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            Operaciones op = new Operaciones();
            lblResultado.Text = (op.suma(n1,n2)).ToString();


        }

        private void lblResta_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            Operaciones op = new Operaciones();
            lblResultado.Text = (op.resta(n1, n2)).ToString();
        }

        private void lblMultiplicacion_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            Operaciones op = new Operaciones();
            lblResultado.Text = (op.mukltiplicacion(n1, n2)).ToString();
        }

        private void lblDivision_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            Operaciones op = new Operaciones();
            lblResultado.Text = (op.division(n1, n2)).ToString();
        }

        private void lblfactorial_Click(object sender, EventArgs e)
        {
            double n3 = Convert.ToDouble(txtn3.Text);
            Operaciones op = new Operaciones();
            lblResultado.Text = (op.factorial(n3)).ToString();
        }
    }
}
