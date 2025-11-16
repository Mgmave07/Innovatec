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
            if (lblSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un nodo.");
                return;
            }

            arbol.Agregar(lblSeleccionado.Text, tbNuevoNombre.Text.Trim());
            CargarTree();
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
            var n = arbol.Buscar(tbBuscar.Text.Trim());
            MessageBox.Show(n != null ? "Encontrado" : "No existe");
        }

        private void btnContarNodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total: " + arbol.ContarNodos());
        }

        private void btnNivelNodo_Click(object sender, EventArgs e)
        {
            int nivel = arbol.Nivel(tbBuscar.Text.Trim());
            MessageBox.Show(nivel == -1 ? "No existe" : $"Nivel: {nivel}");
        }
    }
}
