<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Movie Web API - README</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            line-height: 1.6;
        }
        h1, h2, h3 {
            color: #333;
        }
        code {
            background-color: #f4f4f4;
            padding: 2px 4px;
            border-radius: 4px;
        }
        pre {
            background-color: #f4f4f4;
            padding: 10px;
            border-radius: 4px;
            overflow-x: auto;
        }
        a {
            color: #007BFF;
            text-decoration: none;
        }
        a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <h1>Movie Web API</h1>

    <p>This is a RESTful API for managing a movie database. The API supports CRUD (Create, Read, Update, Delete) operations and is documented using Swagger for easy testing and interaction.</p>

    <h2>Features</h2>
    <ul>
        <li>Create, read, update, and delete movie records.</li>
        <li>Swagger UI for API documentation and testing.</li>
        <li>Pagination and filtering for retrieving movies.</li>
        <li>Built with a modern backend framework (e.g., Node.js, Python Flask, ASP.NET).</li>
    </ul>

    <h2>Endpoints</h2>

    <h3>Create a Movie</h3>
    <p><strong>POST</strong> <code>/api/movies</code></p>
    <pre>
{
  "title": "Inception",
  "director": "Christopher Nolan",
  "releaseDate": "2010-07-16",
  "genre": "Sci-Fi"
}
    </pre>

    <h3>Get All Movies</h3>
    <p><strong>GET</strong> <code>/api/movies</code></p>
    <p>Optional Query Parameters:</p>
    <ul>
        <li><code>?page=1&size=10</code>: Pagination</li>
        <li><code>?genre=Sci-Fi</code>: Filter by genre</li>
    </ul>

    <h3>Get a Movie by ID</h3>
    <p><strong>GET</strong> <code>/api/movies/{id}</code></p>

    <h3>Update a Movie</h3>
    <p><strong>PUT</strong> <code>/api/movies/{id}</code></p>
    <pre>
{
  "title": "Interstellar",
  "director": "Christopher Nolan",
  "releaseDate": "2014-11-07",
  "genre": "Sci-Fi"
}
    </pre>

    <h3>Delete a Movie</h3>
    <p><strong>DELETE</strong> <code>/api/movies/{id}</code></p>

    <h2>Setup and Installation</h2>
    <ol>
        <li>Clone the repository:</li>
        <pre>git clone https://github.com/yourusername/movie-web-api.git</pre>

        <li>Install dependencies:</li>
        <pre>npm install</pre>

        <li>Run the development server:</li>
        <pre>npm start</pre>

        <li>Access the API at <code>http://localhost:3000</code></li>
    </ol>

    <h2>Swagger Documentation</h2>
    <p>The API documentation is available via Swagger UI. To access it:</p>
    <ul>
        <li>Start the server.</li>
        <li>Navigate to <a href="http://localhost:3000/swagger">http://localhost:3000/swagger</a>.</li>
        <li>Explore and test the endpoints directly from the UI.</li>
    </ul>

    <h2>Technologies Used</h2>
    <ul>
        <li>Backend Framework: Node.js / Express.js (or any other framework of your choice)</li>
        <li>Database: MongoDB / PostgreSQL</li>
        <li>API Documentation: Swagger</li>
    </ul>

    <h2>Contributing</h2>
    <p>Contributions are welcome! Please follow these steps:</p>
    <ol>
        <li>Fork the repository.</li>
        <li>Create a new branch for your feature or bugfix.</li>
        <li>Commit your changes.</li>
        <li>Submit a pull request.</li>
    </ol>

    <h2>License</h2>
    <p>This project is licensed under the MIT License. See the <code>LICENSE</code> file for details.</p>

</body>
</html>
