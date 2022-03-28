SELECT ProductName, CategoryName
FROM Products
LEFT JOIN Categories
ON Products.CategoryId = Categories.CategoryId;