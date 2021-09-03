USE CATALOGO;
GO

CREATE TABLE Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY(1,1),
	Email VARCHAR(256) NOT NULL,
	Senha VARCHAR(10) NOT NULL,
	Permissao VARCHAR(50)
); 
GO

INSERT INTO Usuario(Email, Senha, Permissao) VALUES ('sgustavo.borges10@gamil.com', '123456', 'admnistrador');

SELECT IdUsuario, Email, Senha, Permissao FROM Usuario WHERE Email = 'sgustavo.borges10@gmail.com' AND Senha = '123456';

UPDATE Usuario SET Email = 'sgustavo.borges10@gmail.com' WHERE IdUsuario = 1;