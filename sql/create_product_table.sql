USE BDCrudTest;

CREATE TABLE [co].[coProducto]
(
	nIdProduct INT IDENTITY(1,1),
	cNombProdu VARCHAR(255) NOT NULL,
	nPrecioProd MONEY NOT NULL,
	nIdCategori INT NOT NULL,
	PRIMARY KEY (nIdProduct),
	FOREIGN KEY (nIdCategori) REFERENCES [co].[coCategoria](nIdCategori) ON DELETE CASCADE
);
