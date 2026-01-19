namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrCrianza = new System.Windows.Forms.Button();
            this.btnIrProduccion = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
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
            // btnIrCrianza
            // 
            this.btnIrCrianza.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.btnIrCrianza.Location = new System.Drawing.Point(290, 163);
            this.btnIrCrianza.Name = "btnIrCrianza";
            this.btnIrCrianza.Size = new System.Drawing.Size(49, 49);
            this.btnIrCrianza.TabIndex = 1;
            this.btnIrCrianza.Text = "->";
            this.btnIrCrianza.UseVisualStyleBackColor = false;
            // 
            // btnIrProduccion
            // 
            this.btnIrProduccion.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.btnIrProduccion.Location = new System.Drawing.Point(290, 321);
            this.btnIrProduccion.Name = "btnIrProduccion";
            this.btnIrProduccion.Size = new System.Drawing.Size(49, 49);
            this.btnIrProduccion.TabIndex = 2;
            this.btnIrProduccion.Text = "->";
            this.btnIrProduccion.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.btnIrProduccion);
            this.Controls.Add(this.btnIrCrianza);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrCrianza;
        private System.Windows.Forms.Button btnIrProduccion;
    }
}
