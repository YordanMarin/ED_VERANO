using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoble
{
    internal class Lista
    {
        //atributos
        private Nodo primero;
        private Nodo ultimo;

        public Lista() //constructor
        {
            primero = null;
            ultimo = null;
        }

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if(primero == null)
            {
                primero = nuevo;
                primero.Atras = null;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
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

        public Nodo buscar(int num)
        {
            Nodo actual = primero;

            while(actual != null)
            {
                if(actual.Numero == num)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void modificar(int valorActual, int valorModificar)
        {
            Nodo modificar = buscar(valorActual);

            if (modificar != null)
            {
                modificar.Numero = valorModificar;
            }
            else
                MessageBox.Show("Número no existe! No se puede modificar!");
        }

        public void eliminar(int num)
        {
            Nodo eliminar = buscar(num);

            if(eliminar==primero)
            {
                primero = eliminar.Siguiente;
                if(primero != null)
                    primero.Atras = null;
            }else if(eliminar == ultimo){
                ultimo = eliminar.Atras;
                if(ultimo != null)
                    ultimo.Siguiente = null;
            }
            else
            {
                eliminar.Atras.Siguiente = eliminar.Siguiente;
                eliminar.Siguiente.Atras = eliminar.Atras;
            }

        }
    }
}
