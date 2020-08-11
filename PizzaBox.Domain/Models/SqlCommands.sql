
USE master
go
drop DATABASE PizzaBoxDb
go
create DATABASE PizzaBoxDb
go
use PizzaBoxDb
go



INSERT INTO Crusts ([Name], price)
Values ('Normal',7.00);
go
INSERT INTO Crusts ([Name], price)
Values ('Stuffed',12.00);
go
INSERT INTO Sizes ([Name], size, price)
Values ('Small',10,7.00);
go
INSERT INTO Sizes ([Name], size, price)
Values ('Medium',14,9.00);
go
INSERT INTO ToppingsBase ([Name], price)
Values ('Mozzarella cheese',1.00),
('American cheese',1.00),
('Pepperoni',3.00),
('Pineapple',3.00),
('Gold Flakes',100.00);
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