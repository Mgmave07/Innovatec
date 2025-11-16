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
            grafo.AgregarNodo(tbNombre.Text.Trim());
            MessageBox.Show("Edificio agregado.");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            grafo.AgregarArista(
                tbOrigen.Text.Trim(),
                tbDestino.Text.Trim(),
                int.Parse(tbDistancia.Text.Trim()));

            MessageBox.Show("Ruta agregada.");
        }

        private void btnConexiones_Click(object sender, EventArgs e)
        {
            var conn = grafo.Conexiones(tbMostrar.Text.Trim());

            string txt = "Conexiones:\n\n";
            foreach (var c in conn)
                txt += $"{c.Destino} → {c.Peso} m\n";

            MessageBox.Show(txt);
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            var r = grafo.Dijkstra(tbInicio.Text.Trim(), tbFin.Text.Trim());

            if (r.Costo == int.MaxValue)
            {
                MessageBox.Show("No hay ruta.");
                return;
            }

            MessageBox.Show(
                $"Ruta:\n{string.Join(" → ", r.Camino)}\n\nDistancia total: {r.Costo} m"
            );
        }
    }
}
