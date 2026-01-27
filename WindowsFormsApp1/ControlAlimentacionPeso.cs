using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ControlPorcino
{
    public partial class ControlAlimentacionPeso : Form
    {
        public ControlAlimentacionPeso()
        {
            InitializeComponent();
        }

        DataTable tabla;
        string ruta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "control_alimentacion_peso.xml"
        );

        private void btnGuardarAlimentacion_Click(object sender, EventArgs e)
        {
            string tipo = rbBalanceado.Checked ? "Balanceado" :
                          rbMaíz.Checked ? "Maíz" : "Suplemento";
            string tipo2 = rbEngorde.Checked ? "Engorde" :
                           rbCria.Checked ? "Cría" : "Faena";
            MessageBox.Show(
                "Registro guardado correctamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Asegurarse de que la tabla existe y tiene columnas
            if (tabla == null)
            {
                CrearTabla();
            }

            tabla.Rows.Add(
                txtEdadCerdo.Text,
                txtPesoCer.Text,
                tipo,
                tipo2,
                txtCantidadAli.Text,
                dtpAlimentacion.Value.ToShortDateString()
            );

            tabla.WriteXml(ruta);
            Limpiar();
        }

        private void btnVolverAlimentación_Click(object sender, EventArgs e)
        {
            MenuCrianza f = new MenuCrianza();
            f.Show();
            this.Close();
        }

        private void Limpiar()
        {
            txtEdadCerdo.Clear();
            txtPesoCer.Clear();
            txtCantidadAlimentacion.Clear();
            rbBalanceado.Checked = false;
            rbMaíz.Checked = false;
            rbSuplemento.Checked = false;
            rbEngorde.Checked = false;
            rbCria.Checked = false;
            rbFaena.Checked = false;
            txtCantidadAli.Clear();
        }

        private void rbSuplemento_CheckedChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void ControlAlimentacionPeso_Load(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                // Leer en un DataSet para evitar problemas de inferencia de esquema al leer directamente en DataTable
                var ds = new DataSet();
                ds.ReadXml(ruta);

                if (ds.Tables.Count > 0)
                {
                    tabla = ds.Tables[0];
                    // Asegurar nombre consistente (opcional)
                    tabla.TableName = "RegistroAlimentaciónPeso";
                }
                else
                {
                    CrearTabla();
                }
            }
            else
            {
                CrearTabla();
            }

            dgvControlAlimentacionPeso.AutoGenerateColumns = true;
            dgvControlAlimentacionPeso.DataSource = tabla;
        }

        private void CrearTabla()
        {
            tabla = new DataTable("RegistroAlimentaciónPeso");
            tabla.Columns.Add("Edad del cerdo (Meses)");
            tabla.Columns.Add("Peso (kg)");
            tabla.Columns.Add("Tipo de alimento");
            tabla.Columns.Add("Tipo de cerdo");
            tabla.Columns.Add("Cantidad de alimento (Kg)");
            tabla.Columns.Add("Fecha de Registro");
        }

        private void ControlAlimentacionPeso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabla != null)
            {
                tabla.WriteXml(ruta);
            }
        }
    }
}

