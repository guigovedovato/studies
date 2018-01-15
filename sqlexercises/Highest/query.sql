-- Select the second highest salary from each department

SELECT MAX(salary), department
FROM `customer` 
WHERE salary NOT IN (
    SELECT Max(salary) 
    FROM `customer`
    GROUP BY department
)
GROUP BY department