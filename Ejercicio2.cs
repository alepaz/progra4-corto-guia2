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
    public partial class Ejercicio2 : Form
    {
        //Instanciamos las variables nums
        public double Num1, Num2, Num3, Num4, promedio, desviacion;

        public int cont = 0;

        //Bandera publica si todos los datos estan correctos
        public bool bandera = true;

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Bandera por defecto true,. si en algun obtener valor encuentra error 
            bandera = true;

            //Validamos y obtenemos los valores, dependiendo de la bandera en que se encuentre
            if (cont == 0) {
                Num1 = obtener_valor(txtNum);               
            }else if (cont == 1){
                Num2 = obtener_valor(txtNum);
            }else if (cont == 2){
                Num3 = obtener_valor(txtNum);
            }else if (cont == 3){
                Num4 = obtener_valor(txtNum);
            }

            if (bandera && cont < 3)
            {
                //Aumentamos en 1 el numero
                cont++;
                lblnum.Text = "Número: " + (cont + 1).ToString();

                //Boton dira finalizar
                if (cont == 1)
                {
                    dataGridView1.Rows.Insert(0, txtNum.Text);
                }else if (cont == 2) {
                    dataGridView1.Rows.Insert(0, txtNum.Text);
                }else if (cont == 3){
                    btnCalcular.Text = "Finalizar";
                    dataGridView1.Rows.Insert(0, txtNum.Text);
                }

            }
            else if (bandera && cont < 4)
            {
                dataGridView1.Rows.Insert(0, txtNum.Text);

                promedio = Num1 + Num2 + Num3 + Num4;
                promedio = promedio / 4;

                dataGridView1.Rows.Insert(0, promedio.ToString());

                MessageBox.Show("El promedio es de: " + promedio.ToString());

                desviacion = Math.Pow((Num1 - promedio), 2);
                desviacion += Math.Pow((Num2 - promedio), 2);
                desviacion += Math.Pow((Num3 - promedio), 2);
                desviacion += Math.Pow((Num4 - promedio), 2);
                desviacion = desviacion / 4;
                desviacion = Math.Sqrt(desviacion);

                dataGridView1.Rows.Insert(0, promedio.ToString());

                MessageBox.Show("La desviación es de: " + desviacion.ToString());

                //Restablecemos variables para siguiente proceso
                btnCalcular.Text = "Agregar";
                cont = 0;
                lblnum.Text = "Número: " + (cont + 1).ToString();
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
                    if (int.Parse(t1.Text) >= 0 && int.Parse(t1.Text) <= 10)
                    {
                        valor = Convert.ToDouble(t1.Text);
                    }
                    else {

                        bandera = false;
                        MessageBox.Show("El numero se encuentra fuera del rango 0-10");
                    }
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
            //Para limpiar el textbox
            txtNum.Text = "";

        }
    }
}
