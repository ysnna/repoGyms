
use master;
go
 
 --drop database if already exists

 drop database if exists DBMS;
 go

create database DBMS;
go 
use DBMS;
go
if object_ID('tblACCOUNT') is not null
begin 
drop table tblACCOUNT
end
go
--Tài khoản
create table tblACCOUNT(
username varchar(11) not null,
passw varchar(20) not null,
userID int not null,
state varchar(20) null,
--Primarykey--
CONSTRAINT [PK_tblACCOUNT] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
if object_ID('tblCHECKLOGIN') is not null
begin 
drop table tblCHECKLOGIN
end
go
create table tblCHECKLOGIN(
[usr] [varchar](11) null,
[loginDate] [varchar](20) null,
[logoutDate] [varchar](20) null,
[status] [varchar](20) null, )
--Primarykey--

go

insert into tblACCOUNT values
('admin','admin','0',null),
('NV01','nv','1',null),
('NV02','nv','1',null),
('NV03','nv','1',null),
('HLV01','hlv','3',null),
('HLV02','hlv','3',null),
('HLV03','hlv','3',null),
('HLV04','hlv','3',null),
('HLV05','hlv','3',null),
('HLV06','hlv','3',null),
('HLV07','hlv','3',null),
('KH01','kh','2',null),
('KH02','kh','2',null);



go
if object_ID('tblGROUPEMPLOYEE') is not null
begin 
drop table tblGROUPEMPLOYEE
end
go
--Nhóm nhân viên
create table tblGROUPEMPLOYEE(
groupID varchar(10) not null,
groupName nvarchar(30) not null,
--Primarykey--
CONSTRAINT [PK_tblGROUPEMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[groupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

go

insert into tblGROUPEMPLOYEE values
('01','Salesman'),
('02','Personal Trainer');
go

--Nhân viên
if object_ID('tblEMPLOYEE') is not null
begin 
drop table tblEMPLOYEE
end
go
create table tblEMPLOYEE(
empID varchar(20) not null,
grID  varchar(10),
avatar image null,
empFName nvarchar(30) not null,
empLName nvarchar(30) null,
empBDate datetime not null,
empAddress nvarchar(100) not null,
gender nvarchar(10) not null,
phone varchar(11),
salary int not null,
empIDCard varchar(10) not null,
--Primarykey and FK--
CONSTRAINT [PK_tblEMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[empID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
ALTER TABLE [tblEMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_tblEMPLOYEE_tblGROUPEMPLOYEE] FOREIGN KEY([grID])
REFERENCES [tblGROUPEMPLOYEE] ([groupID])
GO
if object_ID('tblINFOPT') is not null
begin 
drop table tblINFOPT
end
go
CREATE TABLE tblINFOPT(
ID varchar(20) not null,
literacy nvarchar(20) null ,
exp nvarchar(20) null,
certificate nvarchar(20) null,
achievements nvarchar(20) null,
CONSTRAINT [PK_tblINFOPT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
ALTER TABLE [tblINFOPT]  WITH CHECK ADD  CONSTRAINT [FK_tblINFOPT_tblEMPLOYEE] FOREIGN KEY([ID])
REFERENCES [tblEMPLOYEE] ([empID])
go
insert into tblEMPLOYEE values
('NV01','01', null, N'Nguyên',N'Anh', '1999-02-14 00:00:00.000', N'Thị xã Ninh Hòa, Nha Trang', '1','0778097405', '10000000', '023285888'),
('NV02','01', null, N'Lê Hồng',N'Danh', '1999-05-20 00:00:00.000', N'Huyện Hoa Lư, Ninh Bình', '0','0779726379', '12000000', '023263762'),
('NV03','01', null, N'Nguyễn Hùng',N'Duy', '1997-07-12 00:00:00.000', N'Huyện Long Thành, Đồng Nai', '0','0841256920', '10000000', '023857639'),
('HLV01','02', null, N'Ngô Trí',N'Đức', '1995-01-07 00:00:00.000', N'Quận Hoàn Kiếm, Hà Nội', '0','094543691', '11000000', '077908232'),
('HLV02','02', null, N'Đinh Ngọc',N'Nhi', '1998-03-11 00:00:00.000', N'Huyện Châu Thành, Bến Tre', '1','0912241303', '12000000', '077001464'),
('HLV03','02', null, N'Võ Thành',N'Văn', '1996-05-24 00:00:00.000', N'Huyện Cù Lao Dung, Sóc Trăng', '0','0943222740', '10000000', '023409962'),
('HLV04','02', null, N'Bùi Minh',N'Trung', '1999-02-09 00:00:00.000', N'Thị xã Phú Mỹ, Bà Rịa - Vũng Tàu', '0','0910362941', '12000000', '023776484'),
('HLV05','02', null, N'Phan',N'Sơn', '1995-09-17 00:00:00.000', N'Quận Thanh Xuân, Hà Nội', '0','0955862959', '11000000', '023800221'),
('HLV06','02', null, N'Lê Kim',N'Đỉnh', '1998-12-30 00:00:00.000', N'Huyện Đắk Glei, Kon Tum', '0','0785484327', '10000000', '077966363'),
('HLV07','02', null, N'Nguyên',N'Vương', '1997-08-29 00:00:00.000', N'Thị xã Hương Thủy, Thừa Thiên - Huế', '0','0868660035', '10000000', '077602089');
go
if object_ID('tblGROUPWORK') is not null
begin 
drop table tblGROUPWORK
end
go
--Nhóm công việc
create table tblGROUPWORK
(
grWorkID varchar(20) not null,
grWorkName nvarchar(20) not null,

--FK & PK--
CONSTRAINT [PK_tblGROUPWORK] PRIMARY KEY CLUSTERED 
(
	[grWorkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO

insert into tblGROUPWORK values
('A', 'Group Yoga'),
('B', 'Group Gym'),
('C', 'Group Dance'),
('D', 'Group Boxing'),
('E', 'Others');
go
if object_ID('tblWORK') is not null
begin 
drop table tblWORK
end
go
--Công việc
create table tblWORK
(
workID varchar(20) not null,
workName nvarchar(50) null,
idPT varchar(20) null,
groupWorkID varchar(20) null,
--Primarykey & FK--
CONSTRAINT [PK_tblWORK] PRIMARY KEY CLUSTERED 
(
	[workID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

go 
ALTER TABLE [tblWORK]  WITH CHECK ADD  CONSTRAINT [FK_tblWORK_tblGROUPWORK] FOREIGN KEY([groupWorkID])
REFERENCES [tblGROUPWORK] ([grWorkID])
go
ALTER TABLE [tblWORK]  WITH CHECK ADD  CONSTRAINT [FK_tblWORK_tblEMPLOYEE] FOREIGN KEY([idPT])
REFERENCES [tblEMPLOYEE] ([empID])
go
insert into tblWORK values
('WK01', 'PT Yoga','HLV02','A'),
('WK02','PT Gym','HLV01','B'),
('WK03','PT Gym','HLV03','B'),
('WK04','Dancer','HLV02','C'),
('WK05','Dancer','HLV04','C'),
('WK06','PT Boxing','HLV05','D'),
('WK07','PT Fitness','HLV07','E'),
('WK08','PT Fitkid','HLV06','E'),
('WK09','PT Lesmill','HLV01','E');
go
if object_ID('tblMEMBERS') is not null
begin 
drop table tblMEMBERS
end
go
--Khách hàng
create table tblMEMBERS
(
memID varchar(20) not null,
memFName nvarchar(50)  null,
memLname nvarchar(50) not null,
avatar image null,
memBDate Datetime not null,
memAddress nvarchar(100) not null,
memGender varchar not null,
memPhone varchar(11) not null,
cardID int not null,
note nvarchar(100) null,
--FK & PK --
CONSTRAINT [PK_tblMEMBERS] PRIMARY KEY CLUSTERED 
(
	[memID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

go

insert into tblMEMBERS values
('KH01',N'Trần Gia',N'Hân', null, '1998-12-08 00:00:00.000', N'Huyện Phú Quý, Phan Thiết', '1','0863612503','077412207',null),
('KH02',N'Nguyễn Thành',N'Tâm', null, '1996-08-29 00:00:00.000', N'Huyện Trảng Bàng, Tây Ninh', '0','0960558964','023755802',null);
go
if object_ID('tblSERVICEPACK') is not null
begin 
drop table tblSERVICEPACK
end
go
--Gói dịch vụ
create table tblSERVICEPACK
(
serID int not null,
serNAME nvarchar(100) not null,
cost decimal null,
note nvarchar(200) null,
tagPT varchar(20) null,
CONSTRAINT [PK_tblSERVICEPACK] PRIMARY KEY CLUSTERED 
(
	[serID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
ALTER TABLE [tblSERVICEPACK]  WITH CHECK ADD  CONSTRAINT [FK_tblSERVICEPACK_tblGROUPWORK] FOREIGN KEY([tagPT]) 
REFERENCES [tblGROUPWORK] ([grWorkID]) 

go

insert into tblSERVICEPACK values
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
if object_ID('tblMACHINES') is not null
begin 
drop table tblMACHINES
end
go
create table tblMACHINES
(
macID int not null,
macName nvarchar(100) not null,
picture image null,
infor nvarchar(500) null,
amount int not null,
CONSTRAINT [PK_tblMACHINES] PRIMARY KEY CLUSTERED 
(
	[macID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go

insert into tblMACHINES values
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
if object_ID('tblPRODUCTS') is not null
begin 
drop table tblPRODUCTS
end
go
create table tblPRODUCTS
(
proID int not null,
picture image null,
proName nvarchar(200) not null,
proCost decimal null,
CONSTRAINT [PK_tblPRODUCTS] PRIMARY KEY CLUSTERED 
(
	[proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go

insert into tblPRODUCTS values
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
if object_ID('tblCONTRACTS') is not null
begin 
drop table tblCONTRACTS
end
go
------------------------------------------------------------------------------------------------------------------------
--Hợp đồng
create table tblCONTRACTS
(
contID varchar(20) not null,
cusID varchar(20) null,
empID varchar(20) null,
conStatus nvarchar(20) null,		--bao nhiêu ngày, vd:30
--PK--

CONSTRAINT [PK_tblPCONTRACTS] PRIMARY KEY CLUSTERED 
(
	[contID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [tblCONTRACTS]  WITH CHECK ADD  CONSTRAINT [FK_tblCONTRACTS_tblMEMBERS] FOREIGN KEY([cusID]) 
REFERENCES [tblMEMBERS] ([memID]) 

ALTER TABLE [tblCONTRACTS]  WITH CHECK ADD  CONSTRAINT [FK_tblCONTRACTS_tblEMPLOYEE] FOREIGN KEY([empID]) 
REFERENCES [tblEMPLOYEE] ([empID]) 



go

insert into tblCONTRACTS values
('CONT01','KH01','NV01',null),
('CONT02','KH02','NV02',null);	
go
if object_ID('tblRECEIPT') is not null
begin 
drop table tblRECEIPT
end
go
--Hóa đơn
create table tblRECEIPT
(
receipt_ID varchar(20) not null,
mem_ID varchar(20) not null,
total decimal null,
--PK FK--
CONSTRAINT [PK_tblRECEIPT] PRIMARY KEY CLUSTERED 
(
	[receipt_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [tblRECEIPT]  WITH CHECK ADD  CONSTRAINT [FK_tblRECEIPT_tblMEMBERS] FOREIGN KEY([mem_ID]) 
REFERENCES [tblMEMBERS] ([memID]) 

go

insert into tblRECEIPT values
('IVC01','KH01','900000'),
('IVC02','KH02','3750000');

go
if object_ID('tblDETAILSCONTRACT') is not null
begin 
drop table tblDETAILSCONTRACT
end
go
--Chi tiết hợp đồng
create table tblDETAILSCONTRACT 
(
cont_ID varchar(20) null,
receipt_ID varchar(20) null,
ptID varchar(20) null,
servicePACK int  null,
dateStart Datetime not null,
dateDischarge Datetime not null,
status varchar(20) null
--PK & FK --
)
ALTER TABLE [tblDETAILSCONTRACT]  WITH CHECK ADD  CONSTRAINT [FK_tblDETAILSCONTRACT_tblCONTRACTS] FOREIGN KEY([cont_ID]) 
REFERENCES [tblCONTRACTS] ([contID]) ON DELETE SET NULL

ALTER TABLE [tblDETAILSCONTRACT]  WITH CHECK ADD  CONSTRAINT [FK_tblDETAILSCONTRACT_tblSERVICEPACK] FOREIGN KEY([servicePACK]) 
REFERENCES [tblSERVICEPACK] ([serID]) ON DELETE SET NULL

ALTER TABLE [tblDETAILSCONTRACT]  WITH CHECK ADD  CONSTRAINT [FK_tblDETAILSCONTRACT_tblRECEIPT] FOREIGN KEY([receipt_ID]) 
REFERENCES [tblRECEIPT] ([receipt_ID])ON DELETE SET NULL

go

insert into tblDETAILSCONTRACT values
('CONT01','IVC01','HLV01','6','2019-10-25 00:00:00.000','2019-11-25 00:00:00.000',null),
('CONT02','IVC02','HLV05','13','2019-11-1 00:00:00.000','2019-11-15 00:00:00.000',null);
go
if object_ID('tblPACKORPRODUCT') is not null
begin 
drop table tblPACKORPRODUCT
end
go
create table tblPACKORPRODUCT
(
idBrand int not null,
brand nvarchar(50) null,
--PK FK--
CONSTRAINT [PK_tblPACKORPRODUCT] PRIMARY KEY CLUSTERED 
(
	[idBrand] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go

insert into tblPACKORPRODUCT values
('1','Package'),
('2','Product');
go
if object_ID('tblDETAILSRECEIPT') is not null
begin 
drop table tblDETAILSRECEIPT
end
go
--Chi tiết hóa đơn
create table tblDETAILSRECEIPT
(
receiptID varchar(20)  null,
receiptDate Datetime not null,
idBrand int null,
idService int null, -- lưu chung package và product
nameServices nvarchar(100) null,
period int null,
total decimal null,
remain nvarchar(100) null,		)		---còn lại bao nhiêu ngày: (now - start) > 0 thì ghi, else null
--PK & FK--
ALTER TABLE [tblDETAILSRECEIPT]  WITH CHECK ADD  CONSTRAINT [FK_tblDETAILSRECEIPT_tblRECEIPT] FOREIGN KEY([receiptID]) 
REFERENCES [tblRECEIPT] ([receipt_ID]) ON DELETE SET NULL

ALTER TABLE [tblDETAILSRECEIPT]  WITH CHECK ADD  CONSTRAINT [FK_DETAILSRECEIPT_tblRECEIPT] FOREIGN KEY([idBrand]) 
REFERENCES [tblPACKORPRODUCT] ([idBrand])ON DELETE SET NULL

ALTER TABLE [tblDETAILSRECEIPT]  WITH CHECK ADD  CONSTRAINT [FK_DETAILSRECEIPT_tblSERVICEPACK] FOREIGN KEY([idService]) 
REFERENCES [tblSERVICEPACK] ([serID])ON DELETE SET NULL

go

insert into tblDETAILSRECEIPT values
('IVC01','2019-10-25 00:00:00.000','1','6','Gym','1','900000', null),
('IVC02','2019-11-1 00:00:00.000','1','13','Gym','1','900000', null);
go

if object_ID('tblDAYSTATISTIC') is not null
begin 
drop table TBLDAYSTATISTIC
end
go
--Thống kê doanh thu theo ngày
create table TBLDAYSTATISTIC
(
dayST datetime not null,
groupST nvarchar(50) null,
amount int null,
total decimal null,
statusST nvarchar(50) null,
);
go 

--Update, Delete, Insert Employee
go 
use DBMS
go
	DROP PROC if exists proINSERTEMP;
go

CREATE PROC proINSERTEMP
@ID varchar(10), @grID varchar(10), @ava image= null, @fname nvarchar(20)= null, @lname nvarchar(20)= null, @bdate DateTime= null,
@add nvarchar(50)= null, @gen nvarchar(10)= null, @phone varchar(10)= null, @sal int= null,@card varchar(10)= null AS
BEGIN 
if exists (select *from tblEMPLOYEE where empID = @ID)
	THROW 50001, ' The ID has already exists! ',1 ;
if @fname is null or @fname =''
	THROW 50001, ' Please Insert First Name ',1 ;
if @lname is null or @lname =''
	THROW 50001, ' Please Insert Last Name ',1 ;
if @bdate is null or @bdate > GETDATE()
	THROW 50001, ' Please Insert First Name ',1 ;
if @phone is null or @phone =''
	THROW 50001, ' Please Insert Phone ',1 ;
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblEMPLOYEE
		values (@ID,@grID,@ava,@fname,@lname,@bdate,@add,@gen,@phone,@sal,@card)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END 
go


go
DROP PROC if exists proUPEMP;
GO

CREATE PROC proUPEMP 
@ID varchar(10), 
@grID varchar(10), 
@ava image= null, 
@fname nvarchar(20)= null, 
@lname nvarchar(20)= null, 
@bdate DateTime= null,
@add nvarchar(50)= null,
@gen nvarchar(10)= null,
@phone varchar(10)= null, 
@sal int= null,
@card varchar(10)= null AS
IF NOT EXISTS (select * from tblEMPLOYEE where empID = @ID)
	THROW 50001, ' The ID is NOT exists! ',1 ;
if @fname is null or @fname =''
	THROW 50001, ' Please Insert First Name ',1 ;
if @lname is null or @lname =''	
	THROW 50001, ' Please Insert Last Name ',1 ;
if @bdate is null or @bdate > GETDATE()
	THROW 50001, ' Please Insert First Name ',1 ;
if @phone is null or @phone =''
	THROW 50001, ' Please Insert Phone ',1 ;
BEGIN
	UPDATE dbo.tblEMPLOYEE
	SET  grID=@grID, 
		 avatar=@ava ,
		 empFName=@fname ,
		 empLName=@lname ,
		 empBDate=@bdate ,
		 empAddress=@add ,
		gender=@gen ,
		phone=@phone ,
		 salary=@sal ,
		 empIDCard = @card
	where empID = @ID
END
go

exec proUPEMP 'HLV03','02', null, N'Võ Thành',N'Thạnh', '1996-05-24 00:00:00.000', N'Huyện Cù Lao Dung, Sóc Trăng', 'Male','0943222740', 10000000, '023409962'
go
select * from tblEMPLOYEE
go
--Cái nào mà ít ràng buộc nhất á

-- Delete Employee
	DROP PROC if exists proDELEMP;
go
CREATE PROC proDELEMP
	@ID varchar(10)
AS 
IF (SELECT COUNT(*) from tblCONTRACTS where empID = @ID) <> 0
THROW 50001, ' Some contracts Still Need Him/Her, Can not delete!',1
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM dbo.tblEMPLOYEE WHERE empID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- iNSERT, UPDATE, DELETE MEMBERS
create trigger DontInSertMmemMore60
on tblMEMBERS
for insert 
as
begin
	declare @count int =0;
	select @count = Count(*) from inserted
	where YEAR(GETDATE()) - YEAR(inserted.memBDate)>60

	if (@count >0)
	begin
		Print N'You are too old to do this exercises! '
		rollback tran
	end
end
go

drop PROC if exists proINSMEM -- Insert MEMBERS
go

use DBMS 
go
-----index
create nonclustered index SeekMem on tblMEMBERS ( cardID asc)
go

select * from tblMEMBERS
select cardID from tblMEMBERS where cardID = 1;
go

CREATE PROC proINSMEM @ID varchar(10), @ava image= null, @fname nvarchar(20)= null, @lname nvarchar(20)= null, @bdate DateTime= null,
@add nvarchar(50)= null, @gen nvarchar(10)= null, @phone varchar(10)= null,@card int = null , @note nvarchar(20) = null AS
BEGIN 
if exists (select *from tblMEMBERS where memID = @ID)
	THROW 50001, ' The ID has already exists! ',1 ;
if @fname is null or @fname =''
	THROW 50001, ' Please Insert First Name ',1 ;
if @lname is null or @lname =''
	THROW 50001, ' Please Insert Last Name ',1 ;
if @bdate is null or @bdate > GETDATE()
	THROW 50001, ' Please Insert First Name ',1 ;
if @phone is null or @phone =''
	THROW 50001, ' Please Insert Phone ',1 ;
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblMEMBERS
		values (@ID,@fname,@lname,@ava,@bdate,@add,@gen,@phone,@card,@note)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- Update MEMBERS
	DROP PROC if exists proUPMEM;
GO
CREATE PROC proUPMEM
@ID varchar(10), 
@fname nvarchar(20)= null, 
@lname nvarchar(20)= null, 
@ava image= null, 
@bdate DateTime= null,
@add nvarchar(50)= null,
@gen nvarchar(10)= null,
@phone varchar(10)= null, 
@card int = null,
@note nvarchar(20) = null
AS
IF NOT EXISTS (select * from tblMEMBERS where memID = @ID)
	THROW 50001, ' The ID is NOT exists! ',1 ;
if @fname is null or @fname =''
	THROW 50001, ' Please Insert First Name ',1 ;
if @lname is null or @lname =''
	THROW 50001, ' Please Insert Last Name ',1 ;
if @bdate is null or @bdate > GETDATE()
	THROW 50001, ' Please Insert First Name ',1 ;
if @phone is null or @phone =''
	THROW 50001, ' Please Insert Phone ',1 ;
BEGIN
	UPDATE tblMEMBERS
	SET
		@fname = memFName,
		@lname = memLName,
		@ava = avatar,
		@bdate = memBDate,
		@add = memAddress,
		@gen = memgender,
		@phone = memphone,
		@note = note,
		@card = cardID
	where memID = @ID
END
go
-- DELETE PROMEM
	DROP PROC if exists proDELMEM
go
CREATE PROC proDELMEM
	@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblMEMBERS WHERE memID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
-- Insert Update Delete CONTRACT
go
drop PROC if exists proINSUPCONTRACT
go
CREATE PROC proINSUPCONTRACT 
@ID varchar(10) null ,
@cusID varchar(10) null,
@empID varchar(10) null ,
@sta nvarchar(20) null,
@stament varchar(10) null
as
BEGIN
IF @stament = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblCONTRACTS
		values (@ID,@cusID,@empID,@sta)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @stament = 'update'
BEGIN
IF NOT EXISTS (select * from tblCONTRACTS where contID = @ID)
	THROW 50001, ' The ID is NOT exists! ',1 ;
	UPDATE tblCONTRACTS SET
	cusID = @cusID,
	empID = @empID,
	conStatus = @sta
	WHERE contID = @ID
END

go
drop PROC if exists proDELCONTRACT
go
CREATE PROC proDELCONTRACT
@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblCONTRACTS WHERE contID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- Insert Update Delete DETAILCONTRACT
drop PROC if exists proINSUPDETAILCONTRACT
go
CREATE PROC proINSUPDETAILCONTRACT 
@ID varchar(10) null ,
@repID varchar(10) null,
@ptID varchar(10) null,
@ser int null,
@start Datetime null,
@dis Datetime null,
@status varchar(20) null,
@stament nvarchar(20) null
as
BEGIN
IF @stament = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblDETAILSCONTRACT
		values (@ID,@repID,@ptID,@ser,@start,@dis,@status)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @stament = 'update'
BEGIN

IF NOT EXISTS (select * from tblDETAILSCONTRACT where cont_ID = @ID)
	THROW 50001, ' The ID is NOT exists! ',1 ;
	UPDATE tblDETAILSCONTRACT SET
	receipt_ID= @repID,
	ptID = @ptID,
	servicePACK = @ser,
	dateStart = @start,
	dateDischarge = @dis,
	status = @status
	WHERE cont_ID = @ID
END

go
drop PROC if exists proDELDETAILCONTRACT
go
CREATE PROC proDELDETAILCONTRACT
@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblDETAILSCONTRACT WHERE cont_ID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- PROCEDURE PRODUCT
drop PROC if exists proINSUPPRODUCT
go
CREATE PROC proINSUPPRODUCT
@ID int null,
@pic image null,
@name nvarchar(20) null,
@cost decimal null,
@sta varchar(20) null 
as 
BEGIN
IF @sta = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblPRODUCTS
		values (@ID,@pic,@name,@cost)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @sta = 'update'
BEGIN
	UPDATE tblPRODUCTS SET
	picture = @pic,
	proName = @name,
	proCost = @cost
	WHERE proID = @ID
END
go
-- Dynamic SQL
drop PROC if exists proDELPRODUCT
go
CREATE PROC proDELPRODUCT
@ID varchar(10)
AS 

BEGIN
	
	--DELETE FROM tblPRODUCTS WHERE proID = @ID;
	declare @sql as nvarchar(1000);
	set @sql = 'DELETE FROM tblPRODUCTS WHERE proID = @a;';
	exec sp_executesql
	@stmt = @sql,
	@params = N'@a AS VARCHAR(10)',
	@a = @ID;
	
END
go

--PROCEDURE MACHINES
drop PROC if exists proINSUPMACHINES
go
CREATE PROC proINSUPMACHINES
@ID int null,
@name nvarchar(20) null,
@pic image null,
@info nvarchar(20) null,
@cost int null,
@sta varchar(20) null 
as 
BEGIN
IF @sta = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblMACHINES
		values (@ID,@name,@pic,@info,@cost)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @sta = 'update'
BEGIN
	UPDATE tblMACHINES SET
	
	macName = @name,
	picture = @pic,
	infor = @info,
	amount = @cost
	where macID = @ID
END
go
drop PROC if exists proDELMACHINES
go
CREATE PROC proDELMACHINES
@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblMACHINES WHERE macID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- PROCEDURES RECEIPT
drop PROC if exists proINSUPPROCEIPT
go
CREATE PROC proINSUPPROCEIPT
@ID int null,
@memID varchar(20) null,
@cost decimal null,
@sta varchar(20) null 
as 
BEGIN
IF @sta = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblRECEIPT
		values (@ID,@memID,@cost)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @sta = 'update'
BEGIN
	UPDATE tblRECEIPT SET
	mem_ID = @memID,
	total = @cost
	where receipt_ID = @ID
END
go
drop PROC if exists proDELRECEIPT
go
CREATE PROC proDELRECEIPT
@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblRECEIPT WHERE receipt_ID= @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
--PROCEDURES DETAILRECEIPT
drop PROC if exists proINSUPDETAILRECEIPT
go
CREATE PROC proINSUPDETAILRECEIPT
@ID int null,
@Date DATETIME null,
@brand int null,
@ser int null,
@name nvarchar(20) null,
@period int null,
@total decimal null,
@remain nvarchar(20) null,
@sta varchar(20) null 
as 
BEGIN
IF @sta = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblDETAILSRECEIPT
		values (@ID,@Date,@brand,@ser,@name,@period,@total,@remain)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @sta = 'update'
BEGIN
	UPDATE tblDETAILSRECEIPT SET
	receiptID = @ID,
	receiptDate = @Date,
	idBrand = @brand,
	idService = @ser,
	nameServices = @name,
	period = @period,
	total = @total,
	remain = @remain
END
go
drop PROC if exists proDETAILSRECEIPT
go
CREATE PROC  proDETAILSRECEIPT
@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblDETAILSRECEIPT WHERE receiptID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
--PROCEDURES SERVICEPACK
drop PROC if exists proSERVICEPACK
go
CREATE PROC proSERVICEPACK
@ID int null,
@name nvarchar(20) null,
@cost decimal null,
@note nvarchar(20) null,
@tagPT varchar(20) null,
@sta varchar(20) null 
as 
BEGIN
IF @sta = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblSERVICEPACK
		values (@ID,@name,@cost,@note,@tagPT)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @sta = 'update'
BEGIN
	UPDATE tblSERVICEPACK SET
	serNAME = @name,
	cost = @cost,
	note = @note,
	tagPT = @tagPT
	where serID = @ID
END
go
drop PROC if exists proDELSERVICEPACK
go
CREATE PROC proDELSERVICEPACk
@ID varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblSERVICEPACK WHERE serID = @ID;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- PROCEDURES checklogin
drop PROC if exists proINSUPCHECKLOGIN
go
CREATE PROC proINSUPCHECKLOGIN
@usr varchar(10) null ,
@login varchar(20) null,
@logout varchar(20) null,
@stament varchar(10) null,
@status varchar(20) null
as
BEGIN
IF @stament = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblChecklogin
		values (@usr,@login,@logout,@status)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @stament = 'update'
BEGIN
	UPDATE tblCHECKLOGIN SET
	loginDate = @login,
	logoutDate = @logout,
	Status = @status
	WHERE usr = @usr
END

go
drop PROC if exists proDELCHECKLOGIN
go
CREATE PROC proCHECKLOGIN
@usr varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblChecklogin WHERE usr = @usr;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- PROCEDURE account
drop PROC if exists proINSUPACCOUNT
go
CREATE PROC proINSUPACCOUNT
@usr varchar(10) null ,
@pass varchar(20) null,
@id int null,
@state varchar(20) null,
@stament varchar(10) null
as
BEGIN
IF @stament = 'insert'
BEGIN TRANSACTION
	BEGIN TRY
		INSERT tblACCOUNT(username,passw,userID,state)
		values (@usr,@pass,@id,@state)
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
End
IF @stament = 'update'
BEGIN
IF NOT EXISTS (select * from tblACCOUNT where username = @ID)
	THROW 50001, ' The ID is NOT exists! ',1 ;
	UPDATE tblACCOUNT SET
	passw = @pass,
	userID = @id,
	state = @state
	WHERE username = @usr
END
go
EXEC proINSUPACCOUNT  'nv200','nv',01,' ', 'insert'
go
drop PROC if exists proDELACCOUNT
go
CREATE PROC proDELACCOUNT
@usr varchar(10)
AS 

BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
	DELETE FROM tblACCOUNT WHERE username = @usr;
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @error nvarchar(1000)
		SELECT @error = 'Error:' + ERROR_MESSAGE()
		RAISERROR (@error , 16, 1)
	END CATCH
END
go
-- Procedure load machines, product, service
drop PROC if exists proLOADMachines
go
CREATE PROC proLOADMachines
as
begin 
select *from tblMACHINES
end
go

drop PROC if exists proLOADProduct
go
CREATE PROC proLOADProduct
as
begin 
select *from tblPRODUCTS
end
go
drop PROC if exists proLOADService
go
CREATE PROC proLOADService
as
begin 
select *from tblSERVICEPACK
end
go
-- Load member
drop PROC if exists proLOADMem
go
CREATE PROC proLOADMem
as
begin 
select *from tblMEMBERS
end
go

--Load Emp
drop PROC if exists proLOADEmp
go
CREATE PROC proLOADEmp
as
begin 
select *from tblEMPLOYEE
end
go
-- Load account
drop PROC if exists sp_proLOADAccount
go
CREATE PROC sp_proLOADAccount
as
begin 
select *from tblACCOUNT
end
go

--Load checklogin
if OBJECT_ID('sp_LOADChecklogin') is not null
		Drop proc sp_LOADChecklogin;
go
CREATE PROC sp_LOADChecklogin
as
begin 
select * from dbo.tblCHECKLOGIN;
end
go

go

--Function 
drop function if exists functGetAccountID
go
create function functGetAccountID(@username varchar(20))

returns table
as
return
(Select userID from tblACCOUNT where username = @username)
go
use DBMS
go
----------VIEW-------
drop view if exists monthStatistic 
go
Create view monthStatistic 
as 
select * from tblDETAILSRECEIPT
where MONTH(GETDATE()) - MONTH(receiptDate) = 30

select * from  monthStatistic 
-------------------------
use master;
go
--Xóa tên đăng nhập
if exists (
	select name
	from master.sys.server_principals
	where name = 'A') 
begin
	drop login login;
end
go

--Tạo đăng nhập mới
if not exists (
	select name
	from master.sys.server_principals
	where name = 'A')
begin 
	create login A
		with password = '123';
end
go
--kiểm tra
select * 
from master.sys.server_principals
where name = 'A';
go

use DBMS
go
--Tạo người dùng
if USER_ID ('A') is null
	begin 
		CREATE USER A FOR LOGIN A;
		alter role [db_owner] add member [A];
	end
go
--xóa schema tên là A nếu tồn tại
drop schema if exists A;
go
--tạo chema tên là A với người dùng A là chủ sở hữu
create schema A authorization A;
go
--kiểm tra
select * from sys.schemas
where name = 'A';
go

--Chỉ dinh A là default_schema
alter user A
	with default_schema = A;
go
--Kiem tra
select name, default_schema_name
from sys.database_principals
where name = 'A';
go
--Chuyển bảng DANGNHAP và PHANQUYEN từ schema dbo sang schema login

alter schema A transfer dbo.tblINFOPT
go




