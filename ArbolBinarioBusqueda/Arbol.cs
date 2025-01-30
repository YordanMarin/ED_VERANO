using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda
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
                MessageBox.Show("No se puede insertar nodos iguales");

            return actual;
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            TreeNode cabe = new TreeNode(actual.numero.ToString()); // raiz

            if(padre == null) // tallos
                tree.Nodes.Add(cabe);
            else // hojas
                padre.Nodes.Add(cabe);

            if(actual.izquierda != null)
                mostrar(actual.izquierda, tree, cabe);
            if(actual.derecha != null)
                mostrar(actual.derecha, tree, cabe);
        }

        public Nodo buscar(Nodo actual, int num)
        {
            while(actual != null)
            {
                if (actual.numero == num)
                    return actual;
                else if(num < actual.numero)
                    actual = actual.izquierda;
                else
                    actual = actual.derecha;
            }
            return null;
        }

        public void pre(Nodo actual, TextBox text)
        {
            if (actual == null)
                return;

            text.Text += actual.numero + " "; //raiz
            pre(actual.izquierda, text); //izquierda
            pre(actual.derecha, text); //derecha
        }

        public void ino(Nodo actual, TextBox text)
        {
            if (actual == null)
                return;

            ino(actual.izquierda, text); //izquierda
            text.Text += actual.numero + " "; //raiz
            ino(actual.derecha, text); //derecha
        }

        public void pos(Nodo actual, TextBox text)
        {
            if (actual == null)
                return;

            pos(actual.izquierda, text); //izquierda
            pos(actual.derecha, text); //derecha
            text.Text += actual.numero + " "; //raiz
            
        }
    }
}
