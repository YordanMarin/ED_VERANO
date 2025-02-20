using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoPrim {
    internal class Grafo {
        private int[,] matrizCosto;
        private int numVertices;

        public Grafo() {
            numVertices=5;
            matrizCosto=new int[numVertices,numVertices];
        }

        public void insertar() {
            matrizCosto[0,1] = 5;
            matrizCosto[0,2]= 3;
            matrizCosto[1,3]= 8;
            matrizCosto[3,4]= 2;
            matrizCosto[2,4]= 4;
            matrizCosto[1,4]= 10;
        }

        public void imprimirMatriz(RichTextBox rich) {
            for(int i = 0;i<numVertices;i++) {
                for(int j = 0;j<numVertices;j++) {
                    rich.Text+=matrizCosto[i,j]+"\t";
                }
                rich.Text += "\n";
            }
        }

        public List<int[]> prim() {
            List<int[]> arbol = new List<int[]>();
            HashSet<int> visitados = new HashSet<int>();

            int inicial = 0;

            visitados.Add(inicial);

            while (visitados.Count<numVertices) {
                int[] aristaMinima = null;
                int costoMinimo = int.MaxValue;

                foreach (int verticeEnArbol in visitados) {
                    for (int i = 0;i<numVertices;i++) {
                        if (!visitados.Contains(i)&&matrizCosto[verticeEnArbol,i]!=0) {
                            int costoArista = matrizCosto[verticeEnArbol,i];
                            if (costoArista<costoMinimo) {
                                aristaMinima=new int[] { verticeEnArbol,i };
                                costoMinimo=costoArista;
                            }
                        }
                    }
                }
                arbol.Add(aristaMinima);
                visitados.Add(aristaMinima[1]);
            }

            return arbol;
        }
    }
}
