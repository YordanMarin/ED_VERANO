using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABBCompleto
{
    public partial class Form1 : Form
    {
        Arbol a = new Arbol();
        Nodo raiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textNumero.Text, out int num)){
                if (raiz == null)
                    raiz = a.insertar(null, num);
                else
                    a.insertar(raiz, num);
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
            }else
            {
                MessageBox.Show("Ingrese valor un valor correcto!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                int nivel = a.buscar(raiz, num);

                if(nivel != -1)
                    MessageBox.Show($"El número {num} esta en el nivel {nivel + 1}");
                else
                    MessageBox.Show($"El número {num} no existe");
            }else
                MessageBox.Show("Ingrese valor un valor correcto!");


        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            textPre.Clear();
            textPost.Clear();
            textIn.Clear();

            a.pre(raiz, textPre);
            a.ino(raiz, textIn);
            a.pos(raiz, textPost);
        }
    }
}
