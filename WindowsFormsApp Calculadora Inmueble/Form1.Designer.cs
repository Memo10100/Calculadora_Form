namespace WindowsFormsApp_Calculadora_Inmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDI = new System.Windows.Forms.TextBox();
            this.textBoxM2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUsado = new System.Windows.Forms.RadioButton();
            this.radioButtonNuevo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonLC = new System.Windows.Forms.RadioButton();
            this.radioButtonPiso = new System.Windows.Forms.RadioButton();
            this.textBoxNumeroDeVentanas = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDePisos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrecioTazado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese La Direccion Del Inmueble";
            // 
            // textBoxDI
            // 
            this.textBoxDI.Location = new System.Drawing.Point(26, 99);
            this.textBoxDI.Name = "textBoxDI";
            this.textBoxDI.Size = new System.Drawing.Size(206, 20);
            this.textBoxDI.TabIndex = 3;
            // 
            // textBoxM2
            // 
            this.textBoxM2.Location = new System.Drawing.Point(26, 138);
            this.textBoxM2.Name = "textBoxM2";
            this.textBoxM2.Size = new System.Drawing.Size(206, 20);
            this.textBoxM2.TabIndex = 5;
            this.textBoxM2.Text = "0";
            this.textBoxM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUsado);
            this.groupBox1.Controls.Add(this.radioButtonNuevo);
            this.groupBox1.Location = new System.Drawing.Point(26, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 46);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Del Inmueble";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonUsado
            // 
            this.radioButtonUsado.AutoSize = true;
            this.radioButtonUsado.Location = new System.Drawing.Point(134, 19);
            this.radioButtonUsado.Name = "radioButtonUsado";
            this.radioButtonUsado.Size = new System.Drawing.Size(56, 17);
            this.radioButtonUsado.TabIndex = 1;
            this.radioButtonUsado.TabStop = true;
            this.radioButtonUsado.Text = "Usado";
            this.radioButtonUsado.UseVisualStyleBackColor = true;
            this.radioButtonUsado.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonNuevo
            // 
            this.radioButtonNuevo.AutoSize = true;
            this.radioButtonNuevo.Checked = true;
            this.radioButtonNuevo.Location = new System.Drawing.Point(13, 19);
            this.radioButtonNuevo.Name = "radioButtonNuevo";
            this.radioButtonNuevo.Size = new System.Drawing.Size(108, 17);
            this.radioButtonNuevo.TabIndex = 0;
            this.radioButtonNuevo.TabStop = true;
            this.radioButtonNuevo.Text = "Nuevo (-15 Años)";
            this.radioButtonNuevo.UseVisualStyleBackColor = true;
            this.radioButtonNuevo.CheckedChanged += new System.EventHandler(this.radioButtonNuevo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonLC);
            this.groupBox2.Controls.Add(this.radioButtonPiso);
            this.groupBox2.Location = new System.Drawing.Point(26, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo De Inmueble A Calcular";
            // 
            // radioButtonLC
            // 
            this.radioButtonLC.AutoSize = true;
            this.radioButtonLC.Location = new System.Drawing.Point(100, 19);
            this.radioButtonLC.Name = "radioButtonLC";
            this.radioButtonLC.Size = new System.Drawing.Size(100, 17);
            this.radioButtonLC.TabIndex = 1;
            this.radioButtonLC.Text = "Local Comercial";
            this.radioButtonLC.UseVisualStyleBackColor = true;
            this.radioButtonLC.CheckedChanged += new System.EventHandler(this.radioButtonLC_CheckedChanged);
            // 
            // radioButtonPiso
            // 
            this.radioButtonPiso.AutoSize = true;
            this.radioButtonPiso.Checked = true;
            this.radioButtonPiso.Location = new System.Drawing.Point(16, 19);
            this.radioButtonPiso.Name = "radioButtonPiso";
            this.radioButtonPiso.Size = new System.Drawing.Size(45, 17);
            this.radioButtonPiso.TabIndex = 0;
            this.radioButtonPiso.TabStop = true;
            this.radioButtonPiso.Text = "Piso";
            this.radioButtonPiso.UseVisualStyleBackColor = true;
            this.radioButtonPiso.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBoxNumeroDeVentanas
            // 
            this.textBoxNumeroDeVentanas.Enabled = false;
            this.textBoxNumeroDeVentanas.Location = new System.Drawing.Point(26, 251);
            this.textBoxNumeroDeVentanas.Name = "textBoxNumeroDeVentanas";
            this.textBoxNumeroDeVentanas.Size = new System.Drawing.Size(206, 20);
            this.textBoxNumeroDeVentanas.TabIndex = 9;
            this.textBoxNumeroDeVentanas.Text = "0";
            this.textBoxNumeroDeVentanas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumeroDeVentanas.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxNumeroDePisos
            // 
            this.textBoxNumeroDePisos.Location = new System.Drawing.Point(26, 300);
            this.textBoxNumeroDePisos.Name = "textBoxNumeroDePisos";
            this.textBoxNumeroDePisos.Size = new System.Drawing.Size(206, 20);
            this.textBoxNumeroDePisos.TabIndex = 11;
            this.textBoxNumeroDePisos.Text = "0";
            this.textBoxNumeroDePisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese m2 Del Inmueble";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese El Numero De Ventanas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingrese El Numero De Pisos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio Base";
            // 
            // textBoxPrecioBase
            // 
            this.textBoxPrecioBase.Location = new System.Drawing.Point(26, 353);
            this.textBoxPrecioBase.Name = "textBoxPrecioBase";
            this.textBoxPrecioBase.Size = new System.Drawing.Size(206, 20);
            this.textBoxPrecioBase.TabIndex = 16;
            this.textBoxPrecioBase.Text = "0";
            this.textBoxPrecioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Inmueble Tazado En:";
            // 
            // textBoxPrecioTazado
            // 
            this.textBoxPrecioTazado.Location = new System.Drawing.Point(132, 454);
            this.textBoxPrecioTazado.Name = "textBoxPrecioTazado";
            this.textBoxPrecioTazado.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioTazado.TabIndex = 21;
            this.textBoxPrecioTazado.Text = "$0";
            this.textBoxPrecioTazado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPrecioTazado.TextChanged += new System.EventHandler(this.textBoxPrecioTazado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(266, 487);
            this.Controls.Add(this.textBoxPrecioTazado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrecioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumeroDePisos);
            this.Controls.Add(this.textBoxNumeroDeVentanas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxM2);
            this.Controls.Add(this.textBoxDI);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDI;
        private System.Windows.Forms.TextBox textBoxM2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUsado;
        private System.Windows.Forms.RadioButton radioButtonNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonLC;
        private System.Windows.Forms.RadioButton radioButtonPiso;
        private System.Windows.Forms.TextBox textBoxNumeroDeVentanas;
        private System.Windows.Forms.TextBox textBoxNumeroDePisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrecioBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrecioTazado;
    }
}

