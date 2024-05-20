USE master 
GO
ALTER DATABASE QuanLyBanVeXe set single_user with rollback immediate
DROP DATABASE QuanLyBanVeXe
DROP DATABASE if exists QuanLyBanVeXe;
GO
CREATE DATABASE QuanLyBanVeXe
GO
USE QuanLyBanVeXe
GO
drop table if exists CHUYENXE;
drop table if exists KHACHHANG;
drop table if exists LOAINV;
drop table if exists NHANVIEN;
drop table if exists TAIXE;
drop table if exists TUYENXE;
drop table if exists VEXE;
drop table if exists XE;
drop table if exists CHITIETCHUYENXE;
drop table if exists CHITIETVEXE;

/*==============================================================*/
/* Table: LOAINV                                                */
/*==============================================================*/
create table LOAINV 
(
   MALOAINV     int             identity(1,1) not null,
   TENLOAI      nvarchar(20)    null,
   primary key (MALOAINV)
);

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN 
(
   MANV         int             identity(1,1) not null,
   TENNV        nvarchar(30)    null,
   CMND         nchar(20)       not null,
   SDT          nchar(20)       null,
   EMAIL        nvarchar(50)    null,
   MALOAINV     int             foreign key(MALOAINV)	references LOAINV(MALOAINV),
   primary key (MANV)
);

/*==============================================================*/
/* Table: TUYENXE                                               */
/*==============================================================*/
create table TUYENXE 
(
   MATUYEN      int             identity(1,1) not null,
   DIEMDI       nvarchar(20)    null,
   DIEMDEN      nvarchar(20)    null,
   primary key (MATUYEN)
);

/*==============================================================*/
/* Table: CHUYENXE                                              */
/*==============================================================*/
create table CHUYENXE 
(
   MACHUYEN     int             identity(1,1) not null,
   TENCHUYEN    nvarchar(50)    null,
   GIODI        datetime        null,
   GIODEN       datetime        null,
   GIAVE        money           null,
   MATAIXE		INT				foreign key(MATAIXE)	references NHANVIEN(MANV),
   MATUYEN      int             foreign key(MATUYEN)	references TUYENXE(MATUYEN),
   primary key (MACHUYEN)
);

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG 
(
   MAKH         int             identity(1,1) not null,
   TENKH        nvarchar(30)    null,
   NGAYSINH     datetime        null,
   SDT          nchar(20)       null,
   EMAIL		nvarchar(50)		null
   primary key (MAKH)
);

/*==============================================================*/
/* Table: VEXE                                                  */
/*==============================================================*/
create table VEXE 
(
   MAVE         int             identity(1,1) not null,
   TENVE        nvarchar(50)    null,
   GHICHU       nvarchar(50)    null, 
   MACTVX		int				null,
   MACHUYEN     int             foreign key(MACHUYEN)	references CHUYENXE(MACHUYEN),
   MAKH         int             foreign key(MAKH)		references KHACHHANG(MAKH),
   primary key (MAVE)
);

/*==============================================================*/
/* Table: XE                                                    */
/*==============================================================*/
create table XE 
(
   MAXE         int             identity(1,1) not null,
   TENXE        nvarchar(50)    null,
   BIENSO       nchar(20)       null,
   SOGHE        int             null,
   primary key (MAXE)
);

/*==============================================================*/
/* Table: CHITIETVEXE                                           */
/*==============================================================*/
create table CHITIETVEXE 
(
   MACTVX       int             identity(1,1) not null,
   GIODI        datetime        null,
   GIODEN       datetime        null,
   VITRIGHE     nchar(5)        null,
   GIAVE        money			null,
   TRANGTHAI    nvarchar(20)	null,
   MAXE         int             foreign key(MAXE)		references XE(MAXE),
   MAVE         int             foreign key(MAVE)		references VEXE(MAVE),
   primary key (MACTVX)
);

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN
(
   MATK			int				identity(1,1) not null,
   ACCOUNT		char(50)		null,
   PASSWORD		char(50)		null,
   MAKH			int				foreign key(MAKH)		references KHACHHANG(MAKH)
   primary key (MATK)
)

