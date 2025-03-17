/*
Question 1:
Establishing Foreign Key Relationship in MySQL
We do have two tables named Department and Employee tables. the task at hand is to create a foreign key relationship with respect to Department table with Employee table.

Note: Due to SQLite compatibility, we can't make use of ALTER TABLE ADD FOREIGN KEY constraint. Instead, create a new table with name "Employees" by enabling the Foreign Key constraint in the table creation and then Insert the respective values of "Employee" table into the "Employees" table and drop the table the "Employee" table.



Input:

Department Table:

+---------------+-----------------+
| department_id | department_name |
+---------------+-----------------+
| 1		| HR	          |
| 2		| IT	          |
| 3		| Marketing       |
+---------------+-----------------+
Employee Table:

+---------------+------------+------------+---------------+
| employee_id   | first_name | last_name  | department_id |
+---------------+------------+------------+---------------+
| 1		| John	     | Doe	  | 2		  |
| 2		| Jane	     | Smith	  | 1		  |
| 3		| Bob	     | Johnson	  | 3		  |
| 4		| Alice	     | Williams	  | 1		  |
+---------------+------------+------------+---------------+


Output:

Employees Table:

+---------------+------------+------------+---------------+
| employee_id   | first_name | last_name  | department_id |
+---------------+------------+------------+---------------+
| 1		| John	     | Doe	  | 2		  |
| 2		| Jane	     | Smith	  | 1		  |
| 3		| Bob	     | Johnson	  | 3		  |
| 4		| Alice	     | Williams	  | 1		  |
+---------------+------------+------------+---------------+

*/

DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;

CREATE TABLE Departments (
  department_id INT PRIMARY KEY,
  department_name VARCHAR(50)
);

INSERT INTO Departments (department_id, department_name) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Marketing');

CREATE TABLE Employee (
  employee_id INT PRIMARY KEY,
  first_name VARCHAR(50),
  last_name VARCHAR(50),
  department_id INT
);

INSERT INTO Employee (employee_id, first_name, last_name, department_id) VALUES
(1, 'John', 'Doe', 2),
(2, 'Jane', 'Smith', 1),
(3, 'Bob', 'Johnson', 3),
(4, 'Alice', 'Williams', 1);

CREATE TABLE Employees (
  employee_id INT PRIMARY KEY,
  first_name VARCHAR(50),
  last_name VARCHAR(50),
  department_id INT,
  FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);

INSERT INTO Employees (employee_id, first_name, last_name, department_id)
SELECT employee_id, first_name, last_name, department_id
FROM Employee;

DROP TABLE Employee;
