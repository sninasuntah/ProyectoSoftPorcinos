using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace ControlPorcino
{
    public partial class MenuCrianza : Form
    {
        public MenuCrianza()
        {
            InitializeComponent();
            pictureBox2.BackColor = Color.Transparent;
        }

        private void btnCrianza_Click(object sender, EventArgs e)
        {
            ControlCrianza f = new ControlCrianza();
            f.Show();
            this.Hide();
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            ControlAlimentacionPeso fAlimentacion = new ControlAlimentacionPeso();
            fAlimentacion.Show();
            this.Hide();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            JuegoMemorama f = new JuegoMemorama();
            f.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            PantallaPrincipal f = new PantallaPrincipal();
            f.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            JuegoMemorama f = new JuegoMemorama();
            f.Show();
            this.Hide();
        }
    }
}