--alter table CHITIETCHUYENXE	add constraint MANV		foreign key(MANV)		references NHANVIEN(MANV)
--alter table CHITIETCHUYENXE	add constraint MATAIXE	foreign key(MATAIXE)	references TAIXE(MATAIXE)
--alter table CHITIETCHUYENXE	add constraint MACHUYEN foreign key(MACHUYEN)	references CHUYENXE(MACHUYEN)
--alter table CHITIETVEXE		add constraint MAXE		foreign key(MAXE)		references XE(MAXE)
--alter table CHITIETVEXE		add constraint MAVE		foreign key(MAVE)		references VEXE(MAVE)
--alter table VEXE				add constraint MAKH		foreign key(MAKH)		references KHACHHANG(MAKH)
--alter table VEXE				add constraint MACHUYEN foreign key(MACHUYEN)	references CHUYENXE(MACHUYEN)
--alter table NHANVIEN			add constraint MALOAINV	foreign key(MALOAINV)	references LOAINV(MALOAINV)
--alter table CHUYENXE			add constraint MATUYEN	foreign key(MATUYEN)	references TUYENXE(MATUYEN)

ALTER TABLE vexe ADD CONSTRAINT  MACTVX FOREIGN KEY(MACTVX) REFERENCES chitietvexe(MACTVX) 

-- XÓA DỮ LIỆU TRONG CÁC BẢNG
delete from CHUYENXE
delete from TUYENXE
delete from XE
delete from NHANVIEN
delete from LOAINV
delete from TAIKHOAN where ACCOUNT <> 'admin'
delete from KHACHHANG
delete from VEXE
delete from CHITIETVEXE

-- RESET AUTO_INCREAMENT
DBCC CHECKIDENT (CHUYENXE, RESEED, 1)
DBCC CHECKIDENT (TUYENXE, RESEED, 1)
DBCC CHECKIDENT (XE, RESEED, 1)
DBCC CHECKIDENT (NHANVIEN, RESEED, 1)
DBCC CHECKIDENT (LOAINV, RESEED, 1)
DBCC CHECKIDENT (TAIKHOAN, RESEED, 1)
DBCC CHECKIDENT (KHACHHANG, RESEED, 1)
DBCC CHECKIDENT (VEXE, RESEED, 1)
DBCC CHECKIDENT (CHITIETVEXE, RESEED, 1)

-- THÊM MỚI DỮ LIỆU
-- Loại nhân viên
INSERT INTO LOAINV(TENLOAI) VALUES (N'Nhân viên hỗ trợ')
INSERT INTO LOAINV(TENLOAI) VALUES (N'Quản lý chuyến xe')
INSERT INTO LOAINV(TENLOAI) VALUES (N'Nhân viên soát vé')
INSERT INTO LOAINV(TENLOAI) VALUES (N'Nhân viên an ninh')
INSERT INTO LOAINV(TENLOAI) VALUES (N'Tài xế')

-- Nhân viên
INSERT INTO NHANVIEN(TENNV,CMND,SDT,EMAIL,MALOAINV) VALUES 
(N'Đặng Minh Nghĩa',		'111111111111','0123123123','nghia@gmail.com',1),
(N'Trương Quang Phát',		'222222222222','0123456789','phat@gmail.com',1),
(N'Nguyễn Ái Thiềm Định',	'333333333333','0239537148','dinh@gmail.com',1),
(N'Phạm Ngọc Thanh Thảo',	'224426205522','0528215947','hoangz@gmail.com',1),
(N'Đặng Tiến Anh',			'654309174406','0155553739','kaka@gmail.com',1),
(N'Đặng Tiến Anh',			'457356414541','0597627570','mothaibanam@gmail.com',1),
(N'Nguyễn Thị Kim Hào',		'894517914263','0483883085','deeznut@gmail.com',2),
(N'Phạm Ngọc Lánh',			'599406425321','0468171235','khabanh@gmail.com',2),
(N'Đặng Khánh Linh',		'724399276242','0560126193','alolaoa@gmail.com',2),
(N'Đặng Văn Cẩn',			'379899828569','0609782104','dinhngu@gmail.com',2),
(N'Tống Thị Thúy Hòa',		'205972125541','0732151374','conginuadau@gmail.com',3),
(N'Phạmvăn Hinh',			'812511772689','0171776400','longlong@gmail.com',3),
(N'Nguyễn Thị Phương Nam',	'130625601702','0131530769','lowgigi@gmail.com',3),
(N'Đỗ Thị Minh Phương',		'886442251463','0134039111','hhihi@gmail.com',3),
(N'Nguyễn Bảo Giang',		'928120713144','0336271886','zetzet@gmail.com',4),
(N'Nguyễn Thị Kim Hào',		'355340382995','0591965549','viprogamer@gmail.com',4),
(N'Dương Thị Mỹ Trinh',		'219432451880','0973237929','hocngunhatlop@gmail.com',4),
(N'Trần Nhật Thy',			'261688085552','0924281102','songvui@gmail.com',4),
(N'Nguyễn Ngọc Qúi',		'532160149431','0408264651','khoctronglong@gmail.com',5),
(N'Đặng Thị Thanh Trúc',	'112627308407','0912359649','gacon@gmail.com',5),
(N'Đinh Trọng Tùng Sơn',	'897326565876','0810715550','vitcon@gmail.com',5),
(N'Lê Khả Mạnh',			'555244745867','0676320204','mamama@gmail.com',5),
(N'Phạm Nữ Huỳnh Thương',	'899143617169','0359405152','truiui@gmail.com',5),
(N'Phan Ngọc Hạnh Như',		'947513456093','0220345205','werrwer@gmail.com',5),
(N'Hoàng Hồng Nhung',		'998411617829','0349705574','hayyy@gmail.com',5),
(N'Nguyễn Viết Hải Vương',	'787496000333','0148990215','dangcap@gmail.com',5),
(N'Lê Thị Ánh Vy',			'927955961131','0303213054','yasuo1@gmail.com',5),
(N'Hoàng Thị Hường',		'588800818094','0589683433','giday2@gmail.com',5),
(N'Cao Huy Tấn Lộc',		'498925300928','0196984614','hmmmmmm@gmail.com',5),
(N'Nguyễn Phương Thùy',		'869168912605','0346178649','concung@gmail.com',5),
(N'Nguyễn Đức Sâm',			'371410281646','0741152496','hocbaitoiqua@gmail.com',5)

