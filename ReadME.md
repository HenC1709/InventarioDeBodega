# 📦 SistemaInventarioBodega — README ACTUALIZADO

# 🚀 Estado actual del proyecto

```txt
V1 Beta Temprana
```

Sistema de inventario en consola desarrollado en C# usando arquitectura modular, persistencia JSON y manejo de movimientos de bodega.

---

# ✅ Características implementadas

## 🧱 Arquitectura modular

Separación del proyecto por responsabilidades:

* Models
* Logic
* Services
* Menus
* Helpers
* Data
* Tickets

---

# 📂 Estructura actual

```txt
SistemaInventarioBodega/
│
├── Data/
│   └── productos.json
│
├── Tickets/
│
├── Models/
│   └── Producto.cs
│
├── Logic/
│   └── InventarioLogic.cs
│
├── Services/
│   ├── JsonService.cs
│   └── TicketService.cs
│
├── Helpers/
│   ├── InputHelper.cs
│   └── ConsoleHelper.cs
│
├── Utils/
│   └── Validaciones.cs
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
* Activo

---

# 💾 Persistencia JSON

Persistencia conectada a:

```txt
Data/productos.json
```

Funciones actuales:

* Guardar productos
* Cargar productos automáticamente
* Persistencia entre ejecuciones

---

# 🖥️ Menú interactivo

Opciones implementadas:

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

Incluye:

* Validaciones reutilizables
* Prevención de productos duplicados

---

## ✔ Mostrar inventario

Incluye:

* Validación de inventario vacío
* Estado visual de stock
* Ocultamiento automático de productos agotados

---

## ✔ Buscar productos

Muestra:

* Nombre
* Categoría
* Cantidad
* Precio
* Estado

---

## ✔ Editar productos

Permite modificar:

* Nombre
* Categoría
* Cantidad
* Precio

---

## ✔ Manejo de stock

Funciones implementadas:

* Retirar stock
* Agregar stock
* Actualización automática de estado

Regla actual:

```txt
Cantidad > 0 → Activo
Cantidad <= 0 → Oculto del inventario visible
```

---

# 🎟️ Sistema de tickets TXT

Cada retiro exitoso genera automáticamente:

```txt
Tickets/ticket_fecha_hora.txt
```

Incluyendo:

* Producto retirado
* Cantidad retirada
* Fecha y hora

---

# 🎨 Mejoras visuales

Uso de:

```txt
ConsoleHelper
```

para manejar:

* Títulos
* Mensajes de éxito
* Advertencias
* Errores

---

# 🧠 Arquitectura actual

## 📌 Menu

Controla:

* interacción usuario
* navegación
* visualización

---

## 📌 Logic

Controla:

* reglas de negocio
* stock
* edición
* manipulación de productos

---

## 📌 Services

Controla:

* JSON
* tickets TXT
* persistencia

---

## 📌 Helpers

Controla:

* validaciones de entrada
* inputs seguros
* visuales consola

---

## 📌 Utils

Preparado para:

* validaciones de negocio
* reglas futuras

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

# 🔥 Estado actual REAL

El proyecto actualmente cuenta con:

✅ Arquitectura modular
✅ Persistencia JSON
✅ CRUD casi completo
✅ Manejo de stock
✅ Edición de productos
✅ Prevención de duplicados
✅ Tickets TXT automáticos
✅ Validaciones reutilizables
✅ UX visual mejorada
✅ Flujo operativo de bodega
✅ Ocultamiento automático de stock agotado

---
