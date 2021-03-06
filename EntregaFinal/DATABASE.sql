USE [master]
GO
/****** Object:  Database [db_a79e23_vivero]    Script Date: 9/11/21 01:38:15 ******/
CREATE DATABASE [db_a79e23_vivero]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_a79e23_vivero_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_a79e23_vivero_DATA.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_a79e23_vivero_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_a79e23_vivero_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_a79e23_vivero] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_a79e23_vivero].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_a79e23_vivero] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_a79e23_vivero] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_a79e23_vivero] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_a79e23_vivero] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_a79e23_vivero] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_a79e23_vivero] SET  MULTI_USER 
GO
ALTER DATABASE [db_a79e23_vivero] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_a79e23_vivero] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_a79e23_vivero] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_a79e23_vivero] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_a79e23_vivero] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_a79e23_vivero] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_a79e23_vivero] SET QUERY_STORE = OFF
GO
USE [db_a79e23_vivero]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
 CONSTRAINT [id_barrio_pc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Canje]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canje](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TipoDoc] [int] NOT NULL,
	[NroDoc] [varchar](30) NOT NULL,
	[Id_Catalogo] [int] NOT NULL,
	[Id_Planta] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [canje_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[TipoDoc] ASC,
	[NroDoc] ASC,
	[Id_Catalogo] ASC,
	[Id_Planta] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catalogo]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [catalogo_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[TipoDoc] [int] NOT NULL,
	[NroDoc] [varchar](30) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Calle] [varchar](30) NULL,
	[NroCalle] [varchar](30) NULL,
	[Barrio] [int] NULL,
	[Localidad] [int] NULL,
	[Telefono] [varchar](30) NULL,
	[Email] [varchar](30) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [id_cliente_pk] PRIMARY KEY CLUSTERED 
