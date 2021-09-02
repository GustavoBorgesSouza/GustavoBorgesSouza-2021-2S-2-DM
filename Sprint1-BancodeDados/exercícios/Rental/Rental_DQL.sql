USE GBM_Rental;
GO

SELECT * FROM Empresa;
GO

SELECT * FROM Cliente;
GO

SELECT IdCliente, NomeCliente, SobrenomeCliente, CPF FROM Cliente;
SELECT IdCliente, NomeCliente, SobrenomeCliente, CPF FROM Cliente WHERE IdCliente = 1;



SELECT * FROM Marca;
GO

SELECT * FROM Modelo;
GO

SELECT * FROM Veiculo;
GO

SELECT IdVeiculo, NomeEmpresa, NomeModelo, NomeMarca, CorVeiculo  FROM Veiculo LEFT JOIN Empresa ON Veiculo.IdEmpresa = Empresa.IdEmpresa INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo INNER JOIN Marca ON Modelo.IdMarca = Marca.IdMarca;
SELECT IdVeiculo, NomeEmpresa, NomeModelo, NomeMarca, CorVeiculo  FROM Veiculo LEFT JOIN Empresa ON Veiculo.IdEmpresa = Empresa.IdEmpresa INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo INNER JOIN Marca ON Modelo.IdMarca = Marca.IdMarca WHERE IdVeiculo = 2;

SELECT * FROM Aluguel;
GO

SELECT IdAluguel, NomeCliente, SobrenomeCliente, NomeModelo, CorVeiculo, DataRetirada, DataDevolucao FROM Aluguel INNER JOIN Cliente ON Aluguel.IdCliente = Cliente.IdCliente INNER JOIN Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo;

SELECT IdAluguel, NomeCliente, SobrenomeCliente, NomeModelo, CorVeiculo, DataRetirada, DataDevolucao FROM Aluguel INNER JOIN Cliente ON Aluguel.IdCliente = Cliente.IdCliente INNER JOIN Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo WHERE IdAluguel = 2;


SELECT NomeCliente, DataRetirada, DataDevolucao, NomeModelo
FROM Aluguel
RIGHT JOIN Cliente
ON Aluguel.IdCliente = Cliente.IdCliente
LEFT JOIN Veiculo
ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
LEFT JOIN Modelo
ON Veiculo.IdModelo = Modelo.IdModelo
GO

