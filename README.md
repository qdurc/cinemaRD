🎬 CinemaRD
CinemaRD es una aplicación fullstack que muestra las películas en cartelera en República Dominicana utilizando la API de TMDb (The Movie Database).
El proyecto está dividido en dos partes:
Backend (.NET Web API) → actúa como BFF (Backend for Frontend), protege la API Key y normaliza datos.
Frontend (React + Vite) → aplicación SPA que consume la API y muestra la cartelera.
📂 Estructura del proyecto
cinemaRD/
  backend/      ← Web API en .NET (C#)
  frontend/     ← React + Vite (JavaScript)
🚀 Tecnologías
Backend
.NET 9 Web API
C#
Swagger (para probar endpoints)
Frontend
React + Vite
Fetch API para consumo de datos
API externa
TMDb API (The Movie Database)
⚙️ Requisitos previos
.NET 9 SDK
Node.js (v18+ recomendado)
Una cuenta y API Key de TMDb → crear aquí
🔧 Instalación y ejecución
1. Clonar el repositorio
git clone https://github.com/tu-usuario/cinemaRD.git
cd cinemaRD
2. Backend (.NET Web API)
Entrar a la carpeta del backend:
cd backend/cinemaRD.Api
Configurar la API Key de TMDb en appsettings.Development.json o en variables de entorno:
{
  "TMDb": {
    "ApiKey": "TU_API_KEY"
  }
}
Ejecutar el proyecto:
dotnet run
El API estará disponible en:
http://localhost:5240
Swagger en: http://localhost:5240/swagger
3. Frontend (React + Vite)
Entrar a la carpeta del frontend:
cd ../../frontend
Instalar dependencias:
npm install
Iniciar el servidor de desarrollo:
npm run dev
Abrir en el navegador:
http://localhost:5173
📌 Endpoints principales (BFF .NET)
GET /api/movies/now → Lista de películas en cartelera en RD.
GET /api/movies/search?q=texto → Buscar películas por nombre.
GET /api/movies/{id} → Detalle de una película.