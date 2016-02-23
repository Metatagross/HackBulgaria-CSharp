SELECT Person.Person.FirstName
FROM Person.Person

SELECT FirstName, LastName, Person.[Address].City
FROM Person.Person
JOIN Person.BusinessEntityAddress on BusinessEntityAddress.BusinessEntityID=Person.BusinessEntityID
Join Person.[Address] on BusinessEntityAddress.AddressID=[Address].AddressID
WHERE City != 'Payson'

SELECT *
FROM HumanResources.Employee
WHERE DATEADD(yy, 40, BirthDate)<GETDATE()

SELECT FirstName, LastName
FROM Person.Person
WHERE LastName LIKE '%ay'

SELECT FirstName, LastName
FROM Person.Person
WHERE FirstName = 'Mary'


SELECT FirstName, LastName
FROM Person.Person
WHERE FirstName LIKE '%mary%'

SELECT FirstName, LastName
FROM Person.Person
WHERE FirstName = 'Lydia' AND LastName = 'Weber'

UPDATE Person.Person
SET LastName = 'Weber-Williams'
WHERE FirstName = 'Lydia' AND LastName = 'Weber'

UPDATE HumanResources.Employee
SET JobTitle='Administrative Assistant'
WHERE JobTitle='Secretary'

Select *
FROM HumanResources.Employee
WHERE JobTitle LIKE 'A%' 