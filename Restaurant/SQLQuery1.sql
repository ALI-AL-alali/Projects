-- ����� ���� ����������
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

-- ����� ���� ��������
CREATE TABLE Tables (
    TableID INT PRIMARY KEY IDENTITY(1,1),
    TableNumber INT NOT NULL,             
    Status NVARCHAR(50) DEFAULT '������' CHECK (Status IN ('������', '������'))
);

-- ����� ���� �������
CREATE TABLE Meals (
    MealID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10, 2) NOT NULL
);

-- ����� ���� �������
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    OrderType NVARCHAR(20) CHECK (OrderType IN ('�����', '�����')) NOT NULL,
    TableNumber INT NULL, 
    TotalPrice DECIMAL(10, 2) NOT NULL,
    UserID INT NOT NULL,
    TableID INT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (TableID) REFERENCES Tables(TableID)
);

-- ����� ���� ������ �������
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    MealID INT NOT NULL,
    Quantity INT NOT NULL,
    SubTotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (MealID) REFERENCES Meals(MealID)
);

-- ����� ���� ��������
CREATE TABLE Bill (
    BillID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    TotalPrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);
