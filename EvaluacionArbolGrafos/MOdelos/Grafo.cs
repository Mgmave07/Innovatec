using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionArbolGrafos.Clases
{
    public class Arista
    {
        public string Destino { get; set; }
        public int Peso { get; set; }

        public Arista(string destino, int peso)
        {
            Destino = destino;
            Peso = peso;
        }
    }
    public class Grafo
    {
        public HashSet<string> Nodos { get; private set; } = new HashSet<string>();
        private Dictionary<string, List<Arista>> ady = new Dictionary<string, List<Arista>>();

        public void AgregarNodo(string nombre)
        {
            if (!Nodos.Contains(nombre))
            {
                Nodos.Add(nombre);
                ady[nombre] = new List<Arista>();
            }
        }

        public void AgregarArista(string a, string b, int peso)
        {
            if (!Nodos.Contains(a) || !Nodos.Contains(b))
                throw new Exception("Uno de los edificios no existe.");

            ady[a].Add(new Arista(b, peso));
            ady[b].Add(new Arista(a, peso));
        }

        public List<Arista> Conexiones(string nodo)
        {
            return ady[nodo];
        }

        public bool EsConexo()
        {
            var visitados = new HashSet<string>();
            DFS(Nodos.First(), visitados);
            return visitados.Count == Nodos.Count;
        }

        private void DFS(string actual, HashSet<string> visitados)
        {
            visitados.Add(actual);
            foreach (var arista in ady[actual])
                if (!visitados.Contains(arista.Destino))
                    DFS(arista.Destino, visitados);
        }

        public (List<string> Camino, int Costo) Dijkstra(string inicio, string fin)
        {
            var dist = Nodos.ToDictionary(n => n, n => int.MaxValue);
            var prev = Nodos.ToDictionary(n => n, n => (string)null);
            var vis = new HashSet<string>();

            dist[inicio] = 0;

            while (vis.Count < Nodos.Count)
            {
                var actual = dist
                    .Where(x => !vis.Contains(x.Key))
                    .OrderBy(x => x.Value)
                    .First().Key;

                vis.Add(actual);

                foreach (var ar in ady[actual])
                {
                    int nd = dist[actual] + ar.Peso;
                    if (nd < dist[ar.Destino])
                    {
                        dist[ar.Destino] = nd;
                        prev[ar.Destino] = actual;
                    }
                }
            }

            List<string> camino = new List<string>();
            string nodo = fin;

            if (dist[fin] == int.MaxValue)
                return (camino, dist[fin]);

            while (nodo != null)
            {
                camino.Insert(0, nodo);
                nodo = prev[nodo];
            }

            return (camino, dist[fin]);
        }
    }
}
