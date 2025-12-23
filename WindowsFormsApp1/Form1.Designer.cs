namespace ControlPorcino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCrianza = new System.Windows.Forms.Button();
            this.btnAlimentación = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.lblEscoja = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(174, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SOFTWARE DE CONTROL DE PORCINOS";
            // 
            // btnCrianza
            // 
            this.btnCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCrianza.Location = new System.Drawing.Point(217, 233);
            this.btnCrianza.Name = "btnCrianza";
            this.btnCrianza.Size = new System.Drawing.Size(148, 83);
            this.btnCrianza.TabIndex = 1;
            this.btnCrianza.Text = "Crianza";
            this.btnCrianza.UseVisualStyleBackColor = false;
            this.btnCrianza.Click += new System.EventHandler(this.btnCrianza_Click);
            // 
            // btnAlimentación
            // 
            this.btnAlimentación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlimentación.Location = new System.Drawing.Point(407, 363);
            this.btnAlimentación.Name = "btnAlimentación";
            this.btnAlimentación.Size = new System.Drawing.Size(150, 81);
            this.btnAlimentación.TabIndex = 2;
            this.btnAlimentación.Text = "Alimentación";
            this.btnAlimentación.UseVisualStyleBackColor = false;
            this.btnAlimentación.Click += new System.EventHandler(this.btnAlimentacion_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPeso.Location = new System.Drawing.Point(22, 363);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(154, 81);
            this.btnPeso.TabIndex = 3;
            this.btnPeso.Text = "Peso";
            this.btnPeso.UseVisualStyleBackColor = false;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // lblEscoja
            // 
            this.lblEscoja.AutoSize = true;
            this.lblEscoja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEscoja.Location = new System.Drawing.Point(224, 153);
            this.lblEscoja.Name = "lblEscoja";
            this.lblEscoja.Size = new System.Drawing.Size(129, 13);
            this.lblEscoja.TabIndex = 4;
            this.lblEscoja.Text = "Escoja una funcionalidad:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.chanchosaltando;
            this.pictureBox4.Location = new System.Drawing.Point(619, 322);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.minichanchos;
            this.pictureBox3.Location = new System.Drawing.Point(619, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.chanchi;
            this.pictureBox2.Location = new System.Drawing.Point(619, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.fondogranja;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(922, 498);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEscoja);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnAlimentación);
            this.Controls.Add(this.btnCrianza);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btnCrianza_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCrianza;
        private System.Windows.Forms.Button btnAlimentación;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Label lblEscoja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

