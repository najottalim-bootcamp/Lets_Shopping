
CREATE DATABASE LetsShopDb;
GO
USE LetsShopDb
GO

CREATE TABLE ProductCategory(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description TEXT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO
CREATE TABLE Discount(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Description TEXT,
    DiscountPrecent INT ,
    Active BIT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO

CREATE TABLE ProductInventory(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Quantity INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)

GO

CREATE TABLE Product(
    Id INT  IDENTITY(1,1),
    Name VARCHAR(100),
    Description TEXT,
    CategoryId INT FOREIGN KEY REFERENCES ProductCategory(Id),
    InventoryId INT FOREIGN KEY REFERENCES ProductInventory(Id) ,
    Price DECIMAL,
    DiscountId INT FOREIGN KEY REFERENCES Discount(Id),
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME,
    PRIMARY KEY (Id)   
)

GO

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserName VARCHAR(100),
    Password TEXT,
    FirstName VARCHAR(50) ,
    LastName VARCHAR(50),
    Telephone VARCHAR(20),
    CreatedAt DATETIME,
    ModifiedAt DATETIME,
    DeletedAt DATETIME
)
GO

CREATE TABLE BranchAddress(
    Id INT PRIMARY KEY IDENTITY(1,1),
    address TEXT,
    City VARCHAR(100),
    Country VARCHAR(100),
    Telephone VARCHAR(20),
)

GO

CREATE TABLE OrderDetails(
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(Id),
    BranchAddressId INT FOREIGN KEY REFERENCES BranchAddress(Id),
    Total DECIMAL,
    PaymentType INT,
    Status INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME
)

GO

CREATE TABLE OrderItems(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT FOREIGN KEY REFERENCES OrderDetails(Id),
    ProductId INT FOREIGN KEY REFERENCES Product(Id),
    Quantity INT,
    CreatedAt DATETIME,
    ModifiedAt DATETIME
)

GO