-- Tuyến xe
INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES 
(N'TP Hồ Chí Minh',N'Quảng Bình'),
(N'TP Hồ Chí Minh',N'Huế'),
(N'TP Hồ Chí Minh',N'Khánh Hòa'),
(N'TP Hồ Chí Minh',N'Đà Lạt'),
(N'Quảng Bình',N'TP Hồ Chí Minh'),
(N'Khánh Hòa',N'TP Hồ Chí Minh'),
(N'Huế',N'TP Hồ Chí Minh'),
(N'Đà Lạt',N'TP Hồ Chí Minh')

-- Chuyến xe
INSERT INTO CHUYENXE(TENCHUYEN,GIODI,GIODEN,GIAVE,MATAIXE,MATUYEN) VALUES
(N'Chuyến TPHCM-QB 1','2024-06-01 10:30','2024-06-02 12:30',700000,25,1),
(N'Chuyến TPHCM-QB 2','2024-06-01 15:30','2024-06-02 17:30',500000,26,1),
(N'Chuyến TPHCM-QB 3','2024-06-01 18:30','2024-06-02 20:30',500000,27,1),
(N'Chuyến TPHCM-QB 4','2024-06-01 21:00','2024-06-02 23:30',900000,28,1),
(N'Chuyến TPHCM-QB 5','2024-06-05 10:30','2024-06-06 12:30',750000,29,1),
(N'Chuyến TPHCM-QB 6','2024-06-05 13:30','2024-06-06 12:30',550000,25,1),
(N'Chuyến TPHCM-QB 7','2024-06-05 20:30','2024-06-06 12:30',750000,26,1),
(N'Chuyến TPHCM-QB 8','2024-06-10 8:00','2024-06-11 10:00',550000,30,1),
(N'Chuyến TPHCM-QB 9','2024-06-10 11:00','2024-06-02 12:30',900000,29,1),
(N'Chuyến TPHCM-QB 10','2024-06-17 10:30','2024-06-18 12:30',800000,28,1),
(N'Chuyến TPHCM-QB 11','2024-06-17 15:30','2024-06-18 17:30',700000,26,1),
(N'Chuyến TPHCM-Huế 1','2024-05-28 13:00','2024-05-28 13:00',500000,30,2),
(N'Chuyến TPHCM-Huế 2','2024-05-28 20:00','2024-05-28 20:00',550000,21,2),
(N'Chuyến TPHCM-Huế 3','2024-06-02 13:00','2024-06-02 13:00',650000,22,2),
(N'Chuyến TPHCM-Huế 4','2024-06-02 20:00','2024-06-02 20:00',750000,23,2),
(N'Chuyến TPHCM-Huế 5','2024-06-07 13:00','2024-06-07 13:00',500000,24,2),
(N'Chuyến TPHCM-Huế 6','2024-06-07 20:00','2024-06-07 20:00',550000,25,2),
(N'Chuyến TPHCM-K.Hòa 1','2024-06-15 20:00','2024-06-16 05:00',300000,20,3),
(N'Chuyến TPHCM-K.Hòa 2','2024-06-18 13:20','2024-06-16 22:00',300000,21,3),
(N'Chuyến TPHCM-K.Hòa 3','2024-06-18 17:30','2024-06-19 02:30',350000,22,3),
(N'Chuyến TPHCM-K.Hòa 4','2024-06-18 20:00','2024-06-19 05:00',350000,23,3),
(N'Chuyến TPHCM-K.Hòa 5','2024-06-25 15:30','2024-06-25 19:30',400000,24,3),
(N'Chuyến TPHCM-K.Hòa 6','2024-06-25 18:30','2024-06-16 03:40',300000,25,3),
(N'Chuyến TPHCM-K.Hòa 7','2024-07-01 10:30','2024-07-01 19:30',200000,26,3),
(N'Chuyến TPHCM-K.Hòa 8','2024-07-01 15:50','2024-07-02 00:00',250000,27,3),
(N'Chuyến TPHCM-K.Hòa 9','2024-07-04 20:30','2024-07-05 04:00',300000,28,3),
(N'Chuyến TPHCM-Đà Lạt 1','2024-06-04 00:30','2024-06-04 08:30',300000,19,4),
(N'Chuyến TPHCM-Đà Lạt 2','2024-06-04 05:30','2024-06-04 13:30',300000,22,4),
(N'Chuyến TPHCM-Đà Lạt 3','2024-06-04 10:30','2024-06-04 18:30',300000,24,4),
(N'Chuyến TPHCM-Đà Lạt 4','2024-06-08 00:30','2024-06-08 08:30',300000,26,4),
(N'Chuyến TPHCM-Đà Lạt 5','2024-06-08 05:30','2024-06-08 13:30',300000,28,4),
(N'Chuyến TPHCM-Đà Lạt 6','2024-06-08 10:30','2024-06-08 18:30',300000,30,4),
(N'Chuyến TPHCM-Đà Lạt 7','2024-06-12 00:00','2024-06-12 08:00',300000,29,4),
(N'Chuyến TPHCM-Đà Lạt 8','2024-06-12 10:00','2024-06-12 18:00',300000,27,4),
(N'Chuyến QB-TPHCM 1','2024-06-02 10:30','2024-06-03 12:30',700000,21,5),
(N'Chuyến QB-TPHCM 2','2024-06-02 15:30','2024-06-03 17:30',500000,31,5),
(N'Chuyến QB-TPHCM 3','2024-06-02 18:30','2024-06-03 20:30',500000,29,5),
(N'Chuyến QB-TPHCM 4','2024-06-02 21:00','2024-06-03 23:30',900000,27,5),
(N'Chuyến QB-TPHCM 5','2024-06-06 10:30','2024-06-07 12:30',750000,29,5),
(N'Chuyến QB-TPHCM 6','2024-06-06 13:30','2024-06-07 15:30',550000,25,5),
(N'Chuyến QB-TPHCM 7','2024-06-06 20:30','2024-06-07 22:30',750000,26,5),
(N'Chuyến QB-TPHCM 8','2024-06-11 8:00','2024-06-12 10:00',550000,30,5),
(N'Chuyến K.Hòa-TPHCM 1','2024-06-16 18:00','2024-06-17 03:00',300000,25,6),
(N'Chuyến K.Hòa-TPHCM 2','2024-06-16 20:00','2024-06-17 05:00',350000,23,6),
(N'Chuyến K.Hòa-TPHCM 3','2024-06-30 18:00','2024-07-01 03:00',300000,21,6),
(N'Chuyến K.Hòa-TPHCM 4','2024-06-30 20:00','2024-07-01 05:00',300000,19,6),
(N'Chuyến Huế-TPHCM 1','2024-05-22 06:00','2024-05-23 06:00',500000,19,7),
(N'Chuyến Huế-TPHCM 2','2024-05-22 10:00','2024-05-23 10:00',500000,20,7),
(N'Chuyến Huế-TPHCM 3','2024-05-28 06:00','2024-05-29 06:00',450000,21,7),
(N'Chuyến Huế-TPHCM 4','2024-05-28 10:00','2024-05-29 10:00',450000,22,7),
(N'Chuyến Huế-TPHCM 5','2024-05-30 06:00','2024-05-31 06:00',500000,23,7),
(N'Chuyến Đà Lạt-TPHCM 1','2024-05-25 00:00','2024-05-25 08:00',300000,29,8),
(N'Chuyến Đà Lạt-TPHCM 2','2024-05-26 00:00','2024-05-26 08:00',300000,31,8)

