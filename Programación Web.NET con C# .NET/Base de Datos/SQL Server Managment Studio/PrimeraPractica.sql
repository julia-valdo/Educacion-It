--SSMS
--Base de datos: Northwind
--Traer todos los productos:
use Northwind
SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products
--Traer todas las categorias:
SELECT CategoryID,CategoryName FROM dbo.Categories
--Traer todos los productos por categoria:
SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products
WHERE CategoryID=7 
--Hardcodeado, en C#.NET tiene que ser una variable
SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products
WHERE CategoryID=@CategoryID
--@CategoryID es una variable de SQL Server
--------------------------------------------------------------
SELECT CategoryID,CategoryName FROM dbo.Categories 
WHERE CategoryID=2 