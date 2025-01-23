namespace Cola
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
            this.btnDestruir = new System.Windows.Forms.Button();
            this.btnElementos = new System.Windows.Forms.Button();
            this.btnVistazo = new System.Windows.Forms.Button();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.textNonbre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDestruir
            // 
            this.btnDestruir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestruir.Location = new System.Drawing.Point(73, 332);
            this.btnDestruir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(106, 39);
            this.btnDestruir.TabIndex = 17;
            this.btnDestruir.Text = "Destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            this.btnDestruir.Click += new System.EventHandler(this.btnDestruir_Click);
            // 
            // btnElementos
            // 
            this.btnElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElementos.Location = new System.Drawing.Point(73, 280);
            this.btnElementos.Margin = new System.Windows.Forms.Padding(2);
            this.btnElementos.Name = "btnElementos";
            this.btnElementos.Size = new System.Drawing.Size(106, 39);
            this.btnElementos.TabIndex = 16;
            this.btnElementos.Text = "# Elementos";
            this.btnElementos.UseVisualStyleBackColor = true;
            this.btnElementos.Click += new System.EventHandler(this.btnElementos_Click);
            // 
            // btnVistazo
            // 
            this.btnVistazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistazo.Location = new System.Drawing.Point(73, 231);
            this.btnVistazo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVistazo.Name = "btnVistazo";
            this.btnVistazo.Size = new System.Drawing.Size(106, 39);
            this.btnVistazo.TabIndex = 15;
            this.btnVistazo.Text = "Vistazo";
            this.btnVistazo.UseVisualStyleBackColor = true;
            this.btnVistazo.Click += new System.EventHandler(this.btnVistazo_Click);
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.ItemHeight = 20;
            this.listBoxNombres.Location = new System.Drawing.Point(194, 129);
            this.listBoxNombres.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(190, 264);
            this.listBoxNombres.TabIndex = 14;
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencolar.Location = new System.Drawing.Point(73, 181);
            this.btnDesencolar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(106, 39);
            this.btnDesencolar.TabIndex = 13;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncolar.Location = new System.Drawing.Point(73, 129);
            this.btnEncolar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(106, 39);
            this.btnEncolar.TabIndex = 12;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // textNonbre
            // 
            this.textNonbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNonbre.Location = new System.Drawing.Point(194, 92);
            this.textNonbre.Margin = new System.Windows.Forms.Padding(2);
            this.textNonbre.Name = "textNonbre";
            this.textNonbre.Size = new System.Drawing.Size(190, 26);
            this.textNonbre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "COLAS (QUEUE)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.btnElementos);
            this.Controls.Add(this.btnVistazo);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.textNonbre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDestruir;
        private System.Windows.Forms.Button btnElementos;
        private System.Windows.Forms.Button btnVistazo;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.TextBox textNonbre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