-- Xe
INSERT INTO XE(TENXE,BIENSO,SOGHE) VALUES
('Limousine 40A','59B-663.99',40),
('Limousine 40A','59B-567.11',40),
('Limousine 40A','59B-513.22',40),
('Limousine 40A','60B-817.33',40),
('Limousine 40A','60B-384.44',40),
('Limousine 40B','60B-660.55',40),
('Limousine 40B','60B-943.66',40),
('Limousine 40B','60B-753.77',40),
('Limousine 42A','73B-268.88',42),
('Limousine 42A','73B-805.99',42),
('Limousine 42A','73B-741.11',42),
('Limousine 42B','73B-141.22',42),
('Limousine 42B','59B-950.33',42)

-- Khách hàng 
INSERT INTO KHACHHANG(TENKH,NGAYSINH,SDT,EMAIL) VALUES
(N'Dương Minh Hiển','1992-02-23','0889092010','zzzz@gmail.com'),
(N'Ngô Quang Thủy','1983-12-13','0475655816','haiya@gmail.com'),
(N'Trần Minh Dương','1975-04-21','0486596073','kungfupanther@gmail.com')

-- Tài khoản				  
INSERT INTO TAIKHOAN(ACCOUNT,PASSWORD) VALUES ('admin','2251022057731868917119086224872421513662')
INSERT INTO TAIKHOAN(ACCOUNT,PASSWORD,MAKH) VALUES
('yasuovippro','3244185981728979115075721453575112',1), --pass la 123
('toibidien','3244185981728979115075721453575112',2),
('contrai','3244185981728979115075721453575112',3)

