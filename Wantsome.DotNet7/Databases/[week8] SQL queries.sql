CREATE DATABASE AwesomeDatabase;

USE AwesomeDatabase;

CREATE TABLE Books
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Title VARCHAR(150),
YearOfPublishing INT,
NumberOfPages INT,
HardCover BIT,
);

ALTER TABLE Books
ADD ReadyToBeSaled INT;

ALTER TABLE Books
ALTER COLUMN ReadyToBeSaled BIT;

ALTER TABLE Books
DROP COLUMN ReadyToBeSaled;

DROP TABLE Books;

CREATE TABLE Persons (
Id INT NOT NULL UNIQUE,
LastName VARCHAR(255) NOT NULL,
FirstName VARCHAR(255) NOT NULL,
Age INT CHECK (Age>=18),
City VARCHAR(255) DEFAULT 'Bucuresti',
);

INSERT INTO Books(Title, YearOfPublishing, NumberOfPages, HardCover)
VALUES('Cats', 2022, 200, 1);

INSERT INTO Books(Title, YearOfPublishing, NumberOfPages, HardCover)
VALUES('Cats123', 2020, 123, 0);

INSERT INTO Persons
VALUES(1, 'Ana', 'Maria', 19, 'Brasov');

-- error because of duplicated id
INSERT INTO Persons
VALUES(1, 'Ana', 'Maria', 19, 'Brasov');

-- error because of NULL LastName
INSERT INTO Persons
VALUES(2, NULL, 'Maria', 19, 'Brasov');

-- error because of too small age
INSERT INTO Persons
VALUES(2, 'Ana', 'Maria', 15, 'Brasov');

-- works with default 'Bucuresti' as City
INSERT INTO Persons
VALUES(2, 'Ana', 'Maria', 25);

INSERT INTO Persons (Id, LastName, FirstName, Age)
VALUES(3, 'Ana', 'Maria', 25);

SELECT Id, Title, YearOfPublishing
FROM Books;

SELECT * 
FROM Books;

SELECT *
FROM Persons;

SELECT Id, Title, YearOfPublishing
FROM Books
WHERE YearOfPublishing > 2020;

SELECT *
FROM Books
WHERE HardCover = 1;

SELECT *
FROM Books
WHERE HardCover = 0;

SELECT Title, LastName, FirstName
FROM Books, Persons;

SELECT Title, (SELECT LastName from Persons WHERE id = 1)
FROM Books;

UPDATE Books
SET YearOfPublishing = 2000;

UPDATE Books
SET YearOfPublishing = 2025 
WHERE Id = 1;

DELETE
FROM Books;

DELETE
FROM Books
WHERE YearOfPublishing > 2021;

-- The following database structure is the one from the PDF
CREATE TABLE Addresses
(
Id INT IDENTITY(1,1) PRIMARY KEY,
StreetName VARCHAR(100),
StreetNumber INT,
City VARCHAR(50),
)

CREATE TABLE Customers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(150),
Age INT,
AddressId INT REFERENCES Addresses(Id)
)

CREATE TABLE Orders
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Details VARCHAR(150),
CustomerId INT REFERENCES Customers(Id)
)

CREATE TABLE Products
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(150)
)

CREATE TABLE Orders_Products
(
Id INT IDENTITY(1,1) PRIMARY KEY,
OrderId INT REFERENCES Orders(Id),
ProductId INT REFERENCES Products(Id)
)

-- Insert the value you see on the PPT slide into you tables
-- Make sure they are inserted by displaying them

INSERT INTO Addresses
VALUES ('Independentei', 10, 'Iasi');
INSERT INTO Addresses
VALUES ('Eroilor', 34, 'Brasov');
INSERT INTO Addresses
VALUES ('Unirii', 53, 'Bucuresti');

SELECT *
FROM Addresses;

INSERT INTO Customers
VALUES ('Nico', 20, 1);
INSERT INTO Customers
VALUES ('Alex', 30, 2);
INSERT INTO Customers
VALUES ('Daniel', 40, 3);

SELECT *
FROM Customers;

INSERT INTO Orders
VALUES ('First Order for Nico', 1);
INSERT INTO Orders
VALUES ('Second Order for Nico', 1);
INSERT INTO Orders
VALUES ('First Order for Alex', 2);
INSERT INTO Orders (Details)
VALUES ('First Order for Unknown');

SELECT *
FROM Orders;

INSERT INTO Products
VALUES ('Book about cats');
INSERT INTO Products
VALUES ('Book about c# development');
INSERT INTO Products
VALUES ('Book about databases');
INSERT INTO Products
VALUES ('Book about neuroscience');

SELECT * 
FROM Products;

INSERT INTO Orders_Products
VALUES (1, 1);
INSERT INTO Orders_Products
VALUES (1, 2);
INSERT INTO Orders_Products
VALUES (2, 4);
INSERT INTO Orders_Products
VALUES (3, 1);

