namespace ejercicio_1_parcial_2_tinoco
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
            this.txtcurp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcurp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbevaluacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcurp
            // 
            this.txtcurp.Location = new System.Drawing.Point(143, 37);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(185, 22);
            this.txtcurp.TabIndex = 0;
            this.txtcurp.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribir su curp";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbcurp
            // 
            this.lbcurp.AutoSize = true;
            this.lbcurp.Location = new System.Drawing.Point(69, 117);
            this.lbcurp.Name = "lbcurp";
            this.lbcurp.Size = new System.Drawing.Size(47, 17);
            this.lbcurp.TabIndex = 2;
            this.lbcurp.Text = "lbcurp";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "evaluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbevaluacion
            // 
            this.lbevaluacion.AutoSize = true;
            this.lbevaluacion.Location = new System.Drawing.Point(250, 117);
            this.lbevaluacion.Name = "lbevaluacion";
            this.lbevaluacion.Size = new System.Drawing.Size(46, 17);
            this.lbevaluacion.TabIndex = 5;
            this.lbevaluacion.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 225);
            this.Controls.Add(this.lbevaluacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbcurp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcurp);
            this.Name = "Form1";
            this.Text = "w";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcurp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcurp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbevaluacion;
    }
}

