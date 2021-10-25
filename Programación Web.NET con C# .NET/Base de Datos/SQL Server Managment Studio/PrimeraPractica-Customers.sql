--Traer todos los customers:
USE Northwind
SELECT CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax FROM dbo.Customers
--Traer un customer por CustomerID:
SELECT CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax FROM dbo.Customers
WHERE CustomerID='BOLID'
--Traer todos los customers por City. Hacer la prueba filtrando por alguna ciudad y luego usar parametro:
SELECT CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax FROM dbo.Customers
WHERE City='Madrid'
--Traer solo la columna City sin duplicado de Customer. Para quitar los valores duplicados usar DISCTINCT:
SELECT DISTINCT City FROM dbo.Customers