﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusquedaEliminar
{
    public partial class Form1 : Form
    {
        Arbol a = new Arbol();
        Nodo raiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           if(int.TryParse(textNumero.Text, out int num))
            {
                if (raiz == null)
                    raiz = a.insertar(null, num);
                else
                    a.insertar(raiz, num);
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un número entero válido!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                raiz = a.eliminar(raiz, num);
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
            }
            else
            {
                MessageBox.Show("Ingrese un número entero válido!");
            }
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Mínimo: " + a.minimo(raiz));
            else
                MessageBox.Show("Árbol vácio!");
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Máximo: " + a.maximo(raiz));
            else
                MessageBox.Show("Árbol vácio!");
        }
    }
}
