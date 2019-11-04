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
username varchar(11) not null,
passw varchar(20) not null,
userID int not null,
--Primarykey--
constraint pk_username primary key (username),
);
go

insert into ACCOUNT values
('admin','admin','0'),
('nv1','nv','1'),
('nv2','nv','1'),
('nv3','nv','1'),
('hlv1','hlv','3'),
('hlv2','hlv','3'),
('hlv3','hlv','3'),
('hlv4','hlv','3'),
('hlv5','hlv','3'),
('hlv6','hlv','3'),
('hlv7','hlv','3'),
('kh1','kh','2'),
('kh2','kh','2');
go

create table ACCOUNTLOGIN(
username varchar(11)null,
loginDate datetime null,
logoutDate datetime null,
--Primarykey--
foreign key(username) references ACCOUNT on delete set null,
);
go

--Nhóm nhân viên
create table GROUPEMPLOYEE(
groupID varchar(10) not null,
groupName nvarchar(30) not null,
--Primarykey--
constraint pk_groupID primary key (groupID),
);
go

insert into GROUPEMPLOYEE values
('01','Salesman'),
('02','Personal Trainer');
go

--Nhân viên
create table EMPLOYEE(
employeeID varchar(20) not null,
groupID  varchar(10),
avatar image null,
employeeFName nvarchar(30) not null,
employeeLName nvarchar(30) null,
employeeBDate datetime not null,
employeeAddress nvarchar(100) not null,
gender bit not null,
phone varchar(11),
salary int not null,
employeeIDCard int not null,
--Primarykey and FK--
constraint pk_employee primary key (employeeID),
foreign key(groupID) references GROUPEMPLOYEE on delete set null,
--foreign key(phone) references ACCOUNT on delete set null
);
go

insert into EMPLOYEE values
('nv1','01', null, N'Nguyên',N'Anh', '1999-02-14 00:00:00.000', N'Thị xã Ninh Hòa, Nha Trang', '1','0778097405', '10000000', '023285888'),
('nv2','01', null, N'Lê Hồng',N'Danh', '1999-05-20 00:00:00.000', N'Huyện Hoa Lư, Ninh Bình', '0','0779726379', '12000000', '023263762'),
('nv3','01', null, N'Nguyễn Hùng',N'Duy', '1997-07-12 00:00:00.000', N'Huyện Long Thành, Đồng Nai', '0','0841256920', '10000000', '023857639'),
('hlv1','02', null, N'Ngô Trí',N'Đức', '1995-01-07 00:00:00.000', N'Quận Hoàn Kiếm, Hà Nội', '0','094543691', '11000000', '077908232'),
('hlv2','02', null, N'Đinh Ngọc',N'Nhi', '1998-03-11 00:00:00.000', N'Huyện Châu Thành, Bến Tre', '1','0912241303', '12000000', '077001464'),
('hlv3','02', null, N'Võ Thành',N'Văn', '1996-05-24 00:00:00.000', N'Huyện Cù Lao Dung, Sóc Trăng', '0','0943222740', '10000000', '023409962'),
('hlv4','02', null, N'Bùi Minh',N'Trung', '1999-02-09 00:00:00.000', N'Thị xã Phú Mỹ, Bà Rịa - Vũng Tàu', '0','0910362941', '12000000', '023776484'),
('hlv5','02', null, N'Phan',N'Sơn', '1995-09-17 00:00:00.000', N'Quận Thanh Xuân, Hà Nội', '0','0955862959', '11000000', '023800221'),
('hlv6','02', null, N'Lê Kim',N'Đỉnh', '1998-12-30 00:00:00.000', N'Huyện Đắk Glei, Kon Tum', '0','0785484327', '10000000', '077966363'),
('hlv7','02', null, N'Nguyên',N'Vương', '1997-08-29 00:00:00.000', N'Thị xã Hương Thủy, Thừa Thiên - Huế', '0','0868660035', '10000000', '077602089');
go

--Nhóm công việc
create table GROUPWORK
(
groupWorkID varchar(20) not null,
groupWorkName nvarchar(20) not null,
--FK & PK--
constraint pk_groupWorkID primary key (groupWorkID),
);
go 

insert into GROUPWORK values
('A', 'Group Yoga'),
('B', 'Group Gym'),
('C', 'Group Dance'),
('D', 'Group Boxing'),
('E', 'Others');
go

--Công việc
create table WORK
(
workID varchar(20) not null,
workName nvarchar(50) null,
idPT varchar(20) null,
groupWorkID varchar(20) null,
--Primarykey & FK--
constraint pk_workID primary key (workID),
foreign key (groupWorkID) references GROUPWORK on delete set null,
foreign key (idPT) references EMPLOYEE on delete set null
);
go

insert into WORK values
('WK01', 'PT Yoga','hlv2','A'),
('WK02','PT Gym','hlv1','B'),
('WK03','PT Gym','hlv3','B'),
('WK04','Dancer','hlv2','C'),
('WK05','Dancer','hlv4','C'),
('WK06','PT Boxing','hlv5','D'),
('WK07','PT Fitness','hlv7','E'),
('WK08','PT Fitkid','hlv6','E'),
('WK09','PT Lesmill','hlv1','E');
go

