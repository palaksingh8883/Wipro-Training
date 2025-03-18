/*
Question 1:
Books Priced at $10 and Above
Write an SQL query to retrieve the book titles and customer names for the books priced at $10 and above that have been ordered. 
Use the goodreads and orders tables

*/

-- Write your query below
SELECT g.book_title, o.customer_id
FROM goodreads g
JOIN orders o ON g.book_id = o.book_id
WHERE g.price >= 10;
