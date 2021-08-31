USE GBM_Rental;
GO

INSERT INTO Empresa(NomeEmpresa)
VALUES ('Localiza');
GO

INSERT INTO Cliente(NomeCliente, SobrenomeCliente, CPF)
VALUES ('Odirlei', 'Sabella', '67452289212'), ('Thiago', 'Nascimento' , '71892728634');
GO

INSERT INTO Marca(NomeMarca)
VALUES ('Ford'), ('Fiat'), ('Chevrolet');
GO

INSERT INTO Modelo(IdMarca, NomeModelo, AnoLancamento)
VALUES (3, 'Onix', '2015-12-06'), (1, 'Fiesta', '2014-10-14'), (2, 'Argo', '2017-11-12');
GO

INSERT INTO Veiculo(IdEmpresa, IdModelo, CorVeiculo)
VALUES (1, 1, 'Branco'), (1, 2, 'Preto'), (1, 3, 'Cinza');
GO

INSERT INTO Aluguel(IdVeiculo, IdCliente, DataRetirada, DataDevolucao)
VALUES (1, 1, '2021-07-03', '2021-07-10'), (2, 2, '2021-07-03', '2021-07-05'), (3, 2, '2021-07-06', '2021-07-16');
GO