--Khách hàng
create table MEMBERS
(
memID varchar(20) not null,
memFName nvarchar(50)  null,
memLname nvarchar(50) not null,
avatar image null,
memBDate Datetime not null,
memAddress nvarchar(100) not null,
memGender bit not null,
memPhone varchar(11) not null,
cardID int not null,
note nvarchar(100) null,
--FK & PK --
constraint pk_MEMBERS primary key (memID),
constraint ck_cardID unique (cardID),
);
go

insert into MEMBERS values
('kh1',N'Trần Gia',N'Hân', null, '1998-12-08 00:00:00.000', N'Huyện Phú Quý, Phan Thiết', '1','0863612503','077412207',null),
('kh2',N'Nguyễn Thành',N'Tâm', null, '1996-08-29 00:00:00.000', N'Huyện Trảng Bàng, Tây Ninh', '0','0960558964','023755802',null);
go

--Gói dịch vụ
create table SERVICEPACK
(
serviceID int not null,
serviceNAME nvarchar(100) not null,
cost decimal null,
note nvarchar(200) null,
tagPT varchar(20) null,
constraint pk_serviceID primary key (serviceID),
);
go

insert into SERVICEPACK values
('1','Yoga','850000','Gentle, vinyasa, hatha, power,..','A'),
('2','Fitkids','800000','Core training, kick boxing, yoga, crossfit,..','E'),
('3','Sauna','900000','2 hours a day','E'),
('4','Lesmills','800000','Bodyjam, RPM, bodybalance, bodycombat,..','E'),
('5','Dance','850000','Dance fit, freestyle dance, zumba,..','C'),
('6','Gym','900000','Body pump, E-Hardcore, bums and tums, body fitness, body building,..','B'),
('7','Kick boxing','800000','Kick boxing, Muay Thái,..','D'),
('8','Group X','900000','Step, kickfit, zumba,..','C'),
('9','Classic','1800000','All services + free drinking water + discount on Whey Protein (5% OFF),..',null),
('10','Passport','9000000','All services + free PT 7 days + free drinks + discount on Whey Protein (15% OFF),..',null),
('11','Superior','24000000','All services + free PT 15 days + free drinks + discount on Whey Protein (25% OFF),..',null),
('12','PT 7 days','2000000','Discount on Whey Protein (5% OFF)',null),
('13','PT 15 days','3750000','Discount on Whey Protein (10% OFF)',null),
('14','PT 30 days','7200000','Discount on Whey Protein (15% OFF)',null),
('15','PT 3 months','20000000','Discount on Whey Protein (20% OFF)',null),
('16','PT 6 months','38000000','Discount on Whey Protein (25% OFF)',null),
('17','PT 12 months','70000000','Discount on Whey Protein (35% OFF)',null);
go

create table MACHINES
(
idMachine int not null,
nameMachine nvarchar(100) not null,
picture image null,
infor nvarchar(500) null,
amount int not null,
constraint pk_idMachine primary key (idMachine),
);
go

insert into MACHINES values
('1',N'Máy tập cơ sô, cơ lưng', null, N'Để 2 tay vào 2 tay cầm của máy tập. Thực hiện kéo đến khi nào bạn cảm thấy thấm mệt', '15'),
('2',N'Máy chạy bộ điện – Treadmill', null, N'Nắm vào tay cầm phía trước để giữ thăng bằng. Giảm tốc độ trước khi ngừng chạy 5 phút', '20'),
('3',N'Máy đạp chân ngang có ghế tựa', null, N'Đặt 2 tay cầm sát bên hông có đồ nắm, 2 chân đặt trên thảm trước mặt, dùng sức và đạp chân về phía trước', '10'),
('4',N'Xe đạp tập thể dục – Exercise Bike', null, N'Điều chỉnh chiều cao sao cho phù hợp. Sử dụng dây đai chân buộc quá chặt sẽ gây khó chịu', '8'),
('5',N'Máy kéo cáp bằng thanh tạ', null, N'Đứng thẳng, 2 tay cầm lấy tay cầm. Sau đó kéo cáp từ từ lên hướng trước ngực', '15'),
('6',N'Máy đu xà nâng chân – Hanging Leg Raise', null, N'Lòng bàn tay nắm lấy tay cầm của máy, khuỷu tay vuông góc. Sau đó nâng người, chân thẳng ra trước', '8'),
('7',N'Máy tập cơ bụng', null, N'Đặt máy trên nền phẳng. Tựa lưng vào ghế sao cho tư thế thoải mái, phần tựa lưng của ghế ôm gọn vào phần lưng của bạn', '15'),
('8',N'Máy tập cơ đùi và chân – Leg Extension Machine', null, N'Ngồi vào vị trí, đặt tay vào tay cầm 2 bên, chân để sau 2 thanh giữ. Đẩy chân từ từ về trước', '9'),
('9',N'Máy kéo cap và ròng rọc', null, N'Đặt ròng rọc phía trên và thực hiện động tác Cross-over, hoặc đặt bên dưới và thực hiện động tác bên trên', '10'),
('10',N'Leg Press Machine - Máy đạp chân 45 độ', null, N'Chỉnh góc 45 độ. Lưu ý khi tập máy này không được duỗi thẳng chân hoàn toàn khi tập nặng, vì có thể dẫn tới gãy chân', '7'),
('11',N'Tạ đơn', null, N'Thiết kế đơn giản, nhỏ gọn với các mức khối lượng khác nhau. Bạn có thể chọn loại 5kg, 10kg, 15kg,..', '50'),
('12',N'Tạ đòn', null, N'Nhỏ, gọn, có thể thay đổi trọng lượng tạ phù hợp với bài tập. Hiệu quả rất tốt cho các vùng cơ tay, vai, ngực,..', '20');
go

