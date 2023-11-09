USE BDCrudTest;
GO
CREATE PROC [co].[Usp_Upd_Co_Categoria] @nIdCategori INT, @NombreCategoria VARCHAR(255), @EsActiva BIT
AS
UPDATE [co].[coCategoria]
SET cNombCategory = @NombreCategoria,cEsActiva = @EsActiva
WHERE nIdCategori = @nIdCategori;
GO