USE [master]
GO
/****** Object:  Database [BTL44c]    Script Date: 11/15/2019 2:15:25 AM ******/
CREATE DATABASE [BTL44c]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BTL44c', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BTL44c.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BTL44c_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BTL44c_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BTL44c] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTL44c].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTL44c] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTL44c] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTL44c] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTL44c] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTL44c] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTL44c] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BTL44c] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTL44c] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTL44c] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTL44c] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTL44c] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTL44c] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTL44c] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTL44c] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTL44c] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BTL44c] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTL44c] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTL44c] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTL44c] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTL44c] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTL44c] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTL44c] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTL44c] SET RECOVERY FULL 
GO
ALTER DATABASE [BTL44c] SET  MULTI_USER 
GO
ALTER DATABASE [BTL44c] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTL44c] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTL44c] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTL44c] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BTL44c] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BTL44c', N'ON'
GO
ALTER DATABASE [BTL44c] SET QUERY_STORE = OFF
GO
USE [BTL44c]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nvarchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
	[HSL] [float] NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[MaCV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[QueQuan] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[NgayBatDau] [datetime] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TTNV]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TTNV]
as
select MaNV, TenCV, TenNV, datediff(YEAR, NgaySinh, GETDATE()) as Tuoi, QueQuan, SoDienThoai,
 datediff(YEAR, NgayBatDau, GETDATE()) as ThamNien , HSL*3000000 as Luong
from NHANVIEN inner join CHUCVU on NHANVIEN.MaCV = CHUCVU.MaCV
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[NoiSX] [nvarchar](50) NOT NULL,
	[DGia] [float] NULL,
	[DonViTinh] [nvarchar](20) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SP_B]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SP_B](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SL] [float] NULL,
	[ThanhTien] [int] NULL,
	[ChietKhau] [int] NULL,
 CONSTRAINT [PK_SP_B] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TongTien_HD]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TongTien_HD]
as
select MaHD, sum(SANPHAM.DGia*SL) as TongTien
from SP_B inner join SANPHAM on SP_B.MaSP = SANPHAM.MaSP
group by MaHD
GO
/****** Object:  View [dbo].[TongTien_SL_Ban]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TongTien_SL_Ban]
as
select SANPHAM.MaSP, SANPHAM.TenSP, SANPHAM.DGia, sum(SL) as TongSL,  SUM(SL) * SANPHAM.DGia as TongTien
from SP_B inner join SANPHAM on SP_B.MaSP = SANPHAM.MaSP
group by SANPHAM.MaSP, SANPHAM.TenSP, SANPHAM.DGia
GO
/****** Object:  Table [dbo].[SP_N]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SP_N](
	[MaPN] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SLNhap] [float] NULL,
	[NgayNhap] [datetime] NOT NULL,
	[ChietKhau] [float] NULL,
	[DGia] [float] NULL,
 CONSTRAINT [PK_SP_N] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [nvarchar](10) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaChungTu] [nvarchar](50) NOT NULL,
	[LoaiHD] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TongTien_SL_Nhap]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--4. Tính tổng số lượng và tổng số tiền đã nhập của từng hàng hóa
create view [dbo].[TongTien_SL_Nhap]
as
select  MaSP, DGia as TienNhap, sum(SLNhap) as TongSL, sum(SLNhap * DGia) as TongTienNhap
from SP_N inner join PHIEUNHAP on SP_N.MaPN = PHIEUNHAP.MaPN
group by MaSP, DGia

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](10) NOT NULL,
	[NgayBan] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TongHD_Thang]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--5. Tính tổng số hóa đơn đã lập trong từng tháng năm 2018
create view [dbo].[TongHD_Thang]
as
select Month(NgayBan) as Thang, count(MaHD) as TongHD
from HOADON
where year(NgayBan) = 2018
group by month(NgayBan)
GO
/****** Object:  UserDefinedFunction [dbo].[HD_NV_date]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*2. Tạo hàm lấy danh sách hóa đơn theo nhân viên và ngày (ngày/tháng/năm)*/
create function [dbo].[HD_NV_date] (@manv nvarchar(10), @ngay datetime)
returns table as
return
	select * from HOADON
	where @manv = MaNV and @ngay = NgayBan
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienHD]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*3. Tạo hàm tính tổng tiền của từng hóa đơn với mã hóa đơn là tham số đầu vào*/
create function [dbo].[TongTienHD] (@mahd nvarchar(10))
returns table as
return
	select MaHD, sum(SANPHAM.DGia*SL) as TongTien
	from SP_B inner join SANPHAM on SP_B.MaSP = SANPHAM.MaSP
	where @mahd = MaHD
	group by MaHD
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[NCC_MH]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*4. Tạo hàm lấy danh sách nhà cung cấp theo mã hàng */
create function [dbo].[NCC_MH] (@mahh nvarchar(10))
returns table as
return
	select MaSP, NCC.MaNCC, TenNCC
	from NCC inner join PHIEUNHAP on NCC.MaNCC = PHIEUNHAP.MaNCC inner join SP_N on SP_N.MaPN = PHIEUNHAP.MaPN
	where @mahh = MaSP