GO
/*==============================================================*/
/* Stored procedure: DANGNHAP   (Đăng nhập tài khoản)           */
/*==============================================================*/
CREATE OR ALTER PROC DANGNHAP @taikhoan char(50), @matkhau char(50)
AS 
BEGIN
	select * from taikhoan where ACCOUNT = @taikhoan and PASSWORD = @matkhau COLLATE SQL_Latin1_General_CP1_CS_AS
END

GO

create or alter proc GETKHACHHANG @taikhoan char(50)
as
begin
	select KHACHHANG.MAKH, TENKH, NGAYSINH, SDT, EMAIL from KHACHHANG join TAIKHOAN on KHACHHANG.MAKH=TAIKHOAN.MAKH where TAIKHOAN.ACCOUNT=@taikhoan
end

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách tài khoản		            */
/*==============================================================*/
CREATE OR ALTER PROC DSTAIKHOAN
AS 
BEGIN
	select MATK, ACCOUNT, MAKH from TAIKHOAN where ACCOUNT <> 'admin'
END

GO

/*==============================================================*/
/* Stored procedure: Tìm tài khoản theo mã khách hàng           */
/*==============================================================*/
CREATE OR ALTER PROC FindAccountByMaKH @makh int
AS 
BEGIN
	select MATK, ACCOUNT, MAKH from TAIKHOAN where MAKH = @makh
END

GO
/*==============================================================*/
/* Stored procedure: ĐĂNG KÝ	(Đăng ký tài khoản và thông tin)*/
/*==============================================================*/
CREATE OR ALTER PROC DANGKY @tenkh nvarchar(30), @ngaysinh datetime, 
@sdt nchar(20), @email nchar(30), @taikhoan char(50), @matkhau char(50)
AS
BEGIN
	IF (not exists (SELECT * FROM TAIKHOAN T WHERE T.ACCOUNT = @taikhoan))
	BEGIN
		INSERT INTO KHACHHANG(TENKH,NGAYSINH,SDT,EMAIL) VALUES (@tenkh,@ngaysinh,@sdt,@email)
		INSERT INTO TAIKHOAN(ACCOUNT,PASSWORD,MAKH) VALUES (@taikhoan,@matkhau,(SELECT MAX(MAKH) FROM KHACHHANG))
	END
	ELSE RETURN N'Tên tài khoản đã tồn tại!'
END

GO
/*==============================================================*/
/* Stored procedure: ĐỔI MẬT KHẨU				                */
/*==============================================================*/
CREATE OR ALTER PROC DOIMATKHAU @matk int, @mkcu char(50), @mkmoi char(50)
AS
BEGIN
	UPDATE TAIKHOAN
	SET PASSWORD = @mkmoi 
	WHERE MATK = @matk and PASSWORD = @mkcu
END

GO
/*==============================================================*/
/* Stored procedure: LẤY DANH SÁCH KHÁCH HÀNG	                */
/*==============================================================*/
CREATE OR ALTER PROC DSKHACHHANG
AS
BEGIN
	select MAKH,TENKH,NGAYSINH,SDT,EMAIL from KHACHHANG
END

