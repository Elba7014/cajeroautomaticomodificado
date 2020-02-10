using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroautomaticomodificado
{
    public partial class Form1 : Form

       
    {
        public Form1()

   
        {
            InitializeComponent();
        }

        private void Btnretirar_Click(object sender, EventArgs e)
        {
            double num1, num2, total;
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.25, 0.1, 0.05, 0.01 };
            //creamos una vaibiable para guardar las denominaciones
            num1 = double.Parse(txtentrega.Text);
            //convertimos lo ingresado en el textbox en valor numerico y lo definimos con una variable
            num2 = double.Parse(txttotal.Text);
            sbyte n = 0;
            //creamos un contador que nos diga cuantos billetes de x denominacion seran
            string respuesta = "respuesta  \n";
            //creamos una varible que guarde esta respuesta 
            total = num1 - num2;

            foreach (double denominación in denominaciones)
            {//para cada array recorremos los vaores de las denominaciones

                while (denominación <= Math.Round(total, 2))
                {//mientras denominaciones sea menos o igual se redondea a dos digitos 
                    n++;
                    //n aumentara
                    total -= denominación;
                    //al totall se le quitara la denominacion que acabamos de ocupar
                }
                if (n > 0)
                    //si n es mayor que cero 
                {
                    respuesta += n + ( denominación > 1 ? " Billetes " : " Monedas ") + denominación + " \n ";
                    //la respuesta sera igual a la respuesta mas n(si la denominacion es mayor que 1 entonces(?)
                    //se refiere a billetes sino(:) seran monedas)
                }
                n = 0;
            }
            lblrspuesta.Text = respuesta ;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1, num2, total;
            num1 = double.Parse(txtentrega.Text);
            num2 = double.Parse(txttotal.Text);
            total = num1 - num2;

            double cantidad = total;
            int[] fibo = new int[2];
            //definimos la variable de dos elementos
            string respuesta = "respuesta ";
            fibo[0] = 0;
            fibo[1] = 1;
            int num = 0;
                while (num <= cantidad) ;
            {

                int temp = fibo[0] + fibo[1];
            fibo[0] = fibo[1];
             fibo[1] = temp;
            num++;
            }
            lblsucesion.Text = respuesta;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double num1, num2, total;
            num1 = double.Parse(txtentrega.Text);
            num2 = double.Parse(txttotal.Text);
            total = num1 - num2;
            double n;
            n = total;
            if (total / 2 == 0) 
                lblprimo.Text = total + " es un numero primo ";
             else
                lblprimo.Text = total + " no es un numero primo";

        }
    }
    }



