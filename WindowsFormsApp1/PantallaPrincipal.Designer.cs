namespace WindowsFormsApp1
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIrCrianza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrProduccion = new System.Windows.Forms.Button();
            this.btnIrVacunacion = new System.Windows.Forms.Button();
            this.btnIrGastronomia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIrCrianza
            // 
            this.btnIrCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrCrianza.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnIrCrianza.Location = new System.Drawing.Point(282, 163);
            this.btnIrCrianza.Name = "btnIrCrianza";
            this.btnIrCrianza.Size = new System.Drawing.Size(57, 55);
            this.btnIrCrianza.TabIndex = 1;
            this.btnIrCrianza.Text = "->";
            this.btnIrCrianza.UseVisualStyleBackColor = false;
            this.btnIrCrianza.Click += new System.EventHandler(this.btnIrCrianza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Pantalla_Principal__Ninasunta___1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIrProduccion
            // 
            this.btnIrProduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrProduccion.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnIrProduccion.Location = new System.Drawing.Point(282, 318);
            this.btnIrProduccion.Name = "btnIrProduccion";
            this.btnIrProduccion.Size = new System.Drawing.Size(57, 54);
            this.btnIrProduccion.TabIndex = 2;
            this.btnIrProduccion.Text = "->";
            this.btnIrProduccion.UseVisualStyleBackColor = false;
            this.btnIrProduccion.Click += new System.EventHandler(this.btnIrProduccion_Click);
            // 
            // btnIrVacunacion
            // 
            this.btnIrVacunacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrVacunacion.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnIrVacunacion.Location = new System.Drawing.Point(282, 244);
            this.btnIrVacunacion.Name = "btnIrVacunacion";
            this.btnIrVacunacion.Size = new System.Drawing.Size(57, 55);
            this.btnIrVacunacion.TabIndex = 3;
            this.btnIrVacunacion.Text = "->";
            this.btnIrVacunacion.UseVisualStyleBackColor = false;
            this.btnIrVacunacion.Click += new System.EventHandler(this.btnIrVacunacion_Click);
            // 
            // btnIrGastronomia
            // 
            this.btnIrGastronomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrGastronomia.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnIrGastronomia.Location = new System.Drawing.Point(282, 388);
            this.btnIrGastronomia.Name = "btnIrGastronomia";
            this.btnIrGastronomia.Size = new System.Drawing.Size(57, 55);
            this.btnIrGastronomia.TabIndex = 4;
            this.btnIrGastronomia.Text = "->";
            this.btnIrGastronomia.UseVisualStyleBackColor = false;
            this.btnIrGastronomia.Click += new System.EventHandler(this.btnIrGastronomia_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.btnIrGastronomia);
            this.Controls.Add(this.btnIrVacunacion);
            this.Controls.Add(this.btnIrProduccion);
            this.Controls.Add(this.btnIrCrianza);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrCrianza;
        private System.Windows.Forms.Button btnIrProduccion;
        private System.Windows.Forms.Button btnIrVacunacion;
        private System.Windows.Forms.Button btnIrGastronomia;
    }
}