using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Form1 : Form
    {
        Arbol a = new Arbol();
        Nodo raiz;
        Nodo seleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textNumero.Text);

                if(num >=0 && num <= 20)
                {
                    raiz = a.insertar(null, int.Parse(textNumero.Text));
                    treeView1.Nodes.Clear();
                    a.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                }
                else
                {
                    MessageBox.Show("Solo se permiten números entre 0-20!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Solo se pérmiten números enteros!");
            }
        }

        private void btnRamas_Click(object sender, EventArgs e)
        {
            if(raiz != null)
            {
                if(int.TryParse(textNumero.Text, out int num) && num >=0 && num<=20)
                {
                    if (radioIzquierda.Checked == true || radioDerecha.Checked == true)
                    {
                        if(seleccionado != null)
                        {
                            if (radioIzquierda.Checked == true)
                            {
                                seleccionado.izquierda = a.insertar(seleccionado.izquierda, num);
                            }
                            if (radioDerecha.Checked == true)
                            {
                                seleccionado.derecha = a.insertar(seleccionado.derecha, num);
                            }

                            treeView1.Nodes.Clear();
                            a.mostrar(raiz, treeView1, null);
                            treeView1.ExpandAll();
                            textNumero.Clear();
                            radioIzquierda.Checked = false;
                            radioDerecha.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un nodo!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Seleccione izquierda o derecha!");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número entero entre 0-20!");
                }
            }
            else
            {
                MessageBox.Show("Primero inserte la raiz!");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionado = (Nodo)e.Node.Tag;
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Altura: "+a.altura(raiz));
        }
    }
}
