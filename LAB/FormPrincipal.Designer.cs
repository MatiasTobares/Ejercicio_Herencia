namespace LAB
{
    partial class FormPrincipal
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
            this.bnPiso = new System.Windows.Forms.Button();
            this.bnLocal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnPiso
            // 
            this.bnPiso.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnPiso.Location = new System.Drawing.Point(70, 124);
            this.bnPiso.Name = "bnPiso";
            this.bnPiso.Size = new System.Drawing.Size(162, 126);
            this.bnPiso.TabIndex = 1;
            this.bnPiso.Text = "PISO";
            this.bnPiso.UseVisualStyleBackColor = false;
            this.bnPiso.Click += new System.EventHandler(this.bnPiso_Click);
            // 
            // bnLocal
            // 
            this.bnLocal.BackColor = System.Drawing.SystemColors.Highlight;
            this.bnLocal.Location = new System.Drawing.Point(249, 124);
            this.bnLocal.Name = "bnLocal";
            this.bnLocal.Size = new System.Drawing.Size(162, 126);
            this.bnLocal.TabIndex = 2;
            this.bnLocal.Text = "LOCAL";
            this.bnLocal.UseVisualStyleBackColor = false;
            this.bnLocal.Click += new System.EventHandler(this.bnLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELGIA UNA DE LAS OPCIONES";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnLocal);
            this.Controls.Add(this.bnPiso);
            this.Name = "FormPrincipal";
            this.Text = "INMOBILIARIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bnPiso;
        private System.Windows.Forms.Button bnLocal;
        private System.Windows.Forms.Label label1;

    }
}

