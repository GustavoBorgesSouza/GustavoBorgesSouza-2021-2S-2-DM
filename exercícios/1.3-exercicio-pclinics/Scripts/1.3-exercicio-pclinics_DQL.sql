USE Pclinics;
GO

SELECT * FROM Clinica;
GO

SELECT * FROM Veterinario;
GO

SELECT * FROM Dono;
GO

SELECT * FROM TipoPet;
GO

SELECT * FROM Raca;
GO

SELECT * FROM Pet;
GO

SELECT * FROM Consulta;
GO

SELECT NomeVeterinario, RazaoSocial
FROM Veterinario
LEFT JOIN Clinica
ON Veterinario.IdClinica = Clinica.IdClinica
WHERE Clinica.RazaoSocial = 'Clinipet clinica veterinaria';
GO

SELECT * FROM Raca WHERE NomeRaca LIKE 'H%';
GO
SELECT * FROM Raca WHERE NomeRaca LIKE 'S%';
GO

SELECT * FROM Raca WHERE NomeRaca LIKE '%O';
GO
SELECT * FROM Raca WHERE NomeRaca LIKE '%N';
GO

SELECT NomePet, NomeDono
FROM Pet
LEFT JOIN Dono
ON Pet.IdDono = Dono.IdDono;
GO

SELECT NomeVeterinario, NomePet, NomeRaca, NomeTipoPet, NomeClinica, DescricaoConsulta
FROM Consulta 
LEFT JOIN Veterinario
ON Consulta.IdVeterinario = Veterinario.IdVeterinario
LEFT JOIN Pet
ON Consulta.IdPet = Pet.IdPet
LEFT JOIN Raca 
ON Pet.IdRaca = Raca.IdRaca
LEFT JOIN TipoPet
ON Raca.IdTipoPet = TipoPet.IdTipoPet
LEFT JOIN Dono
ON Pet.IdDono = Dono.IdDono
LEFT JOIN Clinica
ON Veterinario.IdClinica = Clinica.IdClinica;
GO