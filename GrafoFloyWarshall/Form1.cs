using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoFloyWarshall
{
    public partial class Form1 : Form
    {
        Grafo g = new Grafo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.insertar();
            g.imprimirMatrizCosto(richTextBox1);
        }

        private void btnFloy_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            g.insertar();
            g.imprimirFloydWarshall(richTextBox2);
        }
    }
}
