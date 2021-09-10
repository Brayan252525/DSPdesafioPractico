using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio_Practico1
{
    public partial class Parte4 : Form
    {
        public Parte4()
        {
            InitializeComponent();
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        string[] nombre =new string[10];
        int[] dia = new int[10];
        string[] mes= new string[10];
        int[] año = new int[10];
        int p = 0;
        private void label1_Click(object sender, EventArgs e)
        {

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
            else if (!IsNumeric(txtAño.Text))
            {
                MessageBox.Show("Debe ingredar un numero");
                txtAño.Focus();
            }
            else if (txtAño.Text == "")
            {
                MessageBox.Show("debe llenar campo");
                txtAño.Focus();
            }
            else
            {
                nombre[p] = txtNombre.Text;
                dia[p] = int.Parse(nudDia.Text);
                mes[p] = cbmMes.Text;
                año[p] = int.Parse(txtAño.Text);
                p++;
                txtNombre.Clear();
                txtAño.Clear();
                
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dtgFecha.Columns.Add("", "Nombre");
            dtgFecha.Columns.Add("", "Día");
            dtgFecha.Columns.Add("", "Mes");
            dtgFecha.Columns.Add("", "Año");

           
            for(int i = 0; i < p; i++)
            {
                dtgFecha.Rows.Add(nombre[i], dia[i], mes[i], año[i]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudDia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
