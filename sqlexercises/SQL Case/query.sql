-- Select all customers by name and surname, salary, department
-- must follow:
-- if there are name and surname, show name and surname
-- if there is not name, show only surname
-- if there is not surname, show only name
-- if there are not name and surname, show 'no identification'

SELECT 
CASE
	WHEN first_name is NOT null and last_name is not null THEN Concat(first_name, ' ', last_name)
    WHEN last_name is null and first_name is not null THEN first_name
    WHEN first_name is null and last_name is not null THEN last_name
    WHEN first_name is null and last_name is null THEN 'no identification'
    END AS 'name', salary, department
FROM `customer`