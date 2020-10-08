namespace LAB
{
    partial class FormPiso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirrecion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdifcio = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdadMueble = new System.Windows.Forms.TextBox();
            this.CargaDatosPiso = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la dirrecion del edificio: ";
            // 
            // txtDirrecion
            // 
            this.txtDirrecion.Location = new System.Drawing.Point(36, 35);
            this.txtDirrecion.Name = "txtDirrecion";
            this.txtDirrecion.Size = new System.Drawing.Size(185, 20);
            this.txtDirrecion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el edificio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el piso: ";
            // 
            // txtEdifcio
            // 
            this.txtEdifcio.Location = new System.Drawing.Point(36, 74);
            this.txtEdifcio.Name = "txtEdifcio";
            this.txtEdifcio.Size = new System.Drawing.Size(185, 20);
            this.txtEdifcio.TabIndex = 4;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(36, 113);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(78, 20);
            this.txtPiso.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese el valor del mueble: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(36, 164);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(133, 20);
            this.txtValor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese la edad del mueble: ";
            // 
            // txtEdadMueble
            // 
            this.txtEdadMueble.Location = new System.Drawing.Point(36, 203);
            this.txtEdadMueble.Name = "txtEdadMueble";
            this.txtEdadMueble.Size = new System.Drawing.Size(133, 20);
            this.txtEdadMueble.TabIndex = 9;
            // 
            // CargaDatosPiso
            // 
            this.CargaDatosPiso.Location = new System.Drawing.Point(259, 164);
            this.CargaDatosPiso.Name = "CargaDatosPiso";
            this.CargaDatosPiso.Size = new System.Drawing.Size(171, 59);
            this.CargaDatosPiso.TabIndex = 10;
            this.CargaDatosPiso.Text = "MOSTRAR DATOS";
            this.CargaDatosPiso.UseVisualStyleBackColor = true;
            this.CargaDatosPiso.Click += new System.EventHandler(this.CargaDatosPiso_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Si desea ver el descuento precione el boton";
            // 
            // FormPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CargaDatosPiso);
            this.Controls.Add(this.txtEdadMueble);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtEdifcio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirrecion);
            this.Controls.Add(this.label1);
            this.Name = "FormPiso";
            this.Text = "Menu de PISO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirrecion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdifcio;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdadMueble;
        private System.Windows.Forms.Button CargaDatosPiso;
        private System.Windows.Forms.Label label6;
    }
}