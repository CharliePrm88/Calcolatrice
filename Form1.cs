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
        private string input;
        private double operando1 = 0;
        private double operando2 = 0;
        private char operazione;
        private double risultato = 0.0;
        private bool primaoperazione=true;
        public Form1()
        {
            InitializeComponent();
        }

        double eseguiOperazione(double operando1, double operando2, char operazione)
        {
            switch (operazione)
            {
                case '+':
                    operando1 += operando2;
                    break;
                case '-':
                    operando1 -= operando2;
                    break;
                case 'X':
                    operando1 *= operando2;
                    break;
                case '/':
                    operando1 /= operando2;
                    break;
            }
            return operando1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "1";
            this.visualizzaRisultato.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "2";
            this.visualizzaRisultato.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "3";
            this.visualizzaRisultato.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "4";
            this.visualizzaRisultato.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "5";
            this.visualizzaRisultato.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "6";
            this.visualizzaRisultato.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "7";
            this.visualizzaRisultato.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "8";
            this.visualizzaRisultato.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "9";
            this.visualizzaRisultato.Text = input;
        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            if (input.Length <= 0)
            {
                input = "";
            }
            else
            {
                input = input.Remove(input.Length - 1);
            }
            this.visualizzaRisultato.Text = input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double.TryParse(input, out operando2);
            operando1 = eseguiOperazione(operando1, operando2, operazione);
            input = Convert.ToString(operando1);
            this.visualizzaRisultato.Text = input;
            operando1 = 0;
            operando2 = 0;
            primaoperazione = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (primaoperazione)
            {
                primaoperazione = false;
                Double.TryParse(input, out operando1);
                input = "";
                this.visualizzaRisultato.Text = input;
                operazione = '+';
            }
            else
            {
                Double.TryParse(input, out operando2);
                input = "";
                this.visualizzaRisultato.Text = input;
                operando1 = eseguiOperazione(operando1, operando2, operazione);
                operazione = '+';
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            input = "";
            this.visualizzaRisultato.Text = input;
            operando1 = 0;
            operando2 = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.visualizzaRisultato.Text = "";
            input += "0";
            this.visualizzaRisultato.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                this.visualizzaRisultato.Text = "";
                input += ".";
                this.visualizzaRisultato.Text = input;
            }
        }

        private void buttonMeno_Click(object sender, EventArgs e)
        {
            if (primaoperazione)
            {
                primaoperazione = false;
                Double.TryParse(input, out operando1);
                input = "";
                this.visualizzaRisultato.Text = input;
                operazione = '-';
            }
            else
            {
                Double.TryParse(input, out operando2);
                input = "";
                this.visualizzaRisultato.Text = input;
                operando1 = eseguiOperazione(operando1, operando2, operazione);
                operazione = '-';
            }
        }

        private void buttonPer_Click(object sender, EventArgs e)
        {
            if (primaoperazione)
            {
                primaoperazione = false;
                Double.TryParse(input, out operando1);
                input = "";
                this.visualizzaRisultato.Text = input;
                operazione = 'X';
            }
            else
            {
                Double.TryParse(input, out operando2);
                input = "";
                this.visualizzaRisultato.Text = input;
                operando1 = eseguiOperazione(operando1, operando2, operazione);
                operazione = 'X';
            }
        }

        private void buttonDiviso_Click(object sender, EventArgs e)
        {
            if (primaoperazione)
            {
                primaoperazione = false;
                Double.TryParse(input, out operando1);
                input = "";
                this.visualizzaRisultato.Text = input;
                operazione = '/';
            }
            else
            {
                Double.TryParse(input, out operando2);
                input = "";
                this.visualizzaRisultato.Text = input;
                operando1=eseguiOperazione(operando1, operando2, operazione);
                operazione = '/';
            }

        }
    }
}
