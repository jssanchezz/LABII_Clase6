namespace Ejercicio_3_Temperatura
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnFaC = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnCaF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(93, 66);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(104, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Ingrese temperatura:";
            // 
            // btnFaC
            // 
            this.btnFaC.Location = new System.Drawing.Point(60, 149);
            this.btnFaC.Name = "btnFaC";
            this.btnFaC.Size = new System.Drawing.Size(159, 23);
            this.btnFaC.TabIndex = 1;
            this.btnFaC.Text = "A - De farenheit a centìgrado";
            this.btnFaC.UseVisualStyleBackColor = true;
            this.btnFaC.Click += new System.EventHandler(this.btnFaC_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(97, 82);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // btnCaF
            // 
            this.btnCaF.Location = new System.Drawing.Point(60, 189);
            this.btnCaF.Name = "btnCaF";
            this.btnCaF.Size = new System.Drawing.Size(159, 23);
            this.btnCaF.TabIndex = 3;
            this.btnCaF.Text = "B - De centigrados a farenheit";
            this.btnCaF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCaF);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.btnFaC);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button btnFaC;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnCaF;
    }
}

