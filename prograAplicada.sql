USE [master]
GO
/****** Object:  Database [prograAplicada]    Script Date: 28/11/2016 19:35:19 ******/
CREATE DATABASE [prograAplicada]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'prograAplicada', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\prograAplicada.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'prograAplicada_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\prograAplicada_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [prograAplicada] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [prograAplicada].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [prograAplicada] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [prograAplicada] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [prograAplicada] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [prograAplicada] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [prograAplicada] SET ARITHABORT OFF 
GO
ALTER DATABASE [prograAplicada] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [prograAplicada] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [prograAplicada] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [prograAplicada] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [prograAplicada] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [prograAplicada] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [prograAplicada] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [prograAplicada] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [prograAplicada] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [prograAplicada] SET  DISABLE_BROKER 
GO
ALTER DATABASE [prograAplicada] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [prograAplicada] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [prograAplicada] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [prograAplicada] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [prograAplicada] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [prograAplicada] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [prograAplicada] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [prograAplicada] SET RECOVERY FULL 
GO
ALTER DATABASE [prograAplicada] SET  MULTI_USER 
GO
ALTER DATABASE [prograAplicada] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [prograAplicada] SET DB_CHAINING OFF 
GO
ALTER DATABASE [prograAplicada] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [prograAplicada] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [prograAplicada] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'prograAplicada', N'ON'
GO
ALTER DATABASE [prograAplicada] SET QUERY_STORE = OFF
GO
USE [prograAplicada]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [prograAplicada]
GO
/****** Object:  Table [dbo].[Agenda]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agenda](
	[ID_Registro] [int] IDENTITY(1,1) NOT NULL,
	[Finalizado] [bit] NULL,
	[ID_Concierto] [int] NULL,
	[Dia_Hora_Inicio] [datetime] NULL,
	[Dia_Hora_Fin] [datetime] NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[ID_Registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Asiento]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asiento](
	[ID_Asiento] [int] NOT NULL,
	[ID_Zona] [int] NULL,
	[Fila] [char](1) NULL,
	[Numero] [int] NULL,
 CONSTRAINT [PK_Asiento] PRIMARY KEY CLUSTERED 
(
	[ID_Asiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Boleto]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleto](
	[ID_Boleto] [int] IDENTITY(1,1) NOT NULL,
	[ID_Asiento] [int] NULL,
	[Folio_Compra] [int] NULL,
	[ID_Concierto] [int] NULL,
	[ID_Trabajador] [int] NULL,
 CONSTRAINT [PK_Boleto] PRIMARY KEY CLUSTERED 
(
	[ID_Boleto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Concierto]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Concierto](
	[ID_Concierto] [int] IDENTITY(1,1) NOT NULL,
	[Artista] [nchar](40) NULL,
	[Género] [nchar](40) NULL,
	[Nombre] [nchar](40) NULL,
	[Descripción] [ntext] NULL,
 CONSTRAINT [PK_Concierto] PRIMARY KEY CLUSTERED 
(
	[ID_Concierto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recibo]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibo](
	[Folio_compra] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Monto] [float] NULL,
 CONSTRAINT [PK_Recibo] PRIMARY KEY CLUSTERED 
(
	[Folio_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[ID_Trabajador] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nchar](10) NULL,
	[Contraseña] [nchar](20) NULL,
	[Nombre] [nchar](30) NULL,
	[Apellido] [nchar](30) NULL,
	[Edad] [nchar](30) NULL,
	[email] [nchar](50) NULL,
	[TipodeTrabajador] [int] NULL,
 CONSTRAINT [PK_Trabajador] PRIMARY KEY CLUSTERED 
(
	[ID_Trabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zona]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zona](
	[ID_Zona] [int] IDENTITY(1,1) NOT NULL,
	[Cupo] [int] NULL,
	[Precio] [int] NULL,
	[Ubicación] [nchar](20) NULL,
 CONSTRAINT [PK_Zona] PRIMARY KEY CLUSTERED 
(
	[ID_Zona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Agenda] ON 

INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (1, 1, 1, CAST(N'2017-11-26T18:06:06.000' AS DateTime), CAST(N'2017-11-26T18:06:06.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (2, 0, 2, CAST(N'2016-12-15T15:30:59.000' AS DateTime), CAST(N'2016-12-15T18:00:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (3, 0, 3, CAST(N'2017-01-05T20:00:00.000' AS DateTime), CAST(N'2017-01-05T22:00:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (4, 0, 4, CAST(N'2017-02-06T16:30:00.000' AS DateTime), CAST(N'2017-02-06T20:30:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (5, 0, 5, CAST(N'2017-11-15T10:00:00.000' AS DateTime), CAST(N'2016-11-15T13:00:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (6, 0, 6, CAST(N'2017-02-12T20:00:00.000' AS DateTime), CAST(N'2017-02-12T20:00:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (7, 0, 7, CAST(N'2017-05-13T21:30:00.000' AS DateTime), CAST(N'2017-05-13T23:30:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (8, 0, 8, CAST(N'2017-10-25T20:00:00.000' AS DateTime), CAST(N'2016-10-25T22:00:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (9, 0, 8, CAST(N'2016-11-28T19:10:00.000' AS DateTime), CAST(N'2016-11-28T19:10:00.000' AS DateTime))
INSERT [dbo].[Agenda] ([ID_Registro], [Finalizado], [ID_Concierto], [Dia_Hora_Inicio], [Dia_Hora_Fin]) VALUES (10, 0, 9, CAST(N'2016-11-28T19:12:36.000' AS DateTime), CAST(N'2016-11-28T19:12:36.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Agenda] OFF
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (1, 1, N'1', 1)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (2, 1, N'1', 2)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (3, 1, N'1', 3)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (4, 1, N'1', 4)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (5, 1, N'1', 5)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (6, 1, N'1', 6)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (7, 1, N'1', 7)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (8, 1, N'1', 8)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (9, 1, N'1', 9)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (10, 1, N'1', 10)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (11, 2, N'2', 11)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (12, 2, N'2', 12)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (13, 2, N'2', 13)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (14, 2, N'2', 14)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (15, 2, N'2', 15)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (16, 2, N'2', 16)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (17, 2, N'2', 17)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (18, 2, N'2', 18)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (19, 2, N'2', 19)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (20, 2, N'2', 20)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (21, 3, N'3', 21)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (22, 3, N'3', 22)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (23, 3, N'3', 23)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (24, 3, N'3', 24)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (25, 3, N'3', 25)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (26, 3, N'3', 26)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (27, 3, N'3', 27)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (28, 3, N'3', 28)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (29, 3, N'3', 29)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (30, 3, N'3', 30)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (31, 4, N'4', 31)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (32, 4, N'4', 32)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (33, 4, N'4', 33)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (34, 4, N'4', 34)
INSERT [dbo].[Asiento] ([ID_Asiento], [ID_Zona], [Fila], [Numero]) VALUES (35, 4, N'4', 35)
SET IDENTITY_INSERT [dbo].[Boleto] ON 

INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1021, 1, 1005, 2, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1023, 2, 1007, 1, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1026, 26, 1010, 6, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1027, 33, 1011, 5, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1028, 33, 1012, 1, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1030, 25, 1014, 6, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1032, 2, 1016, 2, 3)
INSERT [dbo].[Boleto] ([ID_Boleto], [ID_Asiento], [Folio_Compra], [ID_Concierto], [ID_Trabajador]) VALUES (1033, 1, 1017, 1, 3)
SET IDENTITY_INSERT [dbo].[Boleto] OFF
SET IDENTITY_INSERT [dbo].[Concierto] ON 

INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (1, N'Men At Work                             ', N'Rock                                    ', N'Business as Usual                       ', N'"comentarios"')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (2, N'Daft Punk                               ', N'House                                   ', N'Alive                                   ', N'111')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (3, N'Green Day                               ', N'Punk Rock                               ', N'Revolution Radio                        ', N'comentario')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (4, N'Foster the People                       ', N' indie rock                             ', N'Supermodel                              ', N'4')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (5, N'Fall Out Boy                            ', N'pop punk                                ', N'American Psycho                         ', N'111')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (6, N'Metallica                               ', N'Hard Rock                               ', N'World Wired Tour                        ', N'222')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (7, N'Muse                                    ', N'Rock                                    ', N'Drones World Tour                       ', N'333')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (8, N'Red Hot Chili Peppers                   ', N'Rock                                    ', N'The Getaway                             ', N'444')
INSERT [dbo].[Concierto] ([ID_Concierto], [Artista], [Género], [Nombre], [Descripción]) VALUES (9, N'b                                       ', N'b                                       ', N'b                                       ', N'b')
SET IDENTITY_INSERT [dbo].[Concierto] OFF
SET IDENTITY_INSERT [dbo].[Recibo] ON 

INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1, CAST(N'2016-10-27' AS Date), 2131)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (3, CAST(N'2016-11-22' AS Date), 1231)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (5, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (6, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (7, CAST(N'2016-11-22' AS Date), 500)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (8, CAST(N'2016-11-22' AS Date), 300)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (9, CAST(N'2016-11-22' AS Date), 100)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (10, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (11, CAST(N'2016-11-22' AS Date), 100)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (12, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (13, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (14, CAST(N'2016-11-22' AS Date), 500)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (15, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (16, CAST(N'2016-11-22' AS Date), 200)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (17, CAST(N'2016-11-22' AS Date), 300)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1005, CAST(N'2016-11-23' AS Date), 100)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1007, CAST(N'2016-11-23' AS Date), 100)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1010, CAST(N'2016-11-23' AS Date), 300)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1011, CAST(N'2016-11-23' AS Date), 500)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1012, CAST(N'2016-11-23' AS Date), 500)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1014, CAST(N'2016-11-23' AS Date), 300)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1016, CAST(N'2016-11-26' AS Date), 100)
INSERT [dbo].[Recibo] ([Folio_compra], [Fecha], [Monto]) VALUES (1017, CAST(N'2016-11-26' AS Date), 100)
SET IDENTITY_INSERT [dbo].[Recibo] OFF
SET IDENTITY_INSERT [dbo].[Trabajador] ON 

INSERT [dbo].[Trabajador] ([ID_Trabajador], [Usuario], [Contraseña], [Nombre], [Apellido], [Edad], [email], [TipodeTrabajador]) VALUES (1, N'Brenda    ', N'36606460            ', N'Brenda                        ', N'Avila                         ', N'18                            ', N'brendasamant@hotmail.com                          ', 1)
INSERT [dbo].[Trabajador] ([ID_Trabajador], [Usuario], [Contraseña], [Nombre], [Apellido], [Edad], [email], [TipodeTrabajador]) VALUES (2, N'Lima      ', N'<313300022          ', N'Luis Iván                     ', N'Morett                        ', N'18                            ', N'luisivanmorett@gmail.com                          ', 1)
INSERT [dbo].[Trabajador] ([ID_Trabajador], [Usuario], [Contraseña], [Nombre], [Apellido], [Edad], [email], [TipodeTrabajador]) VALUES (3, N'Pansho    ', N'123456              ', N'Jose Francisco                ', N'Martinez                      ', N'18                            ', N'nomesesucorreo@hotmail.com                        ', 2)
INSERT [dbo].[Trabajador] ([ID_Trabajador], [Usuario], [Contraseña], [Nombre], [Apellido], [Edad], [email], [TipodeTrabajador]) VALUES (4, N'Carlos    ', N'Contraseña          ', N'Carlos Alejandro              ', N'Rosales                       ', N'19                            ', N'blablabla@hotmail.com                             ', 3)
SET IDENTITY_INSERT [dbo].[Trabajador] OFF
SET IDENTITY_INSERT [dbo].[Zona] ON 

INSERT [dbo].[Zona] ([ID_Zona], [Cupo], [Precio], [Ubicación]) VALUES (1, 10, 100, N'"comentarios"       ')
INSERT [dbo].[Zona] ([ID_Zona], [Cupo], [Precio], [Ubicación]) VALUES (2, 10, 200, N'"comentarios"       ')
INSERT [dbo].[Zona] ([ID_Zona], [Cupo], [Precio], [Ubicación]) VALUES (3, 10, 300, N'"comentarios"       ')
INSERT [dbo].[Zona] ([ID_Zona], [Cupo], [Precio], [Ubicación]) VALUES (4, 5, 500, N'"comentarios"       ')
SET IDENTITY_INSERT [dbo].[Zona] OFF
ALTER TABLE [dbo].[Recibo] ADD  CONSTRAINT [DF_Recibo_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Concierto] FOREIGN KEY([ID_Concierto])
REFERENCES [dbo].[Concierto] ([ID_Concierto])
GO
ALTER TABLE [dbo].[Agenda] CHECK CONSTRAINT [FK_Agenda_Concierto]
GO
ALTER TABLE [dbo].[Asiento]  WITH CHECK ADD  CONSTRAINT [FK_Asiento_Zona1] FOREIGN KEY([ID_Zona])
REFERENCES [dbo].[Zona] ([ID_Zona])
GO
ALTER TABLE [dbo].[Asiento] CHECK CONSTRAINT [FK_Asiento_Zona1]
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD  CONSTRAINT [FK_Boleto_Asiento] FOREIGN KEY([ID_Asiento])
REFERENCES [dbo].[Asiento] ([ID_Asiento])
GO
ALTER TABLE [dbo].[Boleto] CHECK CONSTRAINT [FK_Boleto_Asiento]
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD  CONSTRAINT [FK_Boleto_Concierto] FOREIGN KEY([ID_Concierto])
REFERENCES [dbo].[Concierto] ([ID_Concierto])
GO
ALTER TABLE [dbo].[Boleto] CHECK CONSTRAINT [FK_Boleto_Concierto]
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD  CONSTRAINT [FK_Boleto_Recibo] FOREIGN KEY([Folio_Compra])
REFERENCES [dbo].[Recibo] ([Folio_compra])
GO
ALTER TABLE [dbo].[Boleto] CHECK CONSTRAINT [FK_Boleto_Recibo]
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD  CONSTRAINT [FK_Boleto_Trabajador] FOREIGN KEY([ID_Trabajador])
REFERENCES [dbo].[Trabajador] ([ID_Trabajador])
GO
ALTER TABLE [dbo].[Boleto] CHECK CONSTRAINT [FK_Boleto_Trabajador]
GO
/****** Object:  StoredProcedure [dbo].[Agregar]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Agregar]
@Nombre as nchar(40),
@Artista as nchar(40),
@Género as nchar(40),
@Descripción as ntext,
@Dia_Hora_Inicio as datetime,
@Dia_Hora_Fin as datetime
as 

begin

insert into concierto ([Nombre],[Artista],[Género],[Descripción]) VALUES (@Nombre,@Artista,@Género,@Descripción)

Declare @Id_Concierto as int
Select @Id_Concierto =  MAX(ID_Concierto)  FROM Concierto

insert into agenda ([ID_Concierto],[Dia_Hora_Inicio],[Dia_Hora_Fin],[Finalizado]) values ( @Id_Concierto,@Dia_Hora_Inicio,@Dia_Hora_Fin,'FALSE')



END
GO
/****** Object:  StoredProcedure [dbo].[Confirmacion]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Confirmacion]
@id_zona as nchar(40),
@folio as nchar(40)
as 

begin

DECLARE @id as INT;
SELECT @id=Asiento.ID_Zona FROM Asiento,boleto
WHERE Boleto.ID_Asiento = Asiento.ID_Asiento
AND Boleto.Folio_Compra = @folio;



IF @id=@id_zona 
SELECT 'true' AS retorno;
ELSE
SELECT 'false' AS retorno;	



END






GO
/****** Object:  StoredProcedure [dbo].[Modificar]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Modificar]
@Nombre as nchar(40),
@Artista as nchar(40),
@Género as nchar(40),
@Descripción as ntext,
@ID_Concierto as int,
@Dia_Hora_Inicio as datetime,
@Dia_Hora_Fin as datetime
as 

begin

UPDATE Concierto
SET Nombre=@Nombre,Artista=@Artista,Género=@Género,Descripción=@Descripción
WHERE ID_Concierto=@ID_Concierto;

UPDATE Agenda
SET Dia_Hora_Inicio=@Dia_Hora_Inicio,Dia_Hora_Fin=@Dia_Hora_Fin
WHERE ID_Concierto=@ID_Concierto;


END
GO
/****** Object:  StoredProcedure [dbo].[ProcedimientoEliminarBoleto]    Script Date: 28/11/2016 19:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcedimientoEliminarBoleto] 
@foliocomprasel nchar(40) 

as
begin

DECLARE @foliocompra AS int;

DECLARE Eliminar_Boleto CURSOR FOR SELECT dbo.Boleto.Folio_Compra FROM dbo.Boleto;
OPEN Eliminar_Boleto
FETCH Eliminar_Boleto INTO @foliocompra
WHILE (@@fetch_status = 0)
BEGIN
	if (@foliocompra=@foliocomprasel)
	BEGIN
	Delete from Boleto where Boleto.Folio_compra=@foliocompra
 Delete from Recibo where Recibo.Folio_compra=@foliocompra

		END
FETCH Eliminar_Boleto INTO @foliocompra
END
CLOSE Eliminar_Boleto;
DEALLOCATE Eliminar_Boleto


end
GO
USE [master]
GO
ALTER DATABASE [prograAplicada] SET  READ_WRITE 
GO
