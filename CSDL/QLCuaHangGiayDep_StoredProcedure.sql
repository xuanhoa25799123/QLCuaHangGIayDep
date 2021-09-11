USE [ShoeShopManagement]
GO
---Thêm, xóa, sửa, xem sản phẩm (Hòa)
create procedure sp_AddProduct
(@name nvarchar(1000),
@price int,
@categoryid int,
@description nvarchar(3000),
@totalquantity int)
as
begin
insert into Product([Name], [Price], [CategoryID], [Description], [TotalQuantity],[State]) values (@name,@price,@categoryid,@description,@totalquantity,0);
end
go
create procedure sp_DeleteProduct
(@id int)
as
begin
update Product set [State] = 1 where ID = @id;
end
go
create procedure sp_ViewAllProduct
as
begin
select * from Product;
end
go
create procedure sp_ViewProductByCategory
(@categoryid int)
as
begin
select * from Product where CategoryID = @categoryid;
end
go
create procedure sp_UpdateProduct
(@id int,
@name nvarchar(1000),
@price int,
@categoryid int,
@description nvarchar(3000),
@totalquantity int)
as
begin
Update Product set Name = @name, Price = @price, CategoryID = @categoryid, Description = @description, TotalQuantity = @totalquantity where ID = @id;
end
go
--Xem, xóa, sửa, thêm nhân viên(Hòa)
create procedure sp_AddEmployee
(@name nvarchar(100),
@dateofbirth datetime,
@address nvarchar(1000),
@phonenumber char(10),
@position nvarchar(100),
@salary int,
@branch int)
as
begin
insert into Employee([Name],[DateOfBirth],[Address],[PhoneNumber],[Position],[Salary],[State],[BranchID]) values (@name,@dateofbirth,@address,@phonenumber,@position,@salary,0,@branch);
end
go
create procedure sp_DeleteEmployee
(@id int)
as
begin
update Employee set [State] = 1 where ID = @id;
end
go
create procedure sp_ViewAllEmployee
as
begin
select * from Employee;
end
go
create procedure sp_UpdateEmployee
(@id int,
@name nvarchar(100),
@dateofbirth datetime,
@address nvarchar(1000),
@phonenumber char(10),
@position nvarchar(100),
@salary int,
@branch int)
as
begin
update Employee set Name = @name, DateOfBirth = @dateofbirth, Address = @address, PhoneNumber = @phonenumber, Position = @position, Salary = @salary, BranchID = @branch where ID = @id;
end
go
--Thêm, xóa, sửa, xem chi tiết hóa đơn(Dũng)
create procedure sp_AddBillDetail
(@billid int,
@productid int,
@currentunitprice int,
@quantity int,
@intomoney int)
as
begin
INSERT INTO BillDetail([BillID], [ProductID],[Quantity], [CurrentUnitPrice],[IntoMoney],[State]) VALUES (@billid, @productid,@quantity, @currentunitprice,@intomoney,0)
end
go
create procedure sp_DeleteBillDetail
(@billid int, @productid int)
as
begin
update BillDetail set [State] = 1 where BillID = @billid and ProductID = @productid;
end
go
create procedure sp_GetBillDetailByBill
(@billid int)
as
begin
select * from BillDetail bd inner join(select ID, Name from Product) p on bd.ProductID = p.ID where BillID = @billid;
end
go
--Doanh thu của nhân viên theo tháng, năm (Hòa)
create procedure sp_SalesByMonth
(@employeeid int,
@month int,
@year int)
as
begin
Select sum(Total) from Bill where EmployeeID = @employeeid and month(CheckoutDate) = @month and year(CheckoutDate) = @year;
end
go
--Các sản phẩm nhân viên đã bán (Hòa)
create procedure sp_ProductsSaleByEmployee
(@employeeid int)
as
begin
select p.Name, d.Quantity from Product p,Bill b, BillDetail d where p.ID = d.ProductID and b.ID = d.BillID and b.EmployeeID = @employeeid;
end
go
--Các sản phẩm bán chạy nhất (Bửu)
create procedure sp_MostSellingProduct
as
begin
select ProductID, sum(Quantity) as Quantity from BillDetail group by ProductID order by Quantity DESC; 
end
go
--Các sản phẩm có doanh thu cao nhất (Bửu)
create procedure sp_HighestSalesProduct
as
begin
select d.ProductID, sum(d.IntoMoney) as Sales from BillDetail d group by d.ProductID order by Sales DESC; 
end
go
--Nhân viên bán được nhiều nhất (Dũng)
create procedure sp_MostSellsEmployee
as
begin
select b.EmployeeID, sum(b.Total) as TotalSales from Bill b group by b.EmployeeID order by TotalSales DESC;
end
go
--Thêm, xóa, sửa, xem thể loại (Dũng)
create procedure sp_AddCategory(
@name varchar(100),@parent_id int
)
as
begin
insert into Category values(@name,@parent_id);
end
go
create procedure sp_DeleteCategory(
@id int
)
as
begin
	delete from Category where ID = @id;
