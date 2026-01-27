using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ControlPorcino
{
    public partial class ControlCrianza : Form
    {
        public ControlCrianza()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        DataTable tabla = new DataTable("Registro Crianza");
        string ruta = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "crianza.xml"
         );
        private void ConfigurarGrid()
        {
            dgvCrianza.Rows.Clear();
        }

        private void btnGuardarCrianza_Click(object sender, EventArgs e)
        {
            string sexo = rbMacho.Checked ? "Macho" : "Hembra";
            string salud = rbSaludable.Checked ? "Saludable" : "Enfermo";

            if (sexo == "" || salud == "")
            {
                MessageBox.Show("Seleccione sexo y estado de salud");
                return; // NO guarda
            }

            tabla.Rows.Add(
                txtIDCrianza.Text,
                dtpCrianza.Value.ToShortDateString(),
                sexo,
                salud,
                txtObservaciones.Text
            );
            tabla.WriteXml(ruta);
            MessageBox.Show("Registro guardado correctamente");

            Limpiar();
        }

        private void Limpiar()
        {
            txtIDCrianza.Clear();
            txtObservaciones.Clear();
            rbMacho.Checked = false;
            rbHembra.Checked = false;
            rbSaludable.Checked = false;
            rbEnfermo.Checked = false;
        }

        private void btnVolverCrianza_Click(object sender, EventArgs e)
        {
            MenuCrianza f = new MenuCrianza();
            f.Show();
            this.Close();
        }

        
        private void label2_Click(object sender, EventArgs e) { }
        private void lblSexo_Click(object sender, EventArgs e) { }
        private void rbMacho_CheckedChanged(object sender, EventArgs e) { }
        private void rbHembra_CheckedChanged(object sender, EventArgs e) { }
        private void rbEnfermo_CheckedChanged(object sender, EventArgs e) { }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void ControlCrianza_Load(object sender, EventArgs e)
        {
            tabla.Columns.Add("ID del Cerdo");
            tabla.Columns.Add("Fecha de Registro");
            tabla.Columns.Add("Sexo");
            tabla.Columns.Add("Estado de Salud");
            tabla.Columns.Add("Observaciones");
            if (File.Exists(ruta))

                {
                    tabla.ReadXml(ruta);
                }

            dgvCrianza.AutoGenerateColumns = true;
            dgvCrianza.DataSource = tabla;
        }

        private void ControlCrianza_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabla.WriteXml(ruta);
        }

        private void txtIDCrianza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
