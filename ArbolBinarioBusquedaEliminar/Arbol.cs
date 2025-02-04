using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusquedaEliminar
{
    internal class Arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) //raiz
                return nuevo;
            if (num < actual.numero) // rama izquierda
                actual.izquierda = insertar(actual.izquierda, num);
            else if (num > actual.numero) //ramma derecha
                actual.derecha = insertar(actual.derecha, num);
            else
                MessageBox.Show("No se permiten duplicados");
            return actual;
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode padre)
        {
            if (actual == null) return;

            TreeNode cabe = new TreeNode(actual.numero.ToString()); //raiz

            if(padre == null) //tallos
                tree.Nodes.Add(cabe);
            else //hojas
                padre.Nodes.Add(cabe);

            if(actual.izquierda != null)
                mostrar(actual.izquierda, tree, cabe);
            if(actual.derecha != null)
                mostrar(actual.derecha, tree, cabe);
        }

        public Nodo eliminar(Nodo actual, int num)
        {
            if (actual == null)
                return null;

            if (num < actual.numero)
                actual.izquierda = eliminar(actual.izquierda, num);
            else if (num > actual.numero)
                actual.derecha = eliminar(actual.derecha, num);
            else
            {
                //caso 1: nodo sin hijos o con solo 1 hijo
                if(actual.izquierda == null)
                    return actual.derecha;
                else if(actual.derecha == null)
                    return actual.izquierda;

                //caso 2: nodo con 2 hijos
                actual.numero = minimo(actual.derecha);

                actual.derecha = eliminar(actual.derecha, actual.numero);
            }
            return actual;
        }

        public int minimo(Nodo actual)
        {
            while(actual.izquierda != null)
            {
                actual = actual.izquierda;
            }
            return actual.numero;
        }

        public int maximo(Nodo actual)
        {
            while (actual.derecha != null)
            {
                actual = actual.derecha;
            }
            return actual.numero;
        }
    }
}