end

go
create procedure sp_UpdateCategory(
@id int,@name varchar(100),@parent_id int
)
as
begin
	update Category set Name=@name, Parent_ID = @parent_id where ID = @id;
end

go
create procedure sp_GetAllCategory
as
begin
	select * from Category;
end
--Thêm, xóa, sửa, xem chi nhánh (Bửu)
go
create procedure sp_AddBranch(
@name varchar(1000),@address varchar(1000)
)
as
begin
insert into Branch values(@name,@address);
end
go
create procedure sp_UpdateBranch(
@id int,@name varchar(1000),@address varchar(1000)
)
as
begin
	update Branch set Name=@name,Address=@address where ID=@id;
end

go
create procedure sp_ViewBranch
as
begin
	select * from Branch;
end
--Thêm, xóa, sửa, xem hóa đơn (Bửu)
go
create procedure sp_AddBill(
	@employee_id int,@customer_name nvarchar(1000),@phone char(10),@checkoutdate smalldatetime,@total int, @discount float)
as
begin
	insert into Bill([EmployeeID], [CustomerName],[PhoneNumber],[CheckoutDate],[Total], [State],[Discount]) values(@employee_id,@customer_name,@phone,@checkoutdate,@total,0, @discount);
end

go
create procedure sp_UpdateBill(
	@id int,@employee_id int,@customer_name nvarchar(1000),@phone char(10),@checkoutday smalldatetime,@total int
)
as
begin
	update Bill set EmployeeID=@employee_id,CustomerName=@customer_name,PhoneNumber=@phone,CheckoutDate=@checkoutday,Total=@total where ID=@id;
end

go

create procedure sp_DeleteBill(@id int)
as
begin
	update Bill set State = 1 where ID=@id;
	update BillDetail set State = 1 where BillID = @id;
end
go


create procedure sp_ViewBill
as
begin
	select * from Bill
end
go
create procedure sp_DSMatHangDaBan
as
begin
select Name = p.Name, Quantity = b.Quantity, IntoMoney = b.IntoMoney
from Product p
inner join (select ProductID, sum(Quantity) as Quantity, sum(IntoMoney) as IntoMoney from BillDetail where [State] = 0  group by ProductID) b 
on b.ProductID = p.ID;
end
go
create procedure sp_DSMatHangDaBanTheoNgay
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as
begin
select Name = p.Name, Quantity = b.Quantity, IntoMoney = b.IntoMoney
from Product p
inner join (select ProductID, sum(Quantity) as Quantity, sum(IntoMoney) as IntoMoney from BillDetail bd 
			inner join Bill bi on bd.BillID = bi.ID 
			where day(bi.CheckoutDate) >= @beginday
			and day(bi.CheckoutDate) <= @endday
			and month(bi.CheckoutDate) >= @beginmonth
			and month(bi.CheckoutDate) <= @endmonth
			and year(bi.CheckoutDate) >=@beginyear 
			and year(bi.CheckoutDate) <= @endyear
			and bi.[State] = 0
			group by ProductID
			 ) b 
on b.ProductID = p.ID
end
go
create procedure sp_DoanhThu
as 
begin
select SoLuong = count(ID), TongGiamGia = sum(Discount), TongBanHang = sum(Total)
from Bill
where [State] = 0
end
go
create procedure sp_DoanhThuTheoThang
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as 
begin
select SoLuong = count(ID), TongGiamGia = sum(Discount), TongBanHang = sum(Total)
from Bill
where day(CheckoutDate) >= @beginday
			and day(CheckoutDate) <= @endday
			and month(CheckoutDate) >= @beginmonth
			and month(CheckoutDate) <= @endmonth
			and year(CheckoutDate) >=@beginyear 
			and year(CheckoutDate) <= @endyear
			and [State] = 0
