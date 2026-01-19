using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1; 

namespace ControlPorcino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrianza_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            Alimentacion fAlimentacion = new Alimentacion();
            fAlimentacion.Show();
            this.Hide();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            Peso fPeso = new Peso();
            fPeso.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FrmProd ventanaProduccion = new FrmProd();
            ventanaProduccion.Show();
            this.Hide();
        }
    }
}
