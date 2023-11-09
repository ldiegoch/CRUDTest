USE BDCrudTest;
GO
CREATE PROC [co].[Usp_Del_Co_Categoria] @nIdCategory INT
AS
DELETE FROM [co].[coCategoria]
WHERE nIdCategori = @nIdCategory;
GO