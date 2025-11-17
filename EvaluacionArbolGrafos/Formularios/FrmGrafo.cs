using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluacionArbolGrafos.Clases;

namespace EvaluacionArbolGrafos.Formularios
{
    public partial class FrmGrafo : Form
    {
        private Grafo grafo = new Grafo();
        public FrmGrafo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre de edificio.");
                return;
            }

            if (grafo.Nodos.Contains(nombre))
            {
                MessageBox.Show("Ya existe un edificio con ese nombre.");
                return;
            }

            grafo.AgregarNodo(nombre);
            MessageBox.Show("Edificio agregado correctamente.");
            tbNombre.Clear();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string a = tbOrigen.Text.Trim();
            string b = tbDestino.Text.Trim();
            string pesoTxt = tbDistancia.Text.Trim();

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                MessageBox.Show("Debe ingresar origen y destino.");
                return;
            }

            if (a == b)
            {
                MessageBox.Show("El edificio origen y destino no pueden ser el mismo.");
                return;
            }

            if (!grafo.Nodos.Contains(a) || !grafo.Nodos.Contains(b))
            {
                MessageBox.Show("Ambos edificios deben existir antes de crear una ruta.");
                return;
            }

            if (!int.TryParse(pesoTxt, out int peso) || peso <= 0)
            {
                MessageBox.Show("La distancia debe ser un número mayor que cero.");
                return;
            }

            grafo.AgregarArista(a, b, peso);
            MessageBox.Show("Ruta agregada correctamente.");

            tbOrigen.Clear();
            tbDestino.Clear();
            tbDistancia.Clear();
        }

        private void btnConexiones_Click(object sender, EventArgs e)
        {
            string nodo = tbMostrar.Text.Trim();

            if (string.IsNullOrEmpty(nodo))
            {
                MessageBox.Show("Ingrese un edificio.");
                return;
            }

            if (!grafo.Nodos.Contains(nodo))
            {
                MessageBox.Show("Ese edificio no existe.");
                return;
            }

            var conn = grafo.Conexiones(nodo);

            if (conn.Count == 0)
            {
                MessageBox.Show("Este edificio no tiene conexiones.");
                return;
            }
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            string ini = tbInicio.Text.Trim();
            string fin = tbFin.Text.Trim();

            if (string.IsNullOrEmpty(ini) || string.IsNullOrEmpty(fin))
            {
                MessageBox.Show("Debe ingresar edificio de inicio y fin.");
                return;
            }

            if (!grafo.Nodos.Contains(ini) || !grafo.Nodos.Contains(fin))
            {
                MessageBox.Show("Ambos edificios deben existir.");
                return;
            }

            if (ini == fin)
            {
                MessageBox.Show("El inicio y el destino no pueden ser el mismo.");
                return;
            }

            var r = grafo.Dijkstra(ini, fin);

            if (r.Costo == int.MaxValue)
            {
                MessageBox.Show("No existe ruta entre esos edificios.");
                return;
            }

            MessageBox.Show(
                "Ruta más corta:\n" +
                string.Join(" → ", r.Camino) +
                $"\nDistancia total: {r.Costo} metros"
            );
        }
    }
}
