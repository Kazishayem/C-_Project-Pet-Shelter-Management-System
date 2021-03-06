USE [master]
GO
/****** Object:  Database [Pet Shelter]    Script Date: 05-Jan-21 2:26:48 PM ******/
CREATE DATABASE [Pet Shelter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pet Shelter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Pet Shelter.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Pet Shelter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Pet Shelter_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Pet Shelter] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pet Shelter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pet Shelter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pet Shelter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pet Shelter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pet Shelter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pet Shelter] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pet Shelter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pet Shelter] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Pet Shelter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pet Shelter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pet Shelter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pet Shelter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pet Shelter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pet Shelter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pet Shelter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pet Shelter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pet Shelter] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pet Shelter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pet Shelter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pet Shelter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pet Shelter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pet Shelter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pet Shelter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pet Shelter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pet Shelter] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pet Shelter] SET  MULTI_USER 
GO
ALTER DATABASE [Pet Shelter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pet Shelter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pet Shelter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pet Shelter] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Pet Shelter]
GO
/****** Object:  Table [dbo].[info]    Script Date: 05-Jan-21 2:26:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[info](
	[fullname] [nvarchar](20) NOT NULL,
	[type] [nvarchar](20) NOT NULL,
	[id] [nvarchar](20) NOT NULL,
	[password] [nvarchar](20) NOT NULL,
	[dob] [date] NOT NULL,
	[age] [int] NOT NULL,
	[gender] [nvarchar](20) NOT NULL,
	[address] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[petinfo]    Script Date: 05-Jan-21 2:26:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[petinfo](
	[petid] [nvarchar](20) NOT NULL,
	[pettype] [nvarchar](20) NOT NULL,
	[petage] [nvarchar](20) NOT NULL,
	[weight] [nvarchar](20) NOT NULL,
	[color] [nvarchar](20) NOT NULL,
	[petcatagory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_petinfo] PRIMARY KEY CLUSTERED 
(
	[petid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[requestinfo]    Script Date: 05-Jan-21 2:26:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[requestinfo](
	[userid] [nvarchar](20) NOT NULL,
	[pid] [nvarchar](20) NULL,
	[ptype] [nvarchar](20) NOT NULL,
	[catagory] [nvarchar](20) NOT NULL,
	[fosterdays] [nvarchar](20) NULL,
 CONSTRAINT [PK_requestinfo] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'Kazi Shayem Mahamood', N'admin', N'A-001', N'1234', CAST(N'1999-02-06' AS Date), 22, N'male', N'chittagong')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'Mir Abrar', N'admin', N'A-002', N'2226', CAST(N'1999-03-10' AS Date), 23, N'male', N'dhaka')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'Akash ahmed', N'admin', N'A-003', N'1111', CAST(N'1998-01-04' AS Date), 23, N'male', N'dhaka')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'shihab', N'admin', N'A-004', N'1', CAST(N'2021-06-04' AS Date), 21, N'male', N'1')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'Sadia akter', N'user', N'U-001', N'2644', CAST(N'1999-04-21' AS Date), 26, N'female', N'rajshahi')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'Mosfique', N'user', N'U-002', N'2347', CAST(N'1990-01-03' AS Date), 44, N'male', N'dhaka')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'Chodury', N'user', N'U-003', N'2222', CAST(N'2021-01-12' AS Date), 29, N'male', N'dhaka')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'dance', N'user', N'U-004', N'3333', CAST(N'2021-01-04' AS Date), 30, N'male', N'dhaka')
INSERT [dbo].[info] ([fullname], [type], [id], [password], [dob], [age], [gender], [address]) VALUES (N'kashem', N'user', N'U-005', N'4444', CAST(N'2021-01-04' AS Date), 30, N'male', N'dhaka')
INSERT [dbo].[petinfo] ([petid], [pettype], [petage], [weight], [color], [petcatagory]) VALUES (N'P-001', N'cat', N'5months', N'1.5kg', N'brown', N'adoption')
INSERT [dbo].[petinfo] ([petid], [pettype], [petage], [weight], [color], [petcatagory]) VALUES (N'P-002', N'cat', N'8months', N'2kg', N'white-black', N'foster')
INSERT [dbo].[petinfo] ([petid], [pettype], [petage], [weight], [color], [petcatagory]) VALUES (N'P-003', N'rabbit', N'3 weeks', N'600gm', N'white', N'adoption')
INSERT [dbo].[petinfo] ([petid], [pettype], [petage], [weight], [color], [petcatagory]) VALUES (N'P-004', N'rabbit', N'7 weeks', N'700gm', N'brown', N'adoption')
INSERT [dbo].[petinfo] ([petid], [pettype], [petage], [weight], [color], [petcatagory]) VALUES (N'P-005', N'dog', N'5 months', N'3kg', N'brown', N'foster')
INSERT [dbo].[requestinfo] ([userid], [pid], [ptype], [catagory], [fosterdays]) VALUES (N'U-001', N'P-001', N'cat', N'adoption', N'15 days')
INSERT [dbo].[requestinfo] ([userid], [pid], [ptype], [catagory], [fosterdays]) VALUES (N'U-002', N'P-002', N'cat', N'adoption', N'')
INSERT [dbo].[requestinfo] ([userid], [pid], [ptype], [catagory], [fosterdays]) VALUES (N'U-003', N'', N'dog', N'return rescued pet', N'')
INSERT [dbo].[requestinfo] ([userid], [pid], [ptype], [catagory], [fosterdays]) VALUES (N'U-004', N'P-004', N'dog', N'adoption', N'')
INSERT [dbo].[requestinfo] ([userid], [pid], [ptype], [catagory], [fosterdays]) VALUES (N'U-005', N'P-005', N'dog', N'foster', N'30 days')
USE [master]
GO
ALTER DATABASE [Pet Shelter] SET  READ_WRITE 
GO
