﻿namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Convertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dolares = new System.Windows.Forms.TextBox();
            this.Cambio = new System.Windows.Forms.TextBox();
            this.Pesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(322, 155);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(100, 39);
            this.Convertir.TabIndex = 0;
            this.Convertir.Text = "Convertir";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "tipo de cambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "dolares";
            // 
            // Dolares
            // 
            this.Dolares.BackColor = System.Drawing.Color.White;
            this.Dolares.Location = new System.Drawing.Point(44, 125);
            this.Dolares.Name = "Dolares";
            this.Dolares.Size = new System.Drawing.Size(140, 20);
            this.Dolares.TabIndex = 4;
            this.Dolares.TextChanged += new System.EventHandler(this.Dolares_TextChanged);
            // 
            // Cambio
            // 
            this.Cambio.Location = new System.Drawing.Point(322, 63);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(100, 20);
            this.Cambio.TabIndex = 5;
            this.Cambio.TextChanged += new System.EventHandler(this.Cambio_TextChanged);
            // 
            // Pesos
            // 
            this.Pesos.Location = new System.Drawing.Point(44, 66);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(140, 20);
            this.Pesos.TabIndex = 6;
            this.Pesos.TextChanged += new System.EventHandler(this.Pesos_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 262);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.Cambio);
            this.Controls.Add(this.Dolares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Dolares;
        public System.Windows.Forms.TextBox Cambio;
        public System.Windows.Forms.TextBox Pesos;
    }
}

