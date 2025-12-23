using System;
using System.Windows.Forms;

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
    }
}
