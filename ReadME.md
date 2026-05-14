# 📦 SistemaInventarioBodega — V1 Alpha

Primer prototipo funcional del sistema de inventario en consola usando C# y persistencia JSON.

---

# ✅ Características implementadas

## 🧱 Arquitectura modular

Estructura organizada por capas:

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
│   └── InvetarioLogic.cs
│
├── Services/
│   └── JsonService.cs
│
├── Helpers/
│   └── InputHelper.cs
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

Sistema conectado a:

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
* Mostrar inventario
* Buscar productos
* Cambiar estado de stock
* Salir

---

# 🔎 Funcionalidades actuales

## ✔ Agregar productos

Creación dinámica desde consola.

## ✔ Mostrar inventario

Listado completo de productos guardados.

## ✔ Buscar productos

Búsqueda por nombre.

## ✔ Estado de stock

Sistema básico de disponibilidad:

```txt
Cantidad > 0 → Disponible
Cantidad <= 0 → Fuera de Stock
```

## ✔ Validaciones reutilizables

Uso de:

* ReadInt()
* ReadDecimal()
* ReadString()

para evitar errores de entrada y crashes.

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
* stock
* búsquedas
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
V1 Alpha Avanzada / Camino a Beta
```

El sistema actualmente cuenta con:

* arquitectura modular
* persistencia JSON
* menú modular
* validaciones robustas
* flujo de consola estable
* lógica de stock
* código más mantenible

---

# 🚀 Próximos objetivos (Beta)

* Editar productos
* Ticket de retiro
* Soft delete real
* Mejorar UX consola
* Filtros y búsqueda avanzada
* Mejor manejo visual de stock
* Refactor adicional de lógica
* Sistema de carrito/caja (V2 futura)
 
 # ✅ añadidos 13/05/26
 
 * Retirar stock
 * añadir stock
 