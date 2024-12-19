-- ≈‰‘«¡ ÃœÊ· «·„” Œœ„Ì‰
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

-- ≈‰‘«¡ ÃœÊ· «·ÿ«Ê·« 
CREATE TABLE Tables (
    TableID INT PRIMARY KEY IDENTITY(1,1),
    TableNumber INT NOT NULL,             
    Status NVARCHAR(50) DEFAULT '„ Ê›—…' CHECK (Status IN ('„ Ê›—…', '„ÕÃÊ“…'))
);

-- ≈‰‘«¡ ÃœÊ· «·ÊÃ»« 
CREATE TABLE Meals (
    MealID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10, 2) NOT NULL
);

-- ≈‰‘«¡ ÃœÊ· «·ÿ·»« 
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    OrderType NVARCHAR(20) CHECK (OrderType IN ('Œ«—ÃÌ', 'œ«Œ·Ì')) NOT NULL,
    TableNumber INT NULL, 
    TotalPrice DECIMAL(10, 2) NOT NULL,
    UserID INT NOT NULL,
    TableID INT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (TableID) REFERENCES Tables(TableID)
);

-- ≈‰‘«¡ ÃœÊ·  ›«’Ì· «·ÿ·»« 
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    MealID INT NOT NULL,
    Quantity INT NOT NULL,
    SubTotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (MealID) REFERENCES Meals(MealID)
);

-- «‰‘«¡ ÃœÊ· «·›Ê« Ì—
CREATE TABLE Bill (
    BillID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    TotalPrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);
