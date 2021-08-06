USE optus;
GO

SELECT * FROM Empresa;
GO

SELECT * FROM Usuario;
GO

SELECT * FROM Artista;
GO

SELECT * FROM Estilo;
GO

SELECT * FROM Album;
GO

SELECT * FROM EstiloAlbum;
GO

SELECT NomeUsuario,Email 
FROM Usuario WHERE TipoPermissao = 1;
GO

SELECT * FROM Album WHERE DataLancamento > '2015-05-17';
GO

SELECT * FROM Usuario WHERE Email = 'clebinhoemail@gmail.com' AND Senha = '654321';
GO

SELECT  TituloAlbum ,NomeArtista, NomeEstilo
FROM EstiloAlbum
INNER JOIN Album 
ON Album.IdAlbum = EstiloAlbum.IdAlbum
INNER JOIN Artista
ON Artista.IdArtista = Album.IdArtista
LEFT JOIN Estilo 
ON Estilo.IdEstilo = EstiloAlbum.IdEstilo
WHERE Album.Visivel = 1;
GO
