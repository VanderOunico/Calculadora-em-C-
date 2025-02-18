Vanderlei Archila Virissimo 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Calcular("+");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calcular("-");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Calcular("/");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calcular("*");
        }
        private void Calcular(string operacao)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNumero1.Text);
                double num2 = Convert.ToDouble(txtNumero2.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            throw new DivideByZeroException();
                        break;
                }

                lblResultado.Text = $"Resultado: {resultado}";


            }
        }
    }

}
