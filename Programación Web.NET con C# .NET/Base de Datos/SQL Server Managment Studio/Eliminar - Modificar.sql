USE Northwind
GO
SELECT * FROM dbo.Cliente
--Eliminar (si no escribo el WHERE elimino todo)
DELETE FROM dbo.Cliente WHERE Id=2
--Modificar (si no escribo el WHERE actualizo todo)
UPDATE dbo.Cliente 
SET Nombre='Gabriela Marina', 
	Apellido='Giles Pocetti', 
	FechaNacimiento='1975-06-02'
WHERE Id=3