/*
Question 2:
Total Quantity of Spare Parts for a Vehicle Model
We have a table named SpareParts that contains information about various spare parts, including the quantity available and the vehicle model they belong to.

Now, write a SQL query to get the total quantity of all spare parts for a particular vehicle model.

*/

-- Write your query below
SELECT SUM(Quantity) AS TotalQuantity
FROM spareparts
WHERE Model = 'four';  -- Replace 'four' with the desired vehicle model
