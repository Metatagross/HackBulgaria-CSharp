USE HackCompany
GO
Select *
From Employee e
Where e.Manager IS NULL;

GO
SELECT *
FROM Employee
WHERE Manager=1;

GO
Select *
From Employee
Where Department=1
ORDER BY Name;

GO
Select Department.Name, Employee.Name, Employee.BirthDate
From Employee
Join Department On Department.DepartmentID = Employee.Department
Where Employee.BirthDate>'1990-01-01'

GO
Select Department.DepartmentID, COUNT(Employee.EmployeeID) as CountEmployee
From  Department
Join Employee on Employee.Department=Department.DepartmentID
Group by Department.DepartmentID
Having COUNT(Employee.EmployeeID)>3

GO
Select Top 1 Department.DepartmentID,COUNT(Employee.EmployeeID) as CountEmployee
From  Department
Join Employee on Employee.Department=Department.DepartmentID
Group by Department.DepartmentID
Order by COUNT(Employee.EmployeeID) Desc

GO
Select Top 1 OrderProducts.OrderID,COUNT(OrderProducts.ProductID) as CountProducts
From  OrderProducts
Group by OrderProducts.OrderID
Order by COUNT(OrderProducts.ProductID) Desc

GO
SELECT SUM(Customers.Discount)/COUNT(Customers.Discount) as [Average Discount]
FROM Customers

GO
UPDATE Employee
SET BirthDate=DATEADD(YY,1,BirthDate)

GO
UPDATE Customers
SET Discount=2*Discount
WHERE Customers.CustomerId =  (SELECT TOP 1 Orders.CustomerID
								FROM Orders 
								GROUP BY CustomerID
								ORDER BY COUNT(Orders.CustomerID) DESC)

GO 
DELETE FROM Products
WHERE Products.ProductID NOT IN (SELECT OrderProducts.ProductID
								 FROM OrderProducts)