GO
/****** Object:  UserDefinedFunction [dbo].[MH_NCC]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--5. Tạo hàm lấy danh sách các mặt hàng theo mã nhà cung cấp 
create function [dbo].[MH_NCC] (@mancc nvarchar(10))
returns table as
return
	select NCC.MaNCC, MaSP 
	from NCC inner join PHIEUNHAP on NCC.MaNCC = PHIEUNHAP.MaNCC inner join SP_N on SP_N.MaPN = PHIEUNHAP.MaPN
	where @mancc = NCC.MaNCC
GO
/****** Object:  UserDefinedFunction [dbo].[NV_year]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--6. Tạo hàm với đầu vào là năm, đầu ra là số nhân viên sinh vào năm đó 
create function [dbo].[NV_year] (@namsinh int)
returns table as
return
	select year(NgaySinh) as Nam, count(manv) as SoNV
	from NHANVIEN
	where @namsinh = year(NgaySinh)
	group by YEAR(NgaySinh)
GO
/****** Object:  UserDefinedFunction [dbo].[ChucVu_NV]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*7. Tạo hàm đầu vào là chức vụ đầu ra là những nhân viên cùng chức vụ đó */
create function [dbo].[ChucVu_NV] (@tencv nvarchar(50))
returns table as
return
	select TenCV, TenNV
	from NHANVIEN inner join CHUCVU on NHANVIEN.MaCV = CHUCVU.MaCV
	where @tencv = TenCV
