DROP DATABASE if exists QuanLyBanVeXe;
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
   MACTCX		int				not null,
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
   EMAIL		nchar(30)		null
   primary key (MAKH)
);

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
   EMAIL        nvarchar(20)    null,
   MALOAINV     int             foreign key(MALOAINV)	references LOAINV(MALOAINV),
   primary key (MANV)
);

/*==============================================================*/
/* Table: TAIXE                                                 */
/*==============================================================*/
create table TAIXE 
(
   MATAIXE      int             identity(1,1) not null,
   TENTX        nvarchar(30)    null,
   CMND         nchar(20)       not null,
   SDT          nchar(20)       null,
   primary key (MATAIXE)
);

/*==============================================================*/
/* Table: VEXE                                                  */
/*==============================================================*/
create table VEXE 
(
   MAVE         int             identity(1,1) not null,
   TENVE        nvarchar(50)    null,
   GHICHU       nvarchar(50)    null, 
   MACTVX		int				not null,
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
/* Table: CHITIETCHUYENXE                                       */
/*==============================================================*/

create table CHITIETCHUYENXE
(
   MACTCX		int				identity(1,1) not null,
   SOGHETRONG	int				null,
   MACHUYEN		int				foreign key(MACHUYEN)	references CHUYENXE(MACHUYEN),
   MANV         int             foreign key(MANV)		references NHANVIEN(MANV),
   MATAIXE		int				foreign key(MATAIXE)	references TAIXE(MATAIXE),
   primary key (MACTCX)
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

ALTER TABLE CHUYENXE ADD CONSTRAINT MACTCX FOREIGN KEY(MACTCX) REFERENCES CHITIETCHUYENXE(MACTCX)
ALTER TABLE vexe ADD CONSTRAINT  MACTVX FOREIGN KEY(MACTVX) REFERENCES chitietvexe(MACTVX) 

--ALTER TABLE CHITIETCHUYENXE ADD MACHUYEN INT NOT NULL
--alter table vexe add mactvx int not null
--ALTER TABLE CHUYENXE ADD MACTCX INT NOT NULL
--ALTER TABLE KHACHHANG ADD EMAIL NCHAR(30) NULL

INSERT INTO LOAINV(TENLOAI) VALUES (N'Nhân viên hỗ trợ')
INSERT INTO LOAINV(TENLOAI) VALUES (N'Quản lý chuyến xe')
INSERT INTO LOAINV(TENLOAI) VALUES (N'Nhân viên soát vé')
INSERT INTO NHANVIEN(TENNV,CMND,SDT,EMAIL,MALOAINV) VALUES (N'Đặng Minh Nghĩa','111','0123123123','nghia@gmail.com',1)
INSERT INTO NHANVIEN(TENNV,CMND,SDT,EMAIL,MALOAINV) VALUES (N'Trương Quang Phát','222','0123456789','phat@gmail.com',1)
INSERT INTO NHANVIEN(TENNV,CMND,SDT,EMAIL,MALOAINV) VALUES (N'Nguyễn Ái Thiềm Định','333','0987654321','dinh@gmail.com',2)

INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (N'TP Hồ Chí Minh',N'Quảng Bình')
INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (N'TP Hồ Chí Minh',N'Huế')
INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (N'TP Hồ Chí Minh',N'Khánh Hòa')
INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (N'Khánh Hòa',N'TP Hồ Chí Minh')
INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (N'Huế',N'TP Hồ Chí Minh')
INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (N'Quảng Bình',N'TP Hồ Chí Minh')

INSERT INTO TAIKHOAN(ACCOUNT,PASSWORD) VALUES ('admin','123456')

--ALTER TABLE TUYENXE DROP COLUMN TENTUYEN
--ALTER TABLE KHACHHANG ADD TAIKHOAN NCHAR(50) NULL
--ALTER TABLE KHACHHANG ADD MATKHAU  NCHAR(50) NULL
--ALTER TABLE KHACHHANG drop column MATKHAU 
--ALTER TABLE KHACHHANG drop column TAIKHOAN 
--ALTER TABLE KHACHHANG ADD CONSTRAINT MATK FOREIGN KEY(MATK) REFERENCES TAIKHOAN(MATK)
--ALTER TABLE KHACHHANG drop CONSTRAINT MATK
--ALTER TABLE KHACHHANG DROP COLUMN CMND 
GO
/*==============================================================*/
/* Stored procedure: DANGNHAP   (Đăng nhập tài khoản)           */
/*==============================================================*/
CREATE PROC DANGNHAP @taikhoan char(50), @matkhau char(50)
AS 
BEGIN
	select * from taikhoan where ACCOUNT = @taikhoan and PASSWORD = @matkhau
END

GO

/*==============================================================*/
/* Stored procedure: ĐĂNG KÝ	(Đăng ký tài khoản và thông tin)*/
/*==============================================================*/
CREATE PROC DANGKY @tenkh nvarchar(30), @ngaysinh datetime, 
@sdt nchar(20), @email nchar(30), @taikhoan char(50), @matkhau char(50)
AS
BEGIN
	IF (not exists (SELECT * FROM TAIKHOAN T WHERE T.ACCOUNT = @taikhoan))
	BEGIN
		INSERT INTO KHACHHANG(TENKH,NGAYSINH,SDT,EMAIL) VALUES (@tenkh,@ngaysinh,@sdt,@email)
		INSERT INTO TAIKHOAN(ACCOUNT,PASSWORD,MAKH) VALUES (@taikhoan,@matkhau,(SELECT MAX(MAKH) FROM KHACHHANG))
		RETURN 1
	END
	ELSE PRINT(N'Tên tài khoản đã tồn tại!')
	RETURN 0
END

GO

CREATE PROC DOIMATKHAU @matk int, @mkcu char(50), @mkmoi char(50)
AS
BEGIN
	UPDATE TAIKHOAN
	SET PASSWORD = @mkmoi 
	WHERE MATK = @matk and PASSWORD = @mkcu
END

GO

CREATE PROC XUATVE @makh int, @machuyen int 
AS
BEGIN
END

GO
/*==============================================================*/
/* Stored procedure: DSKHACHHANG	(Lấy DS tuyến xe)             */
/*==============================================================*/
CREATE PROC DSKHACHHANG
AS
BEGIN
	select MAKH,TENKH,NGAYSINH,SDT,EMAIL from KHACHHANG
END

GO
SELECT * FROM CHUYENXE
/*==============================================================*/
/* Stored procedure: XOAKHACHHANG	(Xóa tài khoản)             */
/*==============================================================*/
CREATe PROC XOAKHACHHANG @makh int
AS
BEGIN
	IF (exists (SELECT * FROM KHACHHANG k WHERE k.MAKH = @makh))
	begin
		DELETE FROM KHACHHANG WHERE MAKH = @makh
		DELETE FROM TAIKHOAN WHERE MAKH = @makh
	end
END

GO
/*==============================================================*/
/* Stored procedure: SUATHONGTINKHACHHANG                       */
/*==============================================================*/
CREATE PROC SUATHONGTINKHACHHANG @makh int, @tenkh nvarchar(30), @ngaysinh datetime, 
@sdt nchar(20), @email nchar(30)
AS
BEGIN
	UPDATE KHACHHANG
	SET TENKH = @tenkh, NGAYSINH = @ngaysinh, SDT = @sdt, EMAIL = @email
	WHERE MAKH = @makh
END

GO

CREATE PROC DSTUYENXE
AS
BEGIN
	select MATUYEN, DIEMDI, DIEMDEN from TUYENXE
END

GO

CREATE PROC THEMTUYENXE @diemdi nvarchar(20), @diemden nvarchar(20)
AS
	IF (not exists (SELECT * FROM TUYENXE WHERE DIEMDI = @diemdi and DIEMDEN = @diemden))
	BEGIN
		INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (@diemdi,@diemden)
	END
	ELSE RETURN N'Tuyến xe đã tồn tại!'

GO
select * from TUYENXE
CREATE PROC XOATUYENXE @matuyen int
AS 
	DELETE TUYENXE WHERE TUYENXE.MATUYEN = @matuyen
GO


CREATE PROC THEMCHUYENXE @tenchuyen nvarchar(50), @giodi datetime, @gioden datetime, @giave money, @matuyen int
AS 
BEGIN
	IF (not exists (SELECT * FROM CHUYENXE WHERE CHUYENXE.TENCHUYEN = @tenchuyen))
	BEGIN
		INSERT INTO CHUYENXE(TENCHUYEN, GIODI, GIODEN, GIAVE, MATUYEN) VALUES (@tenchuyen, @giodi, @gioden, @giave, @matuyen)
	END
END

GO

CREATE PROC SUATHONGTINCHUYENXE @machuyen int, @tenchuyen nvarchar(50), @giodi datetime, @gioden datetime, @giave money
AS
BEGIN
	UPDATE CHUYENXE
	SET TENCHUYEN = @tenchuyen, GIODI = @giodi, GIODEN = @gioden, GIAVE = @giave
	WHERE MACHUYEN = @machuyen
END

GO

CREATE PROC XOACHUYENXE @machuyen int
AS 
	DELETE CHUYENXE WHERE CHUYENXE.MACHUYEN = @machuyen
	DELETE CHITIETCHUYENXE WHERE CHITIETCHUYENXE.MACHUYEN = @machuyen

GO

CREATE PROC THEMXE @tenxe nvarchar(50), @bienso nchar(20), @soghe int
AS 
BEGIN
	IF (not exists (SELECT * FROM XE WHERE XE.BIENSO = @bienso))
	BEGIN
		INSERT INTO XE(TENXE,BIENSO,SOGHE) VALUES (@tenxe, @bienso, @soghe)
	END
END

GO

CREATE PROC SUATHONGTINXE @maxe int, @tenxe nvarchar(50), @bienso nchar(20), @soghe int
AS
BEGIN
	UPDATE XE
	SET TENXE=@tenxe, BIENSO = @bienso, SOGHE = @soghe
	WHERE MAXE = @maxe
END

GO

CREATE PROC XOAXE @maxe int
AS 
	DELETE XE WHERE XE.MAXE = @maxe

GO

CREATE PROC DSNHANVIEN
AS
BEGIN
	select MANV, TENNV, CMND, SDT, EMAIL, MALOAINV from NHANVIEN
END

GO

CREATE PROC THEMNHANVIEN @tennv nvarchar(30), @cmnd nchar(20), @sdt nchar(20), @email nvarchar(20), @maloainv int
AS 
BEGIN
	IF (not exists (SELECT * FROM NHANVIEN WHERE NHANVIEN.CMND = @cmnd))
	BEGIN
		INSERT INTO NHANVIEN(TENNV,CMND,SDT,EMAIL,MALOAINV) VALUES (@tennv,@cmnd,@sdt,@email,@maloainv)
	END
END

GO

CREATE PROC SUATHONGTINNV @manv int, @tennv nvarchar(30), @cmnd nchar(20), @sdt nchar(20), @email nvarchar(20), @maloainv int
AS 
BEGIN
	UPDATE NHANVIEN
	SET TENNV = @tennv, CMND = @cmnd, SDT = @sdt, EMAIL = @email, MALOAINV = @maloainv
	WHERE MANV = @manv
END

GO

CREATE PROC XOANHANVIEN @manv int
AS 
	DELETE NHANVIEN WHERE NHANVIEN.MANV = @manv

GO

CREATE PROC THEMTAIXE @tentx nvarchar(30), @cmnd nchar(20), @sdt nchar(20)
AS 
BEGIN
	IF (not exists (SELECT * FROM TAIXE WHERE TAIXE.CMND = @cmnd))
	BEGIN
		INSERT INTO TAIXE(TENTX,CMND,SDT) VALUES (@tentx,@cmnd,@sdt)
	END
END

GO

CREATE PROC SUATHONGTINTX @mataixe int, @tentx nvarchar(30), @cmnd nchar(20), @sdt nchar(20)
AS 
BEGIN
	UPDATE TAIXE
	SET TENTX = @tentx, CMND = @cmnd, SDT = @sdt
	WHERE MATAIXE = @mataixe
END

GO

CREATE PROC XOATAIXE @mataixe int
AS 
	DELETE TAIXE WHERE TAIXE.MATAIXE = @mataixe

GO

CREATE PROC THEMLOAINV @tenloai nvarchar(20)
AS
BEGIN
	IF (not exists (SELECT * FROM LOAINV WHERE LOAINV.TENLOAI = @tenloai))
	BEGIN
		INSERT INTO LOAINV(TENLOAI) VALUES (@tenloai)
	END
END

GO

CREATE PROC XOALOAINV @maloainv int
AS 
	DELETE LOAINV WHERE LOAINV.MALOAINV = @maloainv

GO
select * from TUYENXE