USE optus;
GO

INSERT INTO Empresa(NomeEmpresa)
VALUES ('optus');
GO

--SELECT * FROM Empresa;
--GO

INSERT INTO Usuario(IdEmpresa, NomeUsuario, Email, Senha, TipoPermissao)
VALUES (1, 'Gustavo', 'sgustavo.borges10@gmail.com', '123456', 1), (1, 'Cleber', 'clebinhoemail@gmail.com', '654321', 0);
GO

--SELECT * FROM Usuario;
--GO

INSERT INTO Artista(IdEmpresa, NomeArtista)
VALUES (1, 'Tyler'), (1, 'Cuco'), (1, 'Joji');
GO

--SELECT * FROM Artista;
--GO

INSERT INTO Estilo(NomeEstilo)
VALUES ('Pop'), ('Rock'), ('Indie'), ('Jazz');
GO

--SELECT * FROM Estilo;
--GO

INSERT INTO Album(IdArtista, TituloAlbum, DataLancamento, Localizacao, Tempo, Visivel)
VALUES (2, 'Chiquito', '2018-05-03', 'California', '22:54', 1),
(1, 'Blurryface', '2015-05-17', 'Nova Iorque', '52:17', 1), (3, 'Nectar', '2020-09-25', 'Osaka', '53:05', 1);
GO

--SELECT * FROM Album;
--GO

INSERT INTO EstiloAlbum(IdAlbum, IdEstilo)
VALUES (1, 3), (1,1), (2,1), (2,2), (3,1), (3,3);
GO

--SELECT * FROM EstiloAlbum;
--GO
