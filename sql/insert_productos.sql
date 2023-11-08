USE BDCrudTest;

GO
INSERT INTO [co].[coProducto](cNombProdu,nPrecioProd,nIdCategori)
SELECT Productos.Nombre, Productos.Precio, Categoria.nIdCategori
FROM (
	VALUES
	('Aceite para motor', 12985,'Automotriz'),
	('Firestone LLanta', 69995,'Automotriz'),
	('Bateria', 139995,'Automotriz'),
	('Bombilla LED', 29995,'Ferreteria'),
	('Lijadora', 55950,'Ferreteria'),
	('Sierra Caladora', 51950,'Ferreteria')
) as Productos(Nombre,Precio,Categoria)
LEFT JOIN [co].[coCategoria] as Categoria ON Productos.Categoria = Categoria.cNombCategory;
GO
