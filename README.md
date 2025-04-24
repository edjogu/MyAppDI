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

## ✍️ Autor

Edwar Guzman – @edjogu