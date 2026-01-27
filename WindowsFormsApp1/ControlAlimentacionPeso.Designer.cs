namespace ControlPorcino
{
    partial class ControlAlimentacionPeso
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
            this.btnVolverAlimentación = new System.Windows.Forms.Button();
            this.lblIDAlimentacion = new System.Windows.Forms.Label();
            this.lblTipoAlimento = new System.Windows.Forms.Label();
            this.lblCantidadAlimentacion = new System.Windows.Forms.Label();
            this.lblFechaAlimentacion = new System.Windows.Forms.Label();
            this.txtEdadCerdo = new System.Windows.Forms.TextBox();
            this.gbTipoAlimento = new System.Windows.Forms.GroupBox();
            this.rbSuplemento = new System.Windows.Forms.RadioButton();
            this.rbMaíz = new System.Windows.Forms.RadioButton();
            this.rbBalanceado = new System.Windows.Forms.RadioButton();
            this.txtCantidadAlimentacion = new System.Windows.Forms.TextBox();
            this.dtpAlimentacion = new System.Windows.Forms.DateTimePicker();
            this.dgvControlAlimentacionPeso = new System.Windows.Forms.DataGridView();
            this.btnGuardarAlimentacion = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPesoCer = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gbTipoCerdo = new System.Windows.Forms.GroupBox();
            this.rbFaena = new System.Windows.Forms.RadioButton();
            this.rbEngorde = new System.Windows.Forms.RadioButton();
            this.rbCria = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadAli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTipoAlimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlAlimentacionPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gbTipoCerdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverAlimentación
            // 
            this.btnVolverAlimentación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolverAlimentación.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnVolverAlimentación.Location = new System.Drawing.Point(35, 28);
            this.btnVolverAlimentación.Name = "btnVolverAlimentación";
            this.btnVolverAlimentación.Size = new System.Drawing.Size(95, 56);
            this.btnVolverAlimentación.TabIndex = 0;
            this.btnVolverAlimentación.Text = "Volver";
            this.btnVolverAlimentación.UseVisualStyleBackColor = false;
            this.btnVolverAlimentación.Click += new System.EventHandler(this.btnVolverAlimentación_Click);
            // 
            // lblIDAlimentacion
            // 
            this.lblIDAlimentacion.AutoSize = true;
            this.lblIDAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblIDAlimentacion.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAlimentacion.Location = new System.Drawing.Point(146, 44);
            this.lblIDAlimentacion.Name = "lblIDAlimentacion";
            this.lblIDAlimentacion.Size = new System.Drawing.Size(93, 15);
            this.lblIDAlimentacion.TabIndex = 1;
            this.lblIDAlimentacion.Text = "Edad del cerdo:";
            this.lblIDAlimentacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoAlimento
            // 
            this.lblTipoAlimento.AutoSize = true;
            this.lblTipoAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTipoAlimento.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAlimento.Location = new System.Drawing.Point(39, 119);
            this.lblTipoAlimento.Name = "lblTipoAlimento";
            this.lblTipoAlimento.Size = new System.Drawing.Size(88, 13);
            this.lblTipoAlimento.TabIndex = 2;
            this.lblTipoAlimento.Text = "Tipo Alimento:";
            this.lblTipoAlimento.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantidadAlimentacion
            // 
            this.lblCantidadAlimentacion.AutoSize = true;
            this.lblCantidadAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCantidadAlimentacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidadAlimentacion.Location = new System.Drawing.Point(296, 119);
            this.lblCantidadAlimentacion.Name = "lblCantidadAlimentacion";
            this.lblCantidadAlimentacion.Size = new System.Drawing.Size(85, 13);
            this.lblCantidadAlimentacion.TabIndex = 3;
            this.lblCantidadAlimentacion.Text = "Tipo de cerdo:";
            // 
            // lblFechaAlimentacion
            // 
            this.lblFechaAlimentacion.AutoSize = true;
            this.lblFechaAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFechaAlimentacion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaAlimentacion.Location = new System.Drawing.Point(32, 183);
            this.lblFechaAlimentacion.Name = "lblFechaAlimentacion";
            this.lblFechaAlimentacion.Size = new System.Drawing.Size(109, 13);
            this.lblFechaAlimentacion.TabIndex = 4;
            this.lblFechaAlimentacion.Text = "Fecha de Registro:";
            // 
            // txtEdadCerdo
            // 
            this.txtEdadCerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEdadCerdo.Location = new System.Drawing.Point(245, 44);
            this.txtEdadCerdo.Name = "txtEdadCerdo";
            this.txtEdadCerdo.Size = new System.Drawing.Size(100, 20);
            this.txtEdadCerdo.TabIndex = 5;
            // 
            // gbTipoAlimento
            // 
            this.gbTipoAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbTipoAlimento.Controls.Add(this.rbSuplemento);
            this.gbTipoAlimento.Controls.Add(this.rbMaíz);
            this.gbTipoAlimento.Controls.Add(this.rbBalanceado);
            this.gbTipoAlimento.Location = new System.Drawing.Point(133, 90);
            this.gbTipoAlimento.Name = "gbTipoAlimento";
            this.gbTipoAlimento.Size = new System.Drawing.Size(132, 78);
            this.gbTipoAlimento.TabIndex = 6;
            this.gbTipoAlimento.TabStop = false;
            // 
            // rbSuplemento
            // 
            this.rbSuplemento.AutoSize = true;
            this.rbSuplemento.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold);
            this.rbSuplemento.Location = new System.Drawing.Point(6, 50);
            this.rbSuplemento.Name = "rbSuplemento";
            this.rbSuplemento.Size = new System.Drawing.Size(107, 22);
            this.rbSuplemento.TabIndex = 2;
            this.rbSuplemento.TabStop = true;
            this.rbSuplemento.Text = "Suplemento";
            this.rbSuplemento.UseVisualStyleBackColor = true;
            this.rbSuplemento.CheckedChanged += new System.EventHandler(this.rbSuplemento_CheckedChanged);
            // 
            // rbMaíz
            // 
            this.rbMaíz.AutoSize = true;
            this.rbMaíz.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold);
            this.rbMaíz.Location = new System.Drawing.Point(6, 26);
            this.rbMaíz.Name = "rbMaíz";
            this.rbMaíz.Size = new System.Drawing.Size(58, 22);
            this.rbMaíz.TabIndex = 1;
            this.rbMaíz.TabStop = true;
            this.rbMaíz.Text = "Maíz";
            this.rbMaíz.UseVisualStyleBackColor = true;
            // 
            // rbBalanceado
            // 
            this.rbBalanceado.AutoSize = true;
            this.rbBalanceado.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold);
            this.rbBalanceado.Location = new System.Drawing.Point(6, 3);
            this.rbBalanceado.Name = "rbBalanceado";
            this.rbBalanceado.Size = new System.Drawing.Size(107, 22);
            this.rbBalanceado.TabIndex = 0;
            this.rbBalanceado.TabStop = true;
            this.rbBalanceado.Text = "Balanceado";
            this.rbBalanceado.UseVisualStyleBackColor = true;
            // 
            // txtCantidadAlimentacion
            // 
            this.txtCantidadAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCantidadAlimentacion.Location = new System.Drawing.Point(401, 116);
            this.txtCantidadAlimentacion.Name = "txtCantidadAlimentacion";
            this.txtCantidadAlimentacion.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAlimentacion.TabIndex = 7;
            // 
            // dtpAlimentacion
            // 
            this.dtpAlimentacion.Location = new System.Drawing.Point(65, 208);
            this.dtpAlimentacion.Name = "dtpAlimentacion";
            this.dtpAlimentacion.Size = new System.Drawing.Size(200, 20);
            this.dtpAlimentacion.TabIndex = 8;
            // 
            // dgvControlAlimentacionPeso
            // 
            this.dgvControlAlimentacionPeso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvControlAlimentacionPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlAlimentacionPeso.Location = new System.Drawing.Point(33, 243);
            this.dgvControlAlimentacionPeso.Name = "dgvControlAlimentacionPeso";
            this.dgvControlAlimentacionPeso.Size = new System.Drawing.Size(491, 150);
            this.dgvControlAlimentacionPeso.TabIndex = 9;
            // 
            // btnGuardarAlimentacion
            // 
            this.btnGuardarAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAlimentacion.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarAlimentacion.Location = new System.Drawing.Point(201, 411);
            this.btnGuardarAlimentacion.Name = "btnGuardarAlimentacion";
            this.btnGuardarAlimentacion.Size = new System.Drawing.Size(149, 56);
            this.btnGuardarAlimentacion.TabIndex = 10;
            this.btnGuardarAlimentacion.Text = "Guardar";
            this.btnGuardarAlimentacion.UseVisualStyleBackColor = false;
            this.btnGuardarAlimentacion.Click += new System.EventHandler(this.btnGuardarAlimentacion_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPeso.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeso.Location = new System.Drawing.Point(351, 47);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(64, 13);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso (Kg):";
            // 
            // txtPesoCer
            // 
            this.txtPesoCer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPesoCer.Location = new System.Drawing.Point(419, 44);
            this.txtPesoCer.Name = "txtPesoCer";
            this.txtPesoCer.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCer.TabIndex = 17;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Control_de_Alimentación__Ninasunta_;
            this.pictureBox5.Location = new System.Drawing.Point(0, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(938, 497);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // gbTipoCerdo
            // 
            this.gbTipoCerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbTipoCerdo.Controls.Add(this.rbFaena);
            this.gbTipoCerdo.Controls.Add(this.rbEngorde);
            this.gbTipoCerdo.Controls.Add(this.rbCria);
            this.gbTipoCerdo.Location = new System.Drawing.Point(387, 90);
            this.gbTipoCerdo.Name = "gbTipoCerdo";
            this.gbTipoCerdo.Size = new System.Drawing.Size(132, 78);
            this.gbTipoCerdo.TabIndex = 7;
            this.gbTipoCerdo.TabStop = false;
            // 
            // rbFaena
            // 
            this.rbFaena.AutoSize = true;
            this.rbFaena.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold);
            this.rbFaena.Location = new System.Drawing.Point(6, 50);
            this.rbFaena.Name = "rbFaena";
            this.rbFaena.Size = new System.Drawing.Size(69, 22);
            this.rbFaena.TabIndex = 2;
            this.rbFaena.TabStop = true;
            this.rbFaena.Text = "Faena";
            this.rbFaena.UseVisualStyleBackColor = true;
            // 
            // rbEngorde
            // 
            this.rbEngorde.AutoSize = true;
            this.rbEngorde.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold);
            this.rbEngorde.Location = new System.Drawing.Point(6, 26);
            this.rbEngorde.Name = "rbEngorde";
            this.rbEngorde.Size = new System.Drawing.Size(83, 22);
            this.rbEngorde.TabIndex = 1;
            this.rbEngorde.TabStop = true;
            this.rbEngorde.Text = "Engorde";
            this.rbEngorde.UseVisualStyleBackColor = true;
            // 
            // rbCria
            // 
            this.rbCria.AutoSize = true;
            this.rbCria.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold);
            this.rbCria.Location = new System.Drawing.Point(6, 3);
            this.rbCria.Name = "rbCria";
            this.rbCria.Size = new System.Drawing.Size(54, 22);
            this.rbCria.TabIndex = 0;
            this.rbCria.TabStop = true;
            this.rbCria.Text = "Cría";
            this.rbCria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(273, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cantidad de alimentos (Kg):";
            // 
            // txtCantidadAli
            // 
            this.txtCantidadAli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCantidadAli.Location = new System.Drawing.Point(393, 208);
            this.txtCantidadAli.Name = "txtCantidadAli";
            this.txtCantidadAli.Size = new System.Drawing.Size(114, 20);
            this.txtCantidadAli.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(169, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "(Meses)";
            // 
            // ControlAlimentacionPeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(936, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadAli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTipoCerdo);
            this.Controls.Add(this.txtPesoCer);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnGuardarAlimentacion);
            this.Controls.Add(this.dgvControlAlimentacionPeso);
            this.Controls.Add(this.dtpAlimentacion);
            this.Controls.Add(this.gbTipoAlimento);
            this.Controls.Add(this.txtEdadCerdo);
            this.Controls.Add(this.lblFechaAlimentacion);
            this.Controls.Add(this.lblCantidadAlimentacion);
            this.Controls.Add(this.lblTipoAlimento);
            this.Controls.Add(this.lblIDAlimentacion);
            this.Controls.Add(this.btnVolverAlimentación);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtCantidadAlimentacion);
            this.Name = "ControlAlimentacionPeso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlAlimentacionPeso_FormClosing);
            this.Load += new System.EventHandler(this.ControlAlimentacionPeso_Load);
            this.gbTipoAlimento.ResumeLayout(false);
            this.gbTipoAlimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlAlimentacionPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gbTipoCerdo.ResumeLayout(false);
            this.gbTipoCerdo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverAlimentación;
        private System.Windows.Forms.Label lblIDAlimentacion;
        private System.Windows.Forms.Label lblTipoAlimento;
        private System.Windows.Forms.Label lblCantidadAlimentacion;
        private System.Windows.Forms.Label lblFechaAlimentacion;
        private System.Windows.Forms.TextBox txtEdadCerdo;
        private System.Windows.Forms.GroupBox gbTipoAlimento;
        private System.Windows.Forms.TextBox txtCantidadAlimentacion;
        private System.Windows.Forms.DateTimePicker dtpAlimentacion;
        private System.Windows.Forms.DataGridView dgvControlAlimentacionPeso;
        private System.Windows.Forms.RadioButton rbSuplemento;
        private System.Windows.Forms.RadioButton rbMaíz;
        private System.Windows.Forms.RadioButton rbBalanceado;
        private System.Windows.Forms.Button btnGuardarAlimentacion;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPesoCer;
        private System.Windows.Forms.GroupBox gbTipoCerdo;
        private System.Windows.Forms.RadioButton rbFaena;
        private System.Windows.Forms.RadioButton rbEngorde;
        private System.Windows.Forms.RadioButton rbCria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadAli;
        private System.Windows.Forms.Label label2;
    }
}