GO
/****** Object:  UserDefinedFunction [dbo].[NV_QQ]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[NV_QQ] (@qq nvarchar(50))
returns table as
return
select * from NhanVien
where @qq = QueQuan
GO
/****** Object:  Table [dbo].[CT_PKK]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PKK](
	[MaPKK] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SL_NHAP] [float] NULL,
	[SL_BAN] [float] NULL,
 CONSTRAINT [PK_CT_PKK] PRIMARY KEY CLUSTERED 
(
	[MaPKK] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUKIEMKE]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUKIEMKE](
	[MaPKK] [nvarchar](10) NOT NULL,
	[NgayKK] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PHIEUKIEMKE] PRIMARY KEY CLUSTERED 
(
	[MaPKK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HSL]) VALUES (N'CV1', N'Giám Đốc', 6)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HSL]) VALUES (N'CV2', N'Nhân Viên Thu Ngân', 3)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HSL]) VALUES (N'CV3', N'Nhân Viên Kiểm Kê', 3.5)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HSL]) VALUES (N'CV4', N'Nhân Viên Tiếp Thị', 2.8)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HSL]) VALUES (N'CV5', N'Bảo Vệ', 2.5)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HSL]) VALUES (N'CV6', N'Nhân Viên Quản Lý', 4)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK1      ', N'HH1       ', 30, 12)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK1      ', N'HH2       ', 50, 8)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK1      ', N'HH3       ', 60, 20)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK1      ', N'HH4       ', 120, 60)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK1      ', N'HH5       ', 120, 40)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK1      ', N'HH6       ', 120, 50)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK2      ', N'HH10      ', 100, 34)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK2      ', N'HH7       ', 100, 20)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK2      ', N'HH8       ', 100, 18)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK2      ', N'HH9       ', 100, 28)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK3', N'HH1', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK3', N'HH2', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK3', N'HH3', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK3', N'HH4', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK3', N'HH6', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK3', N'HH9', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH12', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH23', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH26', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH3', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH4', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH5', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK4', N'HH8', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK5', N'HH8', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK6', N'HH4', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK6', N'HH5', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK6', N'HH6', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK6', N'HH7', NULL, NULL)
INSERT [dbo].[CT_PKK] ([MaPKK], [MaSP], [SL_NHAP], [SL_BAN]) VALUES (N'PKK6', N'HH8', NULL, NULL)
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD1       ', CAST(N'2018-09-05T00:00:00.000' AS DateTime), N'NV002', N'KH01')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD10', CAST(N'2018-09-05T00:00:00.000' AS DateTime), N'NV010', N'KH01')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD2       ', CAST(N'2018-05-09T00:00:00.000' AS DateTime), N'NV002', N'KH02')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD3       ', CAST(N'2018-09-09T00:00:00.000' AS DateTime), N'NV002', N'KH03')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD4       ', CAST(N'2016-05-07T00:00:00.000' AS DateTime), N'NV002', N'KH01')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD5       ', CAST(N'2016-06-16T00:00:00.000' AS DateTime), N'NV002', N'KH04')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD6', CAST(N'2019-09-09T00:00:00.000' AS DateTime), N'NV006', N'KH01')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD7', CAST(N'2018-06-16T00:00:00.000' AS DateTime), N'NV006', N'KH02')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD8', CAST(N'2015-02-16T00:00:00.000' AS DateTime), N'NV007', N'KH02')
INSERT [dbo].[HOADON] ([MaHD], [NgayBan], [MaNV], [MaKH]) VALUES (N'HD9', CAST(N'2017-06-07T00:00:00.000' AS DateTime), N'NV009', N'KH04')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [SoDienThoai]) VALUES (N'KH01', N'Nguyễn Hàng A', N'123 Cầu Giấy', N'0923670622
')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [SoDienThoai]) VALUES (N'KH02', N'Nguyễn Hàng B', N'456 Kim Mã', N'0927006628
')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [SoDienThoai]) VALUES (N'KH03', N'Nguyễn Hàng C', N'159 Đội Cấn', N'0993669103
')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [SoDienThoai]) VALUES (N'KH04', N'Nguyễn Hàng D', N'77 Hoàng Hoa Thám', N'0952191532
')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [SoDienThoai]) VALUES (N'KH05', N'Nguyễn Hàng E', N'156 Đào Tấn', N'0967864264
')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [DiaChi], [SoDienThoai]) VALUES (N'KH06', N'Nguyễn Hàng G', N'158 Hoàng Quốc Việt', N'0947288165
')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC1', N'Hà Nội 1', N'Hà Nội', N'0120382514
', N'hanoi1@gmail.com')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC2', N'Hà Nội 2', N'Hà Nội', N'0985470179
', N'hanoihai@gmail.com')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC3', N'Sài Gòn 1', N'HCM', N'0159947694
', N'hcm1@gmail.com')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC4', N'Sài Gòn 2', N'HCM', N'0928010802
', N'saigon2@gmail.com')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC5', N'Hải Phòng 1', N'Hải Phòng', N'0125250304
', N'hp1@gmail.com')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC6', N'Hải Phòng 2', N'Hải Phòng', N'0122600335
', N'haiphong2@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV001', N'CV1', N'Nguyễn Văn A', N'Nam', CAST(N'1989-09-03T00:00:00.000' AS DateTime), N'Hà Nội', N'0957616854
', CAST(N'2012-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV002', N'CV2', N'Nguyễn Văn B', N'Nữ', CAST(N'1994-05-13T00:00:00.000' AS DateTime), N'HCM', N'0976139978
', CAST(N'2013-12-05T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV003', N'CV3', N'Nguyễn Văn C', N'Nam', CAST(N'1995-03-05T00:00:00.000' AS DateTime), N'Hải Phòng', N'0165318361
', CAST(N'2009-06-22T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV004', N'CV4', N'Nguyễn Văn D', N'Nam', CAST(N'1999-09-09T00:00:00.000' AS DateTime), N'Hà Nội', N'0948031476
', CAST(N'2016-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV005', N'CV5', N'Nguyễn Văn E', N'Nữ', CAST(N'1991-01-01T00:00:00.000' AS DateTime), N'Nghệ An', N'0997467603
', CAST(N'2017-11-20T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV006', N'CV2', N'Nguyễn Văn F', N'Nam', CAST(N'1996-09-15T00:00:00.000' AS DateTime), N'Đà Nẵng', N'0163591449
', CAST(N'2019-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV007', N'CV2', N'Nguyễn Văn G', N'Nữ', CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Hà Nội', N'0955550241
', CAST(N'2009-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV008', N'CV6', N'Nguyễn Văn H', N'Nam', CAST(N'1989-05-05T00:00:00.000' AS DateTime), N'Bắc Ninh', N'0143039482
', CAST(N'2005-09-05T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV009', N'CV2', N'Nguyễn Văn I', N'Nam', CAST(N'2006-06-07T00:00:00.000' AS DateTime), N'HCM', N'0984217829
', CAST(N'2016-12-06T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV010', N'CV2', N'Nguyễn Văn J', N'Nữ', CAST(N'2005-06-04T00:00:00.000' AS DateTime), N'Hà Nội', N'0943039482
', CAST(N'2018-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV011', N'CV3', N'Nguyễn Văn K', N'Nam', CAST(N'1996-03-05T00:00:00.000' AS DateTime), N'Lạng Sơn', N'0140266212
', CAST(N'2012-06-06T00:00:00.000' AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [MaCV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoDienThoai], [NgayBatDau]) VALUES (N'NV012', N'CV4', N'Nguyễn Văn L', N'Nam', CAST(N'2001-11-11T00:00:00.000' AS DateTime), N'Hà Nội', N'0935304569
', CAST(N'2015-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEUKIEMKE] ([MaPKK], [NgayKK], [MaNV]) VALUES (N'PKK1      ', CAST(N'2018-09-05T00:00:00.000' AS DateTime), N'NV003')
INSERT [dbo].[PHIEUKIEMKE] ([MaPKK], [NgayKK], [MaNV]) VALUES (N'PKK2      ', CAST(N'2017-05-09T00:00:00.000' AS DateTime), N'NV011')
INSERT [dbo].[PHIEUKIEMKE] ([MaPKK], [NgayKK], [MaNV]) VALUES (N'PKK3', CAST(N'2019-09-09T00:00:00.000' AS DateTime), N'NV003')
INSERT [dbo].[PHIEUKIEMKE] ([MaPKK], [NgayKK], [MaNV]) VALUES (N'PKK4', CAST(N'2012-12-12T00:00:00.000' AS DateTime), N'NV011')
INSERT [dbo].[PHIEUKIEMKE] ([MaPKK], [NgayKK], [MaNV]) VALUES (N'PKK5', CAST(N'2009-09-09T00:00:00.000' AS DateTime), N'NV011')
INSERT [dbo].[PHIEUKIEMKE] ([MaPKK], [NgayKK], [MaNV]) VALUES (N'PKK6', CAST(N'2008-08-08T00:00:00.000' AS DateTime), N'NV003')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayNhap], [MaChungTu], [LoaiHD], [MaNCC], [MaNV]) VALUES (N'PN1', CAST(N'2017-01-11T00:00:00.000' AS DateTime), N'CT1', N'Giấy', N'NCC1', N'NV003')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayNhap], [MaChungTu], [LoaiHD], [MaNCC], [MaNV]) VALUES (N'PN2', CAST(N'2016-11-11T00:00:00.000' AS DateTime), N'CT2', N'Fax', N'NCC3', N'NV011')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayNhap], [MaChungTu], [LoaiHD], [MaNCC], [MaNV]) VALUES (N'PN3', CAST(N'2016-06-06T00:00:00.000' AS DateTime), N'CT3', N'Fax', N'NCC2', N'NV003')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayNhap], [MaChungTu], [LoaiHD], [MaNCC], [MaNV]) VALUES (N'PN4', CAST(N'2012-12-12T00:00:00.000' AS DateTime), N'CT4', N'Thư ĐT', N'NCC4', N'NV003')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [NgayNhap], [MaChungTu], [LoaiHD], [MaNCC], [MaNV]) VALUES (N'PN5', CAST(N'2017-03-07T00:00:00.000' AS DateTime), N'CT5', N'Giấy', N'NCC6', N'NV011')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH1       ', N'Dầu Gội', N'HN2', 200000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH10      ', N'Nước Lọc', N'HP1', 150000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH11', N'Giấy Vệ Sinh', N'HN2', 100000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH12', N'Rau Muống', N'HN2', 5000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH13', N'Bưởi', N'SG2', 50000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH14', N'Kiwi Vàng', N'HP1', 280000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH15', N'Trứng Gà', N'HN1', 23000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH16', N'Trứng Vịt', N'HN2', 26000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH17', N'Gà Nguyên Con', N'SG2', 180000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH18', N'Vịt Nguyên Con', N'SG1', 260000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH19', N'Ngan Nguyên Con', N'SG1', 146000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH2       ', N'Sữa Tắm', N'HN1', 120000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH20', N'Bún Khô', N'HP1', 14500, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH21', N'Mì Gói', N'HN1', 3200, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH22', N'Phở Bò Vifon', N'HN2', 4600, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH23', N'Sting đỏ', N'SG1', 8000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH24', N'Sting vàng', N'SG1', 8000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH25', N'Coca', N'SG2', 6000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH26', N'Coca Zero', N'SG2', 6500, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH27', N'Coca White', N'SG2', 6500, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH28', N'Coca Cafe', N'SG2', 7000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH29', N'Coca Energy', N'SG2', 7000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH3       ', N'Sữa Rửa Mặt', N'HN2', 60000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH30', N'Coca 1,5l', N'SG2', 22000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH4       ', N'Khăn Mặt', N'HN2', 31000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH5       ', N'Khăn Tắm', N'SG1', 156000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH6       ', N'Kem Đánh Răng', N'SG1', 64000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH7       ', N'Bánh Ngọt', N'SG2', 42000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH8       ', N'Bánh Mì', N'SG2', 3000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [NoiSX], [DGia], [DonViTinh]) VALUES (N'HH9       ', N'Nước Ngọt', N'HP1', 5000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD1       ', N'HH1       ', 10, 2000000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD1       ', N'HH2       ', 10, 2400000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD1       ', N'HH3       ', 20, 1200000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD1       ', N'HH4       ', 100, 3100000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD2       ', N'HH1       ', 5, 1000000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD2       ', N'HH2       ', 20, 2400000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD3       ', N'HH7       ', 25, 1050000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD3       ', N'HH8       ', 20, 60000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD4       ', N'HH10      ', 29, 4350000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD4       ', N'HH9       ', 19, 95000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD5       ', N'HH4       ', 25, 775000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD5       ', N'HH5       ', 28, 4368000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD5       ', N'HH6       ', 50, 3200000, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD6', N'HH1', 5, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD6', N'HH2', 10, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD6', N'HH7', 6, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD7', N'HH17', 9, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD7', N'HH19', 9, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD7', N'HH2', 5, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD7', N'HH22', 11, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD8', N'HH18', 16, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD8', N'HH23', 6, NULL, NULL)
INSERT [dbo].[SP_B] ([MaHD], [MaSP], [SL], [ThanhTien], [ChietKhau]) VALUES (N'HD9', N'HH10', 10, NULL, NULL)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN1       ', N'HH1       ', 5, CAST(N'2017-01-11T00:00:00.000' AS DateTime), 0, 50000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN1', N'HH10', 4, CAST(N'2019-09-09T00:00:00.000' AS DateTime), 0, 60000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN1       ', N'HH2       ', 10, CAST(N'2017-01-11T00:00:00.000' AS DateTime), 0, 50000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN1       ', N'HH3       ', 15, CAST(N'2017-01-11T00:00:00.000' AS DateTime), 0, 30000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN1       ', N'HH4       ', 100, CAST(N'2017-01-11T00:00:00.000' AS DateTime), 0, 8000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN1', N'HH9', 6, CAST(N'2019-09-09T00:00:00.000' AS DateTime), 0, 15000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN2', N'HH1', 12, CAST(N'2012-12-12T00:00:00.000' AS DateTime), 0, 41000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN2       ', N'HH10      ', 50, CAST(N'2016-11-11T00:00:00.000' AS DateTime), 0, 10000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN2', N'HH4', 60, CAST(N'2012-12-12T00:00:00.000' AS DateTime), 0, 56000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN2       ', N'HH7       ', 5, CAST(N'2016-11-11T00:00:00.000' AS DateTime), 0, 15000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN2       ', N'HH8       ', 15, CAST(N'2016-11-11T00:00:00.000' AS DateTime), 0, 15000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN2       ', N'HH9       ', 30, CAST(N'2016-11-11T00:00:00.000' AS DateTime), 0, 15000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN3', N'HH1', 58, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 56000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN3', N'HH3', 6, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 30000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN3', N'HH8', 56, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 50000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN3', N'HH9', 34, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 12000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN4', N'HH1', 100, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 54000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN4', N'HH2', 16, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 50000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN4', N'HH6', 4, CAST(N'2015-05-05T00:00:00.000' AS DateTime), 0, 108000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN5', N'HH1', 8, CAST(N'2009-09-09T00:00:00.000' AS DateTime), 0, 12000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN5', N'HH3', 56, CAST(N'2009-09-09T00:00:00.000' AS DateTime), 0, 89000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN5', N'HH6', 6, CAST(N'2009-09-09T00:00:00.000' AS DateTime), 0, 40000)
INSERT [dbo].[SP_N] ([MaPN], [MaSP], [SLNhap], [NgayNhap], [ChietKhau], [DGia]) VALUES (N'PN5', N'HH9', 5, CAST(N'2009-09-09T00:00:00.000' AS DateTime), 0, 46000)
ALTER TABLE [dbo].[CT_PKK]  WITH CHECK ADD  CONSTRAINT [FK_CT_PKK_HANGHOA] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CT_PKK] CHECK CONSTRAINT [FK_CT_PKK_HANGHOA]
GO
ALTER TABLE [dbo].[CT_PKK]  WITH CHECK ADD  CONSTRAINT [FK_CT_PKK_PHIEUKIEMKE] FOREIGN KEY([MaPKK])
REFERENCES [dbo].[PHIEUKIEMKE] ([MaPKK])
GO
ALTER TABLE [dbo].[CT_PKK] CHECK CONSTRAINT [FK_CT_PKK_PHIEUKIEMKE]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[PHIEUKIEMKE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUKIEMKE_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUKIEMKE] CHECK CONSTRAINT [FK_PHIEUKIEMKE_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NCC]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[SP_B]  WITH CHECK ADD  CONSTRAINT [FK_SP_B_HANGHOA] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[SP_B] CHECK CONSTRAINT [FK_SP_B_HANGHOA]
GO
ALTER TABLE [dbo].[SP_B]  WITH CHECK ADD  CONSTRAINT [FK_SP_B_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[SP_B] CHECK CONSTRAINT [FK_SP_B_HOADON]
GO
ALTER TABLE [dbo].[SP_N]  WITH CHECK ADD  CONSTRAINT [FK_SP_N_HANGHOA] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[SP_N] CHECK CONSTRAINT [FK_SP_N_HANGHOA]
GO
ALTER TABLE [dbo].[SP_N]  WITH CHECK ADD  CONSTRAINT [FK_SP_N_PHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[SP_N] CHECK CONSTRAINT [FK_SP_N_PHIEUNHAP]
GO
/****** Object:  StoredProcedure [dbo].[bai4cau1]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bai4cau1] @mahd nvarchar(50) , @tongtien int output
as
begin
select @tongtien=SUM(GiaBan*SL)
from CT_HOADON left join HANGHOA on CT_HOADON.MaHH=HANGHOA.MaHH
where @mahd=MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[HD_DT_NV]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--3. Cho biết tổng số hóa đơn đã lập và tổng doanh thu đã bán hàng của một nhân viên trong một năm nào đó dựa vào mã nhân viên
create proc [dbo].[HD_DT_NV]
@manv nvarchar(10), @year int,
@tongHD int output,
@tongDT int output
as
begin 
	select @tongHD = count(HOADON.MaHD) from HOADON where @manv = MaNV and @year = YEAR(NgayBan)
	select @tongDT = sum(SL * SANPHAM.DGia)
	from (HOADON inner join SP_B on HOADON.MaHD = SP_B.MaHD) inner join SANPHAM on SP_B.MaSP = SANPHAM.MaSP
	where @manv = MaNV and @year = YEAR(NgayBan)
end

GO
/****** Object:  StoredProcedure [dbo].[Tong_SLNhap_TienNhap]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*4. Cho biết tổng số lượng đã nhập và tổng số tiền đã nhập của một mặt hàng nào đó trong một năm nào đó dựa vào mã hàng hóa nào đó */
create proc [dbo].[Tong_SLNhap_TienNhap]
@mahh nvarchar(10), @year int,
@tongSLN int output, @ttNhap int output
as
begin
	select @tongSLN = count(SANPHAM.MaSP), @ttNhap = sum(SLNhap * SP_N.DGia)
	from SP_N inner join SANPHAM on SP_N.MaSP = SANPHAM.MaSP 
	where @mahh = SANPHAM.MaSP and @year = year(NgayNhap)
end
GO
/****** Object:  StoredProcedure [dbo].[TongHD_datetime]    Script Date: 11/15/2019 2:15:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*2. Cho biết tổng số hóa đơn đã lập được trong một tháng của một năm nào đó */
create proc [dbo].[TongHD_datetime]
@month int, @year int,
@tonghd int output
as
begin
	select @tonghd = count(MaHD)
	from HOADON
	where @month = MONTH(NgayBan) and @year = year(NgayBan)
end
GO
USE [master]
GO
ALTER DATABASE [BTL44c] SET  READ_WRITE 
GO