GO
/*==============================================================*/
/* Stored procedure: Tìm khách hàng theo tên	                */
/*==============================================================*/
CREATE OR ALTER PROC TIMKHACHHANGTHEOTEN @tenkh nvarchar(30)
AS
BEGIN
	select MAKH,TENKH,NGAYSINH,SDT,EMAIL from KHACHHANG where dbo.fuConvertToUnsign1(TENKH) like N'%' + dbo.fuConvertToUnsign1(@tenkh) + '%'
END

GO

/*==============================================================*/
/* Stored procedure: Xóa Khách Hàng và tài khoản tương ứng      */
/*==============================================================*/
CREATE OR ALTER PROC XOAKHACHHANG @makh int
AS
BEGIN
	IF (exists (SELECT * FROM KHACHHANG k WHERE k.MAKH = @makh))
	begin
		DELETE FROM TAIKHOAN WHERE MAKH = @makh
		DELETE FROM KHACHHANG WHERE MAKH = @makh
	end
END

GO

/*==============================================================*/
/* Stored procedure: Sửa thông tin khách hàng                   */
/*==============================================================*/
CREATE OR ALTER PROC SUATHONGTINKHACHHANG @makh int, @tenkh nvarchar(30), @ngaysinh datetime, 
@sdt nchar(20), @email nchar(30)
AS
BEGIN
	UPDATE KHACHHANG
	SET TENKH = @tenkh, NGAYSINH = @ngaysinh, SDT = @sdt, EMAIL = @email
	WHERE MAKH = @makh
END

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách tuyến xe                     */
/*==============================================================*/
CREATE OR ALTER PROC DSTUYENXE
AS
BEGIN
	select MATUYEN, DIEMDI, DIEMDEN from TUYENXE
END

GO

/*==============================================================*/
/* Stored procedure: Thêm tuyến xe			                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMTUYENXE @diemdi nvarchar(20), @diemden nvarchar(20)
AS
	IF (not exists (SELECT * FROM TUYENXE WHERE DIEMDI = @diemdi and DIEMDEN = @diemden))
	BEGIN
		INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (@diemdi,@diemden)
	END
	ELSE RETURN N'Tuyến xe đã tồn tại!'

GO
/*==============================================================*/
/* Stored procedure: Xóa tuyến xe			                    */
/*==============================================================*/
CREATE OR ALTER PROC XOATUYENXE @matuyen int
AS 
	DELETE TUYENXE WHERE TUYENXE.MATUYEN = @matuyen

GO
/*==============================================================*/
/* Stored procedure: Tìm tuyến xe bằng điểm đi và điểm đến      */
/*==============================================================*/
CREATE OR ALTER PROC TIMTUYENXE @diemdi nvarchar(20), @diemden nvarchar(20)
AS 
	select MATUYEN, DIEMDI, DIEMDEN from TUYENXE where (dbo.fuConvertToUnsign1(DIEMDI) like N'%' + dbo.fuConvertToUnsign1(@diemdi) + '%') and (dbo.fuConvertToUnsign1(DIEMDEN) like N'%' + dbo.fuConvertToUnsign1(@diemden) + '%')

GO
/*==============================================================*/
/* Stored procedure: Tìm tuyến xe bằng mã tuyến			        */
/*==============================================================*/
CREATE OR ALTER PROC TimTuyenXeByID @ma int
AS 
	select MATUYEN, DIEMDI, DIEMDEN from TUYENXE where MATUYEN = @ma

GO
/*==============================================================*/
/* Stored procedure: lấy danh sách chuyến xe                    */
/*==============================================================*/
CREATE OR ALTER PROC DSCHUYENXE
AS 
BEGIN
	select MACHUYEN, TENCHUYEN, GIODI, GIODEN, GIAVE, MATUYEN, MATAIXE from CHUYENXE
END

GO


/*==============================================================*/
/* Stored procedure: Thêm chuyến xe			                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMCHUYENXE @tenchuyen nvarchar(50), @giodi datetime, @gioden datetime, @giave money, @mataixe int, @matuyen int
AS 
BEGIN
	IF (not exists (SELECT * FROM CHUYENXE WHERE CHUYENXE.TENCHUYEN = @tenchuyen))
	BEGIN
		INSERT INTO CHUYENXE(TENCHUYEN, GIODI, GIODEN, GIAVE, MATAIXE, MATUYEN) VALUES (@tenchuyen, @giodi, @gioden, @giave, @mataixe, @matuyen)
	END
END

GO

/*==============================================================*/
/* Stored procedure: Sửa thông tin chuyến xe                    */
/*==============================================================*/
CREATE OR ALTER PROC SUATHONGTINCHUYENXE @machuyen int, @tenchuyen nvarchar(50), @giodi datetime, @gioden datetime, @giave money
AS
BEGIN
	UPDATE CHUYENXE
	SET TENCHUYEN = @tenchuyen, GIODI = @giodi, GIODEN = @gioden, GIAVE = @giave
	WHERE MACHUYEN = @machuyen
