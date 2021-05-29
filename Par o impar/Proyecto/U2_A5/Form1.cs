using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_A5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void boton_Click(object sender, EventArgs e)
        {
            /*Declaracion de variables*/
            double N1;
            string R;
            /*Asignacion de datos capturados  a la variable N1*/
            N1 = double.Parse(num.Text);
            {
                /*Condicion para saber si el residuo es 0*/
                if ((N1 % 2) == 0)
                {
                    /*Asignar cadena de datos a R*/
                    R = "Número Par";
                    /*imprime resultado en etiqueta result*/
                    result.Text = R.ToString();                    
                }
                else
                {
                    /*Asignar cadena de datos a R*/
                    R = "Número Impar";
                    /*imprime resultado en etiqueta result*/
                    result.Text = R.ToString();               
                }
            }
            /*limpia la caja de texto que captura el numero a dividir*/
            num.Text = "";
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*validacion para solocapturar numeros y  mesaje en caso de ingresar otro tipo de caracteres*/
            if ((e.KeyChar >= 32 && e.KeyChar <=47) || (e.KeyChar >= 58 && e.KeyChar <=255))
            {
                MessageBox.Show("Ingresa solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
