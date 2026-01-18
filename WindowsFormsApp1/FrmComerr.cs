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
    public partial class FrmComerr : Form
    {
        public FrmComerr()
        {
            InitializeComponent();
        }

        private void FrmComerr_Load(object sender, EventArgs e)
        {
            lblDestino.Text = "DESTINO DE VENTA: ";
            lblPrecio.Text = "PRECIO ESTIMADO DE VENTA: ";
            lblMotivo.Text = "MOTIVO: ";
            lblTotal.Text = "Total de venta: $0.00";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmProdu f1 = new FrmProdu();
            f1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int edad;
            double pesoKilos;

            if (!int.TryParse(txtEdad.Text, out edad) || edad < 0)
            {
                MessageBox.Show("Ingresa una edad válida");
                return;
            }

            if (!double.TryParse(txtPeso.Text, out pesoKilos) || pesoKilos < 0)
            {
                MessageBox.Show("Ingresa un peso válido");
                return;
            }

            string destino = "";
            double precioLibra = 0;
            string motivo = "";

            if (edad >= 5 && pesoKilos >= 80)
            {
                destino = "FAENA";
                precioLibra = 1.40;
                motivo = "EL PORCINO HA ALCANZADO EL PESO Y LA MADUREZ ÓPTIMA PARA EL MERCADO DE CARNE.";
            }
            else if (edad <= 2 || pesoKilos <= 30)
            {
                destino = "CRÍA";
                precioLibra = 2.10;
                motivo = "POR SU CORTA EDAD, SE VALORIZA COMO PIE DE CRÍA POR SU POTENCIAL GENÉTICO.";
            }
            else
            {
                destino = "ENGORDE";
                precioLibra = 1.25;
                motivo = "SE ENCUENTRA EN DESARROLLO INTERMEDIO; SU VENTA SE DESTINA A FINALIZAR EL ENGORDE.";
            }

            double pesoLibras = pesoKilos * 2.20462;
            double totalVenta = pesoLibras * precioLibra;

            lblDestino.Text = "DESTINO DE VENTA: " + destino;
            lblPrecio.Text = "PRECIO ESTIMADO DE VENTA: $" + precioLibra.ToString("F2") + " POR LIBRA";
            lblMotivo.Text = "MOTIVO: " + motivo;
            lblTotal.Text = "Total de venta: $" + totalVenta.ToString("N2");
        }
    }
}