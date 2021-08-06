USE Locadora;
GO

SELECT * FROM Empresa;
GO

SELECT * FROM Cliente;
GO

SELECT * FROM Marca;
GO

SELECT * FROM Modelo;
GO

SELECT * FROM Veiculo;
GO

SELECT * FROM Aluguel;
GO

SELECT DataRetirada, DataDevolucao, NomeCliente, NomeModelo
FROM Aluguel
LEFT JOIN Cliente
ON Aluguel.IdCliente = Cliente.IdCliente
LEFT JOIN Veiculo
ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
LEFT JOIN Modelo
ON Veiculo.IdModelo = Modelo.IdModelo;
GO

SELECT NomeCliente, DataRetirada, DataDevolucao, NomeModelo
FROM Aluguel
RIGHT JOIN Cliente
ON Aluguel.IdCliente = Cliente.IdCliente
LEFT JOIN Veiculo
ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
LEFT JOIN Modelo
ON Veiculo.IdModelo = Modelo.IdModelo
WHERE NomeCliente = 'Thiago';
GO