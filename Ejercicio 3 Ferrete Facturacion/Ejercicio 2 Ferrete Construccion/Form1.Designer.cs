namespace Ejercicio_2_Ferrete_Construccion
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
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(94, 13);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(90, 13);
            this.lblLargo.TabIndex = 0;
            this.lblLargo.Text = "Largo del terreno:";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(97, 29);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 1;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(94, 53);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(94, 13);
            this.lblAncho.TabIndex = 2;
            this.lblAncho.Text = "Ancho del terreno:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(97, 69);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 3;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(94, 92);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(91, 13);
            this.lblRadio.TabIndex = 4;
            this.lblRadio.Text = "Radio del terreno:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(97, 108);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 5;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(58, 154);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(172, 23);
            this.btnRectangulo.TabIndex = 6;
            this.btnRectangulo.Text = "A - Rectangulo de alambre";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(58, 183);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(172, 21);
            this.btnCirculo.TabIndex = 7;
            this.btnCirculo.Text = "B - Circulo de alambre";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.Location = new System.Drawing.Point(58, 210);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(172, 20);
            this.btnMateriales.TabIndex = 8;
            this.btnMateriales.Text = "C - Materiales contrapiso";
            this.btnMateriales.UseVisualStyleBackColor = true;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblLargo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnMateriales;
    }
}

