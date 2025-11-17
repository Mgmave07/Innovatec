Documentación del Código - EvaluacionArbolGrafos
Esta es una aplicación de Windows Forms en C# que implementa dos estructuras de datos fundamentales: árboles y grafos FrmPrincipal.cs:14-19 . La aplicación proporciona dos módulos principales accesibles desde un menú de navegación FrmPrincipal.cs:21-31 .

Arquitectura General
La aplicación sigue el patrón Windows Forms con separación entre lógica de negocio y presentación EvaluacionArbolGrafos.csproj:8-14 . Está construida sobre .NET Framework 4.7.2 EvaluacionArbolGrafos.csproj:11 .

Estructura de Carpetas
EvaluacionArbolGrafos/  
├── Formularios/          # Interfaces de usuario  
│   ├── FrmArbol.cs      # Módulo de jerarquía organizacional  
│   └── FrmGrafo.cs      # Módulo de rutas del parque  
├── Modelos/             # Estructuras de datos  
│   ├── Arbol.cs         # Implementación de árbol n-ario  
│   └── Grafo.cs         # Implementación de grafo ponderado  
└── FrmPrincipal.cs      # Formulario principal de navegación  
Módulo 1: Jerarquía Organizacional (Árbol)
Modelo de Datos
Clase NodoOrganizacional: Representa un nodo en la jerarquía con nombre y lista de hijos Arbol.cs:20-27 .

Clase ArbolOrganizacional: Implementa un árbol n-ario con las siguientes operaciones Arbol.cs:20-27 :

Agregar nodo: Añade un hijo a un nodo padre especificado Arbol.cs:29-36
Buscar: Encuentra un nodo por nombre usando búsqueda recursiva Arbol.cs:38-55
Recorrido Preorden: Visita raíz antes que hijos Arbol.cs:57-69
Recorrido Postorden: Visita hijos antes que raíz Arbol.cs:71-83
Contar nodos: Cuenta total de nodos recursivamente Arbol.cs:85-96
Nivel de nodo: Calcula la profundidad de un nodo Arbol.cs:98-116
Interfaz de Usuario
FrmArbol inicializa con un árbol que contiene el nodo raíz "Presidencia" FrmArbol.cs:18-23 . Los usuarios pueden:

Seleccionar nodo: Click en el TreeView actualiza la etiqueta de selección FrmArbol.cs:41-44
Agregar subnodo: Requiere nodo seleccionado y nombre nuevo FrmArbol.cs:46-56
Visualizar recorridos: Botones para preorden y postorden FrmArbol.cs:58-66
Buscar posición: Verifica existencia de un nodo FrmArbol.cs:68-72
Operaciones de análisis: Contar nodos y obtener nivel FrmArbol.cs:74-83
Módulo 2: Sistema de Rutas del Parque (Grafo)
Modelo de Datos
Clase Arista: Representa una conexión con destino y peso (distancia) Grafo.cs:9-19 .

Clase Grafo: Implementa un grafo no dirigido ponderado usando lista de adyacencia Grafo.cs:20-24 :

Agregar nodo: Añade edificio al conjunto de nodos Grafo.cs:25-32
Agregar arista: Crea conexión bidireccional entre dos edificios Grafo.cs:34-41
Conexiones: Retorna lista de adyacencia de un nodo Grafo.cs:43-46
Es conexo: Verifica conectividad usando DFS Grafo.cs:48-61
Dijkstra: Calcula ruta más corta entre dos nodos Grafo.cs:63-104
Interfaz de Usuario
FrmGrafo inicia con un grafo vacío FrmGrafo.cs:16-20 . Los usuarios pueden:

Agregar edificio: Crea nuevo nodo en el grafo FrmGrafo.cs:22-26
Agregar ruta: Conecta dos edificios con distancia especificada FrmGrafo.cs:28-36
Ver conexiones: Muestra edificios adyacentes y distancias FrmGrafo.cs:38-47
Calcular ruta más corta: Usa algoritmo de Dijkstra para encontrar camino óptimo FrmGrafo.cs:49-62
Navegación Principal
El formulario FrmPrincipal (Form1) proporciona un menú con dos opciones FrmPrincipal.cs:21-31 :

Jerarquía Organizativa: Abre instancia de FrmArbol FrmPrincipal.cs:21-25
Sistema de Rutas del Parque: Abre instancia de FrmGrafo FrmPrincipal.cs:27-31
Ambos módulos se abren como ventanas independientes no modales FrmPrincipal.cs:23-30 .

Requisitos Técnicos
.NET Framework: 4.7.2 EvaluacionArbolGrafos.csproj:11
Tipo de aplicación: Windows Forms (WinExe) EvaluacionArbolGrafos.csproj:8
Referencias principales: System.Windows.Forms, System.Drawing EvaluacionArbolGrafos.csproj:45
