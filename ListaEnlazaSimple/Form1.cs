using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazaSimple
{
    public partial class Form1 : Form
    {
        Lista miLista = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
            miLista.insertar(int.Parse(textNumero.Text));
            miLista.mostrar(listBoxNumeros);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miLista.eliminar(int.Parse(textNumero.Text));
            listBoxNumeros.Items.Clear();
            miLista.mostrar(listBoxNumeros);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textNumero.Text);

            if (miLista.buscar(num) == false)
            {
                MessageBox.Show($"El número {num} no existe");
            }
            else
            {
                MessageBox.Show($"El número {num} si existe");
            }

        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            miLista.ascendente();
            listBoxNumeros.Items.Clear();
            miLista.mostrar(listBoxNumeros);
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            miLista.descendente();
            listBoxNumeros.Items.Clear();
            miLista.mostrar(listBoxNumeros);
        }
    }
}
