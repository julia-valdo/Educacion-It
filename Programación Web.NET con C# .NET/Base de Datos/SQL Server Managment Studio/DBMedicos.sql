CREATE DATABASE DBMedicos

GO
Use DBMedicos
go

CREATE TABLE dbo.Especialidad
(
Id Int PRIMARY KEY IDENTITY, 
Nombre Varchar(50) NOT NULL
)

CREATE TABLE dbo.Medico
(
Id Int PRIMARY KEY IDENTITY, 
Nombre Varchar(50) NOT NULL,
Apellido Varchar(50) NOT NULL,
NroMatricula int NOT NULL,
EspecialidadId int NOT NULL
)

INSERT dbo.Especialidad (Nombre) VALUES ('Cardiología')
INSERT dbo.Especialidad (Nombre) VALUES ('Dermatología')
SELECT * FROM dbo.Especialidad
SELECT Id,Nombre FROM dbo.Especialidad

ALTER table dbo.Medico
ADD foreign key(EspecialidadId) references dbo.Especialidad(Id)

INSERT dbo.Medico (Nombre, Apellido, NroMatricula, EspecialidadId) VALUES ('Isabelle K.', 'Huson', 667, 1)
INSERT dbo.Medico (Nombre, Apellido, NroMatricula, EspecialidadId) VALUES ('Teresa P.', 'Weesner', 515, 1)
INSERT dbo.Medico (Nombre, Apellido, NroMatricula, EspecialidadId) VALUES ('James M.', 'Jones', 046, 2)
SELECT * FROM dbo.Medico
SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico