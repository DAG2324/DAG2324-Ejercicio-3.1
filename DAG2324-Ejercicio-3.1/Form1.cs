﻿using System;
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
        //SOY EL USUARIO DAVEALVA Y ESTOY USANDO LA RAMA-1
        private void bCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
<<<<<<< HEAD
            
            int numPalabras = 0;
=======
            char tipoTelegrama = ' ';
>>>>>>> 21877174ea8ee4178478e459c169de2aaa6ffee1
            double coste;
            textoTelegrama = txtTelegrama.Text;
<<<<<<< HEAD
            
=======

            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            int numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;

            /*quitamos las variables de prgem que hemos dejado en comentarios posteriores,
            para poder añadir la nueva variable que nos permite delimitar los espacios vacios
            y así poder contar palabras completas y no caracteres
            int numPalabras = 0;
            numPalabras = textoTelegrama.Length;*/

            //Leo el telegrama
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
>>>>>>> 21877174ea8ee4178478e459c169de2aaa6ffee1
            //Obtengo el número de palabras que forma el telegrama 

            //Si el telegrama es ordinario
<<<<<<< HEAD
            if (rOrdinario.Checked)
=======
            if (tipoTelegrama != 'u')
>>>>>>> 21877174ea8ee4178478e459c169de2aaa6ffee1
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else
            //Si el telegrama es urgente
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
