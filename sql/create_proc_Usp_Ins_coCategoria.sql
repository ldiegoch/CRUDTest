USE BDCrudTest;
GO
CREATE PROC [co].[Usp_Ins_Co_Categoria] @NombreCategoria VARCHAR(255), @EsActiva BIT
AS
INSERT INTO [co].[coCategoria](
	cNombCategory,cEsActiva
)
VALUES( @NombreCategoria, @EsActiva )
GO