--Sản phẩm
create table PRODUCTS
(
productID int not null,
picture image null,
productName nvarchar(200) not null,
productCost decimal null,
constraint pk_productID primary key (productID),
);
go

insert into PRODUCTS values
('1',null,N'Khăn lau', '30000'),
('2',null,N'Áo thể thao nam', '200000'),
('3',null,N'Giày tập Gym (Đỏ)', '400000'),
('4',null,N'Giày tập Gym (Đen)', '420000'),
('5',null,N'Nước suối', '8000'),
('6',null,N'Sting', '12000'),
('7',null,N'Whey protein concentrate 2.5kg', '1500000'),
('8',null,N'Whey protein isolate 2.5kg', '1600000'),
('9',null,N'Whey protein hydrolyzed 2kg', '1350000'),
('10',null,N'Whey protein blend 2.27kg', '1420000'),
('11',null,N'Găng tay chuyên dụng', '160000'),
('12',null,N'Coca cola', '11000'),
('13',null,N'Thảm tập Gym và Yoga 2 lớp (1x1m)', '290000'),
('14',null,N'Đai cố định lưng, hỗ trợ nâng tạ', '230000');
go

------------------------------------------------------------------------------------------------------------------------

--Hợp đồng
create table CONTRACTS
(
contractID varchar(20) not null,
cusID varchar(20) null,
ptID varchar(20) null,
servicePACK int  null,
dateStart Datetime not null,
dateDischarge Datetime not null,
conStatus nvarchar(20) null,		--bao nhiêu ngày, vd:30
--PK--
constraint pk_contractID primary key (contractID),
foreign key (cusID) references MEMBERS on delete set null,
foreign key (ptID) references EMPLOYEE on delete set null,
foreign key (servicePACK) references SERVICEPACK on delete set null,
);
go

insert into CONTRACTS values
('CONT01','kh1','hlv1','6','2019-10-25 00:00:00.000','2019-11-25 00:00:00.000',N'Đang sử dụng'),
('CONT02','kh2','hlv5','13','2019-11-1 00:00:00.000','2019-11-15 00:00:00.000',N'Đang sử dụng');
go

--Hóa đơn
create table RECEIPT
(
receiptID varchar(20) not null,
memID varchar(20) not null,
total decimal null,
--PK FK--
constraint pk_receiptID primary key (receiptID),
foreign key (memID) references MEMBERS,
);
go

insert into RECEIPT values
('IVC01','kh1','900000'),
('IVC02','kh2','3750000');
go

--Chi tiết hợp đồng
create table DETAILSCONTRACT 
(
contID varchar(20) not null,
employeeID varchar(20) null,
receiptID varchar(20) null,
--PK & FK --
constraint pk_contID primary key (contID),
foreign key (employeeID) references EMPLOYEE on delete set null,
foreign key (receiptID) references RECEIPT on delete set null
);
go

insert into DETAILSCONTRACT values
('CONT01','nv1','IVC01'),
('CONT02','nv2','IVC02');
go

create table PACKORPRODUCT
(
idBrand int not null,
brand nvarchar(50) null,
--PK FK--
constraint pk_idBrand primary key (idBrand),
);
go

insert into PACKORPRODUCT values
('1','Package'),
('2','Product');
go

--Chi tiết hóa đơn
create table DETAILSREPCEIPT
(
receiptID varchar(20)  null,
repceiptDate Datetime not null,
idBrand int null,
idService int null, -- lưu chung package và product
nameServices nvarchar(100) null,
discount decimal null,
total decimal null,
remain nvarchar(100) null,				---còn lại bao nhiêu ngày: (now - start) > 0 thì ghi, else null
--PK & FK--
foreign key (receiptID) references RECEIPT on delete set null,
foreign key (idBrand) references PACKORPRODUCT on delete set null,
);
go

insert into DETAILSREPCEIPT values
('IVC01','2019-10-25 00:00:00.000','1','6','Gym','0','900000', '30'),
('IVC02','2019-11-1 00:00:00.000','1','13','Gym','0','900000', '30');
go

--Thống kê doanh thu theo ngày
create table DAYSTATISTIC
(
dayST datetime not null,
groupST nvarchar(50) null,
amount int null,
total decimal null,
statusST nvarchar(50) null,
);
go