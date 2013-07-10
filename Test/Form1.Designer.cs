namespace Test
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
            this.valueButton1 = new ValueButtonLib.ValueButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueButton1
            // 
            this.valueButton1.ButtonValue = 5;
            this.valueButton1.Location = new System.Drawing.Point(150, 78);
            this.valueButton1.Name = "valueButton1";
            this.valueButton1.Size = new System.Drawing.Size(75, 23);
            this.valueButton1.TabIndex = 0;
            this.valueButton1.Text = "valueButton1";
            this.valueButton1.UseVisualStyleBackColor = true;
            this.valueButton1.Click += new System.EventHandler(this.valueButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ValueButtonLib.ValueButton valueButton1;
        private System.Windows.Forms.Label label1;
    }
}

