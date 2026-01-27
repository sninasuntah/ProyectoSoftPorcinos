using ControlPorcino;
using picks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnIrCrianza_Click(object sender, EventArgs e)
        {
            MenuCrianza f = new MenuCrianza();
            f.Show();
            this.Hide();
        }

        private void btnIrProduccion_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnIrVacunacion_Click(object sender, EventArgs e)
        {
            MenuEnfermedados me = new MenuEnfermedades
            me.Show();
            this.Hide();

        }

        private void btnIrGastronomia_Click(object sender, EventArgs e)
        {
            Frmgastronomia fg = new Frmgastronomia();
            fg.Show();
            this.Hide();
        }
    }
}
