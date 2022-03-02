using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5) {
                lblResultado.Text = "Seu IMC: " + Math.Round(imc, 2) + "\nAbaixo do peso!";
            }
            else if (imc >= 18.5 && imc <= 24.9) {
                lblResultado.Text = "Seu IMC: " + Math.Round(imc, 2) + "\nPeso Normal!";
            }
            else if (imc >= 25 && imc <= 29.9) {
                lblResultado.Text = "Seu IMC: " + Math.Round(imc, 2) + "\nSobrepeso!";
            }
            else if (imc >= 30 && imc <= 34.9) {
                lblResultado.Text = "Seu IMC: " + Math.Round(imc, 2) + "\nObesidade grau 1!";
            }
            else if (imc >= 35 && imc <= 39.9) {
                lblResultado.Text = "Seu IMC: " + Math.Round(imc, 2) + "\nObesidade grau 2!";
            }
            else {
                lblResultado.Text = "Seu IMC: " + Math.Round(imc, 2) + "\nObesidade Grau 3!";
            }
        }

        private void label3_Click_1(object sender, EventArgs e) {
            
        }
    }
}
