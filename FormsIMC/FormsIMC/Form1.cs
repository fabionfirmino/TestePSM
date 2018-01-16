using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //Declaração de variaveis

            double peso;
            double altura;
            double imc;

            //recebendo os valores digitados no textbox
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            //Efetuando o calculo

            imc = peso / (altura * altura);

            //Exibindo o resultado no textbox do imc

            txtimc.Text = imc.ToString(); string.Format("{0:N}", 30, 09); // saída = 43.239,11
            //txtimc.Text = string.Format("{0:N}", 30,09); // saída = 43.239,11
            


            if ( imc >= 17)
            {
                MessageBox.Show("Peso Normal");
            }
            else if (imc > 17 && imc <= 25)
            {
                MessageBox.Show("Acima do Peso!");
            }
            else if (imc < 17)
            {
                MessageBox.Show("Abaixo do Peso");
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtimc.Clear();
            txtaltura.Clear();
            txtpeso.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
