CREATE DATABASE GestionBiblioteca;
GO

USE GestionBiblioteca;
GO

CREATE TABLE Estados (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) UNIQUE
);

-- Valores en la tabla Estados
INSERT INTO Estados (Nombre) VALUES ('Disponible'), ('Prestado'), ('Perdido'), ('Deteriorado');

CREATE TABLE Libros (
    ID INT PRIMARY KEY IDENTITY,
    Titulo NVARCHAR(255),
    Autor NVARCHAR(255),
    Categoria NVARCHAR(255),
    ISBN NVARCHAR(13)
);

CREATE TABLE Copias (
    ID INT PRIMARY KEY IDENTITY,
    LibroID INT FOREIGN KEY REFERENCES Libros(ID),
    CodigoBarras NVARCHAR(255),
    EstadoID INT FOREIGN KEY REFERENCES Estados(ID)
);

CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(255),
    Apellidos NVARCHAR(255),
    DocumentoIdentidad NVARCHAR(20),
    Telefono NVARCHAR(20),
    Email NVARCHAR(255),
    Direccion NVARCHAR(255),
    Ubigeo NVARCHAR(6)
);

CREATE TABLE EstadosPrestamos (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) UNIQUE
);

-- Valores en la tabla EstadosPrestamos
INSERT INTO EstadosPrestamos (Nombre) VALUES ('Pendiente'), ('Aprobado'), ('Rechazado'), ('Devuelto');

CREATE TABLE Prestamos (
    ID INT PRIMARY KEY IDENTITY,
    UsuarioID INT FOREIGN KEY REFERENCES Usuarios(ID),
    CopiaID INT FOREIGN KEY REFERENCES Copias(ID),
    FechaPrestamo DATETIME,
    FechaDevolucion DATETIME,
    EstadoID INT FOREIGN KEY REFERENCES EstadosPrestamos(ID)
);

CREATE TABLE ListaNegra (
    ID INT PRIMARY KEY IDENTITY,
    UsuarioID INT FOREIGN KEY REFERENCES Usuarios(ID),
    Motivo NVARCHAR(255)
);

CREATE TABLE Auditoria (
    ID INT PRIMARY KEY IDENTITY,
    Accion NVARCHAR(255),
    UsuarioID INT FOREIGN KEY REFERENCES Usuarios(ID),
    Fecha DATETIME
);
-- Agregar un Usuario para las pruebas
INSERT INTO Usuarios (Nombre, Apellidos, DocumentoIdentidad, Telefono, Email, Direccion, Ubigeo)
VALUES ('Juan', 'Pérez', '12345678', '987654321', 'juan.perez@example.com', 'Calle Falsa 123', '150101');