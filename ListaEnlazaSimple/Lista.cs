using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazaSimple
{
    internal class Lista
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if(primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while(actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }

        public void eliminar(int num)
        {
            Nodo actual = primero;
            Nodo anterior = null;
            bool encontrado = false;

            while(actual != null)
            {
                if(actual.Numero == num)
                {
                    if(actual == primero)
                    {
                        primero = primero.Siguiente;
                    }else if(actual == ultimo)
                    {
                        anterior.Siguiente = null;
                        ultimo = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    encontrado = true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            if (encontrado == false)
                MessageBox.Show($"El número {num} no esta en la lista");
        }
    }
}
