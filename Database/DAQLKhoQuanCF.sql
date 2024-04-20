﻿CREATE DATABASE QLKHOQUANCF

GO
USE QLKHOQUANCF

CREATE TABLE LoaiNV 
(
    MaLoaiNV varchar(10) NOT NULL,
    TenLoaiNV nvarchar(20) NOT NULL,
    PRIMARY KEY (MaLoaiNV)
)

CREATE TABLE NhanVien 
(
    MaNV varchar(10) NOT NULL,
    HoNV nvarchar(15) NOT NULL,
    TenNV nvarchar(20) NOT NULL,
    DiaChi nvarchar(30) NOT NULL,
    SDT varchar(15) NOT NULL,
    GioiTinh bit NOT NULL,
    UserName varchar(15) NOT NULL,
    Password varchar(20) NOT NULL,
    MaLoai varchar(10) foreign key(MaLoai) references LoaiNV(MaLoaiNV) NOT NULL,
    PRIMARY KEY (MaNV)
)

CREATE TABLE LoaiHH 
(
    TenLoaiHH nvarchar(20) NOT NULL,
    MaLoaiHH varchar(10) NOT NULL,
    PRIMARY KEY (MaLoaiHH)
)

CREATE TABLE HangHoa (
    MaHH varchar(10) NOT NULL,
    TenHH nvarchar(25) NOT NULL,
    MoTa nvarchar(50) NOT NULL,
    SoLuong int NOT NULL,
    NgayCapNhat datetime DEFAULT GETDATE() NULL,
    MaLoai varchar(10) foreign key(MaLoai) references LoaiHH(MaLoaiHH) NOT NULL,
    PRIMARY KEY (MaHH)
)

CREATE TABLE DonDatHang 
(
    MaDH varchar(10) NOT NULL,
    NgayDat datetime DEFAULT GETDATE() NULL,
    TrangThai nvarchar(20) NOT NULL,
    MaNV varchar(10) foreign key(MaNV) references NhanVien(MaNV) NOT NULL,
    PRIMARY KEY (MaDH)
)

CREATE TABLE YeuCauDatHang 
(
    NgayYC date DEFAULT CONVERT(date, GETDATE()),
    MaNV varchar(10) foreign key(MaNV) references NhanVien(MaNV) NOT NULL,
    MaHH varchar(10) foreign key(MaHH) references HangHoa(MaHH) NOT NULL,
    TrangThai nvarchar(20) NOT NULL,
    CONSTRAINT PK_YCDATHG PRIMARY KEY (NgayYC, MaNV, MaHH)
)

CREATE TABLE YeuCauNhapHang 
(
    NgayYC date DEFAULT CONVERT(date, GETDATE()),
    MaNV varchar(10) foreign key(MaNV) references NhanVien(MaNV) NOT NULL,
    MaHH varchar(10) foreign key(MaHH) references HangHoa(MaHH) NOT NULL,
    TrangThai nvarchar(20) NOT NULL,
    CONSTRAINT PK_YCNHAPHG PRIMARY KEY (NgayYC, MaNV, MaHH)
)

CREATE TABLE ChiTietDH (
    MaDH varchar(10) foreign key(MaDH) references DonDatHang(MaDH) NOT NULL,
    MaHH varchar(10) foreign key(MaHH) references HangHoa(MaHH) NOT NULL,
    SoLuong int NOT NULL,
    GiaNhap float NOT NULL,
    CONSTRAINT PK_CTDH PRIMARY KEY (MaDH, MaHH)
)

CREATE TABLE HangXuatKho 
(
    ID int identity(1,1) NOT NULL,
    NgayXuat datetime DEFAULT GETDATE() NULL,
    MaNV varchar(10) foreign key(MaNV) references NhanVien(MaNV) NOT NULL,
    MaHH varchar(10) foreign key(MaHH) references HangHoa(MaHH) NOT NULL,
    SoLuong int NOT NULL,
    PRIMARY KEY (ID)
)
--------------bảng loại nhân viên----------------------
INSERT INTO LoaiNV (MaLoaiNV, TenLoaiNV)
VALUES ('L01', N'Quản lý'),
       ('L02', N'Nhân viên kho'),
       ('L03', N'Nhân viên bán hàng');

