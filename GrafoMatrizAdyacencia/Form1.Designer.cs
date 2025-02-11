namespace GrafoMatrizAdyacencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textAmplitud = new System.Windows.Forms.TextBox();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.textProfundidad = new System.Windows.Forms.TextBox();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.textTopologico = new System.Windows.Forms.TextBox();
            this.btnTopologico = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 46);
            this.label1.TabIndex = 42;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(74, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(640, 299);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // textAmplitud
            // 
            this.textAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmplitud.Location = new System.Drawing.Point(296, 471);
            this.textAmplitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAmplitud.Name = "textAmplitud";
            this.textAmplitud.Size = new System.Drawing.Size(418, 30);
            this.textAmplitud.TabIndex = 54;
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmplitud.Location = new System.Drawing.Point(72, 462);
            this.btnAmplitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(195, 48);
            this.btnAmplitud.TabIndex = 53;
            this.btnAmplitud.Text = "Amplitud - BFS";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // textProfundidad
            // 
            this.textProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfundidad.Location = new System.Drawing.Point(296, 522);
            this.textProfundidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textProfundidad.Name = "textProfundidad";
            this.textProfundidad.Size = new System.Drawing.Size(418, 30);
            this.textProfundidad.TabIndex = 56;
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidad.Location = new System.Drawing.Point(72, 515);
            this.btnProfundidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(195, 48);
            this.btnProfundidad.TabIndex = 55;
            this.btnProfundidad.Text = "Profundidad - DFS";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // textTopologico
            // 
            this.textTopologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTopologico.Location = new System.Drawing.Point(296, 579);
            this.textTopologico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTopologico.Name = "textTopologico";
            this.textTopologico.Size = new System.Drawing.Size(418, 30);
            this.textTopologico.TabIndex = 58;
            // 
            // btnTopologico
            // 
            this.btnTopologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopologico.Location = new System.Drawing.Point(72, 570);
            this.btnTopologico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTopologico.Name = "btnTopologico";
            this.btnTopologico.Size = new System.Drawing.Size(195, 48);
            this.btnTopologico.TabIndex = 57;
            this.btnTopologico.Text = "Topologico";
            this.btnTopologico.UseVisualStyleBackColor = true;
            this.btnTopologico.Click += new System.EventHandler(this.btnTopologico_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(74, 80);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(640, 48);
            this.btnMatriz.TabIndex = 59;
            this.btnMatriz.Text = "MATRIZ DE ADYACENCIA";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 646);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.textTopologico);
            this.Controls.Add(this.btnTopologico);
            this.Controls.Add(this.textProfundidad);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.textAmplitud);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textAmplitud;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.TextBox textProfundidad;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.TextBox textTopologico;
        private System.Windows.Forms.Button btnTopologico;
        private System.Windows.Forms.Button btnMatriz;
    }
}

