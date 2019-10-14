use master;
go
 
 --drop database if already exists
 if DB_ID('GYMManager') is not null
 drop database GYMManager;
 go

create database GYMManager;
go 
use GYMManager;
go

--Tài khoản
create table ACCOUNT(
username varchar(10) not null,
passw varchar(15) not null,
userID int not null,
--Primarykey--
constraint pk_username primary key (username),
);
go

--Nhóm nhân viên
create table GROUPEMPLOYEE(
groupID varchar(20) not null,
groupName nvarchar(30) not null,
leaderFName nvarchar(30) null,
leaderLName nvarchar(30) null,
--Primarykey--
constraint pk_groupID primary key (groupID),
);
go

--Nhân viên
create table EMPLOYEE(
employeeID varchar(20) not null,
groupID  varchar(20),
avatar image,
employeeFName nvarchar(30) not null,
employeeLName nvarchar(30) null,
employeeBDate datetime not null,
employeeAddress nvarchar(30) not null,
gender bit not null,
phone varchar(10) not null,
salary int not null,
employeeIDCard int not null,
--Primarykey and FK--
constraint pk_employee primary key (employeeID),
foreign key(groupID) references GROUPEMPLOYEE on delete set null,
foreign key(phone) references ACCOUNT
);
go

--Nhóm công việc
create table GROUPWORK
(
groupWorkID varchar(20) not null,
groupWorkName nvarchar(20) not null,
--FK & PK--
constraint pk_groupWorkID primary key (groupWorkID)
);
go 

--Công việc
create table WORK
(
workID varchar(20) not null,
workName nvarchar(20) not null,
workGroup varchar(20) not null,
groupWorkID varchar(20) null,
--Primarykey & FK--
constraint pk_workID primary key (workID),
foreign key (groupWorkID) references GROUPWORK on delete set null	
);
go

--Khách hàng
create table MEMBERS
(
memID varchar(20) not null,
memLname nvarchar(20) not null,
memFName nvarchar(20)  null,
avatar image,
memBDate Datetime not null,
memAddress nvarchar(30) not null,
memGender bit not null,
memPhone varchar(10) not null,
cardID int not null,
note nvarchar(30) null,
--FK & PK --
constraint pk_MEMBERS primary key (memID),
constraint ck_cardID unique (cardID),
foreign key (memPhone) references ACCOUNT
);
go

--Khả năng
create table ABILITIES
(
employeeID varchar(20) null,
workID varchar(20) null,
--FK & PK--
foreign key (employeeID) references EMPLOYEE on delete set null,
foreign key (workID) references WORK on delete set null
);
go 

--Các loại lớp học
create table CLASSROOM 
(
classID nvarchar(20) not null,
roomNum nvarchar(20) not null,
teacher varchar(20) null, -- ID Work
constraint pk_classID primary key (classID),
foreign key (teacher) references EMPLOYEE on delete set null
);
go

--Gói dịch vụ
create table SERVICEPACK
(
serviceID varchar(20) not null,
serviceNAME nvarchar(20) not null,
cost int null,
note nvarchar(20) null,
constraint pk_serviceID primary key (serviceID),
);
go

--Hợp đồng
create table CONTRACTS
(
contractID varchar(20) not null,
cusID varchar(20)  null,
servicePACK varchar(20)  null,
dateSigned Datetime not null,
dateLiquidation Datetime not null,
conStatus nvarchar(20) null,
--PK--
constraint pk_contractID primary key (contractID),
foreign key (cusID) references MEMBERS on delete set null,
foreign key (servicePACK) references SERVICEPACK on delete set null,
);
go

--Chi tiết hợp đồng
create table DETAILSCONTRACT 
(
contractID varchar(20) not null,
employeeID varchar(20) null,
workID varchar(20) null,
value int not null,
--PK & FK --
foreign key (contractID) references CONTRACTS,
foreign key (employeeID) references EMPLOYEE on delete set null,
foreign key (workID) references WORK on delete set null
);
go

--Sản phẩm
create table PRODUCTS
(
productID varchar(20) not null,
picture image,
productName nvarchar(20) not null,
productCost int not null,
constraint pk_product primary key (productID),
);
go

--Hóa đơn
create table RECEIPT
(
receiptID varchar(20) not null,
memID varchar(20) not null,
repceiptDate Datetime not null,
repceiptTime Time not null,
employeeID varchar(20) not null,
value int not null,
--PK FK--
constraint pk_receipt primary key (receiptID),
foreign key (memID) references MEMBERS,
);
go

--Chi tiết hóa đơn
create table DETAILSREPCEPIT
(
receiptID varchar(20)  null,
productID varchar(20) null,
--PK & FK--
foreign key (receiptID) references RECEIPT on delete set null,
foreign key (productID) references PRODUCTS on delete set null
);

go

--Thống kê doanh thu theo ngày
create table DAYSTATISTIC
(
day datetime not null,
dayAverage float null,
type nvarchar null,
note varchar(20) null,
);
go

--Thống kê doanh thu theo tháng
create table MONTHSTATISTIC
(
month nvarchar not null,
monthAverage float null,
type nvarchar(20) null,
note varchar(20) null,
);