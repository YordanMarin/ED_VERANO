using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda
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
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (raiz == null)
                    raiz = a.insertar(null, num);
                else
                    a.insertar(raiz, num);

                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
            }
            else
                MessageBox.Show("Ingrese un número entero válido!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (a.buscar(raiz, num) != null)
                    MessageBox.Show($"El número {num} existe");
                else
                    MessageBox.Show($"El número {num} no existe");
            }
            else
                MessageBox.Show("Ingrese un número entero válido!");
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            if (raiz != null)
            {
                textPre.Clear();
                textIn.Clear();
                textPost.Clear();

                a.pre(raiz, textPre);
                a.ino(raiz, textIn);
                a.pos(raiz, textPost);
            }
            else
                MessageBox.Show("Árbol vácio!");
        }
    }
}
