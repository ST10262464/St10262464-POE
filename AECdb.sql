CREATE DATABASE AgriEnergyConnectDB;
GO

USE AgriEnergyConnectDB;

CREATE TABLE Farmers (
    FarmerId INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    PasswordHash NVARCHAR(MAX)
);

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY,
    FarmerId INT,
    Name NVARCHAR(100),
    Category NVARCHAR(50),
    ProductionDate DATE,
    FOREIGN KEY (FarmerId) REFERENCES Farmers(FarmerId)
);

CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    PasswordHash NVARCHAR(MAX)
);

INSERT INTO Farmers (FullName, Email, PasswordHash)
VALUES
('Shivon Prawlall', 'sp@mail.com', 'pass1'),
('Shae Lyn', 'shae@mail.com', 'pass2'),
('Rudi Hannie', 'rudi@mail.com', 'pass3');

INSERT INTO Products (FarmerId, Name, Category, ProductionDate)
VALUES
(12, 'Apple', 'Fruit', '2025-03-01'),
(13, 'Carrot', 'Vegetable', '2025-04-15'),
(14, 'Tomato', 'Vegetable', '2025-05-10');

INSERT INTO Employees (FullName, Email, PasswordHash)
VALUES
('Alice Brown', 'alice@mail.com', 'passA'),
('Bob Green', 'bob@mail.com', 'passB'),
('Charlie White', 'charlie@mail.com', 'passC');




SELECT * FROM Farmers;
SELECT * FROM Products;
SELECT * FROM Employees;
