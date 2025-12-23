using System;
using System.Windows.Forms;

namespace ControlPorcino
{
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();

            btnGuardarPeso.Click += btnGuardarPeso_Click;
            btnVolverPeso.Click += btnVolverPeso_Click;
        }

        private void btnGuardarPeso_Click(object sender, EventArgs e)
        {
            // Solo agregamos los valores necesarios: ID, Peso, Fecha
            dgvPeso.Rows.Add(
                textBox1.Text,           // ID del cerdo
                textBox2.Text,           // Peso
                dtpPeso.Value.ToShortDateString()  // Fecha del pesaje
            );

            // Limpiar controles
            textBox1.Clear();
            textBox2.Clear();
        }


        private void btnVolverPeso_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void lblPeso_Click(object sender, EventArgs e) { }
    }
}

