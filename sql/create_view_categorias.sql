USE BDCrudTest;
GO
CREATE VIEW [co].[Categoria]
AS
SELECT nIdCategori as Id, cNombCategory as Nombre, cEsActiva as EsActiva
FROM [co].[coCategoria];
GO
