using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Windows.Forms;
//using System

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pesos_TextChanged(object sender, EventArgs e)
        {


        }

        private void Dolares_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cambio_TextChanged(object sender, EventArgs e)
        {
        }
        private void Convertir_Click(object sender, EventArgs e)
        {

            DialogResult resultado;

            Cambiar cambiar = new Cambiar();
            String pattern = @"[^0-9'.']";

            Regex regex = new Regex(pattern);


            if (regex.IsMatch(Pesos.Text) || (regex.IsMatch(Cambio.Text)))
            {

                MessageBox.Show("Inserta solo valores numericos!");

            }
                
            else if (Pesos.Text == "0" || Cambio.Text == "0")
            {

                MessageBox.Show("Error.. no puedes inserta solo el cero");

            }
            else if (Pesos.Text.Trim() == "")
            {
                if (Cambio.Text.Trim() == "")
                {

                    resultado = MessageBox.Show("Los campos no pueden estar vacios!!!");

                }
            }
            else
            {

                cambiar.pesos = Convert.ToDouble(Pesos.Text);
                cambiar.change = Convert.ToDouble(Cambio.Text);

                cambiar.dolar = cambiar.pesos / cambiar.change; //cambio de pesos a dolares

                Dolares.Text = cambiar.dolar.ToString("N1");// mostrar resultado de la operación en dolares textbox

            }
         
        }
    }

}

