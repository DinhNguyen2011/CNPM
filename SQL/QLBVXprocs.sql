USE QuanLyBanVeXe
GO
/*==============================================================*/
/* Stored procedure: DANGNHAP   (Đăng nhập tài khoản)           */
/*==============================================================*/
CREATE PROC DANGNHAP @taikhoan char(50), @matkhau char(50)
AS 
BEGIN
	select * from TAIKHOAN where ACCOUNT = @taikhoan and PASSWORD = @matkhau
END

GO
select * from TAIKHOAN
exec DANGNHAP 'admin','123456'
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
/* Stored procedure: XOATAIKHOAN	(Xóa tài khoản)             */
/*==============================================================*/
CREATE PROC XOATAIKHOAN @matk int
AS
BEGIN
	IF (exists (SELECT * FROM TAIKHOAN T WHERE T.MATK = @matk))
	DELETE FROM TAIKHOAN WHERE TAIKHOAN.MATK = @matk
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

CREATE PROC THEMTUYENXE @diemdi nvarchar(20), @diemden nvarchar(20)
AS
	IF (not exists (SELECT * FROM TUYENXE WHERE DIEMDI = @diemdi and DIEMDEN = @diemden))
	BEGIN
		INSERT INTO TUYENXE(DIEMDI,DIEMDEN) VALUES (@diemdi,@diemden)
	END
	ELSE RETURN N'Tuyến xe đã tồn tại!'

GO

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