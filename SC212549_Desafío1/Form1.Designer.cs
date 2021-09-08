namespace SC212549_Desafío1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAR = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbFilaB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFilaC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilaD = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFilaE = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFilaA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido/a! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por favor reserva un asiento para disfrutar de tu pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asientos - Fila A:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 391);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre de quien reserva:";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(179, 388);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(121, 23);
            this.btnReservar.TabIndex = 9;
            this.btnReservar.Text = "Reservar asiento";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir del programa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SC212549_Desafío1.Properties.Resources.Img;
            this.pictureBox1.Location = new System.Drawing.Point(33, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstAR
            // 
            this.lstAR.FormattingEnabled = true;
            this.lstAR.Location = new System.Drawing.Point(327, 109);
            this.lstAR.Name = "lstAR";
            this.lstAR.Size = new System.Drawing.Size(141, 160);
            this.lstAR.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lista de asientos reservados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista de asientos:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SC212549_Desafío1.Properties.Resources.img2;
            this.pictureBox2.Location = new System.Drawing.Point(496, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // cmbFilaB
            // 
            this.cmbFilaB.FormattingEnabled = true;
            this.cmbFilaB.Location = new System.Drawing.Point(179, 313);
            this.cmbFilaB.Name = "cmbFilaB";
            this.cmbFilaB.Size = new System.Drawing.Size(121, 21);
            this.cmbFilaB.TabIndex = 18;
            this.cmbFilaB.SelectedIndexChanged += new System.EventHandler(this.CmbFilaB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Asientos - Fila B:";
            // 
            // cmbFilaC
            // 
            this.cmbFilaC.FormattingEnabled = true;
            this.cmbFilaC.Location = new System.Drawing.Point(327, 313);
            this.cmbFilaC.Name = "cmbFilaC";
            this.cmbFilaC.Size = new System.Drawing.Size(121, 21);
            this.cmbFilaC.TabIndex = 20;
            this.cmbFilaC.SelectedIndexChanged += new System.EventHandler(this.CmbFilaC_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Asientos - Fila C:";
            // 
            // cmbFilaD
            // 
            this.cmbFilaD.FormattingEnabled = true;
            this.cmbFilaD.Location = new System.Drawing.Point(484, 313);
            this.cmbFilaD.Name = "cmbFilaD";
            this.cmbFilaD.Size = new System.Drawing.Size(121, 21);
            this.cmbFilaD.TabIndex = 22;
            this.cmbFilaD.SelectedIndexChanged += new System.EventHandler(this.CmbFilaD_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Asientos - Fila D:";
            // 
            // cmbFilaE
            // 
            this.cmbFilaE.FormattingEnabled = true;
            this.cmbFilaE.Location = new System.Drawing.Point(629, 313);
            this.cmbFilaE.Name = "cmbFilaE";
            this.cmbFilaE.Size = new System.Drawing.Size(121, 21);
            this.cmbFilaE.TabIndex = 24;
            this.cmbFilaE.SelectedIndexChanged += new System.EventHandler(this.CmbFilaE_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Asientos - Fila E:";
            // 
            // cmbFilaA
            // 
            this.cmbFilaA.FormattingEnabled = true;
            this.cmbFilaA.Location = new System.Drawing.Point(33, 313);
            this.cmbFilaA.Name = "cmbFilaA";
            this.cmbFilaA.Size = new System.Drawing.Size(121, 21);
            this.cmbFilaA.TabIndex = 25;
            this.cmbFilaA.SelectedIndexChanged += new System.EventHandler(this.CmbFilaA_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFilaA);
            this.Controls.Add(this.cmbFilaE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbFilaD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbFilaC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbFilaB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstAR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cine - Reservación de Asientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbFilaB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFilaC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFilaD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFilaE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbFilaA;
    }
}

