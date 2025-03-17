/*
Question 3:
Show dishes with prices for a specific restaurant
We have two tables: Restaurant and Dishes. The Restaurant table contains information about different restaurants, including their names. The Dishes table contains information about various dishes, including their names, prices, and the restaurant they belong to.

Now write a query to retrieve all the dishes with their respective prices that belong to the restaurant 'Punjabi Rasoi'.



Sample Output:

DishName	Price
Dal Makhni	120


*/

-- Write your query below
SELECT D.DishName, D.Price
FROM Dishes D
JOIN Restaurant R ON D.RestaurantId = R.Id
WHERE R.Name = 'Punjabi Rasoi';
