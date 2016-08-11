using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corto_guia2
{
    public partial class Form1 : Form
    {
        //Instanciamos las variables nums
        public double Num1, Num2, Num3, Resultado;

        //Bandera publica si todos los datos estan correctos
        public bool bandera = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bandera por defecto true,. si en algun obtener valor encuentra error 
            bandera = true;

            //Validamos y obtenemos los valores
            Num1 = obtener_valor(txtR1);
            Num2 = obtener_valor(txtR2);
            Num3 = obtener_valor(txtR3);

            if (bandera)
            {
                Resultado = 1/(1/(Num1 + Num2) + 1 / Num3);
                MessageBox.Show("El resultado de la R equivalente es: " + Resultado.ToString());

            }
            else {
                MessageBox.Show("Alguno de los datos es incorrecto");
            }

            limpiar_pantalla();
        }

        public double obtener_valor(TextBox t1)
        { //Para transformar lo que se digite en el textbox a formato
            //numerico
            double valor = 0;

            if (t1.Text.Length > 0)
            {
                if (double.TryParse(t1.Text, out valor))
                {
                    valor = Convert.ToDouble(t1.Text);
                }
                else
                {
                    bandera = false;
                    MessageBox.Show("El valor debe ser numerico");
                }

            }
            else
            {
                bandera = false;
                MessageBox.Show("El control se encuentra vacio");
            }

            return valor;

        }

        public void limpiar_pantalla()
        { 
            //Para limpiar los textboxs

            txtR1.Text = "";
            txtR2.Text = "";
            txtR3.Text = "";

        }
    }
}
