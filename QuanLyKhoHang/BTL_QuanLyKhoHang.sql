create database BTL_QuanLyKhoHang;
use BTL_QuanLyKhoHang;

create table TaiKhoan(
	ID_TaiKhoan int primary key identity,
	Ten_TaiKhoan varchar(30) not null unique,
	MatKhau_TaiKhoan varchar(30) not null
)

create table HangHoa(
	MaHang varchar(30) primary key,
	TenHang varchar(50),
	SoLuongTon int not null,
	DonViTinh varchar(20),
	DonGia float not null,
	MoTa varchar(100),
	NhaSanXuat varchar(100),
	ID_TaiKhoan int foreign key references TaiKhoan(ID_TaiKhoan) not null
)

create table NhanVien(
	MaNhanVien varchar(30) primary key,
	HoTen varchar(50),
	SoDienThoai varchar(10),
	DiaChi varchar(100),
	NgayVaoLam date,
	ID_TaiKhoan int foreign key references TaiKhoan(ID_TaiKhoan) not null
)

create table PhieuNhap(
	MaPhieuNhap varchar(30) primary key,
	NgayNhap date,
	MaNhanVien varchar(30) foreign key references NhanVien(MaNhanVien),
	NhaCungCap varchar(50),
	MaHang varchar(30) foreign key references HangHoa(MaHang),
	SoLuongNhap int not null,
	ID_TaiKhoan int foreign key references TaiKhoan(ID_TaiKhoan) not null
)

create table PhieuXuat(
	MaPhieuXuat varchar(30) primary key,
	NgayXuat date,
	MaNhanVien varchar(30) foreign key references NhanVien(MaNhanVien),
	KhachHang varchar(50),
	MaHang varchar(30) foreign key references HangHoa(MaHang),
	SoLuongXuat int not null,
	ThanhTien float,
	ID_TaiKhoan int foreign key references TaiKhoan(ID_TaiKhoan) not null
)

create table QuanLyKho(
	MaHang varchar(30) foreign key references HangHoa(MaHang),
	MaKe varchar(10),
	TenKe varchar(10),
	Tang varchar(10),
	Ngan varchar(10),
	ID_TaiKhoan int foreign key references TaiKhoan(ID_TaiKhoan) not null,
	primary key(MaHang)
)

create trigger update_SoLuongNhap_SoLuongTon on PhieuNhap
after update
as
begin
	update HangHoa
	set SoLuongTon = SoLuongTon - deleted.SoLuongNhap + inserted.SoLuongNhap
	from HangHoa
	inner join inserted on HangHoa.MaHang = inserted.MaHang
	inner join deleted on HangHoa.MaHang = deleted.MaHang
end

create trigger update_SoLuongXuat_SoLuongTon on PhieuXuat
after update
as
begin
	update HangHoa
	set SoLuongTon = SoLuongTon + deleted.SoLuongXuat - inserted.SoLuongXuat
	from HangHoa
	inner join inserted on HangHoa.MaHang = inserted.MaHang
	inner join deleted on HangHoa.MaHang = deleted.MaHang
end

create trigger tinh_ThanhTien on PhieuXuat
after insert, update
as
begin
	update PhieuXuat
	set ThanhTien = inserted.SoLuongXuat * HangHoa.DonGia
	from PhieuXuat
	inner join inserted on PhieuXuat.MaPhieuXuat = inserted.MaPhieuXuat
	inner join HangHoa on inserted.MaHang = HangHoa.MaHang
end