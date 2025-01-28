using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    internal class Arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if(actual == null)
            {
                return nuevo;
            }else if((actual.izquierda != null || actual.derecha == null)&&(actual.izquierda == null || actual.derecha != null))
            {
                MessageBox.Show("Nodo ocupado");
            }else if (actual.izquierda == null)
            {
                actual.izquierda = nuevo;
            }
            else
            {
                actual.derecha = nuevo;
            }
            return actual;
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            TreeNode cabe = new TreeNode(actual.numero.ToString());
            cabe.Tag = actual;
            
            if(padre == null) //tallo
            {
                tree.Nodes.Add(cabe);
            }
            else //hojas
            {
                padre.Nodes.Add(cabe);
            }

            if(actual.izquierda != null)
                mostrar(actual.izquierda, tree, cabe);
            if (actual.derecha != null)
                mostrar(actual.derecha, tree, cabe);
        }

        public int altura(Nodo actual)
        {
            if(actual == null)
            {
                return 0;
            }
            else
            {
                int altIzquierda = altura(actual.izquierda);
                int altDerecha = altura (actual.derecha);

                return Math.Max(altDerecha, altIzquierda) + 1;
            }
        }
    }
}
