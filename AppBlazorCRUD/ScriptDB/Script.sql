-- Crear la base de datos "crudblazordb"
CREATE DATABASE CRUDblazordb;
GO

-- Usar la base de datos "crudblazordb"
USE CRUDblazordb;
GO

-- Crear la tabla "Cliente"
CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    FechaNacimiento DATE
);

-- Data Source=.;Initial Catalog=CRUDblazordb;Integrated Security=True;Encrypt=False
-- Scaffold-DbContext "Data Source=.;Initial Catalog=CRUDblazordb;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data