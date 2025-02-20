using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoPrim {
    public partial class Form1: Form {

        Grafo g = new Grafo();
        public Form1() {
            InitializeComponent();
        }

        private void btnMatriz_Click(object sender,EventArgs e) {
            richTextBox1.Clear();
            g.insertar();
            g.imprimirMatriz(richTextBox1);
        }

        private void btnPrim_Click(object sender,EventArgs e) {
            listBox1.Items.Clear();
            List<int[]> arbol = g.prim();

            foreach (var arista in arbol) {
                listBox1.Items.Add($"{arista[0]}, {arista[1]}");
            }
        }
    }
}
