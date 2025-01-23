using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola
{
    public partial class Form1 : Form
    {
        Cola c = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            
            if (c.validarTexto(textNonbre.Text) == true)
            {
                c.Enqueue(textNonbre.Text.Trim());
                listBoxNombres.Items.Clear();
                c.mostrar(listBoxNombres);
            }
            else
            {
                MessageBox.Show("Solo permite texto!");
            }


            //c.Enqueue(textNonbre.Text);
            //listBoxNombres.Items.Clear();
            //c.mostrar(listBoxNombres);
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (c.Dequeue() != null)
            {
                MessageBox.Show("Desapilado correctamente");
                listBoxNombres.Items.Clear();
                c.mostrar(listBoxNombres);
            }
            else
            {
                MessageBox.Show("Cola esta vacía!");
            }
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string prim = c.Peek();
            if (prim != null)
            {
                MessageBox.Show("Primero: "+prim);
            }
            else
            {
                MessageBox.Show("Cola esta vacía!");
            }
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("#Elementos: " + c.Count());
        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
            c.Clear();
            listBoxNombres.Items.Clear();
        }
    }
}
