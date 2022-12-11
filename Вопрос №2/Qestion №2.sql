CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name VARCHAR(255) NOT NULL
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name VARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products
VALUES
	(1, 'Sony PlayStation 5'),
	(2, 'Дэн Браун Точка Обмана'),
	(3, 'Дэн Браун Код да Винчи');
	
INSERT INTO Categories
VALUES
	(1, 'Игры и консоли'),
	(2, 'Книги'),

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 2);

SELECT Prod."Name", Cat."Name"
FROM Products Prod
LEFT JOIN ProductCategories ProdCat
	ON Prod.Id = ProdCat.ProductId
LEFT JOIN Categories Cat
	ON ProdCat.CategoryId = Cat.Id;	