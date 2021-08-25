 Use Unidas;
 GO

 INSERT INTO Pessoa(Nome)
 VALUES ('Saulo'), ('João'), ('Pedro');
 GO

 --SELECT * FROM Pessoa;
 --GO

 INSERT INTO CNH(IdPessoa, Descricao)
 VALUES (1, '9999999'), (3, '8888888'), (2, '7777777');
 GO

 --SELECT * FROM CNH;
 --GO

 UPDATE CNH SET IdPessoa = 2 WHERE IdPessoa = 3;
 GO

 DELETE FROM CNH WHERE IdCNH = 3;
 GO

 INSERT INTO CNH(IdPessoa, Descricao)
 VALUES (3, '777777');
 GO

 INSERT INTO Email(IdPessoa, EnderecoEmail)
 VALUES (3, 'Pedroemail@gmail.com'), (1, 'Saulo@gmail.com'), (2, 'joao@gmail.com');
 GO

 INSERT INTO Email(IdPessoa, EnderecoEmail)
 VALUES (1, 'SauloSENAI@gmail.com');
 GO

 --SELECT * FROM Email;
 --GO

 INSERT INTO Telefone(IdPessoa, NumeroTelefone)
 VALUES (3, '11940028922'), (1, '11986868784'), (2, '1191924576');
 GO

 --SELECT * FROM Telefone;
 --GO