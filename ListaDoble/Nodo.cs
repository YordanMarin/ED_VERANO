using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoble
{
    internal class Nodo
    {
        private int numero;
        private Nodo atras;
        private Nodo siguiente;

        public int Numero { get => numero; set => numero = value; }
        internal Nodo Atras { get => atras; set => atras = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
