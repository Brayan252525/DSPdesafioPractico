using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio_Practico1
{
    public partial class Parte2 : Form
    {
       
        public Parte2()
        {
            InitializeComponent();
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
       

        
   
        string nombre = "";
        int edad = 0;
        int[] edadt=new int[10];
        int p = 0;
        int promedio = 0;
        double promediot = 0;
        int dimensionMatriz = 0;
        private void btnPromedio_Click(object sender, EventArgs e)
        {
          
            for (p = 0; p <dimensionMatriz; p++)
            {
                promedio = promedio + edadt[p];
            }
            promediot = promedio / dimensionMatriz;
            MessageBox.Show(Convert.ToString(promediot));
            ltbDatos.Items.Add("                    ----PROMEDIO----");
            ltbDatos.Items.Add(promediot);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (IsNumeric(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("debe llenar campo");
                txtNombre.Focus();
            }
            else if (!IsNumeric(txtEdad.Text))
            {
                MessageBox.Show("Debe ingredar un numero");
                txtEdad.Focus();
            }
            else if (txtEdad.Text == "")
            {
                MessageBox.Show("debe llenar campo");
                txtEdad.Focus();
            }
            else
            {
                dimensionMatriz++;
                edadt[p] = int.Parse(txtEdad.Text);
                p++;
                nombre = txtNombre.Text;
                edad = int.Parse(txtEdad.Text);
                //sumatoria = sumatoria + edad;
                ltbDatos.Items.Add("Se registró: "+nombre + "  de  " + edad+"  años de edad");
                txtEdad.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
               
            }
        }

        private void btnEdades_Click(object sender, EventArgs e)
        {
                int max = edadt[0];
                int min = edadt[0];
                for (int i = 0; i < dimensionMatriz; i++)
                {
                    if (min > edadt[i])
                    {
                        min = edadt[i];
                    }
                    else if (max < edadt[i])
                    {
                        max = edadt[i];
                    }
                }

            ltbDatos.Items.Add("               ----NUMERO MAYOR----");
            ltbDatos.Items.Add(max);
            ltbDatos.Items.Add("               ----NUMERO MENOR----");
            ltbDatos.Items.Add(min);




        }

    }
}
