using ControlPorcino;
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

namespace picks
{
    public partial class FrmProd : Form
    {
        private string[] datosCuriosos =
        {
            "🐷 Los cerdos pueden reconocer su nombre.\nPueden recordar comandos y nombres de otros cerdos.",
            "🐷 Un cerdo sano puede ganar hasta 700 g por día.\nDepende de la alimentación y la raza.",
            "🐷 Los cerdos son más inteligentes que los perros.\nPueden resolver laberintos y recordar rutas.",
            "🐷 La carne porcina es de las más consumidas del mundo.\nSe adapta a muchos tipos de cocina.",
            "🐷 Un cerdo de engorde suele estar listo entre 5 y 7 meses.\nDepende de la raza y alimentación."
        };

        Random r = new Random();

        public FrmProd()
        {
            InitializeComponent();
        }

        private void FrmProd_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblPesoFalta.Text = "";
            lblDatoCurioso.Text = "🧠 Dato curioso del cerdo";
        }
=======
>>>>>>> a249241 (Arreglo de boton ir produ, finalizacion de frmProdu y frmComerr)
        private void ProcesarCerdos(int edadActual, double pesoActual, int edadMin, double pesoMin, string titulo, string concepto)
        {
            if (edadActual >= edadMin && pesoActual >= pesoMin)
            {
                lblResultado.Text = $"✅ APTO PARA {titulo}.\nCumple con la edad y el peso ideal.";
                lblPesoFalta.Text = "¡LISTO PARA VENTA!";
            }
            else
            {
                double faltante = pesoMin - pesoActual;

                if (edadActual < edadMin && pesoActual < pesoMin)
                {
                    lblResultado.Text = $"❌ NO APTO PARA {titulo} porque no cumple con los meses ni con el peso requerido.";
                    lblPesoFalta.Text = $"LE FALTAN {faltante:N2} KG";
                }
                else if (edadActual < edadMin && pesoActual >= pesoMin)
                {
                    lblResultado.Text = $"❌ NO APTO PARA {titulo} porque cumple con el peso, pero le faltan los meses de desarrollo.";
                    lblPesoFalta.Text = $"FALTA EDAD ({edadMin} MESES)";
                }
                else
                {
                    lblResultado.Text = $"❌ NO APTO PARA {titulo} porque cumple con los meses, pero le falta peso corporal.";
                    lblPesoFalta.Text = $"LE FALTAN {faltante:N2} KG";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int edad;
            double peso;

            if (!int.TryParse(txtEdad.Text, out edad) || edad < 0)
            {
                MessageBox.Show("Por favor, ingresa una edad válida.");
                return;
            }

            if (!double.TryParse(txtPeso.Text, out peso) || peso < 0)
            {
                MessageBox.Show("Por favor, ingresa un peso válido.");
                return;
            }

            if (comTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Tipo de Cerdo.");
                return;
            }

            string tipoSeleccionado = comTipo.SelectedItem.ToString();

            if (tipoSeleccionado == "CRIA")
            {
                ProcesarCerdos(edad, peso, 2, 20, "VENTA DE CRÍA", "destete");
            }
            else if (tipoSeleccionado == "ENGORDE")
            {
                ProcesarCerdos(edad, peso, 4, 50, "VENTA DE ENGORDE", "engorde");
            }
            else
            {
                ProcesarCerdos(edad, peso, 5, 80, "LA VENTA (FAENA)", "faena");
            }

            lblDatoCurioso.Text = datosCuriosos[r.Next(datosCuriosos.Length)];
        }

<<<<<<< HEAD
        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmCom f2 = new FrmCom();
            f2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();              
            this.Hide();
        }
    }
}
    