CREATE DATABASE CATALOGO;
GO

USE CATALOGO;
GO

CREATE TABLE Genero(
	IdGenero TINYINT PRIMARY KEY IDENTITY(1,1),
	NomeGenero VARCHAR(30)
);
GO

--(1,1) inicia com 1 e dps vai adicionando 1 a cada

CREATE TABLE Filme(
	IdFilme INT PRIMARY KEY IDENTITY(1,1),
	IdGenero TINYINT FOREIGN KEY REFERENCES Genero(IdGenero),
	TituloFilme VARCHAR(70)
);

