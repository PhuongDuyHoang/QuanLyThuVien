USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

set dateformat dmy

USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 6/22/2019 10:04:36 PM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[tblChiTietPhieuMuon]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuMuon](
	[maphieumuon] [varchar](50) NOT NULL,
	[macuonsach] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[maphieumuon] ASC,
	[macuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuNhap](
	[maphieunhap] [varchar](50) NOT NULL,
	[madausach] [varchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[ghichu] [nvarchar](max) NULL,
	[thanhtien] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC,
	[madausach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChiTietPhieuTra]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuTra](
	[maphieutra] [varchar](50) NOT NULL,
	[macuonsach] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuTra] PRIMARY KEY CLUSTERED 
(
	[maphieutra] ASC,
	[macuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblChiTietPhieuXuat]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuXuat](
	[maphieuxuat] [varchar](50) NOT NULL,
	[macuonsach] [varchar](50) NOT NULL,
	[thanhtien] [int] NOT NULL,
	[ghichu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[maphieuxuat] ASC,
	[macuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCuonSach]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCuonSach](
	[macuonsach] [varchar](50) NOT NULL,
	[tinhtrang] [varchar](50) NOT NULL,
	[dausach] [varchar](50) NOT NULL,
	[soke] [int] NOT NULL,
 CONSTRAINT [PK_tblCuonSach] PRIMARY KEY CLUSTERED 
(
	[macuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[madangnhap] [varchar](50) NOT NULL,
	[nguoidung] [varchar](50) NOT NULL,
	[tendangnhap] [nvarchar](max) NOT NULL,
	[matkhau] [nvarchar](max) NOT NULL,
	[dangnhaplandau] [bit] NOT NULL,
 CONSTRAINT [PK_tblDangNhap] PRIMARY KEY CLUSTERED 
(
	[madangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDauSach]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDauSach](
	[madausach] [varchar](50) NOT NULL,
	[tendausach] [nvarchar](max) NOT NULL,
	[tomtat] [nchar](10) NULL,
	[nhaxuatban] [varchar](50) NOT NULL,
	[namxuatban] [int] NOT NULL,
	[trigia] [int] NOT NULL,
 CONSTRAINT [PK_tblDauSach] PRIMARY KEY CLUSTERED 
(
	[madausach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDauSach_NgonNgu]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDauSach_NgonNgu](
	[madausach] [varchar](50) NOT NULL,
	[mangonngu] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblDauSach_NgonNgu] PRIMARY KEY CLUSTERED 
(
	[madausach] ASC,
	[mangonngu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDauSach_TacGia]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDauSach_TacGia](
	[madausach] [varchar](50) NOT NULL,
	[matacgia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblDauSach_TacGia] PRIMARY KEY CLUSTERED 
(
	[madausach] ASC,
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDauSach_TheLoai]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDauSach_TheLoai](
	[madausach] [varchar](50) NOT NULL,
	[matheloai] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblDauSach_TheLoai] PRIMARY KEY CLUSTERED 
(
	[madausach] ASC,
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNgonNgu]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNgonNgu](
	[mangonngu] [varchar](50) NOT NULL,
	[tenngonngu] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblNgonNgu] PRIMARY KEY CLUSTERED 
(
	[mangonngu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNguoiDung]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNguoiDung](
	[manguoidung] [varchar](50) NOT NULL,
	[hoten] [nvarchar](max) NOT NULL,
	[CMND] [nvarchar](max) NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[diachi] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[sodienthoai] [nvarchar](max) NULL,
	[vaitro] [varchar](50) NOT NULL,
	[ngaytao] [datetime] NOT NULL,
 CONSTRAINT [PK_tblNguoiDung] PRIMARY KEY CLUSTERED 
(
	[manguoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[manhacungcap] [varchar](50) NOT NULL,
	[tennhacungcap] [nvarchar](max) NOT NULL,
	[diachi] [nvarchar](max) NOT NULL,
	[sodienthoai] [nvarchar](max) NOT NULL,
	[sofax] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[manhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaThanhLy]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaThanhLy](
	[manhathanhly] [varchar](50) NOT NULL,
	[tennhathanhly] [nvarchar](max) NOT NULL,
	[diachi] [nvarchar](max) NOT NULL,
	[sodienthoai] [nvarchar](max) NOT NULL,
	[sofax] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblNhaThanhLy] PRIMARY KEY CLUSTERED 
(
	[manhathanhly] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaXuatBan]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaXuatBan](
	[manhaxuatban] [varchar](50) NOT NULL,
	[tennhaxuatban] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuMuon]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuMuon](
	[maphieumuon] [varchar](50) NOT NULL,
	[docgia] [varchar](50) NOT NULL,
	[thuthu] [varchar](50) NOT NULL,
	[ngaymuon] [datetime] NOT NULL,
 CONSTRAINT [PK_tblPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[maphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuNhap](
	[maphieunhap] [varchar](50) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[nhacungcap] [varchar](50) NOT NULL,
	[tongtien] [int] NOT NULL,
	[nguoinhap] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuTra]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuTra](
	[maphieutra] [varchar](50) NOT NULL,
	[docgia] [varchar](50) NOT NULL,
	[thuthu] [varchar](50) NOT NULL,
	[ngaytra] [datetime] NOT NULL,
 CONSTRAINT [PK_tblPhieuTra] PRIMARY KEY CLUSTERED 
(
	[maphieutra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuXuat]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuXuat](
	[maphieuxuat] [varchar](50) NOT NULL,
	[ngayxuat] [datetime] NOT NULL,
	[nhathanhly] [varchar](50) NOT NULL,
	[tongtien] [int] NOT NULL,
	[nguoixuat] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[maphieuxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [varchar](50) NOT NULL,
	[tentacgia] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTheLoai](
	[matheloai] [varchar](50) NOT NULL,
	[tentheloai] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblTheLoai] PRIMARY KEY CLUSTERED 
(
	[matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTinhTrang]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTinhTrang](
	[matinhtrang] [varchar](50) NOT NULL,
	[tentinhtrang] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblTinhTrang] PRIMARY KEY CLUSTERED 
(
	[matinhtrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblVaiTro]    Script Date: 6/22/2019 10:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblVaiTro](
	[mavaitro] [varchar](50) NOT NULL,
	[tenvaitro] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblVaiTro] PRIMARY KEY CLUSTERED 
(
	[mavaitro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuon_tblCuonSach] FOREIGN KEY([macuonsach])
REFERENCES [dbo].[tblCuonSach] ([macuonsach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon] CHECK CONSTRAINT [FK_tblChiTietPhieuMuon_tblCuonSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuon_tblPhieuMuon] FOREIGN KEY([maphieumuon])
REFERENCES [dbo].[tblPhieuMuon] ([maphieumuon])
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon] CHECK CONSTRAINT [FK_tblChiTietPhieuMuon_tblPhieuMuon]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuNhap_tblDauSach] FOREIGN KEY([madausach])
REFERENCES [dbo].[tblDauSach] ([madausach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_tblChiTietPhieuNhap_tblDauSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuNhap_tblPhieuNhap] FOREIGN KEY([maphieunhap])
REFERENCES [dbo].[tblPhieuNhap] ([maphieunhap])
GO
ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_tblChiTietPhieuNhap_tblPhieuNhap]
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuTra_tblCuonSach] FOREIGN KEY([macuonsach])
REFERENCES [dbo].[tblCuonSach] ([macuonsach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra] CHECK CONSTRAINT [FK_tblChiTietPhieuTra_tblCuonSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuTra] FOREIGN KEY([maphieutra])
REFERENCES [dbo].[tblPhieuTra] ([maphieutra])
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra] CHECK CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuTra]
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuXuat_tblCuonSach] FOREIGN KEY([macuonsach])
REFERENCES [dbo].[tblCuonSach] ([macuonsach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat] CHECK CONSTRAINT [FK_tblChiTietPhieuXuat_tblCuonSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuXuat_tblPhieuXuat] FOREIGN KEY([maphieuxuat])
REFERENCES [dbo].[tblPhieuXuat] ([maphieuxuat])
GO
ALTER TABLE [dbo].[tblChiTietPhieuXuat] CHECK CONSTRAINT [FK_tblChiTietPhieuXuat_tblPhieuXuat]
GO
ALTER TABLE [dbo].[tblCuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCuonSach_tblDauSach] FOREIGN KEY([dausach])
REFERENCES [dbo].[tblDauSach] ([madausach])
GO
ALTER TABLE [dbo].[tblCuonSach] CHECK CONSTRAINT [FK_tblCuonSach_tblDauSach]
GO
ALTER TABLE [dbo].[tblCuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCuonSach_tblTinhTrang] FOREIGN KEY([tinhtrang])
REFERENCES [dbo].[tblTinhTrang] ([matinhtrang])
GO
ALTER TABLE [dbo].[tblCuonSach] CHECK CONSTRAINT [FK_tblCuonSach_tblTinhTrang]
GO
ALTER TABLE [dbo].[tblDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblDangNhap_tblNguoiDung] FOREIGN KEY([nguoidung])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblDangNhap] CHECK CONSTRAINT [FK_tblDangNhap_tblNguoiDung]
GO
ALTER TABLE [dbo].[tblDauSach]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_tblNhaXuatBan] FOREIGN KEY([nhaxuatban])
REFERENCES [dbo].[tblNhaXuatBan] ([manhaxuatban])
GO
ALTER TABLE [dbo].[tblDauSach] CHECK CONSTRAINT [FK_tblDauSach_tblNhaXuatBan]
GO
ALTER TABLE [dbo].[tblDauSach_NgonNgu]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_NgonNgu_tblDauSach] FOREIGN KEY([madausach])
REFERENCES [dbo].[tblDauSach] ([madausach])
GO
ALTER TABLE [dbo].[tblDauSach_NgonNgu] CHECK CONSTRAINT [FK_tblDauSach_NgonNgu_tblDauSach]
GO
ALTER TABLE [dbo].[tblDauSach_NgonNgu]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_NgonNgu_tblNgonNgu] FOREIGN KEY([mangonngu])
REFERENCES [dbo].[tblNgonNgu] ([mangonngu])
GO
ALTER TABLE [dbo].[tblDauSach_NgonNgu] CHECK CONSTRAINT [FK_tblDauSach_NgonNgu_tblNgonNgu]
GO
ALTER TABLE [dbo].[tblDauSach_TacGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_TacGia_tblDauSach] FOREIGN KEY([madausach])
REFERENCES [dbo].[tblDauSach] ([madausach])
GO
ALTER TABLE [dbo].[tblDauSach_TacGia] CHECK CONSTRAINT [FK_tblDauSach_TacGia_tblDauSach]
GO
ALTER TABLE [dbo].[tblDauSach_TacGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_TacGia_tblTacGia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tblTacGia] ([matacgia])
GO
ALTER TABLE [dbo].[tblDauSach_TacGia] CHECK CONSTRAINT [FK_tblDauSach_TacGia_tblTacGia]
GO
ALTER TABLE [dbo].[tblDauSach_TheLoai]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_TheLoai_tblDauSach] FOREIGN KEY([madausach])
REFERENCES [dbo].[tblDauSach] ([madausach])
GO
ALTER TABLE [dbo].[tblDauSach_TheLoai] CHECK CONSTRAINT [FK_tblDauSach_TheLoai_tblDauSach]
GO
ALTER TABLE [dbo].[tblDauSach_TheLoai]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_TheLoai_tblTheLoai] FOREIGN KEY([matheloai])
REFERENCES [dbo].[tblTheLoai] ([matheloai])
GO
ALTER TABLE [dbo].[tblDauSach_TheLoai] CHECK CONSTRAINT [FK_tblDauSach_TheLoai_tblTheLoai]
GO
ALTER TABLE [dbo].[tblNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_tblNguoiDung_tblVaiTro] FOREIGN KEY([vaitro])
REFERENCES [dbo].[tblVaiTro] ([mavaitro])
GO
ALTER TABLE [dbo].[tblNguoiDung] CHECK CONSTRAINT [FK_tblNguoiDung_tblVaiTro]
GO
ALTER TABLE [dbo].[tblPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuon_tblNguoiDung] FOREIGN KEY([docgia])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblPhieuMuon] CHECK CONSTRAINT [FK_tblPhieuMuon_tblNguoiDung]
GO
ALTER TABLE [dbo].[tblPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuon_tblNguoiDung1] FOREIGN KEY([thuthu])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblPhieuMuon] CHECK CONSTRAINT [FK_tblPhieuMuon_tblNguoiDung1]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuNhap_tblNguoiDung] FOREIGN KEY([nguoinhap])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_tblPhieuNhap_tblNguoiDung]
GO
ALTER TABLE [dbo].[tblPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuNhap_tblNhaCungCap] FOREIGN KEY([nhacungcap])
REFERENCES [dbo].[tblNhaCungCap] ([manhacungcap])
GO
ALTER TABLE [dbo].[tblPhieuNhap] CHECK CONSTRAINT [FK_tblPhieuNhap_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuTra_tblNguoiDung] FOREIGN KEY([docgia])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblPhieuTra] CHECK CONSTRAINT [FK_tblPhieuTra_tblNguoiDung]
GO
ALTER TABLE [dbo].[tblPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuTra_tblNguoiDung1] FOREIGN KEY([thuthu])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblPhieuTra] CHECK CONSTRAINT [FK_tblPhieuTra_tblNguoiDung1]
GO
ALTER TABLE [dbo].[tblPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuXuat_tblNguoiDung] FOREIGN KEY([nguoixuat])
REFERENCES [dbo].[tblNguoiDung] ([manguoidung])
GO
ALTER TABLE [dbo].[tblPhieuXuat] CHECK CONSTRAINT [FK_tblPhieuXuat_tblNguoiDung]
GO
ALTER TABLE [dbo].[tblPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuXuat_tblNhaThanhLy] FOREIGN KEY([nhathanhly])
REFERENCES [dbo].[tblNhaThanhLy] ([manhathanhly])
GO
ALTER TABLE [dbo].[tblPhieuXuat] CHECK CONSTRAINT [FK_tblPhieuXuat_tblNhaThanhLy]
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
