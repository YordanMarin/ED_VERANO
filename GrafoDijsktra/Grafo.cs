using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoDijsktra
{
    internal class Grafo
    {
        private int[,] matrizCosto;
        private int numVertices;

        public Grafo()
        {
            numVertices = 7;
            matrizCosto = new int[numVertices, numVertices];
        }

        public void insertar()
        {
            matrizCosto[0, 1] = 2;
            matrizCosto[0, 2] = 4;
            matrizCosto[0, 3] = 1;
            matrizCosto[1, 3] = 3;
            matrizCosto[1, 4] = 10;
            matrizCosto[2, 5] = 5;
            matrizCosto[3, 2] = 2;
            matrizCosto[3, 5] = 8;
            matrizCosto[3, 6] = 4;
            matrizCosto[4, 3] = 2;
            matrizCosto[4, 6] = 6;
            matrizCosto[6, 5] = 1;
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i = 0; i < numVertices; i++)
            {
                for(int j = 0; j < numVertices; j++)
                {
                    rich.Text += matrizCosto[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }

        public void Dijkstra(int origen, RichTextBox rich)
        {
            bool[] visitados = new bool[numVertices];
            int[] distancias = new int[numVertices];

            for(int i = 0;i < numVertices; i++)
            {
                visitados[i] = false;
                distancias[i] = int.MaxValue;
            }
            distancias[origen] = 0;

            for(int i = 0; i < numVertices-1; i++)
            {
                int min = distanciaMin(distancias, visitados);
                visitados[min] = true;
                for(int j = 0;j < numVertices; j++)
                {
                    if(!visitados[j] && matrizCosto[min,j] != 0 && distancias[min]!= int.MaxValue && distancias[min] + matrizCosto[min,j] < distancias[j])
                    {
                        distancias[j] = distancias[min]+matrizCosto[min, j];
                    }
                }
            }

            //imprimir las distancias
            rich.Text += "Origen \t Destino \t Distancia\n";
            for(int i = 0; i < numVertices; i++)
            {
                if (distancias[i] == int.MaxValue)
                    rich.Text += origen + "\t\t" + i + "\\ttNo hay ruta\n";
                else
                    rich.Text += origen + "\t\t" + i + "\t\t"+distancias[i]+"\n";
            }
        }

        public int distanciaMin(int[] distancias, bool[] visitados)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for(int i = 0; i< numVertices; i++)
            {
                if (!visitados[i] && distancias[i] <= min)
                {
                    min = distancias[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
