using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoble
{
    public partial class Form1 : Form
    {
        Lista l = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            l.insertar(int.Parse(textNumero.Text));
            listBoxNumeros.Items.Clear();
            l.mostrar(listBoxNumeros);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            l.buscar(int.Parse(textNumero.Text));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            l.modificar(int.Parse(textNumero.Text), int.Parse(textModificar.Text));
            listBoxNumeros.Items.Clear() ;
            l.mostrar(listBoxNumeros);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            l.eliminar(int.Parse(textNumero.Text));
            listBoxNumeros.Items.Clear();
            l.mostrar(listBoxNumeros);
        }
    }
}
