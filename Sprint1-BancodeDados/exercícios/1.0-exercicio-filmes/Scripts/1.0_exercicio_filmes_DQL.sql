USE CATALOGO;
GO

/*
	Estrutura JOIN

	SELECT coluna 1, coluna2,...
	FROM tabela1
	Tipo JOIN tabela2
	ON tablea1.campo1 = tabela2.campo2;
	GO

	obs.: On é a relação e deve conter uma PK e uma FK
*/

SELECT * FROM Genero;
GO

SELECT * FROM Filme;
GO

SELECT TituloFilme, NomeGenero
FROM Filme
LEFT JOIN Genero
ON Filme.IdGenero = Genero.IdGenero;
GO

SELECT TituloFilme, NomeGenero
FROM Filme
RIGHT JOIN Genero
ON Filme.IdGenero = Genero.IdGenero;
GO

SELECT TituloFilme, NomeGenero
FROM Filme
INNER JOIN Genero
ON Filme.IdGenero = Genero.IdGenero;
GO

SELECT TituloFilme, NomeGenero
FROM Filme
FULL OUTER JOIN Genero
ON Filme.IdGenero = Genero.IdGenero;
GO