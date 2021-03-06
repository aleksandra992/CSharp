/****** Script for SelectTopNRows command from SSMS  ******/
--4.Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
USE TelerikAcademy
SELECT * 
FROM Departments

--5.Write a SQL query to find all department names.
SELECT Name
FROM Departments

--6.Write a SQL query to find the salary of each employee.
SELECT e.FirstName,e.LastName, e.Salary
FROM Employees e


--7.Write a SQL to find the full name of each employee.

SELECT e.FirstName+' '+e.LastName as [Full Name]
FROM Employees e

--8.Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresse
SELECT e.FirstName+'.'+e.LastName+'@telerik.com' as [Full Name Address] 
FROM Employees e

--9.Write a SQL query to find all different employee salaries.
SELECT DISTINCT e.Salary
FROM Employees e
 
--10.Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT *
FROM Employees e
WHERE e.JobTitle='Sales Representative'

--11.Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT e.FirstName+' '+e.LastName
FROM Employees e
WHERE e.FirstName LIKE 'SA%'

--12.Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT e.FirstName+' '+e.LastName
FROM Employees e
WHERE e.LastName LIKE '%ei%'

--13.Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT e.Salary
FROM Employees e
WHERE e.Salary>20000 AND e.Salary<30000

--14.Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT e.FirstName+' '+e.LastName, e.Salary
FROM Employees e
WHERE e.Salary IN (25000, 14000, 12500, 23600)

--15.Write a SQL query to find all employees that do not have manager.
SELECT *
FROM Employees e
WHERE e.ManagerID IS NULL

--16.Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT *
FROM Employees e
WHERE e.Salary>50000
ORDER BY e.Salary DESC

--17.Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 *
FROM Employees e
ORDER BY e.Salary DESC

--18.Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT e.FirstName,e.LastName,a.AddressText
FROM Employees e
 INNER JOIN Addresses a
 ON e.AddressID=a.AddressID

 --19.Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
 SELECT e.FirstName,e.LastName, a.AddressText
 FROM Employees e, Addresses a
 WHERE e.AddressID=a.AddressID

 --20.Write a SQL query to find all employees along with their manager.
 SELECT e.FirstName as [Employee Name], m.FirstName as [Manager Name]
 FROM Employees e
 INNER JOIN Employees m
 ON  e.ManagerID=m.EmployeeID

 --21.Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
 SELECT e.FirstName,m.FirstName As[Manager Name],a.AddressText as [Employee Address]
 FROM Employees e
 JOIN Employees m
 ON e.ManagerID=m.EmployeeID
 JOIN Addresses a
 ON e.AddressID=a.AddressID

 --22.Write a SQL query to find all departments and all town names as a single list. Use UNION.
 SELECT d.Name as [Name]
 FROM Departments d
 UNION
 SELECt t.Name as [Name]
 FROM Towns t

 --23.Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
 SELECT  m.FirstName as [Manager Name],ISNULL(e.FirstName ,'has no employees to manage') as [Employee Name]
 FROM Employees e
 RIGHT OUTER JOIN Employees m
 ON  e.ManagerID=m.EmployeeID

 SELECT e.FirstName as [Employee Name],ISNULL(m.FirstName,'has no manager') as [Manager Name]
 FROM Employees e
 LEFT OUTER JOIN Employees m
 ON  e.ManagerID=m.EmployeeID

 --24.Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
 SELECT e.FirstName +' '+e.LastName as [Employee],d.Name,e.HireDate
 FROM Employees e
 INNER JOIN Departments d
 ON e.DepartmentID=d.DepartmentID AND d.Name IN('Sales','Finance')
 WHERE e.HireDate BETWEEN '1995-01-01 00:00:00' AND '2005-12-31 00:00:00'