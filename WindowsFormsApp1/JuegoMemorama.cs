using ControlPorcino;
using System;
using System.Collections;
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
    public partial class JuegoMemorama : Form
    {
        int TamanioColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<int> CartasEnumeradas;
        List<int> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        bool bloquearInteraccion = false;

        public JuegoMemorama()
        {
            InitializeComponent();
            iniciarJuego();
        }
        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            lblRecord.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<int>();
            CartasRevueltas = new List<int>();
            CartasSeleccionadas = new ArrayList();
            // rellenar pares con ids numéricas (1..8)
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i + 1);
                CartasEnumeradas.Add(i + 1);
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (int ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentaje));
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentaje));
            }
            int contadorFichas = 1;
            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    // usar Tag para índice (0-based)
                    CartasJuego.Tag = contadorFichas - 1;
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.cer_volteado;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += new EventHandler(btnCarta_Click);
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (bloquearInteraccion) return;

            if (CartasSeleccionadas.Count < 2)
            {
                Movimientos++;
                lblRecord.Text = Convert.ToString(Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                // evitar seleccionar la misma carta dos veces
                if (CartasSeleccionadas.Contains(CartasSeleccionadasUsuario)) return;

                int indice = (int)CartasSeleccionadasUsuario.Tag;
                CartaActual = CartasRevueltas[indice];
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                // 2 veces se realizó el click
                if (CartasSeleccionadas.Count == 2)
                {
                    // bloquear interacción hasta resolver par
                    bloquearInteraccion = true;

                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = CartasRevueltas[(int)CartaTemporal1.Tag];
                    int Carta2 = CartasRevueltas[(int)CartaTemporal2.Tag];
                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                        bloquearInteraccion = false;
                        if (CantidadDeCartasVolteadas >= 8)
                        {
                            MessageBox.Show("¡Felicidades! Has completado el juego en " + Movimientos + " movimientos.", "Juego Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            // intenta recuperar recurso "img{NumeroImagen}", fallback a imagen por defecto si no existe
            try
            {
                if (NumeroImagen == 0)
                {
                    if (Properties.Resources.ResourceManager.GetObject("image") is Bitmap bmp0) return bmp0;
                }
                var key = "img" + NumeroImagen;
                var obj = Properties.Resources.ResourceManager.GetObject(key);
                if (obj is Bitmap bmp) return bmp;
            }
            catch
            {
                // ignorar y usar fallback
            }
            // fallback seguro: usar la imagen de reverso para evitar null
            return Properties.Resources.cer_volteado;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Voltear cartas incorrectas y desbloquear interacción
            if (CartaTemporal1 != null && CartaTemporal2 != null)
            {
                CartaTemporal1.Image = Properties.Resources.cer_volteado;
                CartaTemporal2.Image = Properties.Resources.cer_volteado;
            }
            CartasSeleccionadas.Clear();
            bloquearInteraccion = false;
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuCrianza f = new MenuCrianza();
            f.Show();
            this.Hide();
        }
    }
}
