using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoMatrizAdyacencia
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
            g.imprimirMatriz(richTextBox1);
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            textAmplitud.Clear();
            g.BFS(textAmplitud);
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            textProfundidad.Clear();
            g.DFS(textProfundidad);
        }

        private void btnTopologico_Click(object sender, EventArgs e)
        {
            textTopologico.Clear();
            g.topologico(textTopologico);
        }
    }
}
