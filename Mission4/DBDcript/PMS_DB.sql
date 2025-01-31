USE [PMS]
GO
DROP TABLE [dbo].[Certificate]
GO
DROP TABLE [dbo].[Emp]
GO
/****** Object:  Table [dbo].[Dept]    Script Date: 05/29/2014 21:32:12 ******/
DROP TABLE [dbo].[Dept]
GO
/****** Object:  Table [dbo].[Dept]    Script Date: 05/29/2014 21:32:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dept](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](20) NOT NULL,
	[LocId] [int] NOT NULL,
 CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dept] ON
INSERT [dbo].[Dept] ([Id], [DeptName], [LocId]) VALUES (1, N'총무팀', 100)
INSERT [dbo].[Dept] ([Id], [DeptName], [LocId]) VALUES (2, N'인사부', 200)
INSERT [dbo].[Dept] ([Id], [DeptName], [LocId]) VALUES (3, N'영업부', 300)
INSERT [dbo].[Dept] ([Id], [DeptName], [LocId]) VALUES (4, N'감사팀', 400)
INSERT [dbo].[Dept] ([Id], [DeptName], [LocId]) VALUES (5, N'전산팀', 500)
SET IDENTITY_INSERT [dbo].[Dept] OFF
/****** Object:  Table [dbo].[Emp]    Script Date: 05/29/2014 21:32:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Emp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpNo] [nvarchar](6) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Title] [nvarchar](10) NOT NULL,
	[HireDate] [datetime] NOT NULL,
	[Salary] [int] NOT NULL,
	[Bonus] [int] NULL,
	[ManagerId] [int] NULL,
	[DeptId] [int] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Emp] ON
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (1, N'1000', N'1000', N'배기수', N'사장', CAST(0x00007C9B00000000 AS DateTime), 1200, 400, 1, 1)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (2, N'1001', N'1001', N'홍길동', N'부장', CAST(0x0000810F00000000 AS DateTime), 570, 300, 1, 2)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (3, N'1002', N'1002', N'차승호', N'부장', CAST(0x000090B300000000 AS DateTime), 700, 100, 1, 3)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (4, N'1003', N'1003', N'김주부', N'과장', CAST(0x00008EAC00000000 AS DateTime), 450, NULL, 2, 3)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (5, N'1004', N'1004', N'황기훈', N'과장', CAST(0x0000902800000000 AS DateTime), 360, NULL, 1, 2)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (6, N'1005', N'1005', N'정수미', N'대리', CAST(0x0000944B00000000 AS DateTime), 300, NULL, 4, 2)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (7, N'1006', N'1006', N'권민수', N'사원', CAST(0x0000A32200000000 AS DateTime), 250, 40, NULL, 5)
INSERT [dbo].[Emp] ([Id], [EmpNo], [Password], [Name], [Title], [HireDate], [Salary], [Bonus], [ManagerId], [DeptId]) VALUES (8, N'1007', N'1007', N'김지희', N'사원', CAST(0x0000A32200000000 AS DateTime), 250, 40, 5, NULL)
SET IDENTITY_INSERT [dbo].[Emp] OFF
/****** Object:  ForeignKey [FK_Dept_Member]    Script Date: 05/29/2014 21:32:12 ******/
ALTER TABLE [dbo].[Emp]  WITH CHECK ADD  CONSTRAINT [FK_Dept_Member] FOREIGN KEY([DeptId])
REFERENCES [dbo].[Dept] ([Id])
GO
ALTER TABLE [dbo].[Emp] CHECK CONSTRAINT [FK_Dept_Member]
GO

CREATE TABLE [dbo].[Certificate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NOT NULL,
	[CertificateName] [nvarchar](30) NOT NULL
 CONSTRAINT [PK_Certificate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Certificate]  WITH CHECK ADD  CONSTRAINT [FK_Emp_Certificate] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Emp] ([Id])
GO
SET IDENTITY_INSERT [dbo].[Certificate] ON
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (1, 1, '정보처리기사1급')
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (2, 1, 'MCT')
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (3, 2, '정보처리기사2급')
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (4, 3, 'MCSD')
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (5, 4, '정보처리기사1급')
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (6, 5, 'MCDBA')
INSERT [dbo].[Certificate] ([Id], [EmpId], [CertificateName]) VALUES (7, 5, 'OCP')
SET IDENTITY_INSERT [dbo].[Dept] OFF
