namespace ControlPorcino
{
    partial class Peso
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
            this.lblIDPeso = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpPeso = new System.Windows.Forms.DateTimePicker();
            this.dgvPeso = new System.Windows.Forms.DataGridView();
            this.ColumnIDPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaPesaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverPeso = new System.Windows.Forms.Button();
            this.btnGuardarPeso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDPeso
            // 
            this.lblIDPeso.AutoSize = true;
            this.lblIDPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblIDPeso.Location = new System.Drawing.Point(615, 64);
            this.lblIDPeso.Name = "lblIDPeso";
            this.lblIDPeso.Size = new System.Drawing.Size(68, 13);
            this.lblIDPeso.TabIndex = 1;
            this.lblIDPeso.Text = "ID del cerdo:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPeso.Location = new System.Drawing.Point(606, 137);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(56, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso (Kg):";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(517, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Pesaje:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(748, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(684, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dtpPeso
            // 
            this.dtpPeso.Location = new System.Drawing.Point(648, 203);
            this.dtpPeso.Name = "dtpPeso";
            this.dtpPeso.Size = new System.Drawing.Size(200, 20);
            this.dtpPeso.TabIndex = 6;
            // 
            // dgvPeso
            // 
            this.dgvPeso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDPeso,
            this.ColumnPeso,
            this.ColumnFechaPesaje});
            this.dgvPeso.Location = new System.Drawing.Point(520, 238);
            this.dgvPeso.Name = "dgvPeso";
            this.dgvPeso.Size = new System.Drawing.Size(344, 137);
            this.dgvPeso.TabIndex = 7;
            // 
            // ColumnIDPeso
            // 
            this.ColumnIDPeso.HeaderText = "ID del cerdo";
            this.ColumnIDPeso.Name = "ColumnIDPeso";
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "Peso (Kg)";
            this.ColumnPeso.Name = "ColumnPeso";
            // 
            // ColumnFechaPesaje
            // 
            this.ColumnFechaPesaje.HeaderText = "Fecha del pesaje";
            this.ColumnFechaPesaje.Name = "ColumnFechaPesaje";
            // 
            // btnVolverPeso
            // 
            this.btnVolverPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolverPeso.Location = new System.Drawing.Point(462, 27);
            this.btnVolverPeso.Name = "btnVolverPeso";
            this.btnVolverPeso.Size = new System.Drawing.Size(98, 50);
            this.btnVolverPeso.TabIndex = 10;
            this.btnVolverPeso.Text = "Volver";
            this.btnVolverPeso.UseVisualStyleBackColor = false;
            this.btnVolverPeso.Click += new System.EventHandler(this.btnVolverPeso_Click);
            // 
            // btnGuardarPeso
            // 
            this.btnGuardarPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarPeso.Location = new System.Drawing.Point(462, 418);
            this.btnGuardarPeso.Name = "btnGuardarPeso";
            this.btnGuardarPeso.Size = new System.Drawing.Size(98, 48);
            this.btnGuardarPeso.TabIndex = 11;
            this.btnGuardarPeso.Text = "Guardar";
            this.btnGuardarPeso.UseVisualStyleBackColor = false;
            this.btnGuardarPeso.Click += new System.EventHandler(this.btnGuardarPeso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Control_de_Peso__Ninasunta_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Peso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(933, 487);
            this.Controls.Add(this.btnGuardarPeso);
            this.Controls.Add(this.btnVolverPeso);
            this.Controls.Add(this.dgvPeso);
            this.Controls.Add(this.dtpPeso);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblIDPeso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Peso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpPeso;
        private System.Windows.Forms.DataGridView dgvPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaPesaje;
        private System.Windows.Forms.Button btnVolverPeso;
        private System.Windows.Forms.Button btnGuardarPeso;
    }
}