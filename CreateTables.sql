
CREATE DATABASE LetsShopDb;
GO
USE LetsShopDb
GO

CREATE TABLE Card(
    Id INT PRIMARY KEY IDENTITY(1,1),
    CardNumber VARCHAR(100),
    ExpireDate DATETIME,
    Amount DECIMAL,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE Users(
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    PhoneNumber VARCHAR(100),
    CardId INT FOREIGN KEY REFERENCES Card(Id),
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)
GO
CREATE TABLE Address(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Country VARCHAR(100),
    City VARCHAR(100),
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE Company(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description Text,
    PhoneNumber VARCHAR(100),
    AddressId INT FOREIGN KEY REFERENCES Address(Id),
    CardId INT FOREIGN KEY REFERENCES Card(Id),
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO

CREATE TABLE Category(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    ParentId  INT FOREIGN KEY REFERENCES Category(Id),
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)
GO

CREATE TABLE Discount(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description TEXT,
    Percents DECIMAL,
    StartDate DATETIME,
    EndDate DATETIME,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)
GO
CREATE TABLE Prices (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Prices DECIMAL,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)
GO
CREATE TABLE Product(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description TEXT,
    CompanyId INT FOREIGN KEY REFERENCES Company(Id),
    DiscountId INT FOREIGN KEY REFERENCES Discount(Id),
    CategoryId INT FOREIGN KEY REFERENCES Discount(Id),
    PricesId INT FOREIGN KEY REFERENCES Prices(Id),
    Count INT ,
    ImgPath TEXT,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE Comment(
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(Id),
    ProductId INT FOREIGN KEY REFERENCES Product(Id),
    CommentText TEXT ,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE Cart(
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(Id),
    ProductId INT FOREIGN KEY REFERENCES Product(Id),
    Active BIT,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE Orders(
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(Id),
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE OrderList(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT FOREIGN KEY REFERENCES Orders(Id),
    ProductId INT FOREIGN KEY REFERENCES Product(Id),
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)





