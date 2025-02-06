using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABBCompleto
{
    internal class Arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null)
                return nuevo;
            if (num < actual.numero)
                actual.izquierda = insertar(actual.izquierda, num);
            else if (num > actual.numero)
                actual.derecha = insertar(actual.derecha, num);
            else
                MessageBox.Show("No duplicados!");
            return actual;
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            if(actual != null)
            {
                TreeNode cabe = new TreeNode(actual.numero.ToString());

                if(padre == null)
                    tree.Nodes.Add(cabe);
                else
                    padre.Nodes.Add(cabe);

                if(actual.izquierda != null)
                    mostrar(actual.izquierda, tree, cabe);
                if(actual.derecha != null)
                    mostrar(actual.derecha, tree, cabe);
            }
        }

        public int buscar(Nodo actual, int num)
        {
            int nivel = 0;
            while(actual != null)
            {
                if (num == actual.numero)
                    return nivel;
                else if (num < actual.numero)
                    actual = actual.izquierda;
                else
                    actual = actual.derecha;
                nivel++;
            }
            return -1;
        }

        public void pre(Nodo actual, TextBox text)
        {
            if(actual != null)
            {
                text.Text += actual.numero + " ";
                pre(actual.izquierda, text);
                pre(actual.derecha, text);
            }
        }

        public void ino(Nodo actual, TextBox text)
        {
            if (actual != null)
            {
                ino(actual.izquierda, text);
                text.Text += actual.numero + " ";
                ino(actual.derecha, text);
            }
        }

        public void pos(Nodo actual, TextBox text)
        {
            if (actual != null)
            {
                pos(actual.izquierda, text);
                pos(actual.derecha, text);
                text.Text += actual.numero + " ";
            }
        }
    }
}
