using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCircular
{
    internal class Lista
    {
        private Nodo primero;
        private Nodo ultimo;

        public Lista()
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
                primero.Siguiente = primero;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListBox list)
        {
            if(primero == null)
            {
                return;
            }
            Nodo actual = primero;

            do
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            } while (actual != primero);
        }

        public Nodo buscar(int num)
        {
            if (primero == null)
            {
                return null;
            }

            Nodo actual = primero;

            do
            {
                if(actual.Numero == num)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            } while (actual != primero);
            return null;
        }

        public void modificar(int num1, int num2)
        {
            Nodo modificar = buscar(num1);

            if (modificar != null)
                modificar.Numero = num2;
            else
                MessageBox.Show($"No se puede modificar. Porque {num1} No existe!");
        }

        public void eliminar(int num)
        {
            if (primero == null)
            {
                return;
            }
            Nodo actual = primero;
            Nodo anterior = null;
            bool encontrado = false;

            do
            {
                if(actual.Numero == num)
                {
                    if(actual == primero)
                    {
                        primero = primero.Siguiente;
                        if(primero == actual)
                        {
                            primero = null;
                        }
                        ultimo.Siguiente = primero;

                    }else if(actual == ultimo)
                    {
                        anterior.Siguiente = primero;
                        ultimo = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    encontrado = true;
                    break;
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != primero);

            if(encontrado == false)
                MessageBox.Show($"No se puede eliminar. Porque {num} No existe!");
        }
    }
}
