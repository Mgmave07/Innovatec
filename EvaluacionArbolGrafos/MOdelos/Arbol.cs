using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionArbolGrafos.Clases
{
    public class NodoOrganizacional
    {
        public string Nombre { get; set; }
        public List<NodoOrganizacional> Hijos { get; set; }

        public NodoOrganizacional(string nombre)
        {
            Nombre = nombre;
            Hijos = new List<NodoOrganizacional>();
        }
    }
    public class ArbolOrganizacional
    {
        public NodoOrganizacional Raiz { get; private set; }

        public ArbolOrganizacional(string raiz)
        {
            Raiz = new NodoOrganizacional(raiz);
        }

        public void Agregar(string padre, string nuevo)
        {
            var nodoPadre = Buscar(padre);
            if (nodoPadre == null)
                throw new Exception("El nodo seleccionado no existe.");

            nodoPadre.Hijos.Add(new NodoOrganizacional(nuevo));
        }

        public NodoOrganizacional Buscar(string nombre)
        {
            return BuscarRec(Raiz, nombre);
        }

        private NodoOrganizacional BuscarRec(NodoOrganizacional nodo, string nombre)
        {
            if (nodo.Nombre == nombre)
                return nodo;

            foreach (var hijo in nodo.Hijos)
            {
                var encontrado = BuscarRec(hijo, nombre);
                if (encontrado != null)
                    return encontrado;
            }
            return null;
        }

        public List<string> Preorden()
        {
            List<string> lista = new List<string>();
            PreordenRec(Raiz, lista);
            return lista;
        }

        private void PreordenRec(NodoOrganizacional nodo, List<string> lista)
        {
            lista.Add(nodo.Nombre);
            foreach (var hijo in nodo.Hijos)
                PreordenRec(hijo, lista);
        }

        public List<string> Postorden()
        {
            List<string> lista = new List<string>();
            PostordenRec(Raiz, lista);
            return lista;
        }

        private void PostordenRec(NodoOrganizacional nodo, List<string> lista)
        {
            foreach (var hijo in nodo.Hijos)
                PostordenRec(hijo, lista);
            lista.Add(nodo.Nombre);
        }

        public int ContarNodos()
        {
            return ContarRec(Raiz);
        }

        private int ContarRec(NodoOrganizacional nodo)
        {
            int total = 1;
            foreach (var hijo in nodo.Hijos)
                total += ContarRec(hijo);
            return total;
        }

        public int Nivel(string nombre)
        {
            return NivelRec(Raiz, nombre, 0);
        }

        private int NivelRec(NodoOrganizacional nodo, string nombre, int nivel)
        {
            if (nodo.Nombre == nombre)
                return nivel;

            foreach (var hijo in nodo.Hijos)
            {
                int found = NivelRec(hijo, nombre, nivel + 1);
                if (found != -1)
                    return found;
            }

            return -1;
        }
    }
}
