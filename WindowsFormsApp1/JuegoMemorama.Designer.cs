namespace WindowsFormsApp1
{
    partial class JuegoMemorama
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
            this.components = new System.ComponentModel.Container();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVolverJuegoMemorama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(19, 30);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(468, 390);
            this.PanelJuego.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimientos:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(730, 88);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(34, 38);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "0";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReiniciar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(513, 213);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(251, 45);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reinicio de Juego";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVolverJuegoMemorama
            // 
            this.btnVolverJuegoMemorama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolverJuegoMemorama.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverJuegoMemorama.Location = new System.Drawing.Point(587, 395);
            this.btnVolverJuegoMemorama.Name = "btnVolverJuegoMemorama";
            this.btnVolverJuegoMemorama.Size = new System.Drawing.Size(201, 43);
            this.btnVolverJuegoMemorama.TabIndex = 4;
            this.btnVolverJuegoMemorama.Text = "Volver";
            this.btnVolverJuegoMemorama.UseVisualStyleBackColor = false;
            this.btnVolverJuegoMemorama.Click += new System.EventHandler(this.button1_Click);
            // 
            // JuegoMemorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverJuegoMemorama);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelJuego);
            this.Name = "JuegoMemorama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoMemorama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVolverJuegoMemorama;
    }
}