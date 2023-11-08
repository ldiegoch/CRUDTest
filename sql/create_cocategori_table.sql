USE BDCrudTest;

CREATE TABLE [co].[coCategoria]
(
	nIdCategori INT IDENTITY(1,1),
	cNombCategory VARCHAR(255) NOT NULL,
	cEsActiva BIT DEFAULT 1,
	PRIMARY KEY (nIdCategori)
);