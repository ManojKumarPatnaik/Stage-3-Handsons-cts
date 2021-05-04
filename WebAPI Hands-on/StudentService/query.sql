create database EmployeeDB
GO

use EmployeeDB
Go

create table Employees (
ID int PRIMARY KEY IDENTITY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Gender NVARCHAR(15) NOT NULL,
Salary int
)
GO

INSERT INTO Employees values ('John','Smith','Male', 60000)
INSERT INTO Employees values ('Suzi','Bates','Female', 50000)
INSERT INTO Employees values ('Jason','Roy','Male', 70000)
INSERT INTO Employees values ('Sarah','Taylor','Female', 65000)
INSERT INTO Employees values ('David','Miller','Male', 45000)
Go

select * from Employees