/****** Object:  Table [dbo].[Backgrounds]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Backgrounds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[XueLi] [nvarchar](50) NULL,
 CONSTRAINT [PK_backgrounds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[Number] [varchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ParentDepartmentId] [varchar](50) NULL,
	[StaffSize] [int] NOT NULL,
	[Remark] [varchar](max) NULL,
 CONSTRAINT [PK_Departments_1] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Healths]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Healths](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HealthCondition] [nvarchar](200) NULL,
 CONSTRAINT [PK_Healths] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nationalities]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationalities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nation] [nvarchar](50) NULL,
	[Sort] [int] NULL,
 CONSTRAINT [PK_Nationalities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nations]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nationality] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phrases]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phrases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sn] [int] NOT NULL,
	[PhraseScene] [nvarchar](50) NOT NULL,
	[PhraseContent] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Phrases_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhraseScenes]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhraseScenes](
	[SnS] [int] NOT NULL,
	[SceneName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhraseScenes] PRIMARY KEY CLUSTERED 
(
	[SnS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SkillParameters]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SkillParameters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SkillNumber] [char](10) NOT NULL,
	[SkillName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SkillParameters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 2015/10/16 12:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staffs](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[BillTypeName] [varchar](50) NULL,
	[BillTypeNumber] [varchar](50) NOT NULL,
	[BillNumber] [varchar](50) NULL,
	[Name] [varchar](100) NULL,
	[Gender] [varchar](10) NULL,
	[Department] [varchar](50) NULL,
	[WorkType] [varchar](50) NULL,
	[Position] [varchar](50) NULL,
	[IdentificationType] [varchar](50) NULL,
	[Nationality] [varchar](50) NULL,
	[IdentificationNumber] [varchar](50) NULL,
	[Entrydate] [date] NULL,
	[ClassOrder] [varchar](50) NULL,
	[AppSwitch] [varchar](50) NULL,
	[JobState] [varchar](50) NULL,
	[AbnormalChange] [varchar](50) NULL,
	[FreeCard] [bit] NULL,
	[WorkProperty] [varchar](50) NULL,
	[ApplyOvertimeSwitch] [bit] NULL,
	[Source] [varchar](50) NULL,
	[QualifyingPeriodFull] [varchar](50) NULL,
	[MaritalStatus] [varchar](50) NULL,
	[BirthDate] [date] NULL,
	[NativePlace] [varchar](50) NULL,
	[HealthCondition] [varchar](50) NULL,
	[Nation] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
	[VisaOffice] [varchar](255) NULL,
	[HomeTelNumber] [varchar](12) NULL,
	[EducationBackground] [varchar](50) NULL,
	[GraduationSchool] [varchar](50) NULL,
	[SchoolMajor] [varchar](50) NULL,
	[Degree] [varchar](50) NULL,
	[Introducer] [varchar](50) NULL,
	[IndividualTelNumber] [varchar](12) NULL,
	[BankCardNumber] [varchar](50) NULL,
	[UrgencyContactMan] [varchar](50) NULL,
	[UrgencyContactAddress] [varchar](50) NULL,
	[UrgencyContactPhoneNumber] [varchar](50) NULL,
	[InBlacklist] [bit] NULL,
	[PhysicalCardNumber] [varchar](50) NULL,
	[LeaveDate] [date] NULL,
	[LeaveType] [varchar](50) NULL,
	[LeaveReason] [varchar](50) NULL,
	[AccountVersion] [varchar](50) NULL,
	[AuditStatus] [varchar](50) NULL,
	[BindingNumber] [varchar](50) NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'户籍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'NativePlace'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'民族' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'Nation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'签证机关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'VisaOffice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'毕业院校' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'GraduationSchool'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'SchoolMajor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'离职类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'LeaveType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staffs', @level2type=N'COLUMN',@level2name=N'AuditStatus'
GO

