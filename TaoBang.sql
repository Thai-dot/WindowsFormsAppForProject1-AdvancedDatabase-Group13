create database QLKH_2
go
use QLKH_2
go

create table KhachHang
(
	MaKH char(9),
	Ho nvarchar(20),
	Ten nvarchar(20),
	NgSinh datetime,
	SoNha int,
	Duong nvarchar(50),
	Phuong nvarchar(50),
	Quan nvarchar(50),
	TPho nvarchar(50),
	DienThoai char(10)
	primary key (MakH)
)

create table HoaDon
(
	MaHD char(9),
	MaKH char(9),
	NgayLap datetime,
	TongTien float
	primary key (MaHD)
)

create table CT_HoaDon
(
	MaHD char(9),
	MaSP char(9),
	SoLuong int,
	GiaBan float,
	GiaGiam float,
	ThanhTien float
	primary key (MaHD, MaSP)
)

create table SanPham
(
	MaSP char(9),
	TenSP nvarchar(20),
	SoLuongTon int,
	Mota nvarchar(50),
	Gia float
	primary key (MaSP)
)

alter table HoaDon add 
	constraint FK_HD_KH foreign key (MaKH) references KhachHang(MaKH)

alter table CT_HoaDon add 
	constraint FK_CTHD_HD foreign key (MaHD) references HoaDon(MaHD), 
	constraint FK_CTHD_SP foreign key (MaSP) references SanPham(MaSP)