SELECT * 
FROM Orders_Products;

-- SELECT & operators
SELECT 30 + 20;

SELECT *
FROM Customers
WHERE Age <> 20;

SELECT * 
FROM Customers
WHERE AddressId = ALL (SELECT Id from Addresses WHERE City = 'Brasov');

SELECT * 
FROM Customers
WHERE AddressId = 1 AND Age > 25;

SELECT * 
FROM Customers
WHERE AddressId = 1 OR Age > 25;

SELECT * 
FROM Customers
WHERE Age BETWEEN 15 AND 25;

SELECT * 
FROM Customers
WHERE Age IN (15, 25, 40);

SELECT * 
FROM Addresses
WHERE City LIKE 'Br%';

SELECT * 
FROM Addresses
WHERE City LIKE '%a%';

SELECT * 
FROM Addresses
WHERE City NOT LIKE '%a%';

-- UNION
SELECT Name, Age FROM Customers
UNION
SELECT City, StreetNumber FROM Addresses;

-- JOINS
SELECT *
FROM Customers
INNER JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
RIGHT JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT *
FROM Customers
FULL OUTER JOIN Orders ON Customers.Id = Orders.CustomerId;

-- ALIASES
SELECT Id as CustomerIdentifier, Name
FROM Customers;

SELECT Name, Details
FROM Customers
FULL OUTER JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT Id, Name, Details
FROM Customers
FULL OUTER JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT Customers.Id, Customers.Name, Orders.Details
FROM Customers
FULL OUTER JOIN Orders ON Customers.Id = Orders.CustomerId;

SELECT c.Id, c.Name, o.Details
FROM Customers c
FULL OUTER JOIN Orders o ON c.Id = o.CustomerId;

-- AGGREGATE FUNCTIONS
SELECT AVG(Age)
FROM Customers;

SELECT COUNT(Name) AS NumberOfCustomers
FROM Customers;

SELECT MAX(Age)
FROM Customers;

SELECT MIN(Name) 
FROM Customers;

SELECT SUM(Age)
FROM Customers;

SELECT SUM(Name)
FROM Customers;

-- ORDER BY, GROUP BY, HAVING
SELECT *
FROM Customers
ORDER BY Age DESC;

INSERT INTO Addresses
VALUES ('Eroilor', 23, 'Brasov');
INSERT INTO Addresses
VALUES ('Aviatiei', 12, 'Brasov');

SELECT *
FROM Addresses;

SELECT StreetName, COUNT(StreetName), City
FROM Addresses
GROUP BY StreetName, City;

SELECT StreetName, COUNT(StreetName), City
FROM Addresses
GROUP BY StreetName, City
HAVING StreetName = 'Eroilor';

SELECT StreetName, COUNT(StreetName), City
FROM Addresses
GROUP BY StreetName, City
HAVING City = 'Brasov';

-- STORED PROCEDURES
GO
CREATE PROCEDURE HelloWorldProcedure
AS
BEGIN
    PRINT 'Hello World';
    PRINT 'my test procedure';
    SELECT * FROM Customers;
END
GO

-- call the procedure
exec HelloWorldprocedure;

DROP PROCEDURE HelloWorldProcedure;

GO
CREATE PROCEDURE GetCustomerNameByIdProcedure(
    @customerId INT)
AS
BEGIN
    SELECT Name FROM Customers WHERE id = @customerId;
END
GO

-- call the procedure
exec GetCustomerNameByIdProcedure 2;

DROP PROCEDURE GetCustomerNameByIdProcedure;

-- FUNCTIONS
GO
CREATE FUNCTION dbo.HelloWorldFunction()
RETURNS varchar(20)
AS
BEGIN
    RETURN 'Hello world'
END;
GO

-- call the function
select dbo.HelloWorldFunction();

DROP FUNCTION dbo.HelloWorldFunction;

GO
CREATE FUNCTION dbo.GetCustomerIdByNameFunction()
RETURNS varchar(20)
AS
BEGIN
    DECLARE @identifier INT;
    SET @identifier = (SELECT id FROM Customers WHERE Name = 'Nico');
    RETURN @identifier;
END;
GO

-- call the function
select dbo.GetCustomerIdByNameFunction();

DROP FUNCTION dbo.GetCustomerIdByNameFunction;

GO
CREATE FUNCTION dbo.GetCustomerNameByIdFunction(
    @customerId INT)
RETURNS varchar(20)
AS
BEGIN
    DECLARE @identifier VARCHAR(200);
    SET @identifier = (SELECT Name FROM Customers WHERE Id = @customerId);
    RETURN @identifier;
END;
GO

-- call the function
select dbo.GetCustomerNameByIdFunction(1);
select dbo.GetCustomerNameByIdFunction(2);
select dbo.GetCustomerNameByIdFunction(3) AS CustomerName;

DROP FUNCTION dbo.GetCustomerNameByIdFunction;