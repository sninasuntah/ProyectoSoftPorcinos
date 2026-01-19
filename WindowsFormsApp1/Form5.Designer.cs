namespace WindowsFormsApp1
{
    partial class Form5
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIrCrianza
            // 
            this.btnIrCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrCrianza.Location = new System.Drawing.Point(290, 163);
            this.btnIrCrianza.Name = "btnIrCrianza";
            this.btnIrCrianza.Size = new System.Drawing.Size(49, 49);
            this.btnIrCrianza.TabIndex = 1;
            this.btnIrCrianza.Text = "->";
            this.btnIrCrianza.UseVisualStyleBackColor = false;
            this.btnIrCrianza.Click += new System.EventHandler(this.btnIrCrianza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Pantalla_Principal__Ninasunta_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(285, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIrProduccion
            // 
            this.btnIrProduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrProduccion.Location = new System.Drawing.Point(290, 321);
            this.btnIrProduccion.Name = "btnIrProduccion";
            this.btnIrProduccion.Size = new System.Drawing.Size(49, 49);
            this.btnIrProduccion.TabIndex = 1;
            this.btnIrProduccion.Text = "->";
            this.btnIrProduccion.UseVisualStyleBackColor = false;
            this.btnIrProduccion.Click += new System.EventHandler(this.btnIrProduccion_Click);
            // 
<<<<<<< HEAD
            // btnIrProdu
            // 
            this.btnIrProdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIrProdu.Location = new System.Drawing.Point(290, 333);
            this.btnIrProdu.Name = "btnIrProdu";
            this.btnIrProdu.Size = new System.Drawing.Size(49, 45);
            this.btnIrProdu.TabIndex = 2;
            this.btnIrProdu.Text = "->";
            this.btnIrProdu.UseVisualStyleBackColor = false;
            this.btnIrProdu.Click += new System.EventHandler(this.button1_Click);
=======
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Pantalla_Principal__Ninasunta_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(284, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
>>>>>>> a249241 (Arreglo de boton ir produ, finalizacion de frmProdu y frmComerr)
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 489);
<<<<<<< HEAD
            this.Controls.Add(this.btnIrProdu);
=======
            this.Controls.Add(this.button1);
>>>>>>> a249241 (Arreglo de boton ir produ, finalizacion de frmProdu y frmComerr)
            this.Controls.Add(this.btnIrCrianza);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrCrianza;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnIrProdu;
=======
        private System.Windows.Forms.Button button1;
>>>>>>> a249241 (Arreglo de boton ir produ, finalizacion de frmProdu y frmComerr)
    }
}