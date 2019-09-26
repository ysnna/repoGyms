use GYMManager;
go
--Nhóm nhân viên
create table GROUPEMPLOYEE(
groupID varchar(20) not null,
groupName nvarchar(30) not null,
leaderFName nvarchar(30) not null,
leaderLName nvarchar(30) not null,
--Primarykey--
);
go

--Nhân viên
create table EMPLOYEE(
employeeID varchar(20) not null,
employeeGroupID varchar(20) not null,
employeeFName nvarchar(30) not null,
employeeLName nvarchar(30) null,
employeeBDate datetime not null,
employeeAddress nvarchar(30) not null,
gender bit not null,
phone int not null,
salary int not null,
employeeIDCard int not null,
--Primarykey and FK--
);
go

--Công việc
create table WORK
(
workID varchar(20) not null,
workName nvarchar(20) not null,
workGroup varchar(20) not null,
--Primarykey & FK--
);
go

--Nhóm công việc
create table GROUPWORK
(
groupWorkID varchar(20) not null,
groupWorkName nvarchar(20) not null,
--FK & PK--
);
go 

--Khách hàng
create table MEMBERS
(
memID varchar(20) not null,
memLname nvarchar(20) not null,
memFName nvarchar(20)  null,
memBDate Datetime not null,
memAddress nvarchar(30) not null,
memGender bit not null,
memPhone int not null,
employeeIDCard int not null,
note nvarchar(30) null,
--FK & PK --
);
go

--Khả năng
create table ABILITIES
(
employeeID varchar(20) not null,
workID varchar(20) not null,
--FK & PK--
);
go 

--Các loại lớp học
create table CLASSROOM 
(
classID nvarchar(20) not null,
roomNum nvarchar(20) not null,
teacher nvarchar(20) not null, -- ID Work
);
go

--Hợp đồng
create table CONTRACTS
(
contractID varchar(20) not null,
dateSigned Datetime not null,
dateLiquidation Datetime not null,
memStatus nvarchar(20) null,
value int not null,
);
go

--Chi tiết hợp đồng
create table DETAILSCONTRACT 
(
contractID varchar(20) not null,
employeeID varchar(20) null,
workID varchar(20) null,
value int not null,
);
go

--Gói dịch vụ
create table PRODUCTS
(
productID varchar(20) not null,
productName nvarchar(20) not null,
productCost int not null,
);
go

--Hóa đơn
create table RECEIPT
(
receptID varchar(20) not null,
repceptDate Datetime not null,
repceptTime Time not null,
employeeID varchar(20) not null,
value int not null,
contractID varchar(20) null,
);
go

--Thống kê doanh thu
create table STATISTIC
(
dayAverage int null,
monthAverage int null,
yearAverage int null,
total int null,
note varchar(20),
);