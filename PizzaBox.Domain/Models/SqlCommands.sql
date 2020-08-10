use PizzaBoxDb
go
USE master
go

create DATABASE PizzaBoxDb
go
drop DATABASE PizzaBoxDb
go


INSERT INTO Crusts ([Name], price)
Values ('Normal',7.00);
go
INSERT INTO Sizes ([Name], size, price)
Values ('Smol(Small)',10,7.00);
go
INSERT Into Toppings([Name],Price)
Values
go
-- Delete rows from table 'TableName'
DELETE FROM Sizes
WHERE 	Id = 2/* add search conditions here */
GO
Select *
From Crusts;
go
Select *
From Sizes;
go