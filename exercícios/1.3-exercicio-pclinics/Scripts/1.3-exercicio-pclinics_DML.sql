USE Pclinics;
GO

INSERT INTO Clinica(NomeClinica, Endereco, RazaoSocial)
VALUES ('Clinipet', 'Rua Andrade Xavier numº12', 'Clinipet clinica veterinaria');
GO

--SELECT * FROM Clinica;
--GO

INSERT INTO Veterinario(IdClinica, NomeVeterinario, CRMV)
VALUES (2, 'Lucas', '1342SP'), (2, 'Saulo', '9871SP'), (2, 'Odirlei', '2768SP'),(2, 'Thiago', '2667SP');
GO

--SELECT * FROM Veterinario;
--GO

INSERT INTO Dono(NomeDono)
VALUES ('Caio'), ('Rodrigo'), ('Matheus');
GO

--SELECT * FROM Dono;
--GO

INSERT INTO TipoPet(NomeTipoPet)
VALUES ('Cachorro'), ('Gato'), ('Pássarp');
GO

UPDATE TipoPet SET NomeTipoPet = 'Pássaro' WHERE IdTipoPet = 3;

--SELECT * FROM TipoPet;
--GO

INSERT INTO Raca(IdTipoPet, NomeRaca)
VALUES (1, 'Poodle'), (1, 'Golden'), (1, 'Husky');
GO 

--SELECT * FROM Raca;
--GO

INSERT INTO Pet(IdDono, IdRaca, NomePet, DataNascimento)
VALUES (3, 1, 'Auau', '2012-08-26'), (1, 3, 'Lobão', '2014-06-28'), (2,2, 'Rapi', '2018-05-10');
GO

--SELECT * FROM Pet;
--GO

INSERT INTO Consulta(IdVeterinario, IdPet, DataConsulta, DescricaoConsulta)
VALUES (2, 3, '20210703 01:30:44 PM', 'Operação da pata que o pet fraturou'), (3, 2, '20210703 02:30:44 PM', 'Cirurgia nos olhos do pet, este que já não enxergava muito bem por conta da velhice'),
(4, 1, '20210710 10:40:44 AM', 'Ultrassom rotineiro'), (5,2, '20210726 08:30:44 AM', 'Consulta para ver se o pet estava bem e sem complicações após a cirurgia');
GO

--SELECT * FROM Consulta;
--GO