end
go
create procedure sp_SPGanHet
@SLToiDa int
as
begin
select Name = p.Name, Price = p.Price, Quantity = Quantity, Size from Product p
inner join(select ProductID, Size, Quantity from ProductDetail) pd
on p.ID = pd.ProductID
where Quantity <= @SLToiDa
end
go
create procedure sp_SPBanChay
as
begin
select TOP 5 Name = p.Name, Total = Total from Product p 
inner join (select ProductID, count(ProductID) as Total from BillDetail group by ProductID) bd
on p.ID = bd.ProductID
order by Total DESC
end
go
create procedure sp_SPBanChayTheoThang
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as
begin
select TOP 5 Name = p.Name, Total = Total from Product p 
inner join (select ProductID, count(ProductID) as Total from BillDetail bd
			inner join Bill bi on bd.BillID = bi.ID 
			where day(bi.CheckoutDate) >= @beginday
			and day(bi.CheckoutDate) <= @endday
			and month(bi.CheckoutDate) >= @beginmonth
			and month(bi.CheckoutDate) <= @endmonth
			and year(bi.CheckoutDate) >=@beginyear 
			and year(bi.CheckoutDate) <= @endyear
			group by ProductID) bdd
on p.ID = bdd.ProductID
order by Total DESC
end
go
create procedure sp_KHMuaNhieu
as
begin
select top 10 CustomerName, PhoneNumber,Total = sum(Total)
from Bill
group by CustomerName, PhoneNumber
order by Total DESC
end
go
create procedure sp_KHMuaNhieuTheoThang
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as
begin
select top 10 CustomerName, PhoneNumber,Total = sum(Total)
from Bill
where day(CheckoutDate) >= @beginday
			and day(CheckoutDate) <= @endday
			and month(CheckoutDate) >= @beginmonth
			and month(CheckoutDate) <= @endmonth
			and year(CheckoutDate) >=@beginyear 
			and year(CheckoutDate) <= @endyear
group by CustomerName, PhoneNumber
order by Total DESC
end
go
create procedure sp_SPDoanhThuCao
as
begin
select top 5 p.Name, Total from Product p
inner join (select ProductID, sum(IntoMoney) as Total from BillDetail group by ProductID) bd
on p.ID = bd.ProductID
order by Total DESC
end
go
create procedure sp_SPDoanhThuCaoTheoThang
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as
begin
select top 5 p.Name, Total from Product p
inner join (select ProductID, sum(IntoMoney) as Total from BillDetail bd
			inner join Bill bi on bd.BillID = bi.ID 
			where day(bi.CheckoutDate) >= @beginday
			and day(bi.CheckoutDate) <= @endday
			and month(bi.CheckoutDate) >= @beginmonth
			and month(bi.CheckoutDate) <= @endmonth
			and year(bi.CheckoutDate) >=@beginyear 
			and year(bi.CheckoutDate) <= @endyear
			group by ProductID) bdd
on p.ID = bdd.ProductID
order by Total DESC
end
go
create procedure sp_NVBanNhieuHang
as
begin
select top 5 e.Name, TotalBill, TotalMoney, br.Name as BranchName from Employee e
inner join(select EmployeeID, count(EmployeeID) as TotalBill, sum(Total) as TotalMoney from Bill group by EmployeeID) b
on e.ID = b.EmployeeID
inner join(select ID, [Name] from Branch) br on e.BranchID = br.ID
order by TotalMoney DESC
end
go
create procedure sp_NVBanNhieuHangTheoThang
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as
begin
select top 5 e.Name, TotalBill, TotalMoney, br.Name as BranchName from Employee e
inner join(select EmployeeID, count(EmployeeID) as TotalBill, sum(Total) as TotalMoney from Bill 
			where day(CheckoutDate) >= @beginday
			and day(CheckoutDate) <= @endday
			and month(CheckoutDate) >= @beginmonth
			and month(CheckoutDate) <= @endmonth
			and year(CheckoutDate) >=@beginyear 
			and year(CheckoutDate) <= @endyear
			group by EmployeeID) b
