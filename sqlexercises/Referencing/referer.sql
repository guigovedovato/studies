SELECT i.Id, i.Created, c.FullName, r.FullName AS Referer
FROM Invoice i
INNER JOIN Customer c ON i.CustomerId = c.Id
INNER JOIN Customer r ON c.CustomerId = r.Id
ORDER BY i.Created
