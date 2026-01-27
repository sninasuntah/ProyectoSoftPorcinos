namespace ControlPorcino
{
    partial class ControlCrianza
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
            this.btnVolverCrianza = new System.Windows.Forms.Button();
            this.btnGuardarCrianza = new System.Windows.Forms.Button();
            this.lblIDCrianza = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lblObservacionesCrianza = new System.Windows.Forms.Label();
            this.dgvCrianza = new System.Windows.Forms.DataGridView();
            this.txtIDCrianza = new System.Windows.Forms.TextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbHembra = new System.Windows.Forms.RadioButton();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.gbSalud = new System.Windows.Forms.GroupBox();
            this.rbEnfermo = new System.Windows.Forms.RadioButton();
            this.rbSaludable = new System.Windows.Forms.RadioButton();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpCrianza = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrianza)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbSalud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverCrianza
            // 
            this.btnVolverCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolverCrianza.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCrianza.Location = new System.Drawing.Point(426, 24);
            this.btnVolverCrianza.Name = "btnVolverCrianza";
            this.btnVolverCrianza.Size = new System.Drawing.Size(106, 53);
            this.btnVolverCrianza.TabIndex = 1;
            this.btnVolverCrianza.Text = "Volver";
            this.btnVolverCrianza.UseVisualStyleBackColor = false;
            this.btnVolverCrianza.Click += new System.EventHandler(this.btnVolverCrianza_Click);
            // 
            // btnGuardarCrianza
            // 
            this.btnGuardarCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarCrianza.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCrianza.Location = new System.Drawing.Point(580, 426);
            this.btnGuardarCrianza.Name = "btnGuardarCrianza";
            this.btnGuardarCrianza.Size = new System.Drawing.Size(159, 67);
            this.btnGuardarCrianza.TabIndex = 2;
            this.btnGuardarCrianza.Text = "Guardar";
            this.btnGuardarCrianza.UseVisualStyleBackColor = false;
            this.btnGuardarCrianza.Click += new System.EventHandler(this.btnGuardarCrianza_Click);
            // 
            // lblIDCrianza
            // 
            this.lblIDCrianza.AutoSize = true;
            this.lblIDCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblIDCrianza.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblIDCrianza.Location = new System.Drawing.Point(576, 44);
            this.lblIDCrianza.Name = "lblIDCrianza";
            this.lblIDCrianza.Size = new System.Drawing.Size(124, 20);
            this.lblIDCrianza.TabIndex = 3;
            this.lblIDCrianza.Text = "Edad del Cerdo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(499, 88);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(172, 20);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSexo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblSexo.Location = new System.Drawing.Point(453, 151);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 20);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSalud.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalud.Location = new System.Drawing.Point(652, 151);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(134, 20);
            this.lblSalud.TabIndex = 6;
            this.lblSalud.Text = "Estado de Salud:";
            // 
            // lblObservacionesCrianza
            // 
            this.lblObservacionesCrianza.AutoSize = true;
            this.lblObservacionesCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblObservacionesCrianza.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblObservacionesCrianza.Location = new System.Drawing.Point(466, 219);
            this.lblObservacionesCrianza.Name = "lblObservacionesCrianza";
            this.lblObservacionesCrianza.Size = new System.Drawing.Size(121, 20);
            this.lblObservacionesCrianza.TabIndex = 7;
            this.lblObservacionesCrianza.Text = "Observaciones:";
            // 
            // dgvCrianza
            // 
            this.dgvCrianza.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCrianza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrianza.Location = new System.Drawing.Point(416, 288);
            this.dgvCrianza.Name = "dgvCrianza";
            this.dgvCrianza.Size = new System.Drawing.Size(526, 118);
            this.dgvCrianza.TabIndex = 8;
            // 
            // txtIDCrianza
            // 
            this.txtIDCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtIDCrianza.Location = new System.Drawing.Point(725, 44);
            this.txtIDCrianza.Name = "txtIDCrianza";
            this.txtIDCrianza.Size = new System.Drawing.Size(93, 20);
            this.txtIDCrianza.TabIndex = 9;
            this.txtIDCrianza.TextChanged += new System.EventHandler(this.txtIDCrianza_TextChanged);
            // 
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbSexo.Controls.Add(this.rbHembra);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Location = new System.Drawing.Point(518, 133);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(115, 53);
            this.gbSexo.TabIndex = 14;
            this.gbSexo.TabStop = false;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.rbHembra.Location = new System.Drawing.Point(6, 32);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(89, 24);
            this.rbHembra.TabIndex = 1;
            this.rbHembra.TabStop = true;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            this.rbHembra.CheckedChanged += new System.EventHandler(this.rbHembra_CheckedChanged);
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.rbMacho.Location = new System.Drawing.Point(6, 0);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(77, 24);
            this.rbMacho.TabIndex = 0;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            this.rbMacho.CheckedChanged += new System.EventHandler(this.rbMacho_CheckedChanged);
            // 
            // gbSalud
            // 
            this.gbSalud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbSalud.Controls.Add(this.rbEnfermo);
            this.gbSalud.Controls.Add(this.rbSaludable);
            this.gbSalud.Location = new System.Drawing.Point(792, 133);
            this.gbSalud.Name = "gbSalud";
            this.gbSalud.Size = new System.Drawing.Size(120, 53);
            this.gbSalud.TabIndex = 15;
            this.gbSalud.TabStop = false;
            // 
            // rbEnfermo
            // 
            this.rbEnfermo.AutoSize = true;
            this.rbEnfermo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.rbEnfermo.Location = new System.Drawing.Point(6, 29);
            this.rbEnfermo.Name = "rbEnfermo";
            this.rbEnfermo.Size = new System.Drawing.Size(91, 24);
            this.rbEnfermo.TabIndex = 1;
            this.rbEnfermo.TabStop = true;
            this.rbEnfermo.Text = "Enfermo";
            this.rbEnfermo.UseVisualStyleBackColor = true;
            this.rbEnfermo.CheckedChanged += new System.EventHandler(this.rbEnfermo_CheckedChanged);
            // 
            // rbSaludable
            // 
            this.rbSaludable.AutoSize = true;
            this.rbSaludable.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold);
            this.rbSaludable.Location = new System.Drawing.Point(6, 0);
            this.rbSaludable.Name = "rbSaludable";
            this.rbSaludable.Size = new System.Drawing.Size(102, 24);
            this.rbSaludable.TabIndex = 0;
            this.rbSaludable.TabStop = true;
            this.rbSaludable.Text = "Saludable";
            this.rbSaludable.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtObservaciones.Location = new System.Drawing.Point(593, 195);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(287, 78);
            this.txtObservaciones.TabIndex = 17;
            this.txtObservaciones.TextChanged += new System.EventHandler(this.txtObservaciones_TextChanged);
            // 
            // dtpCrianza
            // 
            this.dtpCrianza.Location = new System.Drawing.Point(677, 88);
            this.dtpCrianza.Name = "dtpCrianza";
            this.dtpCrianza.Size = new System.Drawing.Size(200, 20);
            this.dtpCrianza.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Control_Crianza__Ninasunta_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ControlCrianza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(954, 521);
            this.Controls.Add(this.dtpCrianza);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.gbSalud);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtIDCrianza);
            this.Controls.Add(this.dgvCrianza);
            this.Controls.Add(this.lblObservacionesCrianza);
            this.Controls.Add(this.lblSalud);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblIDCrianza);
            this.Controls.Add(this.btnGuardarCrianza);
            this.Controls.Add(this.btnVolverCrianza);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ControlCrianza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlCrianza_FormClosing);
            this.Load += new System.EventHandler(this.ControlCrianza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrianza)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbSalud.ResumeLayout(false);
            this.gbSalud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolverCrianza;
        private System.Windows.Forms.Button btnGuardarCrianza;
        private System.Windows.Forms.Label lblIDCrianza;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.Label lblObservacionesCrianza;
        private System.Windows.Forms.DataGridView dgvCrianza;
        private System.Windows.Forms.TextBox txtIDCrianza;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbHembra;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.GroupBox gbSalud;
        private System.Windows.Forms.RadioButton rbEnfermo;
        private System.Windows.Forms.RadioButton rbSaludable;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpCrianza;
    }
}