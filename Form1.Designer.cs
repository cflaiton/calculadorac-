namespace Calculadora
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Button();
            this.lblResta = new System.Windows.Forms.Button();
            this.lblMultiplicacion = new System.Windows.Forms.Button();
            this.lblDivision = new System.Windows.Forms.Button();
            this.lblfactorial = new System.Windows.Forms.Button();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(110, 39);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(52, 20);
            this.txtn1.TabIndex = 0;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(209, 39);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(55, 20);
            this.txtn2.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(174, 93);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(144, 81);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.Location = new System.Drawing.Point(52, 89);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(75, 23);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "Suma";
            this.lblSuma.UseVisualStyleBackColor = true;
            this.lblSuma.Click += new System.EventHandler(this.lblSuma_Click);
            // 
            // lblResta
            // 
            this.lblResta.Location = new System.Drawing.Point(52, 118);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(75, 23);
            this.lblResta.TabIndex = 2;
            this.lblResta.Text = "Resta";
            this.lblResta.UseVisualStyleBackColor = true;
            this.lblResta.Click += new System.EventHandler(this.lblResta_Click);
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.Location = new System.Drawing.Point(52, 147);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(75, 23);
            this.lblMultiplicacion.TabIndex = 2;
            this.lblMultiplicacion.Text = "Multiplicacion";
            this.lblMultiplicacion.UseVisualStyleBackColor = true;
            this.lblMultiplicacion.Click += new System.EventHandler(this.lblMultiplicacion_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.Location = new System.Drawing.Point(52, 176);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(75, 23);
            this.lblDivision.TabIndex = 2;
            this.lblDivision.Text = "Division";
            this.lblDivision.UseVisualStyleBackColor = true;
            this.lblDivision.Click += new System.EventHandler(this.lblDivision_Click);
            // 
            // lblfactorial
            // 
            this.lblfactorial.Location = new System.Drawing.Point(175, 211);
            this.lblfactorial.Name = "lblfactorial";
            this.lblfactorial.Size = new System.Drawing.Size(75, 23);
            this.lblfactorial.TabIndex = 3;
            this.lblfactorial.Text = "Factorial";
            this.lblfactorial.UseVisualStyleBackColor = true;
            this.lblfactorial.Click += new System.EventHandler(this.lblfactorial_Click);
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(107, 212);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(55, 20);
            this.txtn3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 258);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.lblfactorial);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button lblSuma;
        private System.Windows.Forms.Button lblResta;
        private System.Windows.Forms.Button lblMultiplicacion;
        private System.Windows.Forms.Button lblDivision;
        private System.Windows.Forms.Button lblfactorial;
        private System.Windows.Forms.TextBox txtn3;
    }
}

