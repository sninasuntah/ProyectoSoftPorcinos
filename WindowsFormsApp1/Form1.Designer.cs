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
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCrianza.Location = new System.Drawing.Point(302, 153);
            this.btnCrianza.Name = "btnCrianza";
            this.btnCrianza.Size = new System.Drawing.Size(51, 51);
            this.btnCrianza.TabIndex = 1;
            this.btnCrianza.Text = "->";
            this.btnCrianza.UseVisualStyleBackColor = false;
            this.btnCrianza.Click += new System.EventHandler(this.btnCrianza_Click);
            // 
            // btnAlimentación
            // 
            this.btnAlimentación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlimentación.Location = new System.Drawing.Point(302, 252);
            this.btnAlimentación.Name = "btnAlimentación";
            this.btnAlimentación.Size = new System.Drawing.Size(51, 49);
            this.btnAlimentación.TabIndex = 2;
            this.btnAlimentación.Text = "->";
            this.btnAlimentación.UseVisualStyleBackColor = false;
            this.btnAlimentación.Click += new System.EventHandler(this.btnAlimentacion_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPeso.Location = new System.Drawing.Point(302, 344);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(51, 50);
            this.btnPeso.TabIndex = 3;
            this.btnPeso.Text = "->";
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
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolverPrincipal.Location = new System.Drawing.Point(156, 418);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(90, 48);
            this.btnVolverPrincipal.TabIndex = 6;
            this.btnVolverPrincipal.Text = "Volver";
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(922, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolverPrincipal);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnAlimentación);
            this.Controls.Add(this.btnCrianza);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEscoja);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.btnCrianza_Click);
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
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

