namespace ArbolBinario
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
            this.btnraiz = new System.Windows.Forms.Button();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRamas = new System.Windows.Forms.Button();
            this.radioIzquierda = new System.Windows.Forms.RadioButton();
            this.radioDerecha = new System.Windows.Forms.RadioButton();
            this.btnAltura = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.Location = new System.Drawing.Point(64, 169);
            this.btnraiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(162, 48);
            this.btnraiz.TabIndex = 16;
            this.btnraiz.Text = "Insertar raiz";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(247, 123);
            this.textNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(252, 30);
            this.textNumero.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "ARBOL BINARIO";
            // 
            // btnRamas
            // 
            this.btnRamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRamas.Location = new System.Drawing.Point(64, 234);
            this.btnRamas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRamas.Name = "btnRamas";
            this.btnRamas.Size = new System.Drawing.Size(162, 48);
            this.btnRamas.TabIndex = 17;
            this.btnRamas.Text = "Insertar ramas";
            this.btnRamas.UseVisualStyleBackColor = true;
            this.btnRamas.Click += new System.EventHandler(this.btnRamas_Click);
            // 
            // radioIzquierda
            // 
            this.radioIzquierda.AutoSize = true;
            this.radioIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIzquierda.Location = new System.Drawing.Point(113, 312);
            this.radioIzquierda.Name = "radioIzquierda";
            this.radioIzquierda.Size = new System.Drawing.Size(98, 24);
            this.radioIzquierda.TabIndex = 18;
            this.radioIzquierda.TabStop = true;
            this.radioIzquierda.Text = "Izquierda";
            this.radioIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioDerecha
            // 
            this.radioDerecha.AutoSize = true;
            this.radioDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDerecha.Location = new System.Drawing.Point(113, 353);
            this.radioDerecha.Name = "radioDerecha";
            this.radioDerecha.Size = new System.Drawing.Size(94, 24);
            this.radioDerecha.TabIndex = 20;
            this.radioDerecha.TabStop = true;
            this.radioDerecha.Text = "Derecha";
            this.radioDerecha.UseVisualStyleBackColor = true;
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(85, 409);
            this.btnAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(141, 48);
            this.btnAltura.TabIndex = 21;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(247, 169);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(252, 318);
            this.treeView1.TabIndex = 22;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 578);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.radioDerecha);
            this.Controls.Add(this.radioIzquierda);
            this.Controls.Add(this.btnRamas);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRamas;
        private System.Windows.Forms.RadioButton radioIzquierda;
        private System.Windows.Forms.RadioButton radioDerecha;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.TreeView treeView1;
    }
}

