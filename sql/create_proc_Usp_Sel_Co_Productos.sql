USE BDCrudTest;
GO
CREATE PROC [co].[Usp_Sel_Co_Productos] @nIdCategori INT
AS
SELECT
	producto.nIdProduct,
	producto.cNombProdu,
	producto.nPrecioProd,
	producto.nIdCategori,
	categoria.cNombCategory
FROM [co].[coProducto] AS producto
INNER JOIN [co].[coCategoria] AS categoria
	ON producto.nIdCategori = categoria.nIdCategori
	AND categoria.nIdCategori = @nIdCategori;
GO