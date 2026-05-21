# 📦 SistemaInventarioBodega — V1 Beta Temprana

Sistema de inventario en consola desarrollado en C# con arquitectura modular, persistencia JSON y manejo básico de stock.

---

# ✅ Características implementadas

## 🧱 Arquitectura modular

El proyecto se encuentra separado por responsabilidades:

* Models
* Logic
* Services
* Menus
* Helpers
* Data

---

# 📂 Estructura del proyecto

```txt
SistemaInventarioBodega/
│
├── Data/
│   └── productos.json
│
├── Models/
│   └── Producto.cs
│
├── Logic/
│   └── InventarioLogic.cs
│
├── Services/
│   └── JsonService.cs
│
├── Helpers/
│   ├── InputHelper.cs
│   └── ConsoleHelper.cs
│
├── Menus/
│   └── Menu.cs
│
└── Program.cs
```

---

# 📦 Gestión de productos

## Producto contiene:

* Nombre
* Categoria
* Cantidad
* Precio
* EnStock

---

# 💾 Persistencia JSON

Persistencia conectada a:

```txt
Data/productos.json
```

Funciones implementadas:

* Guardar productos
* Cargar productos automáticamente
* Persistencia entre ejecuciones

---

# 🖥️ Menú interactivo

Opciones actuales:

* Agregar productos
* Mostrar productos
* Buscar productos
* Cambiar estado de stock
* Retirar productos
* Agregar stock
* Editar productos
* Salir

---

# 🔎 Funcionalidades actuales

## ✔ Agregar productos

Creación dinámica desde consola.

Incluye:

* Validación reutilizable
* Prevención de productos duplicados

---

## ✔ Mostrar inventario

Listado completo de productos guardados.

Incluye:

* Validación de inventario vacío
* Estado visual de stock

---

## ✔ Buscar productos

Búsqueda por nombre.

Incluye:

* Información detallada
* Estado visual del producto

---

## ✔ Editar productos

Permite modificar:

* Nombre
* Categoría
* Cantidad
* Precio

Actualizando automáticamente el estado de stock.

---

## ✔ Manejo de stock

Funciones implementadas:

* Retirar stock
* Agregar stock
* Actualización automática de disponibilidad

Sistema actual:

```txt
Cantidad > 0 → Disponible
Cantidad <= 0 → Fuera de Stock
```

---

# 🎨 Mejoras visuales

Uso de:

```txt
ConsoleHelper
```

para centralizar:

* Títulos
* Mensajes de éxito
* Advertencias
* Errores

---

# 🧠 Arquitectura actual

## 📌 Menu

Controla:

* flujo de consola
* interacción con usuario
* navegación

---

## 📌 Logic

Controla:

* reglas del inventario
* búsquedas
* stock
* edición
* manipulación de productos

---

## 📌 Services

Controla:

* lectura JSON
* guardado JSON

---

## 📌 Helpers

Controla:

* validaciones reutilizables
* inputs seguros
* mensajes visuales

---

# 🛠️ Tecnologías usadas

* C#
* .NET
* Newtonsoft.Json

---

# 🚀 Cómo ejecutar

```bash
dotnet run
```

---

# 📌 Estado actual del proyecto

```txt
V1 Beta Temprana
```

El sistema actualmente cuenta con:

* arquitectura modular
* persistencia JSON
* CRUD casi completo
* manejo de stock
* edición de productos
* validaciones reutilizables
* prevención de duplicados
* UX visual mejorada
* flujo de consola estable

---

# 🚀 Próximos objetivos

* Soft delete
* Tickets TXT
* Reportes simples
* Mejoras visuales adicionales
* Refactor pequeño de lógica
* Búsquedas avanzadas
* Filtros básicos
