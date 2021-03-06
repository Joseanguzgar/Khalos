USE [master]
GO
/****** Object:  Database [KhalosBD]    Script Date: 22/7/2018 16:59:12 ******/
CREATE DATABASE [KhalosBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KhalosBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS01\MSSQL\DATA\KhalosBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KhalosBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS01\MSSQL\DATA\KhalosBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KhalosBD] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KhalosBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KhalosBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KhalosBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KhalosBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KhalosBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KhalosBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [KhalosBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KhalosBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KhalosBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KhalosBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KhalosBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KhalosBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KhalosBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KhalosBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KhalosBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KhalosBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KhalosBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KhalosBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KhalosBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KhalosBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KhalosBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KhalosBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KhalosBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KhalosBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KhalosBD] SET  MULTI_USER 
GO
ALTER DATABASE [KhalosBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KhalosBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KhalosBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KhalosBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KhalosBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KhalosBD] SET QUERY_STORE = OFF
GO
USE [KhalosBD]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [KhalosBD]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Identificacion] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cobro](
	[Id_Cobro] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Factura] [int] NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [int] NOT NULL,
 CONSTRAINT [PK_Cobro] PRIMARY KEY CLUSTERED 
(
	[Id_Cobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Cobro]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Cobro](
	[Id_DetCobro] [int] NOT NULL,
	[Id_Cobro] [int] NOT NULL,
	[Id_Factura] [int] NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL,
 CONSTRAINT [PK_Detalle_Cobro] PRIMARY KEY CLUSTERED 
(
	[Id_DetCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[IdDetalle] [int] NOT NULL,
	[IdFactura] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [float] NOT NULL,
	[Precio] [float] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[PrecioTotal] [float] NOT NULL,
	[NombreTienda] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Ubicacion] [varchar](120) NOT NULL,
	[Correo] [varchar](80) NOT NULL,
	[Facebook] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pendiente]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pendiente](
	[Id_Pendiente] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Factura] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pendiente] PRIMARY KEY CLUSTERED 
(
	[Id_Pendiente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cantidad_Stock] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Talla] [varchar](50) NOT NULL,
	[PrecioMayor] [float] NOT NULL,
	[PrecioDetalle] [float] NOT NULL,
	[PrecioCosto] [float] NOT NULL,
	[Color] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cuenta] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (1, N'Ropa')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (2, N'Calzado')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (3, N'Accesorios')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (4, N'Bolsos')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (5, N'Sueter')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id_Cliente], [Nombre], [Correo], [Direccion], [Telefono], [Identificacion]) VALUES (1, N'Gabriela Chacón', N'gabymchq', N'desamparados', N'88501544', N'1791171')
INSERT [dbo].[Cliente] ([Id_Cliente], [Nombre], [Correo], [Direccion], [Telefono], [Identificacion]) VALUES (2, N'Ricardo', N'lic.marin.abogado', N'desamparados', N'2', N'1810758')
INSERT [dbo].[Cliente] ([Id_Cliente], [Nombre], [Correo], [Direccion], [Telefono], [Identificacion]) VALUES (3, N'Maria', N'ede', N'sasa', N'88501544', N'116870340')
INSERT [dbo].[Cliente] ([Id_Cliente], [Nombre], [Correo], [Direccion], [Telefono], [Identificacion]) VALUES (5, N'dej', N'ekedk', N'dkdkd', N'de', N'11')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [IdCategoria], [Nombre], [Cantidad_Stock], [Descripcion], [Talla], [PrecioMayor], [PrecioDetalle], [PrecioCosto], [Color]) VALUES (2, 2, N'asas', 2, N'asaadw', N'2', 1345, 2525, 25000, N'color')
INSERT [dbo].[Producto] ([IdProducto], [IdCategoria], [Nombre], [Cantidad_Stock], [Descripcion], [Talla], [PrecioMayor], [PrecioDetalle], [PrecioCosto], [Color]) VALUES (3, 4, N'sadasd', 5, N'asd', N'10', 41561, 5925, 1592, N'aaa')
INSERT [dbo].[Producto] ([IdProducto], [IdCategoria], [Nombre], [Cantidad_Stock], [Descripcion], [Talla], [PrecioMayor], [PrecioDetalle], [PrecioCosto], [Color]) VALUES (4, 5, N'Sudadera', 5, N'Calvin', N'XL', 8100, 12000, 10000, N'Gris')
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([IdRol], [Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([IdRol], [Nombre]) VALUES (2, N'Vendedor')
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [IdRol], [Nombre], [Cuenta], [Contraseña]) VALUES (1, 1, N'Maritza ', N'Admin', N'123')
INSERT [dbo].[Usuario] ([IdUsuario], [IdRol], [Nombre], [Cuenta], [Contraseña]) VALUES (2, 2, N'José', N'Jose', N'2114')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_DetalleFactura] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Factura] ([IdFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_DetalleFactura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
/****** Object:  StoredProcedure [dbo].[sp_CantidadStock]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CantidadStock]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT p.IdProducto as Codigo, c.Nombre as Categoria, p.Nombre as Nombre, p.PrecioDetalle as   
	Precio, p.Cantidad_Stock as Disponible, p.Descripcion as Descripcion, p.Marca as Marca,
	p.Talla as Talla from Producto p join Categoria c 
	on p.IdCategoria = c.IdCategoria 
	AND p.Cantidad_Stock > 0;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_listarProductos]    Script Date: 22/7/2018 16:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_listarProductos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 SELECT p.IdProducto as Codigo, ca.Nombre as Categoria, p.Nombre as Nombre, p.PrecioDetalle as Precio,
	p.Cantidad_Stock as Cantidad_en_Stock, p.Descripcion as Descripcion
	FROM Producto p JOIN Categoria ca ON p.IdCategoria = ca.IdCategoria;
end
GO
USE [master]
GO
ALTER DATABASE [KhalosBD] SET  READ_WRITE 
GO
