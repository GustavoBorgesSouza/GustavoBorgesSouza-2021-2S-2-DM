USE CATALOGO;
GO

INSERT INTO Genero(NomeGenero)
VALUES ('Ação'), ('Aventura'),('Romance'), ('Suspense');
GO

DELETE FROM Genero WHERE IdGenero = 2;
GO

UPDATE Genero SET NomeGenero = 'Comédia' WHERE IdGenero = 4;
GO

--SELECT * FROM Genero;
--GO

INSERT INTO Filme(IdGenero, TituloFilme)
VALUES (3, 'A culpa é das estrelas'), (1, 'Rocky'), (4, 'Minha mãe é uma peça');
GO

--SELECT * FROM Filme;
--GO

