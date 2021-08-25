USE Unidas;
GO

SELECT * FROM Pessoa;
GO

 SELECT * FROM CNH;
 GO

 SELECT * FROM Email;
 GO

 SELECT * FROM Telefone;
 GO

 SELECT Nome, NumeroTelefone, EnderecoEmail, Descricao
 FROM Pessoa
 LEFT JOIN Telefone
 ON Pessoa.IdPessoa = Telefone.IdPessoa
 LEFT JOIN Email
 ON Pessoa.IdPessoa = Email.IdPessoa
 LEFT JOIN CNH
 ON Pessoa.IdPessoa = CNH.IdPessoa
 ORDER BY Nome desc;
 GO