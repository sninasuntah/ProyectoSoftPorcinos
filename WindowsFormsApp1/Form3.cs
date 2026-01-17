using System;
using System.Windows.Forms;

namespace ControlPorcino
{
    public partial class Alimentacion : Form
    {
        public Alimentacion()
        {
            InitializeComponent();

            
           
        }

        private void btnGuardarAlimentacion_Click(object sender, EventArgs e)
        {
            string tipo = rbBalanceado.Checked ? "Balanceado" :
                          rbMaíz.Checked ? "Maíz" : "Suplemento";
            MessageBox.Show(
            "Registro guardado correctamente",
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
            dgvAlimentacion.Rows.Add(
                txtIDAlimentacion.Text,
                tipo,
                txtCantidadAlimentacion.Text,
                dtpAlimentacion.Value.ToShortDateString()
            );

            Limpiar();
        }

        private void btnVolverAlimentación_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void Limpiar()
        {
            txtIDAlimentacion.Clear();
            txtCantidadAlimentacion.Clear();
            rbBalanceado.Checked = false;
            rbMaíz.Checked = false;
            rbSuplemento.Checked = false;
        }

        private void rbSuplemento_CheckedChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}

