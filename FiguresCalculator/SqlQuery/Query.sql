CREATE TABLE Products
([Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name] NCHAR(30)
);
INSERT INTO Products
VALUES ('ProductOne'),
       ('ProductTwo'),
       ('ProductThree'),
       ('ProductFour');

CREATE TABLE Categories
([Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name] NCHAR(30)
);
INSERT INTO Categories
VALUES ('CategoryOne'),
       ('CategoryTwo'),
       ('CategoryThree'),
       ('CategoryFour');

CREATE TABLE ProductsAndCategories
([Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [ProductId] INT FOREIGN KEY REFERENCES Products(Id),
    [CategoryId] INT FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO ProductsAndCategories
VALUES (1, 2),
       (2, 1),
       (2, 3),
       (4, 4),
       (2, 4);

SELECT Products.Name AS Product,
    ISNULL(Categories.Name, 'No categories') AS Categoria
FROM Products
    LEFT JOIN ProductsAndCategories
ON Products.Id = ProductsAndCategories.ProductId
    LEFT JOIN Categories ON ProductsAndCategories.CategoryId = Categories.Id;