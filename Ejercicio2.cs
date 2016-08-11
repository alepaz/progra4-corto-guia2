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
        private double Num1, Num2, Num3, Num4, promedio, desviacion;

        //Contador de numero actual
        private int cont = 0;

        //Contador para filas
        public int contFilas = 0;

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
                    //Ingresamos el primer numero y creamos la fila
                    dataGridView1.Rows.Insert(contFilas, txtNum.Text);
                }else if (cont == 2) {
                    //Ingresamos el segundo numero al datagrivview
                    dataGridView1[1, contFilas].Value = txtNum.Text;
                }else if (cont == 3){
                    btnCalcular.Text = "Finalizar";
                    //Ingresamos el terver numero al datagrivview
                    dataGridView1[2, contFilas].Value = txtNum.Text;
                }

            }
            else if (bandera && cont < 4)
            {
                //Ingresamos el cuarto numero al datagrivview
                dataGridView1[3, contFilas].Value = txtNum.Text;

                //Calculo del promedio
                promedio = Num1 + Num2 + Num3 + Num4;
                promedio = promedio / 4;

                //Ingresamos el promedio al dataridview
                dataGridView1[4, contFilas].Value = promedio.ToString();

                MessageBox.Show("El promedio es de: " + promedio.ToString());

                //Calculo de la desviacion
                desviacion = getDesvPart(Num1, promedio) + getDesvPart(Num2, promedio) + getDesvPart(Num3, promedio) + getDesvPart(Num4, promedio);
                desviacion = desviacion / 4;
                desviacion = Math.Sqrt(desviacion);

                //Ingresamos la desviacion al dataridview
                dataGridView1[5, contFilas].Value = desviacion.ToString();
                MessageBox.Show("La desviación es de: " + desviacion.ToString());

                //Restablecemos variables para siguiente proceso
                btnCalcular.Text = "Agregar";
                cont = 0;
                lblnum.Text = "Número: " + (cont + 1).ToString();
                contFilas++;
            }
            
            //Limpiamos el txt
            limpiar_pantalla();

            //Return focus to the textbox
            txtNum.Focus();
            
        }

        public double getDesvPart(double num, double promedio) {

            //Regresa (num - promedio)^2
            return Math.Pow((num - promedio), 2);
        }

        public double obtener_valor(TextBox t1)
        { //Para transformar lo que se digite en el textbox a formato
            //numerico
            double valor = 0;

            //Si el control esta vacio
            if (t1.Text.Length > 0)
            {
                //Si no se puede convertir a double (caracteres)
                if (double.TryParse(t1.Text, out valor))
                {
                    //Si el numero ingresado esta fuera del rango
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
