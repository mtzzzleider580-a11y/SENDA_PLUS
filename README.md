# SENDAPLUS

## 1. Descripción del proyecto

SENDAPLUS es una aplicación de escritorio desarrollada con Windows Forms para la gestión de eventos e invitados. El sistema permite registrar usuarios, autenticar el acceso, crear eventos y administrar invitados utilizando una base de datos MongoDB como almacenamiento principal.

La aplicación está organizada mediante formularios independientes para cada módulo funcional y utiliza clases de dominio para representar las entidades principales del sistema.

---

## 2. Tecnologías

- **Lenguaje:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Base de datos:** MongoDB
- **Driver de base de datos:** MongoDB.Driver
- **Modelado BSON:** MongoDB.Bson
- **Diseño de interfaz:** MaterialSkin
- **Gestión de dependencias:** NuGet
- **IDE recomendado:** Microsoft Visual Studio
- **Solución:** `SENDAPLUS.sln`

---

## 3. Arquitectura

El proyecto sigue una **arquitectura por capas simple**, separando la lógica en diferentes responsabilidades:

- **Presentación**
  - Formularios Windows Forms encargados de la interacción con el usuario.
- **Modelo**
  - Clases que representan las entidades del sistema (`Evento`, `Usuarios`, `Invitacion`).
- **Acceso a datos**
  - Clase de conexión centralizada para la comunicación con MongoDB (`ConexionMongo`).

Esta organización facilita la separación entre la interfaz gráfica, los modelos de datos y la comunicación con la base de datos.

---

## 4. Funcionalidades

El código implementa los siguientes módulos principales:

- Inicio de sesión de usuarios.
- Registro de nuevos usuarios.
- Creación de eventos.
- Registro de invitados.
- Consulta de información almacenada en MongoDB.
- Eliminación de registros de invitados.
- Gestión de entidades mediante documentos BSON.
- Conexión centralizada a MongoDB.
- Interfaz gráfica basada en Windows Forms.

---

## 5. Cómo ejecutarlo

### Requisitos

- Visual Studio 2022 (o compatible con .NET Framework)
- MongoDB instalado y en ejecución
- Restauración de paquetes NuGet

### Pasos

1. Clonar el repositorio:

```bash
git clone <URL_DEL_REPOSITORIO>
```

2. Abrir la solución:

```text
SENDAPLUS.sln
```

3. Restaurar los paquetes NuGet desde Visual Studio.

4. Verificar la configuración de la conexión a MongoDB en la clase:

```text
Clase_conexion/ConexionMongo.cs
```

5. Compilar la solución.

6. Ejecutar el proyecto presionando:

```text
F5
```

---

## 6. Estructura del proyecto

```text
SENDAPLUS/
│
├── SENDAPLUS.sln                 # Solución principal
│
├── SENDAPLUS/
│   ├── App.config                # Configuración de la aplicación
│   ├── packages.config           # Dependencias NuGet
│   ├── SENDAPLUS.csproj          # Proyecto de Visual Studio
│   │
│   ├── Clase_conexion/
│   │   └── ConexionMongo.cs      # Conexión con MongoDB
│   │
│   ├── Clases/
│   │   ├── Program.cs            # Punto de entrada
│   │   ├── Evento.cs             # Modelo de eventos
│   │   ├── Usuarios.cs           # Modelo de usuarios
│   │   └── Invitacion.cs         # Modelo de invitaciones
│   │
│   ├── Logins.cs                 # Inicio de sesión
│   ├── FormREGISTRO.cs           # Registro de usuarios
│   ├── Crear Evento.cs           # Gestión de eventos
│   ├── Agrgar invitados.cs       # Gestión de invitados
│   ├── FormInvitado.cs           # Vista para invitados
│   ├── Lider.cs                  # Interfaz para líder
│   │
│   ├── Properties/               # Recursos y configuración
│   ├── bin/                      # Archivos compilados
│   └── obj/                      # Objetos temporales de compilación
│
├── packages/                     # Paquetes NuGet
└── SENDA_BASE DE DATOS/          # Recursos relacionados con la base de datos
```