on e.ID = b.EmployeeID
inner join(select ID, [Name] from Branch) br on e.BranchID = br.ID
order by TotalMoney DESC
end
go
create procedure sp_NVKhongBanDuocHang
as
begin
select e.Name, br.Name as BranchName, PhoneNumber from Employee e
inner join(select ID, [Name] from Branch) br on e.BranchID = br.ID
where not exists (select distinct EmployeeID from Bill b where e.ID = b.EmployeeID) and [State] = 0
end
go
create procedure sp_NVKhongBanDuocHangTheoThang
@beginday int, @endday int, @beginmonth int, @endmonth int, @beginyear int, @endyear int
as
begin
select e.Name, br.Name as BranchName, PhoneNumber from Employee e
inner join(select ID, [Name] from Branch) br on e.BranchID = br.ID
where not exists (select distinct EmployeeID from Bill b 
					where day(CheckoutDate) >= @beginday
					and day(CheckoutDate) <= @endday
					and month(CheckoutDate) >= @beginmonth
					and month(CheckoutDate) <= @endmonth
					and year(CheckoutDate) >=@beginyear 
					and year(CheckoutDate) <= @endyear
					and e.ID = b.EmployeeID) 
and [State] = 0
end
go
create procedure sp_GetEmployeeByID
@EmployeeID int
as
begin
select * from Employee where ID = @EmployeeID
end
go
create procedure sp_DeleteEmployee
@id int
as
begin
update Employee set State = 1 where ID = @id
end
go
create procedure sp_GetBillByID
@id int
as
begin
select * from Bill where ID = @id
end
go
create procedure sp_UpdateProductQuantity
@totalquantity int, @productID int
as
begin
update Product set TotalQuantity = @totalquantity where ID = @productID
end
go
create procedure sp_GetQuantityByProductID
@productID int
as
begin
select sum(Quantity) from ProductDetail where ProductID = @productID
end
go
create procedure sp_GetAllAccount
as
begin
select ID, e.Name, groupname, loginName from Employee e
inner join(
select membername, groupname, loginName from sys.sysmembers m 
inner join (select uid, name as groupname from sys.sysusers) u on m.groupuid = u.uid
inner join (select uid, loginName, users.name as membername, users.sid from sys.sysusers users inner join (select name as loginName, sid from sys.sql_logins) l on users.sid = l.sid) us on m.memberuid = us.uid
where (groupname = 'GIAMDOC' or groupname = 'NHANVIEN' or groupname = 'QLCHINHANH') and membername != 'remoteLogin' and membername != 'dbo') mem
on e.ID = mem.membername
end
go

create procedure sp_DeleteAccount
@ID nvarchar(100), @loginName nvarchar(100)
as
begin
declare @query varchar(100);
declare @dropUser varchar(100);
declare @dropLogin varchar(100);
set @query = 'alter authorization on schema::['+ @ID + '] to dbo';
EXEC (@query)
set @dropUser = 'Drop USER [' + @ID +']';
EXEC (@dropUser);
set @dropLogin = 'Drop Login ' + @loginName;
exec (@dropLogin);
end
go
create procedure sp_ResetPassword
@loginName nvarchar(100)
as
begin
declare @query varchar(100);
declare @pass varchar(100);
set @pass = '123456';
set @query = 'alter login '+ @loginName + ' with password = ''123456''';
exec(@query);
end
go
create procedure sp_UpdateQuantityPD
@quantity int, @productID int, @size nvarchar(100)
as
begin
update ProductDetail set Quantity = Quantity - @quantity where ProductID = @productID and Size = @size
end
go
CREATE PROC [dbo].[sp_GetLoginInfo]
@LoginName nvarchar(50)
AS
BEGIN
	DECLARE @Id nvarchar(50)
	SELECT @Id = Name FROM sys.sysusers where sid = SUSER_SID(@LoginName)
	Select Id = @Id, ROLENAME = NAME
	FROM sys.sysusers
	WHERE UID = (SELECT groupuid
					FROM sys.sysmembers
						WHERE memberuid = (SELECT UID FROM sys.sysusers
											WHERE Name = @Id))
END