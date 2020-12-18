namespace Algoritmo_Shell
{
    partial class Form1
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
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.ltbOrdenados = new System.Windows.Forms.ListBox();
            this.ltbDesordenados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.lbMayorR = new System.Windows.Forms.Label();
            this.lbMenorR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(232, 89);
            this.txtLista.Margin = new System.Windows.Forms.Padding(2);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(114, 20);
            this.txtLista.TabIndex = 0;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLista.Location = new System.Drawing.Point(366, 80);
            this.btnLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(103, 37);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Agregar Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // ltbOrdenados
            // 
            this.ltbOrdenados.FormattingEnabled = true;
            this.ltbOrdenados.Location = new System.Drawing.Point(389, 291);
            this.ltbOrdenados.Margin = new System.Windows.Forms.Padding(2);
            this.ltbOrdenados.Name = "ltbOrdenados";
            this.ltbOrdenados.Size = new System.Drawing.Size(122, 225);
            this.ltbOrdenados.TabIndex = 4;
            // 
            // ltbDesordenados
            // 
            this.ltbDesordenados.FormattingEnabled = true;
            this.ltbDesordenados.Location = new System.Drawing.Point(26, 297);
            this.ltbDesordenados.Margin = new System.Windows.Forms.Padding(2);
            this.ltbDesordenados.Name = "ltbDesordenados";
            this.ltbDesordenados.Size = new System.Drawing.Size(116, 225);
            this.ltbDesordenados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ordenados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desordenados";
            // 
            // btnShell
            // 
            this.btnShell.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShell.Location = new System.Drawing.Point(216, 324);
            this.btnShell.Margin = new System.Windows.Forms.Padding(2);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(106, 59);
            this.btnShell.TabIndex = 8;
            this.btnShell.Text = "Algoritmo Shell";
            this.btnShell.UseVisualStyleBackColor = false;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRandom.Location = new System.Drawing.Point(359, 184);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(110, 37);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Agregar Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar Tamaño";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tamaño del Arreglo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numeros para agregar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMayor);
            this.groupBox1.Controls.Add(this.txtMenor);
            this.groupBox1.Controls.Add(this.lbMayorR);
            this.groupBox1.Controls.Add(this.lbMenorR);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnLista);
            this.groupBox1.Controls.Add(this.txtLista);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(489, 246);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arreglo";
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(359, 144);
            this.txtMayor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(114, 20);
            this.txtMayor.TabIndex = 18;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(231, 145);
            this.txtMenor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(114, 20);
            this.txtMenor.TabIndex = 17;
            // 
            // lbMayorR
            // 
            this.lbMayorR.AutoSize = true;
            this.lbMayorR.Location = new System.Drawing.Point(366, 166);
            this.lbMayorR.Name = "lbMayorR";
            this.lbMayorR.Size = new System.Drawing.Size(79, 13);
            this.lbMayorR.TabIndex = 16;
            this.lbMayorR.Text = "Mayor Random";
            // 
            // lbMenorR
            // 
            this.lbMenorR.AutoSize = true;
            this.lbMenorR.Location = new System.Drawing.Point(251, 167);
            this.lbMenorR.Name = "lbMenorR";
            this.lbMenorR.Size = new System.Drawing.Size(80, 13);
            this.lbMenorR.TabIndex = 15;
            this.lbMenorR.Text = "Menor Random";
            this.lbMenorR.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Algoritmo_Shell.Properties.Resources.logo_tec;
            this.pictureBox1.Location = new System.Drawing.Point(5, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 224);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(227, 420);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 34);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTiempo.Location = new System.Drawing.Point(344, 546);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 15;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(158, 543);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(59, 13);
            this.lbl5.TabIndex = 36;
            this.lbl5.Text = "Iteraciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(562, 568);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbDesordenados);
            this.Controls.Add(this.ltbOrdenados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.ListBox ltbOrdenados;
        private System.Windows.Forms.ListBox ltbDesordenados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMayorR;
        private System.Windows.Forms.Label lbMenorR;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Label lbl5;
    }
}

