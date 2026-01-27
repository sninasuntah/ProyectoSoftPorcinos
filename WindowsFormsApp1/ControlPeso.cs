using System;
using System.Windows.Forms;

namespace ControlPorcino
{
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();

            
            
        }

        private void btnGuardarPeso_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Registro guardado correctamente",
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
            // Solo agregamos los valores necesarios: ID, Peso, Fecha
            dgvPeso.Rows.Add(
                textBox1.Text,           // ID del cerdo
                textBox2.Text,           // Peso
                dtpPeso.Value.ToShortDateString()  // Fecha del pesaje
            );

            
            textBox1.Clear();
            textBox2.Clear();
        }


        private void btnVolverPeso_Click(object sender, EventArgs e)
        {
            MenuCrianza f = new MenuCrianza();
            f.Show();
            this.Close();
        }

        private void lblPeso_Click(object sender, EventArgs e) { }
    }
}

