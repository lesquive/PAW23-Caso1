# Reserva de Restaurantes - Documentación

## Información General

- **Estudiante:** Luis José Esquivel Blanco
- **Universidad:** Universidad Fidélitas
- **Curso:** Programación Avanzada Web
- **Profesor:** José Andres Arias Brenes
- **Fecha:** Octubre de 2023

## Descripción del Proyecto

Este proyecto consiste en una aplicación que permite gestionar reservas de restaurantes a través de una API RESTful. La aplicación ha sido desarrollada utilizando varias tecnologías y se ha documentado para facilitar su comprensión y uso.

## Tecnología Utilizada

- **Backend en C# .NET Core:** La parte del servidor de la aplicación está construida utilizando C# y la plataforma .NET Core. .NET Core es un marco de código abierto y multiplataforma que se utiliza para crear aplicaciones de servidor robustas y escalables.

- **Base de Datos MySQL:** La base de datos utilizada es MySQL, un sistema de gestión de bases de datos relacional (RDBMS) de código abierto. Almacena los datos de las reservas en la tabla "Reservas" dentro del esquema "prograWeb".

- **Razor Frontend:** Para la interfaz de usuario, se utiliza Razor, una tecnología de Microsoft para crear páginas web interactivas y dinámicas en ASP.NET Core. Permite la creación de vistas y páginas web de manera eficiente y flexible.

- **Swagger:** Se ha implementado Swagger para la documentación y exploración de la API. Swagger es una herramienta que genera automáticamente documentación interactiva para las API de una aplicación.

## Procesos Funcionales

1. **GET a /api/reservas:** Esta API endpoint permite obtener la lista de todas las reservas almacenadas en la base de datos. Al acceder a esta URL, se obtiene una lista de las reservas existentes.

2. **POST a /api/reservas:** Puedes agregar nuevas reservas enviando una solicitud POST a esta URL. Los datos de la reserva se proporcionan en el cuerpo de la solicitud y se almacenan en la base de datos.

3. **GET a /api/reservas/id:** Con esta API endpoint, puedes obtener los detalles de una reserva específica utilizando su ID. Proporcionas el ID en la URL y obtienes la información detallada de esa reserva.

4. **POST a /api/reservas/id:** Puedes actualizar una reserva existente enviando una solicitud POST a esta URL, junto con el ID de la reserva que deseas modificar. Los datos actualizados se proporcionan en el cuerpo de la solicitud.

5. **DELETE a /api/reservas/id:** Para eliminar una reserva, se utiliza esta API endpoint. Al proporcionar el ID de la reserva que deseas eliminar, se eliminará de la base de datos.

## Tipo de Servicio Utilizado

El tipo de servicio utilizado en esta aplicación es una REST API (API de Transferencia de Estado Representacional). Una API RESTful es una arquitectura que utiliza HTTP para la comunicación y permite a los clientes (en este caso, la interfaz de usuario de Razor) acceder y modificar recursos (las reservas en la base de datos) a través de las operaciones HTTP estándar, como GET, POST y DELETE. Las respuestas a estas solicitudes están en formato JSON.

¡Gracias por revisar esta documentación! Si tienes alguna pregunta o necesitas más información, no dudes en contactar a Luis José Esquivel Blanco.