---------bang nhan vien--------------------------------
INSERT INTO NhanVien (MaNV, HoNV, TenNV, DiaChi, SDT, GioiTinh, UserName, Password, MaLoai)
VALUES ('NV001', N'Nguyễn ', N'Trâm', N'1A Nhị Binhg', '0798006706',1, 'NVql', '123', 'L01');
INSERT INTO NhanVien (MaNV, HoNV, TenNV, DiaChi, SDT, GioiTinh, UserName, Password, MaLoai)
VALUES ('NV002', N'Dương', N'Như', N'2B Cách Mạng Tháng 8', '0123999555', 1, 'NVkho', '456', 'L02');
INSERT INTO NhanVien (MaNV, HoNV, TenNV, DiaChi, SDT, GioiTinh, UserName, Password, MaLoai)
VALUES ('NV003', N'Phạm', N'Oanh' ,N'Lê Hồng Phong', '0937444218', 1, 'NVbh', '789', 'L03');
-----------------bang loại hàng hóa---------------------------------------
INSERT INTO LoaiHH (MaLoaiHH, TenLoaiHH)
VALUES ('LH001', N'Nguyên liệu pha chế ');
INSERT INTO LoaiHH (MaLoaiHH, TenLoaiHH)
VALUES ('LH002', N'Dụng cụ pha chế');
INSERT INTO LoaiHH (MaLoaiHH, TenLoaiHH)
VALUES ('LH003', N'Vật dụng khác');
--------------bảng hàng hóa------------------------------------------------------
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH001', N'Cà phê rang xay', N'Cà phê Arabica nguyên chất, rang mộc', 10,GETDATE(), 'LH001');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH002', N'Cà phê hòa tan', N'Cà phê Alibaba nguyên chất, hòa tan ', 10,GETDATE(), 'LH001');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH003', N'Trà xanh', N'Trà xanh túi lọc, hương thơm dịu nhẹ', 20,GETDATE(), 'LH001');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH004', N'Đường', N'Đường mía blackpink ,ngọt sâu đậm', 25,GETDATE(), 'LH001');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH005', N'Sữa đặt', N'Sữa đặt ngôi sao xanh,đậm đà', 20,GETDATE(), 'LH001');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH006', N'Thạch nha đam', N'Thạch nha đam dai ngon, ngọt dịu', 20,GETDATE(),'LH001'); 
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES  ('HH007', N'Trân châu đen', N'Trân châu đen dai giòn, đường đen', 15,GETDATE(), 'LH001');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES  ('HH008', N'Kem muối', N'Kem whipping cream béo ngậy, vị muối đặc biệt', 20,GETDATE(),'LH001');
---LH002-----
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES ('HH010', N'Máy pha cà phê phin', N'Pha cà phê phin truyền thống', 5, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH011', N'Máy pha cà phê espresso', N'Pha cà phê espresso hiện đại', 2, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH012', N'Máy xay sinh tố', N'Xay trái cây, đá viên', 3, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH013', N'Máy đánh kem', N'Đánh kem cheese, whipping cream', 1, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH014', N'Cốc thủy tinh', N'Cốc thủy tinh trong suốt, dung tích 200ml', 20, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH015', N'Ly sứ', N'Ly sứ họa tiết, dung tích 300ml', 15, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH016', N'Bình giữ nhiệt', N'Giữ nóng hoặc lạnh thức uống', 5, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH017', N'Bộ muỗng nĩa cà phê', N'Bộ muỗng nĩa bằng thép không gỉ', 10, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH018', N'Dao cắt bánh', N'Cắt bánh kem, bánh ngọt', 2, GETDATE(), 'LH002');
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES('HH019', N'Máy in hóa đơn', N'In hóa đơn cho khách hàng', 1, GETDATE(), 'LH002');
-----LH003---------
INSERT INTO HangHoa (MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai)
VALUES
-- Bàn ghế
('HH020', N'Bàn cafe', N'Bàn gỗ 4 chỗ ngồi', 5, GETDATE(), 'LH003'),
('HH021', N'Ghế cafe', N'Ghế gỗ có đệm', 10, GETDATE(), 'LH003'),
-- Ô dù
('HH022', N'Ô dù che nắng', N'Ô dù che nắng ngoài trời', 2, GETDATE(), 'LH003');
------------bảng đơn đặt hàng---------------
INSERT INTO DonDatHang (MaDH, NgayDat, TrangThai, MaNV)
VALUES
  ('DH001', GETDATE(), N'Chờ xác nhận', 'NV001'),  
  ('DH002', DATEADD(day, -2, GETDATE()), N'Đang xử lý', 'NV001'),
  ('DH003', DATEADD(day, -5, GETDATE()), N'Đã hoàn thành', 'NV001');  
  ------bang yeu cau nhap hang--------
  INSERT INTO YeuCauDatHang (NgayYC, MaNV, MaHH, TrangThai)
VALUES
  (GETDATE(), 'NV002', 'HH015', N'Chờ xử lý'),  
  (DATEADD(day, -3, GETDATE()), 'NV002', 'HH020', N'Đã phê duyệt'),
  (DATEADD(day, -5, GETDATE()), 'NV002', 'HH005', N'Đã hủy'); 
  -------bang yeu cau nhap hang----------
  INSERT INTO YeuCauNhapHang (NgayYC, MaNV, MaHH, TrangThai)
VALUES
  (GETDATE(), 'NV003', 'HH015', N'Chờ xử lý'),
  (DATEADD(day, -1, GETDATE()), 'NV003', 'HH001', N'Đã phê duyệt'),
  (DATEADD(day, -2, GETDATE()), 'NV003', 'HH005', N'Đã hủy'),
  (DATEADD(day, -3, GETDATE()), 'NV003', 'HH006', N'Chờ xử lý'),
  (DATEADD(day, -4, GETDATE()), 'NV003', 'HH022', N'Đã phê duyệt');
  ----------bang chi tiet hd------
 INSERT INTO ChiTietDH (MaDH, MaHH, SoLuong, GiaNhap)
VALUES
  ('DH001', 'HH001', 2, 10000.00),
  ('DH002', 'HH003', 1, 15000.00), 
  ('DH002', 'HH005', 3, 5000.00);  
  --------bang hang xuat kho----------
  INSERT INTO HangXuatKho (NgayXuat, MaNV, MaHH, SoLuong)
VALUES
  (GETDATE(), 'NV002', 'HH001', 5), 
  (DATEADD(day, -2, GETDATE()), 'NV001', 'HH006', 1), 
  (DATEADD(day, -3, GETDATE()), 'NV002', 'HH005', 3); 













       


