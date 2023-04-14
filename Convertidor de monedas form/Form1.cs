using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor_de_monedas_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pesos, dolar, euro;
            try
            {
                pesos = Convert.ToDouble(textBox1.Text);
                dolar = pesos / 54.80;
                euro = pesos / 59.87;
                textBox2.Text = pesos.ToString();   
                textBox5.Text = pesos.ToString(); 
                textBox3.Text =  dolar.ToString();
                textBox4.Text = euro.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = string.Empty;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Confirme salida",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }
    }
}
