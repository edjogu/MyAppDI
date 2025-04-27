# MyAppDI

Proyecto de ejemplo construido con **.NET 8** siguiendo una arquitectura por capas (inspirada en Clean Architecture).

---

## 🧱 Estructura del Proyecto

```plaintext
MyAppDI/
├── MyAppDI.Api           → Capa de presentación (API REST)
├── MyAppDI.Application   → Capa de aplicación (servicios, casos de uso)
├── MyAppDI.Domain        → Capa de dominio (entidades, interfaces)
└── MyAppDI.Infrastructure → Capa de infraestructura (repositorios, DB, servicios externos)

```

---

## ⚙️ Tecnologías utilizadas

- **.NET 8 SDK**
- ASP.NET Core Web API
- C#
- Inyección de dependencias (DI)
- Arquitectura desacoplada

---

## ▶️ Cómo ejecutar el proyecto

```bash
# 1. Clona el repositorio
git clone https://github.com/edjogu/MyAppDI.git
cd MyAppDI

# 2. Restaura y compila
dotnet restore
dotnet build

# 3. Ejecuta la API
dotnet run --project MyAppDI.Api

# Por defecto se abrirá en:
# https://localhost:5001 o http://localhost:5000

```
---


## 🧠 Flujo de ejecución
Controller → CustomerService → ICustomerRepository → CustomerRepository

- Controller: expone el endpoint HTTP.
- Service: orquesta la lógica.
- Interface: contrato que define qué se necesita.
- Repository: implementación técnica (base de datos o mock).

---

## 🔁 Diagrama de arquitectura
Este diagrama representa el flujo de dependencias entre capas, promoviendo el principio de inversión de dependencias (D de SOLID).

---

## 🚀 Endpoints Disponibles

### 📄 GET /api/customers
Obtiene la lista completa de clientes.

**Ejemplo de respuesta:**
```json
[
  {
    "id": "25b97260-c50f-4496-9d4a-dc5bf256d071",
    "name": "Ana López",
    "email": "ana@example.com"
  },
  {
    "id": "4ad830c2-7fb8-4504-98dc-53dd7b66d45e",
    "name": "Carlos Ramírez",
    "email": "carlos@example.com"
  }
]
```

### 📄 GET /api/customers/{id}
Obtiene un cliente por su identificador único (**Guid**).

**Parámetros:**
- `id` (Guid): Identificador del cliente.

**Ejemplo de solicitud:**
```
GET /api/customers/25b97260-c50f-4496-9d4a-dc5bf256d071
```

**Respuesta exitosa (200 OK):**
```json
{
  "id": "25b97260-c50f-4496-9d4a-dc5bf256d071",
  "name": "Ana López",
  "email": "ana@example.com"
}
```

**Respuesta de error (404 Not Found):**
```json
{
  "title": "Not Found",
  "status": 404,
  "traceId": "00-..."
}
```

---

## 🔧 Correr localmente

```bash
dotnet build
dotnet run --project MyAppDI.Api
```

Accede a Swagger UI en:

```
http://localhost:5076/swagger```

---
<!-- Test PR Template -->
---

---

## ✍️ Autor

Edwar Guzman – @edjogu