IF DB_ID('HackCompany') IS NULL
	CREATE DATABASE HackCompany
GO

USE HackCompany
IF OBJECT_ID('dbo.[Department]') IS NULL
CREATE TABLE dbo.[Department]
(
	DepartmentID int NOT NULL PRIMARY KEY,
	Name NVARCHAR(25) NOT NULL,	
)
IF OBJECT_ID('dbo.[Employee]') IS NULL
CREATE TABLE dbo.[Employee]
(
	EmployeeID int NOT NULL PRIMARY KEY,
	Name nvarchar(40) NOT NULL,
	Email NVARCHAR(25) NOT NULL,
	BirthDate DATE NOT NULL,
	Manager int FOREIGN KEY REFERENCES Employee(EmployeeID),
	Department int,
	FOREIGN KEY (Department) REFERENCES Department(DepartmentID)
)
IF OBJECT_ID('dbo.[ProductCategories]') IS NULL
CREATE TABLE dbo.[ProductCategories]
(
	CategoryID NCHAR(3) NOT NULL PRIMARY KEY,
	Name NVARCHAR(25) NOT NULL
)

IF OBJECT_ID('dbo.[Products]') IS NULL
CREATE TABLE dbo.[Products]
(
	ProductID INT PRIMARY KEY,
	Name NVARCHAR(40),
	Price MONEY NOT NULL,
	CategoryID NCHAR(3) NOT NULL FOREIGN KEY REFERENCES ProductCategories(CategoryID)
)
IF OBJECT_ID('dbo.[Customers]') IS NULL
CREATE TABLE dbo.[Customers]
(
	CustomerID INT NOT NULL PRIMARY KEY,
	Name nvarchar(25) NOT NULL,
	Email NVARCHAR(25) NOT NULL,
	[Adress] NVARCHAR(40) NOT NULL,
	Discount FLOAT 
)
IF OBJECT_ID('dbo.[Orders]') IS NULL
CREATE TABLE dbo.[Orders]
(
	OrderID INT NOT NULL PRIMARY KEY,
	DateOfOrder DATETIME NOT NULL,
	TotalPrice MONEY NOT NULL, 
	CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerID)
)
IF OBJECT_ID('dbo.[OrderProducts]') IS NULL
CREATE TABLE dbo.[OrderProducts]
(
	OrderID INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
	ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ProductID)
)
