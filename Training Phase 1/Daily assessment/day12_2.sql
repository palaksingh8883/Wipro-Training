/*
Question 2:
Top Countries by Films Rented
Write a query to find the top 3 countries by the total number of films rented by customers living in those countries.



Sample Output:

Country_id   Country 	rental_count
 
   44	       India	1572


*/

-- Write your query below
SELECT 
    co.country_id,
    co.country,
    COUNT(r.rental_id) AS rental_count
FROM rental r
JOIN customer c ON r.customer_id = c.customer_id
JOIN address a ON c.address_id = a.address_id
JOIN city ci ON a.city_id = ci.city_id
JOIN country co ON ci.country_id = co.country_id
GROUP BY co.country_id, co.country
ORDER BY rental_count DESC
LIMIT 3;
