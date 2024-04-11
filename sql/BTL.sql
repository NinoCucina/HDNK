Use QLHDNK
Go


Create table B_TrangThai(
	MaTrangThai int primary key,
	TenTrangThai nvarchar(100)
)

Create table KhachSan(
	MaKhachSan int primary key,
	TenKhachSan nvarchar(100) not null,
	SoDienThoai varchar(11) not null
)

Create table Khoi(
	MaKhoi int primary key,
	TenKhoi nvarchar(50)not null
)

Create table Lop(
	MaLop int primary key,
	TenLop nvarchar(50) not null,
	SiSo int not null,
	MaKhoi int,
	constraint FK_Lop_Khoi foreign key(MaKhoi) references Khoi(MaKhoi)
)

Create table GiaoVien(
	MaGiaoVien int primary key,
	TenGiaoVien nvarchar(100) not null,
	MaKhoi int,
	MaLop int,
	SoDienthoai nvarchar(11) not null unique,
	GioiTinh bit
	constraint FK_GiaoVien_Lop foreign key(MaLop) references Lop(MaLop),
	constraint FK_GiaoVien_Khoi foreign key(MaKhoi) references Khoi(MaKhoi)
)

Create table TaiKhoan(
	MaTK int primary key,
	TenTK nvarchar(50)not null,
	MatKhau nvarchar(50)not null,
	MaGiaoVien int,
	constraint FK_Tk foreign key(MaGiaoVien) references GiaoVien(MaGiaoVien)
)

Create table HDNK(
	MaHDNK int primary key,
	TenHDNK nvarchar(100) not null,
	NgayKhoiHanh datetime not null,
	NgayKetThuc datetime not null,
	DiaDiem nvarchar(100) not null,
	GiaTien int not null,
	SoLuongNguoiToiDa int not null,
	SoLuongLopToiDa int not null,
	MaGiaoVien int,
	MaKhachSan int,
	MaTrangThai int,
	constraint FK_TrangThai foreign key(MaTrangThai) references B_TrangThai(MaTrangThai),
	constraint FK_GiaoVien_HDNK foreign key(MaGiaoVien) references GiaoVien(MaGiaoVien),
	constraint FK_MaKhachSan_HDNK foreign key(MaKhachSan) references KhachSan(MaKhachSan)
)

Create table HocSinh(
	MaHocSinh int primary key,
	TenHocSinh nvarchar(100) not null,
	MaKhoi int,
	NgaySinh date not null,
	SDTHS int not null,
	GioiTinh bit not null,
	MaLop int,
	MaHDNK int,
	constraint FK_HocSinh_Lop foreign key(MaLop) references Lop(MaLop),
	constraint FK_HocSinh_Khoi foreign key(MaKhoi) references Khoi(MaKhoi),
	constraint FK_HocSinh_HDNK foreign key(MaHDNK) references HDNK(MaHDNK)
)

create table PHHS(
	MaPHHS int primary key,
	TenPHHS nvarchar(50) not null,
	GioiTinh bit not null,
	SDTPH int not null,
	constraint FK_HocSinh_PHHS foreign key(MaPHHS) references HocSinh(MaHocSinh)
)