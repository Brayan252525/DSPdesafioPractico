using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Practico1
{
    public partial class Parte1 : Form
    {
        public Parte1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parte2 vd = new Parte2();
            vd.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDO/A");
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parte3 vd = new Parte3();
            vd.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parte4 vd = new Parte4();
            vd.Show();
        }
    }
}
