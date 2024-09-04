CREATE TABLE Products (
product_id INT PRIMARY KEY,
product_name VARCHAR(255)
);

INSERT INTO Products
VALUES
(1, 'Realme 11 Pro'),
(2, 'Kinder Chocolate'),
(3, 'Toyota Land Cruiser Prado');

CREATE TABLE Categories (
category_id INT PRIMARY KEY,
category_name VARCHAR(255)
);

INSERT INTO Categories
VALUES
(1, 'Food'),
(2, 'Car'),
(3, 'Smartphone');

CREATE TABLE ProductCategories (
product_id INT REFERENCES Products(product_id),
category_id INT REFERENCES Categories(category_id)
);

INSERT INTO ProductCategories
VALUES
(1, 3),
(2, 1),
(3, 2);

SELECT P.product_name, C.category_name
FROM Products as P
JOIN ProductCategories as PC
ON P.product_id = PC.product_id
JOIN Categories as C
ON PC.category_id = C.category_id;