namespace GrafoFloyWarshall
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnFloy = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(76, 436);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(640, 249);
            this.richTextBox2.TabIndex = 69;
            this.richTextBox2.Text = "";
            // 
            // btnFloy
            // 
            this.btnFloy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloy.Location = new System.Drawing.Point(76, 383);
            this.btnFloy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFloy.Name = "btnFloy";
            this.btnFloy.Size = new System.Drawing.Size(640, 48);
            this.btnFloy.TabIndex = 68;
            this.btnFloy.Text = "FLOYD - WARSHALL";
            this.btnFloy.UseVisualStyleBackColor = true;
            this.btnFloy.Click += new System.EventHandler(this.btnFloy_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(76, 70);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(640, 48);
            this.btnMatriz.TabIndex = 67;
            this.btnMatriz.Text = "MATRIZ DE COSTO";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(76, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(640, 238);
            this.richTextBox1.TabIndex = 66;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 46);
            this.label1.TabIndex = 65;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 759);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnFloy);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnFloy;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

