using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio_Practico1
{
    public partial class Parte3 : Form
    {
        public Parte3()
        {
            InitializeComponent();
        }
       
        public static Boolean IsNumeric(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }
       
        public static 
        string[] nombre = new string[10];
        double[] notas = new double[10];
        int p = 0;
        string A = "";
        int dimension = 0;
        //metodo que devuelva para ver si el alumno aprovo
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
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
            else if (!IsNumeric(txtNota.Text))
            {
                MessageBox.Show("Debe ingredar un numero");
                txtNota.Focus();
            }
            else if (txtNota.Text == "")
            {
                MessageBox.Show("debe llenar campo");
                txtNota.Focus();

            }else if (double.Parse(txtNota.Text) < 2 || double.Parse(txtNota.Text) > 10)
            {
                MessageBox.Show("Nota minima es 2 y nota maxima es 10");
                txtNota.Focus();
                txtNota.Clear();
            }
            else
            {
                nombre[p] = txtNombre.Text;
                notas[p] = double.Parse(txtNota.Text);
                p++;
                dimension++;
                txtNombre.Focus();
                txtNombre.Clear();
                txtNota.Clear();

            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //nueva columna
            data.Columns.Add("","Nombre");
            data.Columns.Add("", "Notas");
            data.Columns.Add("", "Estado");

            for (int t = 0; t < dimension; t++)
            {
                if (notas[t] < 6.5)
                {
                    A = "reprobado";
                }
                else if (notas[t] >= 6.5)
                {
                    A = "aprobado";

                }

                data.Rows.Add(nombre[t],notas[t],A );
               
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
               
        }
    }
    
}
