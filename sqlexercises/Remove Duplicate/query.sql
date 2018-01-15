-- Delete duplicate records

DELETE
FROM `customer`
WHERE id IN (
    SELECT MAX(e.id)
    FROM (SELECT * FROM `customer`) e
    GROUP BY e.first_name, e.last_name, e.salary, e.department
    HAVING COUNT(e.id) > 1
)