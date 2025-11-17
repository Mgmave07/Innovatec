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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvaluacionArbolGrafos.Formularios
{
    public partial class FrmArbol : Form
    {
        private ArbolOrganizacional arbol;
        public FrmArbol()
        {
            InitializeComponent();
            arbol = new ArbolOrganizacional("Presidencia");
            CargarTree();
        }
        private void CargarTree()
        {
            tvOrganizacion.Nodes.Clear();
            TreeNode root = new TreeNode(arbol.Raiz.Nombre);
            AgregarRec(arbol.Raiz, root);
            tvOrganizacion.Nodes.Add(root);
            tvOrganizacion.ExpandAll();
        }
        private void AgregarRec(NodoOrganizacional nodo, TreeNode visual)
        {
            foreach (var hijo in nodo.Hijos)
            {
                TreeNode tv = new TreeNode(hijo.Nombre);
                visual.Nodes.Add(tv);
                AgregarRec(hijo, tv);
            }
        }
        private void tvOrganizacion_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblSeleccionado.Text = e.Node.Text;
        }

        private void btnAgregarSubNodo_Click(object sender, EventArgs e)
        {
            string padre = lblSeleccionado.Text.Trim();
            string nuevo = tbNuevoNombre.Text.Trim();

            if (string.IsNullOrEmpty(padre))
            {
                MessageBox.Show("Debe seleccionar un departamento en el árbol.");
                return;
            }

            if (string.IsNullOrEmpty(nuevo))
            {
                MessageBox.Show("Debe escribir el nombre del nuevo departamento o área.");
                return;
            }

            if (arbol.Buscar(nuevo) != null)
            {
                MessageBox.Show("Ya existe un departamento o empleado con ese nombre.");
                return;
            }

            try
            {
                arbol.Agregar(padre, nuevo);
                tbNuevoNombre.Clear();
                CargarTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", arbol.Preorden()));
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", arbol.Postorden()));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = tbBuscar.Text.Trim();

            if (string.IsNullOrEmpty(buscado))
            {
                MessageBox.Show("Ingrese el nombre a buscar.");
                return;
            }

            var n = arbol.Buscar(buscado);

            MessageBox.Show(n != null ? "Encontrado." : "No existe en la jerarquía.");
        }

        private void btnContarNodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total: " + arbol.ContarNodos());
        }

        private void btnNivelNodo_Click(object sender, EventArgs e)
        {
            string buscado = tbBuscar.Text.Trim();

            if (string.IsNullOrEmpty(buscado))
            {
                MessageBox.Show("Ingrese el nombre para consultar su nivel.");
                return;
            }

            int nivel = arbol.Nivel(buscado);

            if (nivel == -1)
            {
                MessageBox.Show("Ese nodo no existe en la jerarquía.");
                return;
            }

            MessageBox.Show($"El nivel de '{buscado}' es: {nivel}");
        }
    }
}
