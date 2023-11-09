USE BDCrudTest;
GO
CREATE PROC [co].[Usp_Del_Co_Categoria] @nIdCategori INT
AS
DELETE FROM [co].[coCategoria]
WHERE nIdCategori = @nIdCategori;
GO