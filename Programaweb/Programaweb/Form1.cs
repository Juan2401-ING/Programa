//Juan Pablo Benalcazar
//Fecha:2020/10/29
//Estructura de datos
//Multiplicacion, factorial y fibonacci.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programaweb
{
    public partial class Form1 : Form
    {
        //Variables que reciben el valor de la calculadora
        int a;
        int b;
        //Operador que recibe mediante consola
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.Mult obj = new Clases.Mult();//Multiplicacion
        Clases.Factorial1 obj2 = new Clases.Factorial1();//Factorizacion
        Clases.Fibo obj3 = new Clases.Fibo();//Fibonacci
        //Definicion de botones y proceso para capturar el dato ingresado por consola
        private void button1_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Textcuadro.Text = Textcuadro.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador =  "*";
            a = int.Parse(Textcuadro.Text);
            Textcuadro.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = "!";
            a = int.Parse(Textcuadro.Text);
            Textcuadro.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operador = "Fi";
            a = int.Parse(Textcuadro.Text);
            Textcuadro.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Recibe e imprime la informacion requerida por el usuario
            int Mul;
            int Fac;
            int Fi;

            switch (operador)
            {
                case "*":
                    {
                        b = int.Parse(Textcuadro.Text);
                        Mul = obj.multiplicacion((a), (b));                     
                        Textcuadro.Text = "La multiplicación de los numeros ingresados es: "+ Mul.ToString();
                        
                    }
                    break;
                case "!":
                    {
                        Fac = obj2.Factorial((a));                    
                        Textcuadro.Text = "El factorial del número ingresado es: " + Fac.ToString();
                    }
                    break;
                case "Fi":
                    {
                        Fi = obj3.Fibonacci ((a));
                        Textcuadro.Text = Fi.ToString();
                        Textcuadro.Text = "El número que se encuentra en la posición " + a + " de la serie de fibonacci es: " + Fi.ToString();
                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Textcuadro.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Textcuadro.Text.Length == 1)
                Textcuadro.Text = "";
            else
                Textcuadro.Text = Textcuadro.Text.Substring(0, Textcuadro.Text.Length - 1);
        }
    }
}