(
	[TipoDoc] ASC,
	[NroDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Composicion]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Composicion](
	[Cod_Prod_Compuesto] [int] NOT NULL,
	[Cod_Prod_Componente] [int] NOT NULL,
	[Cant_Componente] [int] NULL,
 CONSTRAINT [composicion_id_pk] PRIMARY KEY CLUSTERED 
(
	[Cod_Prod_Compuesto] ASC,
	[Cod_Prod_Componente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCatalogo]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCatalogo](
	[ID_Catalogo] [int] NOT NULL,
	[Id_Planta] [int] NOT NULL,
	[Puntos_Necesarios] [int] NULL,
 CONSTRAINT [id_Catalogo_pk] PRIMARY KEY CLUSTERED 
(
	[ID_Catalogo] ASC,
	[Id_Planta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[Tipo_Factura] [int] NOT NULL,
	[Nro_Factura] [int] NOT NULL,
	[Id_Planta] [int] NULL,
	[Id_Producto] [int] NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](18, 0) NULL,
	[NroItem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Tipo_Factura] ASC,
	[Nro_Factura] ASC,
	[NroItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TipoDoc] [int] NULL,
	[NroDoc] [varchar](30) NULL,
	[Nombre] [varchar](30) NULL,
	[Apellido] [varchar](30) NULL,
	[Telefono] [varchar](30) NULL,
	[Calle] [varchar](30) NULL,
	[Nro_Calle] [varchar](30) NULL,
	[Barrio] [int] NULL,
	[Localidad] [int] NULL,
	[Contraseña] [varchar](30) NULL,
	[Estado] [bit] NOT NULL,
	[Perfil] [int] NULL,
 CONSTRAINT [id_empleado_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[ID] [bit] NOT NULL,
	[Descripcion] [varchar](10) NULL,
 CONSTRAINT [id_Estado_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Tipo_Factura] [int] NOT NULL,
	[Nro_Factura] [int] IDENTITY(100,1) NOT NULL,
	[TipoDoc] [int] NOT NULL,
	[NroDoc] [varchar](30) NOT NULL,
	[Fecha] [date] NULL,
	[Id_Empleado] [int] NULL,
	[Monto] [decimal](18, 0) NULL,
	[Puntos]  AS (CONVERT([int],[Monto]/(20))),
	[Estado] [bit] NULL,
 CONSTRAINT [id_factura_pk] PRIMARY KEY CLUSTERED 
(
	[Tipo_Factura] ASC,
	[Nro_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
 CONSTRAINT [id_Localidad_pc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planta]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planta](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[NombreCientifico] [varchar](50) NULL,
	[NombreComun] [varchar](20) NULL,
	[Tipo] [int] NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[Stock] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [id_planta_pk] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Tipo] [int] NULL,
	[Stock] [int] NULL,
	[Costo] [decimal](18, 0) NOT NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [id_Producto_pk] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Calle] [varchar](20) NULL,
	[Nro_Calle] [varchar](30) NULL,
	[Barrio] [int] NULL,
	[Localidad] [int] NULL,
	[Telefono] [varchar](30) NULL,
	[Razon_Social] [varchar](50) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [id_proveedor_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](20) NULL,
 CONSTRAINT [id_tipoDoc_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoFactura]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoFactura](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
 CONSTRAINT [tipofactura_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPlanta]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPlanta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Descripcion] [varchar](30) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [id_tipoPlanta_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 9/11/21 01:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [id_tipoProducto_pk] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Barrio] ([ID], [Nombre]) VALUES (1, N'General Paz')
INSERT [dbo].[Barrio] ([ID], [Nombre]) VALUES (2, N'Nueva Cordoba')
INSERT [dbo].[Barrio] ([ID], [Nombre]) VALUES (3, N'Crisol')
INSERT [dbo].[Barrio] ([ID], [Nombre]) VALUES (4, N'Centro')
INSERT [dbo].[Barrio] ([ID], [Nombre]) VALUES (5, N'Cerro')
GO
SET IDENTITY_INSERT [dbo].[Canje] ON 

INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (1, 1, N'42543887', 2, 4, CAST(N'2020-02-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (12, 1, N'23567890', 1, 2, CAST(N'2020-01-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (13, 1, N'0000000', 2, 4, CAST(N'2020-06-25T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (15, 2, N'23052765', 36, 4, CAST(N'2020-04-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (17, 2, N'434563902', 3, 1, CAST(N'2021-08-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (18, 3, N'31235789', 2, 5, CAST(N'2021-06-22T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (20, 3, N'42543883', 2, 4, CAST(N'2021-07-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (21, 4, N'332532534', 2, 4, CAST(N'2021-09-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (22, 1, N'400000', 36, 4, CAST(N'2021-08-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (23, 2, N'23052765', 2, 4, CAST(N'2021-01-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (25, 1, N'42543887', 2, 4, CAST(N'2020-03-17T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (26, 4, N'332532534', 1, 2, CAST(N'2021-05-07T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (27, 1, N'400000', 1, 2, CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (28, 4, N'332532534', 1, 2, CAST(N'2020-05-14T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (29, 1, N'0000000', 36, 4, CAST(N'2020-02-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (30, 3, N'42543883', 36, 4, CAST(N'2020-09-22T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (31, 2, N'23052765', 1, 2, CAST(N'2020-07-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (32, 4, N'332532534', 3, 1, CAST(N'2020-03-27T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (33, 4, N'332532534', 2, 4, CAST(N'2021-11-06T02:37:00.000' AS DateTime), 0)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (34, 1, N'23567890', 2, 5, CAST(N'2021-11-06T02:59:00.000' AS DateTime), 0)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (35, 1, N'23567890', 1, 2, CAST(N'2021-11-06T02:59:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (36, 1, N'23567890', 2, 4, CAST(N'2021-11-06T03:57:00.000' AS DateTime), 1)
INSERT [dbo].[Canje] ([ID], [TipoDoc], [NroDoc], [Id_Catalogo], [Id_Planta], [Fecha], [Estado]) VALUES (37, 1, N'23567890', 3, 1, CAST(N'2021-11-06T03:58:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Canje] OFF
GO
SET IDENTITY_INSERT [dbo].[Catalogo] ON 

INSERT [dbo].[Catalogo] ([ID], [Nombre], [Estado]) VALUES (1, N'Catalogo de verano', 1)
INSERT [dbo].[Catalogo] ([ID], [Nombre], [Estado]) VALUES (2, N'Catalogo de invierno', 1)
INSERT [dbo].[Catalogo] ([ID], [Nombre], [Estado]) VALUES (3, N'Catalogo de otoño', 1)
INSERT [dbo].[Catalogo] ([ID], [Nombre], [Estado]) VALUES (36, N'Catalogo de Primavera', 1)
SET IDENTITY_INSERT [dbo].[Catalogo] OFF
GO
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (1, N'0000000', N'Anonimo', N'Cliente', N'ninguna', N'0000', 4, 1, N'00000', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (1, N'23567890', N'Franco', N'Armani', N'Velez Sarfield', N'356', 5, 1, N'3513901345', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (1, N'400000', N'Maximo', N'Perez', N'Obispo', N'100', 2, 1, N'123', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (1, N'41905124', N'Esteban', N'Rodriguez', N'Sarmiento', N'780', 5, 3, N'3513423514', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (1, N'42256970', N'Pedro', N'Quinteros', N'Los Paraisos', N'652', 3, 2, N'3517412458', NULL, 0)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (1, N'42543887', N'Juan', N'Mitre', N'La coruña', N'203', 3, 5, N'3514698752', N'juan@gmail.com', 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (2, N'23052765', N'Alfredo', N'Rodriguez', N'Av. Alvear', N'543', 4, 1, N'3518904563', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (2, N'42543821', N'Maria', N'Kuttel', N'Buenos Aires', N'602', 2, 1, N'3514694752', N'Maria@gmail.com', 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (2, N'434563902', N'Pablo', N'Lunati', N'San Martin', N'341', 1, 1, N'3513192313', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (3, N'31235789', N'Marcos', N'Jota', N'Av. Olmos', N'590', 4, 4, N'342676776', NULL, 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (3, N'42543883', N'Milagros', N'Barnasthpol', N'Agustin Garzon', N'86', 4, 1, N'3514624752', N'milagros@gmail.com', 1)
INSERT [dbo].[Cliente] ([TipoDoc], [NroDoc], [Nombre], [Apellido], [Calle], [NroCalle], [Barrio], [Localidad], [Telefono], [Email], [Estado]) VALUES (4, N'332532534', N'Lucas', N'Vildoza', N'San Martin', N'467', 3, 1, N'351789447', NULL, 1)
GO
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (6, 2, 60)
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (6, 5, 40)
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (21, 1, 20)
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (21, 2, 40)
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (21, 3, 40)
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (24, 2, 70)
INSERT [dbo].[Composicion] ([Cod_Prod_Compuesto], [Cod_Prod_Componente], [Cant_Componente]) VALUES (24, 23, 30)
GO
INSERT [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta], [Puntos_Necesarios]) VALUES (1, 2, 200)
INSERT [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta], [Puntos_Necesarios]) VALUES (1, 4, 25)
INSERT [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta], [Puntos_Necesarios]) VALUES (2, 4, 250)
INSERT [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta], [Puntos_Necesarios]) VALUES (2, 5, 250)
INSERT [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta], [Puntos_Necesarios]) VALUES (3, 1, 450)
INSERT [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta], [Puntos_Necesarios]) VALUES (36, 4, 50)
GO
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 101, NULL, 2, 2001, CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 122, 1, NULL, 2001, CAST(1000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 127, 1, NULL, 2001, CAST(1000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 134, 1, NULL, 2001, CAST(1000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 137, NULL, 2, 2001, CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 138, NULL, 2, 2001, CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 138, 2, NULL, 2001, CAST(40 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 138, NULL, 21, 2001, CAST(20 AS Decimal(18, 0)), 3)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 139, NULL, 3, 2001, CAST(60 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 139, 2, NULL, 2001, CAST(40 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 140, 5, NULL, 2001, CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 140, 8, NULL, 2001, CAST(1666 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 143, NULL, 21, 2020, CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 143, NULL, 21, 2020, CAST(20 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 147, NULL, 1, 3000, CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 152, NULL, 24, 2950, CAST(130 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (1, 162, 14, NULL, 400, CAST(500 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 141, 2, NULL, 2002, CAST(40 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 141, NULL, 3, 2001, CAST(60 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 141, NULL, 6, 2003, CAST(300 AS Decimal(18, 0)), 3)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 141, 4, NULL, 2002, CAST(666 AS Decimal(18, 0)), 4)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 142, 4, NULL, 2066, CAST(666 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 144, NULL, 4, 2001, CAST(100 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 145, NULL, 6, 2003, CAST(300 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 145, 5, NULL, 2004, CAST(80 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 145, NULL, 5, 2007, CAST(70 AS Decimal(18, 0)), 3)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 146, 2, NULL, 2003, CAST(40 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 146, NULL, 2, 2002, CAST(30 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 146, NULL, 1, 2006, CAST(80 AS Decimal(18, 0)), 3)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 149, NULL, 2, 2250, CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 149, NULL, 2, 2800, CAST(30 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 154, NULL, 3, 3000, CAST(60 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 155, NULL, 21, 2500, CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 155, NULL, 21, 4300, CAST(20 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 156, 8, NULL, 5, CAST(1666 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 156, 5, NULL, 1, CAST(80 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 156, 5, NULL, 2, CAST(80 AS Decimal(18, 0)), 3)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 157, 8, NULL, 700, CAST(1666 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 157, 5, NULL, 1500, CAST(80 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 158, NULL, 1, 1, CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 159, NULL, 2, 3, CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 159, 4, NULL, 6, CAST(666 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 160, 12, NULL, 80, CAST(850 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 160, 14, NULL, 100, CAST(500 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 161, 11, NULL, 200, CAST(650 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (2, 161, 13, NULL, 25, CAST(2000 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (3, 148, NULL, 3, 3000, CAST(60 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (3, 150, NULL, 23, 2435, CAST(50 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (3, 150, NULL, 2, 2567, CAST(30 AS Decimal(18, 0)), 2)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (3, 151, NULL, 23, 2500, CAST(50 AS Decimal(18, 0)), 1)
INSERT [dbo].[DetalleFactura] ([Tipo_Factura], [Nro_Factura], [Id_Planta], [Id_Producto], [Cantidad], [Precio], [NroItem]) VALUES (3, 153, NULL, 4, 2034, CAST(100 AS Decimal(18, 0)), 1)
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (1, 4, N'12', N'Gonzalo', N'Casas', N'3513987452', N'Nuñez', N'2190', 5, 5, N'12', 1, 1)
INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (2, 1, N'321', N'Damian', N'Quinteros', N'351648957', N'Maipu', N'194', 4, 1, N'321', 1, 1)
INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (3, 3, N'456', N'Juan', N'Perez', N'3513987452', N'Nuñez', N'2190', 4, 2, N'456', 0, 2)
INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (27, 1, N'123', N'Lucas', N'Alonso', N'351312121', N'Belgrano', N'55', 1, 1, N'123', 1, 2)
INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (30, 1, N'123', N'Facundo', N'Perez', N'351521', N'Entre rios', N'123', 1, 1, N'123', 1, 2)
INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (31, 4, N'40622846', N'Stephan', N'Yanguez', N'2945603141', N'Ambrosio', N'123', 2, 1, N'123', 1, 1)
INSERT [dbo].[Empleado] ([ID], [TipoDoc], [NroDoc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Barrio], [Localidad], [Contraseña], [Estado], [Perfil]) VALUES (32, 2, N'12345678', N'Nicolas', N'Hidalgo', N'3518371390', N'Obispo Oro', N'312', 2, 1, N'12', 1, 1)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
INSERT [dbo].[Estado] ([ID], [Descripcion]) VALUES (0, N'Inactivo')
INSERT [dbo].[Estado] ([ID], [Descripcion]) VALUES (1, N'Activo')
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 101, 1, N'42543887', CAST(N'2020-02-11' AS Date), 2, CAST(11320 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 122, 1, N'42543887', CAST(N'2021-10-12' AS Date), 32, CAST(10000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 127, 2, N'23052765', CAST(N'2021-09-12' AS Date), 32, CAST(10000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 134, 1, N'42543887', CAST(N'2021-08-12' AS Date), 32, CAST(10000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 137, 1, N'42543887', CAST(N'2021-07-12' AS Date), 32, CAST(12030 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 138, 1, N'42543887', CAST(N'2021-10-12' AS Date), 32, CAST(12090 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 139, 2, N'23052765', CAST(N'2021-06-12' AS Date), 31, CAST(12100 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 140, 2, N'42543821', CAST(N'2021-02-12' AS Date), 32, CAST(10746 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 143, 1, N'0000000', CAST(N'2021-05-17' AS Date), 1, CAST(12800 AS Decimal(18, 0)), 0)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 147, 2, N'23052765', CAST(N'2021-10-31' AS Date), 32, CAST(80000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 152, 1, N'41905124', CAST(N'2021-10-31' AS Date), 32, CAST(123500 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (1, 162, 2, N'434563902', CAST(N'2021-11-09' AS Date), 31, CAST(200000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 141, 2, N'434563902', CAST(N'2021-06-13' AS Date), 1, CAST(11372 AS Decimal(18, 0)), 0)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 142, 1, N'0000000', CAST(N'2021-10-17' AS Date), 1, CAST(43956 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 144, 1, N'0000000', CAST(N'2021-10-17' AS Date), 1, CAST(12100 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 145, 3, N'31235789', CAST(N'2021-08-27' AS Date), 1, CAST(10710 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 146, 2, N'434563902', CAST(N'2020-12-25' AS Date), 1, CAST(12660 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 149, 3, N'31235789', CAST(N'2020-12-31' AS Date), 32, CAST(31500 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 154, 2, N'434563902', CAST(N'2020-12-31' AS Date), 32, CAST(60000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 155, 1, N'42543887', CAST(N'2020-12-31' AS Date), 32, CAST(56000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 156, 4, N'332532534', CAST(N'2021-10-31' AS Date), 31, CAST(8570 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 157, 1, N'41905124', CAST(N'2021-10-31' AS Date), 31, CAST(1286200 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 158, 1, N'400000', CAST(N'2021-11-04' AS Date), 2, CAST(4000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 159, 1, N'400000', CAST(N'2021-11-05' AS Date), 1, CAST(4086 AS Decimal(18, 0)), 0)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 160, 3, N'42543883', CAST(N'2021-11-09' AS Date), 31, CAST(118000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (2, 161, 1, N'42543887', CAST(N'2021-11-09' AS Date), 31, CAST(180000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (3, 148, 1, N'23567890', CAST(N'2020-12-31' AS Date), 32, CAST(60000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (3, 150, 4, N'332532534', CAST(N'2020-04-27' AS Date), 32, CAST(38760 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (3, 151, 1, N'400000', CAST(N'2020-08-31' AS Date), 32, CAST(25000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Factura] ([Tipo_Factura], [Nro_Factura], [TipoDoc], [NroDoc], [Fecha], [Id_Empleado], [Monto], [Estado]) VALUES (3, 153, 2, N'434563902', CAST(N'2020-05-31' AS Date), 32, CAST(12400 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
INSERT [dbo].[Localidad] ([ID], [Nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[Localidad] ([ID], [Nombre]) VALUES (2, N'Carlos Paz')
INSERT [dbo].[Localidad] ([ID], [Nombre]) VALUES (3, N'Rio Segundo')
INSERT [dbo].[Localidad] ([ID], [Nombre]) VALUES (4, N'Calamuchita')
INSERT [dbo].[Localidad] ([ID], [Nombre]) VALUES (5, N'General Roca')
GO
SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([ID], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfil] ([ID], [Descripcion]) VALUES (2, N'Vendedor')
INSERT [dbo].[Perfil] ([ID], [Descripcion]) VALUES (3, N'Reportes')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[Planta] ON 

INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (1, N'ADIANTUM CAPILLUS-VENERIS', N'Culantrillo', 2, CAST(1000 AS Decimal(18, 0)), 5000, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (2, N'Ocimum basilicum', N'Albahaca', 2, CAST(40 AS Decimal(18, 0)), 4999, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (4, N'Asplenium nidus', N'Nido', 1, CAST(666 AS Decimal(18, 0)), 665, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (5, N'Saccharum officinarum', N'Caña de azucar', 3, CAST(80 AS Decimal(18, 0)), 3497, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (8, N'Quiricocho', N'Flori', 1, CAST(1666 AS Decimal(18, 0)), 4295, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (9, N'Gymnocalycium', N'Cactus', 3, CAST(600 AS Decimal(18, 0)), 300, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (10, N'Euphorbia', N'Peonias', 1, CAST(2000 AS Decimal(18, 0)), 400, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (11, N'Veneris', N'PeoniasB', 2, CAST(650 AS Decimal(18, 0)), 400, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (12, N'Carnegiea gigantea', N'Lirio', 2, CAST(850 AS Decimal(18, 0)), 1320, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (13, N'GymnocalyciumB', N'Cactus', 1, CAST(2000 AS Decimal(18, 0)), 2000, 1)
INSERT [dbo].[Planta] ([Codigo], [NombreCientifico], [NombreComun], [Tipo], [Precio], [Stock], [Estado]) VALUES (14, N'Haworthia fasciata', N'Zinnia', 3, CAST(500 AS Decimal(18, 0)), 135, 1)
SET IDENTITY_INSERT [dbo].[Planta] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (1, N'Maceta', 1, 4999, CAST(40 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (2, N'Tierra negra', 2, 5000, CAST(20 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (3, N'Tierra profesional', 2, 5000, CAST(40 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (4, N'Abono universal', 3, 5000, CAST(65 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (5, N'Humus', 3, 5000, CAST(40 AS Decimal(18, 0)), CAST(70 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (6, N'Tierra con humus', 4, 5000, CAST(150 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (21, N'Maceta con tierra buena', 4, 5000, CAST(10 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (22, N'Fertilizante premium', 3, 5000, CAST(170 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (23, N'Arena comun', 2, 5000, CAST(30 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([Codigo], [Nombre], [Tipo], [Stock], [Costo], [Precio], [Estado]) VALUES (24, N'Tierra con arena', 4, 5000, CAST(70 AS Decimal(18, 0)), CAST(130 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (1, N'Terra', N'Olmos', N'195', 4, 1, N'4271421', N'Venta por mayor de tierra', 1)
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (2, N'AgroInsumo', N'Revolucion de mayo', N'300', 3, 2, N'4277821', N'Por mayor  fertilizantes', 1)
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (3, N'PlanTienda', N'Av Rafael Nuñez', N'500', 5, 3, N'4271746', N'Venta al por mayor de macetas', 1)
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (8, N'InsumoGo', N'Obispo oro', N'321', 1, 5, N'3513913124', N'Venta particular', 1)
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (9, N'AgroPlanta', N'Entre rios', N'750', 4, 1, N'351603149', N'Venta por mayor', 1)
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (10, N'PlantaWorld', N'Roque Saen Peña', N'1000', 3, 5, N'351603015', N'Ventas Mayoristas', 1)
INSERT [dbo].[Proveedor] ([ID], [Nombre], [Calle], [Nro_Calle], [Barrio], [Localidad], [Telefono], [Razon_Social], [Estado]) VALUES (11, N'Vegetable', N'Owen jones', N'1500', 4, 3, N'351603190', N'Ventas Mayoristas', 1)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
INSERT [dbo].[TipoDoc] ([ID], [Descripcion]) VALUES (1, N'DNI Tarjeta')
INSERT [dbo].[TipoDoc] ([ID], [Descripcion]) VALUES (2, N'DNI Libreta verde')
INSERT [dbo].[TipoDoc] ([ID], [Descripcion]) VALUES (3, N'Libreta Civica')
INSERT [dbo].[TipoDoc] ([ID], [Descripcion]) VALUES (4, N'Pasaporte')
GO
INSERT [dbo].[TipoFactura] ([ID], [Nombre]) VALUES (1, N'A: Responsable Inscripto')
INSERT [dbo].[TipoFactura] ([ID], [Nombre]) VALUES (2, N'B: Consumidor Final')
INSERT [dbo].[TipoFactura] ([ID], [Nombre]) VALUES (3, N'C: Monotributista')
GO
SET IDENTITY_INSERT [dbo].[TipoPlanta] ON 

INSERT [dbo].[TipoPlanta] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Helecho', N'Planta de interior', 1)
INSERT [dbo].[TipoPlanta] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Herbacea', N'Culinaria', 1)
INSERT [dbo].[TipoPlanta] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (3, N'Angiospermas', N'Planta con flores', 1)
SET IDENTITY_INSERT [dbo].[TipoPlanta] OFF
GO
INSERT [dbo].[TipoProducto] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Accesorio', N'Piezas parar adornar las plantas', 1)
INSERT [dbo].[TipoProducto] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Tierra', N'Distintos tipos de tierras', 1)
INSERT [dbo].[TipoProducto] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (3, N'Fertilizante', N'Distintos tipos de fertilizantes', 1)
INSERT [dbo].[TipoProducto] ([ID], [Nombre], [Descripcion], [Estado]) VALUES (4, N'Compuesto', N'Producto formado por 2 productos', 1)
GO
ALTER TABLE [dbo].[Canje]  WITH CHECK ADD  CONSTRAINT [canje_cliente_fk] FOREIGN KEY([TipoDoc], [NroDoc])
REFERENCES [dbo].[Cliente] ([TipoDoc], [NroDoc])
GO
ALTER TABLE [dbo].[Canje] CHECK CONSTRAINT [canje_cliente_fk]
GO
ALTER TABLE [dbo].[Canje]  WITH CHECK ADD  CONSTRAINT [canje_productos_fk] FOREIGN KEY([Id_Catalogo], [Id_Planta])
REFERENCES [dbo].[DetalleCatalogo] ([ID_Catalogo], [Id_Planta])
GO
ALTER TABLE [dbo].[Canje] CHECK CONSTRAINT [canje_productos_fk]
GO
ALTER TABLE [dbo].[Canje]  WITH CHECK ADD FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Catalogo]  WITH CHECK ADD  CONSTRAINT [estado_catalogo_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Catalogo] CHECK CONSTRAINT [estado_catalogo_fk]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [estado_cliente_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [estado_cliente_fk]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [id_barrio_fk] FOREIGN KEY([Barrio])
REFERENCES [dbo].[Barrio] ([ID])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [id_barrio_fk]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [id_localidad_fk] FOREIGN KEY([Localidad])
REFERENCES [dbo].[Localidad] ([ID])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [id_localidad_fk]
GO
ALTER TABLE [dbo].[Composicion]  WITH CHECK ADD  CONSTRAINT [cod_prod_comp_fk] FOREIGN KEY([Cod_Prod_Compuesto])
REFERENCES [dbo].[Producto] ([Codigo])
GO
ALTER TABLE [dbo].[Composicion] CHECK CONSTRAINT [cod_prod_comp_fk]
GO
ALTER TABLE [dbo].[Composicion]  WITH CHECK ADD  CONSTRAINT [cod_prod_Componente_fk] FOREIGN KEY([Cod_Prod_Componente])
REFERENCES [dbo].[Producto] ([Codigo])
GO
ALTER TABLE [dbo].[Composicion] CHECK CONSTRAINT [cod_prod_Componente_fk]
GO
ALTER TABLE [dbo].[DetalleCatalogo]  WITH CHECK ADD  CONSTRAINT [id_catalogo_detalle_catalogo_fk] FOREIGN KEY([ID_Catalogo])
REFERENCES [dbo].[Catalogo] ([ID])
GO
ALTER TABLE [dbo].[DetalleCatalogo] CHECK CONSTRAINT [id_catalogo_detalle_catalogo_fk]
GO
ALTER TABLE [dbo].[DetalleCatalogo]  WITH CHECK ADD  CONSTRAINT [id_planta_detalle_catalogo_fk] FOREIGN KEY([Id_Planta])
REFERENCES [dbo].[Planta] ([Codigo])
GO
ALTER TABLE [dbo].[DetalleCatalogo] CHECK CONSTRAINT [id_planta_detalle_catalogo_fk]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [detalle_Factura_fk] FOREIGN KEY([Tipo_Factura], [Nro_Factura])
REFERENCES [dbo].[Factura] ([Tipo_Factura], [Nro_Factura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [detalle_Factura_fk]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [Id_Planta_fk] FOREIGN KEY([Id_Planta])
REFERENCES [dbo].[Planta] ([Codigo])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [Id_Planta_fk]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [Id_Producto_fk] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Producto] ([Codigo])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [Id_Producto_fk]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [barrio_empleado_fk] FOREIGN KEY([Barrio])
REFERENCES [dbo].[Barrio] ([ID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [barrio_empleado_fk]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleado_perfil_fk] FOREIGN KEY([Perfil])
REFERENCES [dbo].[Perfil] ([ID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleado_perfil_fk]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [estado_empleado_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [estado_empleado_fk]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [localidad_empleado_fk] FOREIGN KEY([Localidad])
REFERENCES [dbo].[Localidad] ([ID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [localidad_empleado_fk]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [doc_factura_fk] FOREIGN KEY([TipoDoc], [NroDoc])
REFERENCES [dbo].[Cliente] ([TipoDoc], [NroDoc])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [doc_factura_fk]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_EstadoFactura] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_EstadoFactura]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [id_empleado_fk] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([ID])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [id_empleado_fk]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [TipoFactura_fk] FOREIGN KEY([Tipo_Factura])
REFERENCES [dbo].[TipoFactura] ([ID])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [TipoFactura_fk]
GO
ALTER TABLE [dbo].[Planta]  WITH CHECK ADD  CONSTRAINT [estado_planta_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Planta] CHECK CONSTRAINT [estado_planta_fk]
GO
ALTER TABLE [dbo].[Planta]  WITH CHECK ADD  CONSTRAINT [tipo_planta_fk] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoPlanta] ([ID])
GO
ALTER TABLE [dbo].[Planta] CHECK CONSTRAINT [tipo_planta_fk]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [estado_producto_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [estado_producto_fk]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [tipo_producto_fk] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoProducto] ([ID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [tipo_producto_fk]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [barrio_fk] FOREIGN KEY([Barrio])
REFERENCES [dbo].[Barrio] ([ID])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [barrio_fk]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [estado_proveedor_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [estado_proveedor_fk]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [localidad_fk] FOREIGN KEY([Localidad])
REFERENCES [dbo].[Localidad] ([ID])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [localidad_fk]
GO
ALTER TABLE [dbo].[TipoPlanta]  WITH CHECK ADD  CONSTRAINT [estado_tipo_planta_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[TipoPlanta] CHECK CONSTRAINT [estado_tipo_planta_fk]
GO
ALTER TABLE [dbo].[TipoProducto]  WITH CHECK ADD  CONSTRAINT [estado_tipo_producto_fk] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID])
GO
ALTER TABLE [dbo].[TipoProducto] CHECK CONSTRAINT [estado_tipo_producto_fk]
GO
USE [master]
GO
ALTER DATABASE [db_a79e23_vivero] SET  READ_WRITE 
GO
