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
CREATE OR ALTER PROC DANGNHAP @taikhoan char(50), @matkhau char(50)
AS 
BEGIN
	select * from taikhoan where ACCOUNT = @taikhoan and PASSWORD = @matkhau COLLATE SQL_Latin1_General_CP1_CS_AS
END

GO
/*==============================================================*/
/* Stored procedure: Lấy danh sách tài khoản		            */
/*==============================================================*/
CREATE OR ALTER PROC DSTAIKHOAN
AS 
BEGIN
	select MATK, ACCOUNT, MAKH from TAIKHOAN where ACCOUNT = 'admin'
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
/* Stored procedure: XUẤT VÉ					                */
/*==============================================================*/
CREATE OR ALTER PROC XUATVE @makh int, @machuyen int 
AS
BEGIN

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
/* Stored procedure: Thêm chuyến xe			                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMCHUYENXE @tenchuyen nvarchar(50), @giodi datetime, @gioden datetime, @giave money, @matuyen int
AS 
BEGIN
	IF (not exists (SELECT * FROM CHUYENXE WHERE CHUYENXE.TENCHUYEN = @tenchuyen))
	BEGIN
		INSERT INTO CHUYENXE(TENCHUYEN, GIODI, GIODEN, GIAVE, MATUYEN) VALUES (@tenchuyen, @giodi, @gioden, @giave, @matuyen)
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
	DELETE CHITIETCHUYENXE WHERE CHITIETCHUYENXE.MACHUYEN = @machuyen

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
select * from XE
insert into XE values ('Limousine','51A-12345',30)
insert into XE values ('Giuong nam','51A-56789',45)
insert into XE values ('Limousine2','51A-11111',30)
insert into XE values ('Limousine3','51A-22222',30)
/*==============================================================*/
/* Stored procedure: Xóa xe					                    */
/*==============================================================*/
CREATE OR ALTER PROC XOAXE @maxe int
AS 
	DELETE XE WHERE XE.MAXE = @maxe

GO
select * from NHANVIEN
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
/* Stored procedure: Thêm tài xế			                    */
/*==============================================================*/
CREATE OR ALTER PROC THEMTAIXE @tentx nvarchar(30), @cmnd nchar(20), @sdt nchar(20)
AS 
BEGIN
	IF (not exists (SELECT * FROM TAIXE WHERE TAIXE.CMND = @cmnd))
	BEGIN
		INSERT INTO TAIXE(TENTX,CMND,SDT) VALUES (@tentx,@cmnd,@sdt)
	END
END

GO
/*==============================================================*/
/* Stored procedure: Sửa thông tin tài xế	                    */
/*==============================================================*/
CREATE OR ALTER PROC SUATHONGTINTX @mataixe int, @tentx nvarchar(30), @cmnd nchar(20), @sdt nchar(20)
AS 
BEGIN
	UPDATE TAIXE
	SET TENTX = @tentx, CMND = @cmnd, SDT = @sdt
	WHERE MATAIXE = @mataixe
END

GO
/*==============================================================*/
/* Stored procedure: Xóa tài xế				                    */
/*==============================================================*/
CREATE OR ALTER PROC XOATAIXE @mataixe int
AS 
	DELETE TAIXE WHERE TAIXE.MATAIXE = @mataixe

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
	 select * from CHUYENXE left join TUYENXE on CHUYENXE.MATUYEN = TUYENXE.MATUYEN
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
update TAIKHOAN set PASSWORD = '2251022057731868917119086224872421513662' where ACCOUNT = 'admin'

-- NEW!!!! 19/5/2024 10:02pm xóa bảng tài xế và chi tiết tuyến xe + liên kết nhân viên với chuyến xe

alter table chitietchuyenxe drop constraint FK__CHITIETCH__MATAI__5070F446
drop table TAIXE
alter table chitietchuyenxe drop constraint FK__CHITIETCH__MACHU__4E88ABD4
alter table chitietchuyenxe drop constraint FK__CHITIETCHU__MANV__4F7CD00D
ALTER table chuyenxe drop constraint MACTCX
alter table chuyenxe drop column mactcx
drop table CHITIETCHUYENXE
alter table CHUYENXE ADD MATAIXE INT null
ALTER TABLE CHUYENXE ADD CONSTRAINT MATAIXE FOREIGN KEY(MATAIXE) REFERENCES NHANVIEN(MANV)


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

--Nghĩa: Thêm (SP) TIMTUYENXE, TIMKHACHHANGTHEOTEN, FindAccountByMaKH, TIMXE ở phía trên

