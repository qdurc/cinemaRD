# 🎬 CinemaRD

**CinemaRD** es una aplicación fullstack que muestra las películas en cartelera en República Dominicana utilizando la API de **TMDb** (The Movie Database).  
El proyecto está dividido en dos partes:

- **Backend (.NET Web API)** → actúa como BFF (Backend for Frontend), protege la API Key y normaliza datos.  
- **Frontend (React + Vite)** → aplicación SPA que consume la API y muestra la cartelera.  

---

## 📂 Estructura del proyecto

cinemaRD/
backend/ ← Web API en .NET (C#)
frontend/ ← React + Vite (JavaScript)

---

## 🚀 Tecnologías

**Backend**
- .NET 9 Web API
- C#
- Swagger (para probar endpoints)

**Frontend**
- React + Vite
- Fetch API para consumo de datos

**API externa**
- TMDb API (The Movie Database)

---

## ⚙️ Requisitos previos

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js (v18+ recomendado)](https://nodejs.org/)
- Una cuenta y **API Key de TMDb** → [crear aquí](https://www.themoviedb.org/settings/api)

