namespace ControlPorcino
{
    partial class Form2
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
            this.ColumnIDCrianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaCrianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexoCrianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaludCrianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservacionesCrianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnVolverCrianza.Location = new System.Drawing.Point(426, 24);
            this.btnVolverCrianza.Name = "btnVolverCrianza";
            this.btnVolverCrianza.Size = new System.Drawing.Size(106, 53);
            this.btnVolverCrianza.TabIndex = 1;
            this.btnVolverCrianza.Text = "Volver";
            this.btnVolverCrianza.UseVisualStyleBackColor = true;
            this.btnVolverCrianza.Click += new System.EventHandler(this.btnVolverCrianza_Click);
            // 
            // btnGuardarCrianza
            // 
            this.btnGuardarCrianza.Location = new System.Drawing.Point(426, 329);
            this.btnGuardarCrianza.Name = "btnGuardarCrianza";
            this.btnGuardarCrianza.Size = new System.Drawing.Size(106, 56);
            this.btnGuardarCrianza.TabIndex = 2;
            this.btnGuardarCrianza.Text = "Guardar";
            this.btnGuardarCrianza.UseVisualStyleBackColor = true;
            this.btnGuardarCrianza.Click += new System.EventHandler(this.btnGuardarCrianza_Click);
            // 
            // lblIDCrianza
            // 
            this.lblIDCrianza.AutoSize = true;
            this.lblIDCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblIDCrianza.Location = new System.Drawing.Point(565, 44);
            this.lblIDCrianza.Name = "lblIDCrianza";
            this.lblIDCrianza.Size = new System.Drawing.Size(68, 13);
            this.lblIDCrianza.TabIndex = 3;
            this.lblIDCrianza.Text = "ID del cerdo:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(522, 95);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSexo.Location = new System.Drawing.Point(448, 166);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSalud.Location = new System.Drawing.Point(674, 166);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(88, 13);
            this.lblSalud.TabIndex = 6;
            this.lblSalud.Text = "Estado de Salud:";
            // 
            // lblObservacionesCrianza
            // 
            this.lblObservacionesCrianza.AutoSize = true;
            this.lblObservacionesCrianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblObservacionesCrianza.Location = new System.Drawing.Point(454, 234);
            this.lblObservacionesCrianza.Name = "lblObservacionesCrianza";
            this.lblObservacionesCrianza.Size = new System.Drawing.Size(78, 13);
            this.lblObservacionesCrianza.TabIndex = 7;
            this.lblObservacionesCrianza.Text = "Observaciones";
            // 
            // dgvCrianza
            // 
            this.dgvCrianza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrianza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDCrianza,
            this.ColumnFechaCrianza,
            this.ColumnSexoCrianza,
            this.ColumnSaludCrianza,
            this.ColumnObservacionesCrianza});
            this.dgvCrianza.Location = new System.Drawing.Point(416, 391);
            this.dgvCrianza.Name = "dgvCrianza";
            this.dgvCrianza.Size = new System.Drawing.Size(526, 118);
            this.dgvCrianza.TabIndex = 8;
            // 
            // ColumnIDCrianza
            // 
            this.ColumnIDCrianza.HeaderText = "ID del Cerdo";
            this.ColumnIDCrianza.Name = "ColumnIDCrianza";
            // 
            // ColumnFechaCrianza
            // 
            this.ColumnFechaCrianza.HeaderText = "Fecha";
            this.ColumnFechaCrianza.Name = "ColumnFechaCrianza";
            // 
            // ColumnSexoCrianza
            // 
            this.ColumnSexoCrianza.HeaderText = "Sexo";
            this.ColumnSexoCrianza.Name = "ColumnSexoCrianza";
            // 
            // ColumnSaludCrianza
            // 
            this.ColumnSaludCrianza.HeaderText = "Estado de Salud";
            this.ColumnSaludCrianza.Name = "ColumnSaludCrianza";
            // 
            // ColumnObservacionesCrianza
            // 
            this.ColumnObservacionesCrianza.HeaderText = "Observaciones";
            this.ColumnObservacionesCrianza.Name = "ColumnObservacionesCrianza";
            // 
            // txtIDCrianza
            // 
            this.txtIDCrianza.Location = new System.Drawing.Point(677, 44);
            this.txtIDCrianza.Name = "txtIDCrianza";
            this.txtIDCrianza.Size = new System.Drawing.Size(93, 20);
            this.txtIDCrianza.TabIndex = 9;
            // 
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSexo.Controls.Add(this.rbHembra);
            this.gbSexo.Controls.Add(this.rbMacho);
            this.gbSexo.Location = new System.Drawing.Point(525, 147);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(115, 53);
            this.gbSexo.TabIndex = 14;
            this.gbSexo.TabStop = false;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Location = new System.Drawing.Point(6, 36);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(62, 17);
            this.rbHembra.TabIndex = 1;
            this.rbHembra.TabStop = true;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            this.rbHembra.CheckedChanged += new System.EventHandler(this.rbHembra_CheckedChanged);
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(6, 0);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 0;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            this.rbMacho.CheckedChanged += new System.EventHandler(this.rbMacho_CheckedChanged);
            // 
            // gbSalud
            // 
            this.gbSalud.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSalud.Controls.Add(this.rbEnfermo);
            this.gbSalud.Controls.Add(this.rbSaludable);
            this.gbSalud.Location = new System.Drawing.Point(792, 147);
            this.gbSalud.Name = "gbSalud";
            this.gbSalud.Size = new System.Drawing.Size(120, 53);
            this.gbSalud.TabIndex = 15;
            this.gbSalud.TabStop = false;
            // 
            // rbEnfermo
            // 
            this.rbEnfermo.AutoSize = true;
            this.rbEnfermo.Location = new System.Drawing.Point(6, 36);
            this.rbEnfermo.Name = "rbEnfermo";
            this.rbEnfermo.Size = new System.Drawing.Size(64, 17);
            this.rbEnfermo.TabIndex = 1;
            this.rbEnfermo.TabStop = true;
            this.rbEnfermo.Text = "Enfermo";
            this.rbEnfermo.UseVisualStyleBackColor = true;
            this.rbEnfermo.CheckedChanged += new System.EventHandler(this.rbEnfermo_CheckedChanged);
            // 
            // rbSaludable
            // 
            this.rbSaludable.AutoSize = true;
            this.rbSaludable.Location = new System.Drawing.Point(6, 0);
            this.rbSaludable.Name = "rbSaludable";
            this.rbSaludable.Size = new System.Drawing.Size(72, 17);
            this.rbSaludable.TabIndex = 0;
            this.rbSaludable.TabStop = true;
            this.rbSaludable.Text = "Saludable";
            this.rbSaludable.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(549, 234);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(363, 104);
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
            // Form2
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
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDCrianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaCrianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexoCrianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaludCrianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObservacionesCrianza;
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