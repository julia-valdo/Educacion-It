--Crear una tabla
USE Northwind
GO

CREATE TABLE dbo.Cliente
(
--PRIMARY KEY --> sin duplicados y sin nulo
--IDENTITY es autonumerico (comienza en 1, incrementa en 1)
Id INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(50) NOT NULL,
Apellido VARCHAR(50) NOT NULL,
FechaNacimiento DATE NULL
)

INSERT dbo.Cliente (Nombre, Apellido, FechaNacimiento) VALUES ('Julia', 'Valdovinos', '01/21/1998')

SELECT * FROM dbo.Cliente

INSERT dbo.Cliente (Nombre, Apellido, FechaNacimiento) VALUES (@Nombre, @Apellido, @FechaNacimiento)
