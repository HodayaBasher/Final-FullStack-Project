USE [master]
GO
/****** Object:  Database [Zmedicair_DB]    Script Date: 07/06/2022 21:01:13 ******/
CREATE DATABASE [Zmedicair_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Zmedicair_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Zmedicair_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Zmedicair_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Zmedicair_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Zmedicair_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Zmedicair_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Zmedicair_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Zmedicair_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Zmedicair_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Zmedicair_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Zmedicair_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Zmedicair_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Zmedicair_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Zmedicair_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Zmedicair_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Zmedicair_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Zmedicair_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Zmedicair_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Zmedicair_DB', N'ON'
GO
ALTER DATABASE [Zmedicair_DB] SET QUERY_STORE = OFF
GO
USE [Zmedicair_DB]
GO
/****** Object:  Table [dbo].[CommonQuestions_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommonQuestions_Table](
	[CommonQuestionsID] [smallint] IDENTITY(1,1) NOT NULL,
	[CommonQuestions] [varchar](500) NOT NULL,
	[CommonAnswers] [varchar](500) NOT NULL,
 CONSTRAINT [PK_CommonQuestions_Table] PRIMARY KEY CLUSTERED 
(
	[CommonQuestionsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DailyMonitoringֹֹֹֹ_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DailyMonitoringֹֹֹֹ_Table](
	[DailyID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NOT NULL,
	[DailyDateAndTime] [datetime] NOT NULL,
	[DailyFeeling] [varchar](150) NOT NULL,
 CONSTRAINT [PK_DailyMonitoringֹֹֹֹֹֹ] PRIMARY KEY CLUSTERED 
(
	[DailyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Machines_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machines_Table](
	[MachineID] [smallint] IDENTITY(1,1) NOT NULL,
	[MachineName] [varchar](100) NOT NULL,
	[MachinePrice] [money] NOT NULL,
	[MachineUnitsInStack] [int] NOT NULL,
	[MachineDescription] [varchar](100) NOT NULL,
	[MachineLength] [float] NOT NULL,
	[MachineWidth] [float] NOT NULL,
	[MachineHeight] [float] NOT NULL,
	[MachineWeight] [float] NOT NULL,
 CONSTRAINT [PK_Machines_Table] PRIMARY KEY CLUSTERED 
(
	[MachineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages_Table](
	[MessagesID] [smallint] NOT NULL,
	[UserIdFromWho] [smallint] NOT NULL,
	[UserIdToWho] [smallint] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MessagesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shopping_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shopping_Table](
	[ShoppingID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NOT NULL,
	[ShoppingDate] [date] NOT NULL,
 CONSTRAINT [PK_Shopping_Table] PRIMARY KEY CLUSTERED 
(
	[ShoppingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingInformation_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingInformation_Table](
	[ShoppingInformationID] [smallint] IDENTITY(1,1) NOT NULL,
	[ShoppingID] [smallint] NOT NULL,
	[MachineID] [smallint] NOT NULL,
	[ShoppingAmount] [int] NOT NULL,
 CONSTRAINT [PK_ShoppingInformation_Table] PRIMARY KEY CLUSTERED 
(
	[ShoppingInformationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_Table]    Script Date: 07/06/2022 21:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_Table](
	[UserID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserFirstName] [varchar](100) NOT NULL,
	[UserLastName] [varchar](100) NOT NULL,
	[UserDateOfBirth] [date] NOT NULL,
	[UserEmail] [varchar](254) NULL,
	[UserPhoneNumber] [varchar](50) NOT NULL,
	[UserStatus] [varchar](50) NOT NULL,
	[UserPassword] [varchar](50) NULL,
 CONSTRAINT [PK_Users_Table] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CommonQuestions_Table] ON 
GO
INSERT [dbo].[CommonQuestions_Table] ([CommonQuestionsID], [CommonQuestions], [CommonAnswers]) VALUES (1, N'How much does the device cost ?', N'The device costs 3900 ')
GO
INSERT [dbo].[CommonQuestions_Table] ([CommonQuestionsID], [CommonQuestions], [CommonAnswers]) VALUES (2, N'Does the device include filters ', N'Yes, the device includes one pair of free filters that need to be replaced every year. ')
GO
INSERT [dbo].[CommonQuestions_Table] ([CommonQuestionsID], [CommonQuestions], [CommonAnswers]) VALUES (3, N'Can the device help asthma patients ', N'Yes, the device can help asthmatics.')
GO
SET IDENTITY_INSERT [dbo].[CommonQuestions_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Machines_Table] ON 
GO
INSERT [dbo].[Machines_Table] ([MachineID], [MachineName], [MachinePrice], [MachineUnitsInStack], [MachineDescription], [MachineLength], [MachineWidth], [MachineHeight], [MachineWeight]) VALUES (1, N'Zmedicair tecnolgy', 3900.0000, 10000, N'helps people breath easly', 10, 20, 10, 4.2)
GO
INSERT [dbo].[Machines_Table] ([MachineID], [MachineName], [MachinePrice], [MachineUnitsInStack], [MachineDescription], [MachineLength], [MachineWidth], [MachineHeight], [MachineWeight]) VALUES (2, N'Zmedicair filter', 200.0000, 20000, N'filter for change', 20, 5, 4, 5)
GO
SET IDENTITY_INSERT [dbo].[Machines_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Shopping_Table] ON 
GO
INSERT [dbo].[Shopping_Table] ([ShoppingID], [UserID], [ShoppingDate]) VALUES (1, 1, CAST(N'2001-12-27' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Shopping_Table] OFF
GO
SET IDENTITY_INSERT [dbo].[Users_Table] ON 
GO
INSERT [dbo].[Users_Table] ([UserID], [UserFirstName], [UserLastName], [UserDateOfBirth], [UserEmail], [UserPhoneNumber], [UserStatus], [UserPassword]) VALUES (1, N'Hodaya', N'Basher', CAST(N'2001-12-27' AS Date), N'hodayabasher@gmail.com', N'0548517480', N'worker', N'123')
GO
INSERT [dbo].[Users_Table] ([UserID], [UserFirstName], [UserLastName], [UserDateOfBirth], [UserEmail], [UserPhoneNumber], [UserStatus], [UserPassword]) VALUES (6, N'Shira', N'Hazan', CAST(N'2002-01-17' AS Date), N'shira27813@gmail.com', N'0556727813', N'worker', NULL)
GO
INSERT [dbo].[Users_Table] ([UserID], [UserFirstName], [UserLastName], [UserDateOfBirth], [UserEmail], [UserPhoneNumber], [UserStatus], [UserPassword]) VALUES (7, N'Tehilla', N'Cohen', CAST(N'1999-05-22' AS Date), N'tehilla@gmail.com', N'0559255425', N'customer', NULL)
GO
SET IDENTITY_INSERT [dbo].[Users_Table] OFF
GO
ALTER TABLE [dbo].[DailyMonitoringֹֹֹֹ_Table]  WITH CHECK ADD  CONSTRAINT [FK_DailyMonitoringֹֹֹֹֹֹ_Users_Table] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users_Table] ([UserID])
GO
ALTER TABLE [dbo].[DailyMonitoringֹֹֹֹ_Table] CHECK CONSTRAINT [FK_DailyMonitoringֹֹֹֹֹֹ_Users_Table]
GO
ALTER TABLE [dbo].[Messages_Table]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Table_Users_Table] FOREIGN KEY([UserIdFromWho])
REFERENCES [dbo].[Users_Table] ([UserID])
GO
ALTER TABLE [dbo].[Messages_Table] CHECK CONSTRAINT [FK_Messages_Table_Users_Table]
GO
ALTER TABLE [dbo].[Messages_Table]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Table_Users_Table1] FOREIGN KEY([UserIdToWho])
REFERENCES [dbo].[Users_Table] ([UserID])
GO
ALTER TABLE [dbo].[Messages_Table] CHECK CONSTRAINT [FK_Messages_Table_Users_Table1]
GO
ALTER TABLE [dbo].[Shopping_Table]  WITH CHECK ADD  CONSTRAINT [FK_Shopping_Table_Users_Table1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users_Table] ([UserID])
GO
ALTER TABLE [dbo].[Shopping_Table] CHECK CONSTRAINT [FK_Shopping_Table_Users_Table1]
GO
ALTER TABLE [dbo].[ShoppingInformation_Table]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingInformation_Table_Machines_Table] FOREIGN KEY([MachineID])
REFERENCES [dbo].[Machines_Table] ([MachineID])
GO
ALTER TABLE [dbo].[ShoppingInformation_Table] CHECK CONSTRAINT [FK_ShoppingInformation_Table_Machines_Table]
GO
ALTER TABLE [dbo].[ShoppingInformation_Table]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingInformation_Table_Shopping_Table] FOREIGN KEY([ShoppingID])
REFERENCES [dbo].[Shopping_Table] ([ShoppingID])
GO
ALTER TABLE [dbo].[ShoppingInformation_Table] CHECK CONSTRAINT [FK_ShoppingInformation_Table_Shopping_Table]
GO
USE [master]
GO
ALTER DATABASE [Zmedicair_DB] SET  READ_WRITE 
GO
