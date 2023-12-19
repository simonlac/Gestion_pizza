USE MASTER
GO 
DROP DATABASE Gestion_Pizzeria
GO
-- Création de la base de données Gestion_Pizza
CREATE DATABASE Gestion_Pizzeria
GO
USE Gestion_Pizzeria
GO
-- Création de la table Pizzas
CREATE TABLE Pizzas (
PizzaID CHAR(3) PRIMARY KEY,
Type_Pizza VARCHAR(50),
Prix_Pizza int,
)
GO
-- Création de la table Commandes
CREATE TABLE Commandes (
CommandesID CHAR(6) PRIMARY KEY,
Nb_Pizzas INT,
Date_Commande Date,
PizzaID Char(3),
FOREIGN KEY(PizzaID) REFERENCES Pizzas(PizzaID)
)
GO
---PEUPLER TABLE Pizzas
INSERT INTO Pizzas VALUES
('001','Napolitaine',12),
('002','Végétarienne',15),
('003','Hawaienne',14)


---PEUPLER TABLE Commandes
INSERT INTO Commandes VALUES
('L00111',2, '12/12/2023','001'),
('A00121',3,'18/12/2023','002'),
('M00123',2,'15/12/2023', '003')


---VISIONNER LES TABLES 
SELECT * FROM Pizzas
SELECT * FROM Commandes
Select CommandesID,Commandes.PizzaID, Date_Commande,Nb_Pizzas From Pizzas inner join Commandes
On Pizzas.PizzaID = Commandes.PizzaID

 
-- Procédure stockée
CREATE PROCEDURE obtenir_commandes_apres_date
    @date DATE
AS
BEGIN
   SELECT * FROM Commandes WHERE Date_Commande >=@date;
END;

-- Exécuter la procédure stockée obtenir_commandes_apres_date
Exec obtenir_commandes_apres_date @date = "16-12-2023"