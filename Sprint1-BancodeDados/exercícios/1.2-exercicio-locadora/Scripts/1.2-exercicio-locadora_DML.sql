Use Locadora;
GO

INSERT INTO Empresa(NomeEmpresa)
VALUES ('Localiza');
GO

--SELECT * FROM Empresa;
--GO

INSERT INTO Cliente(NomeCliente, CPF)
VALUES ('Odirlei', '67452289212'), ('Thiago', '71892728634');
GO

--SELECT * FROM Cliente;
--GO

INSERT INTO Marca(NomeMarca)
VALUES ('Ford'), ('Fiat'), ('Chevrolet');
GO

--SELECT * FROM Marca;
--GO

--Selecionei tudo pra ver oq acontecia e deu ruim, IMPORTANTE: fazer um passo de cada vez

DELETE FROM Marca;
GO

INSERT INTO Marca(NomeMarca)
VALUES ('Ford'), ('Fiat'), ('Chevrolet');
GO

INSERT INTO Modelo(IdMarca, NomeModelo, AnoLancamento)
VALUES (6, 'Onix', '2015-12-06'), (4, 'Fiesta', '2014-10-14'), (5, 'Argo', '2017-11-12');
GO

--SELECT * FROM Modelo;
--GO

INSERT INTO Veiculo(IdEmpresa, IdModelo, CorVeiculo)
VALUES (1, 1, 'Branco'), (1, 2, 'Preto'), (1, 3, 'Cinza');
GO

--SELECT * FROM Veiculo;
--GO

INSERT INTO Aluguel(IdVeiculo, IdCliente, DataRetirada, DataDevolucao)
VALUES (1, 1, '2021-07-03', '2021-07-10'), (2, 2, '2021-07-03', '2021-07-05'), (3, 2, '2021-07-06', '2021-07-16');
GO

--SELECT * FROM Aluguel;
--GO