END

GO
/*==============================================================*/
/* Stored procedure: Xóa chuyến xe				                */
/*==============================================================*/
CREATE OR ALTER PROC XOACHUYENXE @machuyen int
AS 
	DELETE CHUYENXE WHERE CHUYENXE.MACHUYEN = @machuyen
GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách xe				                    */
/*==============================================================*/
CREATE OR ALTER PROC DSXE
AS
BEGIN
	select MAXE, TENXE, BIENSO, SOGHE from XE
END

GO
/*==============================================================*/
/* Stored procedure: Tìm xe theo biển số				                    */
/*==============================================================*/
CREATE OR ALTER PROC TIMXE @bienso nchar(20)
AS
BEGIN
	select MAXE, TENXE, BIENSO, SOGHE from XE where BIENSO = @bienso
END

GO
/*==============================================================*/
/* Stored procedure: Thêm xe				                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMXE @tenxe nvarchar(50), @bienso nchar(20), @soghe int
AS 
BEGIN
	IF (not exists (SELECT * FROM XE WHERE XE.BIENSO = @bienso))
	BEGIN
		INSERT INTO XE(TENXE,BIENSO,SOGHE) VALUES (@tenxe, @bienso, @soghe)
	END
	ELSE
		RETURN N'Trùng biển số xe, không thể thêm'
END

GO
/*==============================================================*/
/* Stored procedure: Sửa thông tin xe				            */
/*==============================================================*/
CREATE OR ALTER PROC SUATHONGTINXE @maxe int, @tenxe nvarchar(50), @soghe int
AS
BEGIN
		UPDATE XE
		SET TENXE=@tenxe, SOGHE = @soghe
		WHERE MAXE = @maxe
END

GO
/*==============================================================*/
/* Stored procedure: Xóa xe					                    */
/*==============================================================*/
CREATE OR ALTER PROC XOAXE @maxe int
AS 
	DELETE XE WHERE XE.MAXE = @maxe

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách nhân viên                    */
/*==============================================================*/
CREATE OR ALTER PROC DSNHANVIEN
AS
BEGIN
	select MANV, TENNV, CMND, SDT, EMAIL, MALOAINV from NHANVIEN
END

GO
/*==============================================================*/
/* Stored procedure: Tìm nhân viên theo tên                     */
/*==============================================================*/
CREATE OR ALTER PROC TIMNHANVIENTHEOTEN @tennv nvarchar(30)
AS
BEGIN
	select MANV, TENNV, CMND, SDT, EMAIL, MALOAINV from NHANVIEN where dbo.fuConvertToUnsign1(TENNV) like N'%' + dbo.fuConvertToUnsign1(@tennv) + '%'
END

GO

/*==============================================================*/
/* Stored procedure: lấy danh sách nhân viên là tài xế          */
/*==============================================================*/
CREATE OR ALTER PROC DSTAIXE
AS
BEGIN
	select TENNV 
	from NHANVIEN nv join LOAINV l on nv.MALOAINV = l.MALOAINV 
	where dbo.fuConvertToUnsign1(l.TENLOAI) = dbo.fuConvertToUnsign1(N'tai xe')
END

GO

/*==============================================================*/
/* Stored procedure: Thêm nhân viên			                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMNHANVIEN @tennv nvarchar(30), @cmnd nchar(20), @sdt nchar(20), @email nvarchar(20), @maloainv int
AS 
BEGIN
	IF (not exists (SELECT * FROM NHANVIEN WHERE NHANVIEN.CMND = @cmnd))
	BEGIN
		INSERT INTO NHANVIEN(TENNV,CMND,SDT,EMAIL,MALOAINV) VALUES (@tennv,@cmnd,@sdt,@email,@maloainv)
	END
	ELSE
		RETURN N'Trùng CMND'
END

GO
/*==============================================================*/
/* Stored procedure: Sửa thông tin nhân viên                    */
/*==============================================================*/
CREATE OR ALTER PROC SUATHONGTINNV @manv int, @tennv nvarchar(30), @sdt nchar(20), @email nvarchar(20), @maloainv int
AS 
BEGIN
	IF (exists (SELECT * FROM LOAINV WHERE LOAINV.MALOAINV = @maloainv))
	BEGIN
			UPDATE NHANVIEN
			SET TENNV = @tennv, SDT = @sdt, EMAIL = @email, MALOAINV = @maloainv
			WHERE MANV = @manv
	END
	ELSE 
			RETURN N'Loại NV không phù hợp'
