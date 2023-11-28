using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAG2324_Ejercicio_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Solucion 
        private void bCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            double coste;
            textoTelegrama = txtTelegrama.Text;

            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            int numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;

            if (rOrdinario.Checked)
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else

            if (rUrgente.Checked)
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
