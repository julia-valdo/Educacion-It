CREATE Database DBClub
GO
USE DBClub
GO

CREATE Table dbo.Club
(
Id int PRIMARY KEY IDENTITY,
Nombre Varchar(50) NOT NULL,
Domicilio Varchar(50) NOT NULL,
Telefono Varchar(15) NOT NULL
)

Create Table dbo.Jugador
(
Id int PRIMARY KEY IDENTITY,
Nombre Varchar(50) NOT NULL,
Apellido Varchar(50) NOT NULL,
FechaNacimiento Date,
Puesto Varchar(50)
)

Create Table dbo.Entrenador
(
Id int PRIMARY KEY IDENTITY,
Nombre Varchar(50) NOT NULL,
Apellido Varchar(50) NOT NULL,
Domicilio Varchar(50) NOT NULL,
Telefono Varchar(15) NOT NULL,
Titulo Varchar(50) NOT NULL 
)

INSERT dbo.Jugador (Nombre, Apellido, FechaNacimiento, Puesto) VALUES ('Lionel', 'Messi', '1987/06/24', 'Delantero')
INSERT dbo.Jugador (Nombre, Apellido, FechaNacimiento, Puesto) VALUES ('Sergio', 'Agüero', '1988/06/02', 'Delantero')
INSERT dbo.Jugador (Nombre, Apellido, FechaNacimiento, Puesto) VALUES ('Rodrigo', 'De Paul', '1994/05/24', 'Centrocampista')
INSERT dbo.Jugador (Nombre, Apellido, FechaNacimiento, Puesto) VALUES ('Cristiano', 'Ronaldo', '1985/02/05', 'Delantero')
INSERT dbo.Jugador (Nombre, Apellido, FechaNacimiento, Puesto) VALUES ('Damián Emiliano', 'Martínez', '1992/09/02', 'Arquero')

SELECT * FROM dbo.Jugador
