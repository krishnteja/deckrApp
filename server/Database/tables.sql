USE [DeCKR_Database]
GO
/****** Object:  Table [dbo].[UserSigns]    Script Date: 06/16/2019 15:56:52 ******/
CREATE TABLE [dbo].[UserSigns](
	[EmployeeID] [int] NOT NULL,
	[ContractID] [int] NOT NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_UserSign] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[ContractID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
/****** Object:  Table [dbo].[UserSecurityGroup]    Script Date: 06/16/2019 15:56:50 ******/
CREATE TABLE [dbo].[UserSecurityGroup](
	[EmployeeID] [int] NOT NULL,
	[SecurityID] [int] NOT NULL,
 CONSTRAINT [PK_UserSecurityGroup] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[SecurityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
/****** Object:  Table [dbo].[UserEnrolls]    Script Date: 06/16/2019 15:56:49 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserEnrolls](
	[EmployeeID] [int] NOT NULL,
	[TrainingID] [int] NOT NULL,
	[Progress] [int] NULL,
	[Status] [varchar](100) NULL,
 CONSTRAINT [PK_UserEnroll] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[TrainingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserDepartment]    Script Date: 06/16/2019 15:56:47 ******/
CREATE TABLE [dbo].[UserDepartment](
	[EmployeeID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_UserDepartment] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[DepartmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
/****** Object:  Table [dbo].[User]    Script Date: 06/16/2019 15:56:46 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[EmployeeID] [int] NOT NULL,
	[UserName] [varchar](100) NULL,
	[EmailAddress] [varchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrainingDepartment]    Script Date: 06/16/2019 15:56:45 ******/
CREATE TABLE [dbo].[TrainingDepartment](
	[DepartmentID] [int] NOT NULL,
	[TrainingID] [int] NOT NULL,
 CONSTRAINT [PK_TrainingDepartment] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC,
	[TrainingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
/****** Object:  Table [dbo].[Training]    Script Date: 06/16/2019 15:56:44 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Training](
	[TrainingID] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[Duration] [int] NULL,
	[Description] [varchar](max) NULL,
	[TrainingURL] [varchar](max) NULL,
	[DueDate] [datetime] NULL,
 CONSTRAINT [PK_Training] PRIMARY KEY CLUSTERED 
(
	[TrainingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SecurityGroup]    Script Date: 06/16/2019 15:56:42 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SecurityGroup](
	[SecurityID] [int] NOT NULL,
	[SecurityName] [varchar](100) NULL,
	[SecurityDescription] [varchar](max) NULL,
	[IconName] [varchar](150) NULL,
 CONSTRAINT [PK_SecurityGroup] PRIMARY KEY CLUSTERED 
(
	[SecurityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Module]    Script Date: 06/16/2019 15:56:41 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Module](
	[ModuleID] [int] NOT NULL,
	[ModuleName] [varchar](100) NULL,
 CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 06/16/2019 15:56:39 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[EmployeeID] [int] NOT NULL,
	[UserType] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 06/16/2019 15:56:38 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentID] [int] NOT NULL,
	[DepartmentName] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 06/16/2019 15:56:37 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractID] [int] NOT NULL,
	[ContractName] [varchar](50) NULL,
	[ThumbnailURL] [varchar](256) NULL,
	[ContentURL] [varchar](max) NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdminSettings]    Script Date: 06/16/2019 15:56:35 ******/
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdminSettings](
	[ModuleID] [int] NOT NULL,
	[SettingID] [int] NOT NULL,
	[SettingName] [varchar](100) NULL,
	[SettingDescription] [varchar](max) NULL,
	[SettingValue] [int] NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC,
	[SettingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
GO
SET ANSI_PADDING OFF
GO
