create database [ShoeShopManagement]
go
USE [ShoeShopManagement]
GO
--Khôi
CREATE TABLE [dbo].[Branch](
    [ID] [int] IDENTITY(1,1) PRIMARY KEY,
    [Name] [nvarchar](1000) NOT NULL,
    [Address] [nvarchar](1000) NOT NULL
)
CREATE TABLE [dbo].[Employee](
    [ID] [int] IDENTITY(1,1) PRIMARY KEY,
    [Name][nvarchar](100) NOT NULL,
    [DateOfBirth] [datetime] NOT NULL,
    [Address] [nvarchar](1000) NOT NULL,
	[PhoneNumber] [char](10) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Salary] [int] NOT NULL,
	[State] [bit] NOT NULL,
    [Branch] [int] NOT NULL FOREIGN KEY REFERENCES Branch(ID)
)
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	[Parent_ID] [int] NOT NULL)

CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	[Price] [int] NOT NULL,
	[CategoryID] [int] NOT NULL FOREIGN KEY REFERENCES Category(ID),
	[Description] [nvarchar](3000) NULL,
	[TotalQuantity][int] NOT NULL,
	[State] [bit] NOT NULL)
CREATE TABLE [dbo].[ProductDetail](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY, 
	[IDProduct] [int] NOT NULL FOREIGN KEY REFERENCES Product(ID),
	[Size] [nvarchar](100) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Branch] [int] NOT NULL FOREIGN KEY REFERENCES Branch(ID),
	unique([IDProduct],[Size],[Branch]))
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[EmployeeID] [int] NOT NULL FOREIGN KEY REFERENCES dbo.[Employee](ID),
	[CustomerName] [nvarchar](1000) NOT NULL,
	[Discount] [float] NULL,
	[PhoneNumber] [char](10) NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Total] [int] NOT NULL,
	[State] [bit] NOT NULL
)
CREATE TABLE [dbo].[BillDetail](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[BillID] [int] NOT NULL FOREIGN KEY REFERENCES Bill(ID),
	[ProductID] [int] NOT NULL FOREIGN KEY REFERENCES Product(ID),
    [CurrentUnitPrice] [int] NOT NULL,
	[Quantity][int] NOT NULL,
	[IntoMoney][int] NOT NULL,
	[State] [bit] NOT NULL,
)

GO

--Khôi
INSERT INTO Branch(Name, Address) VALUES (N'Chi nhánh Bùi Thị Xuân', N'134 Phan Đình Phùng - Phường 2 - Đà Lạt')
INSERT INTO Branch(Name, Address) VALUES (N'Chi nhánh Phan Đình Phùng', N'53 Hùng Vương - Phường 5 - Bảo Lộc')


INSERT INTO Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[Branch])VALUES (N'Nga', '2000-8-23', N'123 Phù Đổng Thiên Vương', '0123456789', N'Giám đốc',8000000,0,1)
INSERT INTO Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[Branch])VALUES (N'Khôi', '2000-8-23', N'45 Phù Đổng Thiên Vương', '0123456789',N'Giám đốc',8000000,0,2)
INSERT INTO Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[Branch])VALUES (N'Hòa', '2000-8-23', N'23/2 Hùng Vương', '0123456789', N'Bán hàng',3000000,0,1)
INSERT INTO Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[Branch])VALUES (N'Huệ',  '2000-8-23', N'107 Hai Bà Trưng', '0123456789', N'Bán hàng',3000000,0,2)
INSERT INTO Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[Branch])VALUES (N'Dũng', '2000-8-23', N'23/5 Mai Hắc Đế', '0123456789', N'Quản lý',5000000,0,1)
INSERT INTO Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[Branch])VALUES (N'Bửu', '2000-8-23', N'34 Vạn Kiếp', '0123456789', N'Quản lý',5000000,0,2)



INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày dép nam', 0)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày dép nữ', 0)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày Nike nam', 1)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày Adidas nam', 1)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày Jordan nam', 1)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Dép nam', 1)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Dép nữ', 2)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày Nike nữ', 2)
INSERT INTO [dbo].[Category] ([Name], [Parent_ID]) VALUES (N'Giày Adidas nữ', 2)

INSERT INTO [dbo].[Product] ([Name], [Price], [CategoryID], [Description], [TotalQuantity], [State]) VALUES (N'Giày Sneaker Nam Nike Air Force 1 Crater',2050000,3, NULL, 10,0)
INSERT INTO [dbo].[Product] ([Name], [Price], [CategoryID], [Description], [TotalQuantity], [State]) VALUES (N'Giày Sneaker Nam Nike Air Max 90', 2390000,3,NULL,10,0)
INSERT INTO [dbo].[Product] ([Name], [Price], [CategoryID], [Description], [TotalQuantity], [State]) VALUES (N'Giày Sneaker Nữ Nike Air Force 1', 3200000, 8,NULL,5,0)
INSERT INTO [dbo].[Product] ([Name], [Price], [CategoryID], [Description], [TotalQuantity], [State]) VALUES (N'Giày Sneaker Nam Adidas Ultraboost 20 Prime Blue', 2350000, 4,NULL,5,0)
INSERT INTO [dbo].[Product] ([Name], [Price], [CategoryID], [Description], [TotalQuantity], [State]) VALUES (N'Giày Sneaker Nữ Adidas Qt Racer 2.0',950000,9, NULL,5,0)


INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (1,N'42',5,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (1,N'41',2,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (1,N'41',3,2)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (2,N'40',2,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (2,N'41',3,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (2,N'40',5,2)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (3,N'38',2,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (3,N'39',1,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (3,N'39',2,2)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (4,N'43',1,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (4,N'43',2,2)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (4,N'42',2,2)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (5,N'38',2,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (5,N'39',1,1)
INSERT INTO [dbo].[ProductDetail] ([IDProduct], [Size], [Quantity], [Branch]) VALUES (5,N'39',2,2)


--Dũng
INSERT INTO Bill([EmployeeID], [CustomerName], [PhoneNumber], [CheckoutDate], [Discount], [Total], [State]) VALUES (3,N'Chị Hương','0923548446','2021-02-03',0,3000000,0)
INSERT INTO Bill([EmployeeID], [CustomerName], [PhoneNumber], [CheckoutDate], [Discount], [Total], [State]) VALUES (3,N'Chị Hương', '0580123000', '2021-03-23',0, 4100000,0)
INSERT INTO Bill([EmployeeID], [CustomerName], [PhoneNumber], [CheckoutDate], [Discount], [Total], [State]) VALUES (5,N'Chị Trà','0360012000','2021-02-16',0, 2390000,0)
INSERT INTO Bill([EmployeeID], [CustomerName], [PhoneNumber], [CheckoutDate], [Discount], [Total], [State]) VALUES (6,N'Anh Thành','0024000560','2021-01-08',0, 3200000,0)

INSERT INTO BillDetail([BillID], [ProductID], [CurrentUnitPrice],[IntoMoney],[State],[Quantity]) VALUES (1, 1, 2050000,2050000,0,1)
INSERT INTO BillDetail([BillID], [ProductID], [CurrentUnitPrice],[IntoMoney],[State],[Quantity]) VALUES (1, 5, 950000,950000,0,1)
INSERT INTO BillDetail([BillID], [ProductID], [CurrentUnitPrice],[IntoMoney],[State],[Quantity]) VALUES (2, 1,2050000,4100000,0,2)
INSERT INTO BillDetail([BillID], [ProductID], [CurrentUnitPrice],[IntoMoney],[State],[Quantity]) VALUES (3, 2,2390000,2390000,0,1)
INSERT INTO BillDetail([BillID], [ProductID], [CurrentUnitPrice],[IntoMoney],[State],[Quantity]) VALUES (4, 3,3200000,3200000,0,1)