END

GO
/*==============================================================*/
/* Stored procedure: Xóa nhân viên			                    */
/*==============================================================*/
CREATE OR ALTER PROC XOANHANVIEN @manv int
AS 
	DELETE NHANVIEN WHERE NHANVIEN.MANV = @manv

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách loại nhân viên                    */
/*==============================================================*/
CREATE OR ALTER PROC DSLOAINV
AS
BEGIN
	select MALOAINV, TENLOAI from LOAINV
END

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách tên loại nhân viên                    */
/*==============================================================*/
CREATE OR ALTER PROC DSTENLOAINV
AS
BEGIN
	select TENLOAI from LOAINV
END

GO
/*==============================================================*/
/* Stored procedure: Thêm loại nhân viên	                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMLOAINV @tenloai nvarchar(20)
AS
BEGIN
	IF (not exists (SELECT * FROM LOAINV WHERE LOAINV.TENLOAI = @tenloai))
	BEGIN
		INSERT INTO LOAINV(TENLOAI) VALUES (@tenloai)
	END
	ELSE
		RETURN N'Trùng loại nv'
END

GO
/*==============================================================*/
/* Stored procedure: Xóa loại nhân viên				            */
/*==============================================================*/
CREATE OR ALTER PROC XOALOAINV @maloainv int
AS 
BEGIN
	IF (NOT EXISTS (SELECT * FROM NHANVIEN WHERE MALOAINV = @maloainv))
		DELETE LOAINV WHERE LOAINV.MALOAINV = @maloainv
	ELSE
		RETURN N'Tồn tại nv thuộc loại cần xóa'
END

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách lịch trình			        */
/*==============================================================*/
create or alter proc DSLICHTRINH
as 
begin
	 select MACHUYEN, GIODI, GIODEN, DIEMDI, DIEMDEN,GIAVE
	 from CHUYENXE left join TUYENXE on CHUYENXE.MATUYEN = TUYENXE.MATUYEN
end

GO
/*==============================================================*/
/* Stored procedure: Hàm loại bỏ dấu tiếng Việt để tìm kiếm     */
/*==============================================================*/
CREATE FUNCTION [dbo].[fuConvertToUnsign1]
(
 @strInput NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN 
 IF @strInput IS NULL RETURN @strInput
 IF @strInput = '' RETURN @strInput
 DECLARE @RT NVARCHAR(4000)
 DECLARE @SIGN_CHARS NCHAR(136)
 DECLARE @UNSIGN_CHARS NCHAR (136)
 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế
 ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý
 ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ
 ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'
 +NCHAR(272)+ NCHAR(208)
 SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee
 iiiiiooooooooooooooouuuuuuuuuuyyyyy
 AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII
 OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 DECLARE @COUNTER int
 DECLARE @COUNTER1 int
 SET @COUNTER = 1
 WHILE (@COUNTER <=LEN(@strInput))
 BEGIN 
 SET @COUNTER1 = 1
 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
 BEGIN
 IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1))
 = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
 BEGIN 
 IF @COUNTER=1
 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
 + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
 ELSE
 SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1)
 +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
 + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
 BREAK
 END
 SET @COUNTER1 = @COUNTER1 +1
 END
 SET @COUNTER = @COUNTER +1
 END
 SET @strInput = replace(@strInput,' ','-')
 RETURN @strInput
END
GO

-- NEW!!!! 19/5/2024 10:02pm xóa bảng tài xế và chi tiết tuyến xe + liên kết nhân viên với chuyến xe

--alter table chitietchuyenxe drop constraint FK__CHITIETCH__MATAI__5070F446
--drop table TAIXE
--alter table chitietchuyenxe drop constraint FK__CHITIETCH__MACHU__4E88ABD4
--alter table chitietchuyenxe drop constraint FK__CHITIETCHU__MANV__4F7CD00D
--ALTER table chuyenxe drop constraint MACTCX
--alter table chuyenxe drop column mactcx
--drop table CHITIETCHUYENXE
--alter table CHUYENXE ADD MATAIXE INT null

create or ALTER proc DSDIEMDEN
as 
begin
	 select DISTINCT DIEMDEN FROM TUYENXE
end

go

create or ALTER proc DSDIEMDI
as 
begin
	 select DISTINCT DIEMDI FROM TUYENXE

end

GO

-- Nghĩa thêm SP: DSTAIXE, TimTuyenXeByID, DSCHUYENXE, SỬA PROC THEMCHUYENXE