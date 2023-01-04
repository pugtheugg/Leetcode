-- 183. Customers Who Never Order
-- https://leetcode.com/problems/customers-who-never-order

SELECT Customers.name as "Customers"
FROM Customers 
WHERE NOT EXISTS 
    (SELECT *
    FROM Orders
    WHERE Customers.id = Orders.customerId);