USE [testdatabase]
GO
/****** Object:  StoredProcedure [dbo].[SP_MANT_CATEGORIA]    Script Date: 1/04/2017 18:44:48 ******/
DROP PROCEDURE [dbo].[SP_MANT_CATEGORIA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_CATEGORIA]    Script Date: 1/04/2017 18:44:48 ******/
DROP PROCEDURE [dbo].[SP_CONSULTA_CATEGORIA]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[USUARIO]
GO
/****** Object:  Table [dbo].[PROVEDOR]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[PROVEDOR]
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[PRODUCTO]
GO
/****** Object:  Table [dbo].[PRODPROV]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[PRODPROV]
GO
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[PEDIDO]
GO
/****** Object:  Table [dbo].[DETPEDIDO]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[DETPEDIDO]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 1/04/2017 18:44:49 ******/
DROP TABLE [dbo].[CATEGORIA]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[CAT_ID] [char](2) NOT NULL,
	[CAT_DESCRIPCION] [varchar](100) NOT NULL,
	[CAT_ORDEN] [int] NULL,
	[CAT_ESTADO] [char](1) NULL,
 CONSTRAINT [PK__CATEGORI__5F8323A89CFA4F76] PRIMARY KEY CLUSTERED 
(
	[CAT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETPEDIDO]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETPEDIDO](
	[DET_ITEM] [int] NOT NULL,
	[PED_ID] [char](8) NOT NULL,
	[PROD_ID] [char](4) NOT NULL,
	[DET_CANTIDAD] [numeric](5, 0) NOT NULL,
	[DET_PRECIO] [numeric](10, 2) NULL,
 CONSTRAINT [PK__DETPEDID__4FDB7A09ECCC4FAF] PRIMARY KEY CLUSTERED 
(
	[DET_ITEM] ASC,
	[PED_ID] ASC,
	[PROD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PEDIDO](
	[PED_ID] [char](8) NOT NULL,
	[PED_FECHA] [date] NOT NULL,
	[PED_CLIENTE] [varchar](255) NULL,
	[USR_ID] [char](5) NOT NULL,
	[PED_ESTADO] [char](1) NOT NULL,
 CONSTRAINT [PK__PEDIDO__71F47F6AC2D80227] PRIMARY KEY CLUSTERED 
(
	[PED_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODPROV]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODPROV](
	[PROD_ID] [nchar](4) NULL,
	[PROV_ID] [numeric](18, 0) NULL,
	[PRODPROV_PRECIO] [numeric](18, 0) NOT NULL
)

GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[PROD_ID] [char](4) NOT NULL,
	[PROD_DESCRIPCION] [varchar](200) NOT NULL,
	[PROD_DESC_CORTA] [varchar](100) NOT NULL,
	[PROD_PRECIO] [numeric](10, 2) NULL,
	[PROD_STOCK] [numeric](5, 0) NULL,
	[PROD_ESTADO] [char](1) NOT NULL,
	[CAT_ID] [char](2) NOT NULL,
 CONSTRAINT [PK__PRODUCTO__B3271E11283ACAD2] PRIMARY KEY CLUSTERED 
(
	[PROD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROVEDOR]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEDOR](
	[PROV_ID] [numeric](18, 0) NULL,
	[PROV_NOMBRE] [nvarchar](50) NOT NULL,
	[PROV_RUC] [numeric](18, 0) NOT NULL
)

GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 1/04/2017 18:44:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[USR_ID] [char](5) NOT NULL,
	[USR_NOMBRE] [varchar](100) NOT NULL,
	[USR_APELLIDO] [varchar](100) NOT NULL,
	[USR_CLAVE] [varchar](20) NOT NULL,
	[USR_ESTADO] [char](1) NULL,
 CONSTRAINT [PK__USUARIO__91DE2276CE3C2486] PRIMARY KEY CLUSTERED 
(
	[USR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CATEGORIA] ([CAT_ID], [CAT_DESCRIPCION], [CAT_ORDEN], [CAT_ESTADO]) VALUES (N'01', N'BEBIDAS', 1, N'A')
INSERT [dbo].[CATEGORIA] ([CAT_ID], [CAT_DESCRIPCION], [CAT_ORDEN], [CAT_ESTADO]) VALUES (N'02', N'SANDWICH', 2, N'A')
INSERT [dbo].[CATEGORIA] ([CAT_ID], [CAT_DESCRIPCION], [CAT_ORDEN], [CAT_ESTADO]) VALUES (N'03', N'HELADOS', 3, N'A')
INSERT [dbo].[CATEGORIA] ([CAT_ID], [CAT_DESCRIPCION], [CAT_ORDEN], [CAT_ESTADO]) VALUES (N'04', N'DULCES', 4, N'A')
INSERT [dbo].[PRODPROV] ([PROD_ID], [PROV_ID], [PRODPROV_PRECIO]) VALUES (N'0001', CAST(1 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)))
INSERT [dbo].[PRODPROV] ([PROD_ID], [PROV_ID], [PRODPROV_PRECIO]) VALUES (N'0002', CAST(2 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)))
INSERT [dbo].[PRODPROV] ([PROD_ID], [PROV_ID], [PRODPROV_PRECIO]) VALUES (N'0003', CAST(1 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0001', N'COCA COLA 500 ml', N'COCA 500', CAST(3.50 AS Numeric(10, 2)), CAST(100 AS Numeric(5, 0)), N'A', N'01')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0002', N'INCA KOLA 500 ml', N'INKE 500', CAST(3.50 AS Numeric(10, 2)), CAST(100 AS Numeric(5, 0)), N'A', N'01')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0003', N'FANTA 500 ml', N'FANTA 500', CAST(3.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'01')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0004', N'SPRITE 500 ml', N'SPRITE 500', CAST(3.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'01')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0005', N'AGUA SAN MATEO', N'SN. MATEO 500', CAST(2.50 AS Numeric(10, 2)), CAST(100 AS Numeric(5, 0)), N'A', N'01')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0006', N'SANDWICH TRIPLE', N'SAND. TRIPLE', CAST(3.50 AS Numeric(10, 2)), CAST(20 AS Numeric(5, 0)), N'A', N'02')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0007', N'HAMBURGUESA DE POLLO', N'HAMB. POLLO', CAST(4.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'02')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0008', N'HAMBURGUESA DE CARNE', N'HAMB. CARNE', CAST(4.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'02')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0009', N'HAMBURGUESA ROYAL', N'HAMB. ROYAL', CAST(6.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'02')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0010', N'SANDWICH DE JAMON', N'SAND. JAMON', CAST(8.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'02')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0011', N'SANDWICH DE PAVO', N'SAND. PAVO', CAST(8.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'02')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0012', N'HELADOS SIMPLE', N'HLD. SIMPLE', CAST(5.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'03')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0013', N'HELADOS DOBLE', N'HLD. DOBLE', CAST(8.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'03')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0014', N'HELADOS TRIPLE', N'HLD. TRIPLE', CAST(11.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'03')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0015', N'HELADOS TRIPLE', N'HLD. TRIPLE', CAST(11.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'03')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0016', N'LECHE ASADA', N'LECHE ASADA', CAST(3.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'04')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0017', N'GELATINA', N'GELATINA', CAST(2.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'04')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0018', N'FLAN', N'FLAN', CAST(3.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'04')
INSERT [dbo].[PRODUCTO] ([PROD_ID], [PROD_DESCRIPCION], [PROD_DESC_CORTA], [PROD_PRECIO], [PROD_STOCK], [PROD_ESTADO], [CAT_ID]) VALUES (N'0019', N'TORTA HELADA', N'TORTA HELADA', CAST(4.00 AS Numeric(10, 2)), CAST(50 AS Numeric(5, 0)), N'A', N'04')
INSERT [dbo].[PROVEDOR] ([PROV_ID], [PROV_NOMBRE], [PROV_RUC]) VALUES (CAST(1 AS Numeric(18, 0)), N'COCA COLA', CAST(478945623 AS Numeric(18, 0)))
INSERT [dbo].[PROVEDOR] ([PROV_ID], [PROV_NOMBRE], [PROV_RUC]) VALUES (CAST(2 AS Numeric(18, 0)), N'BACKUS', CAST(178825645 AS Numeric(18, 0)))
INSERT [dbo].[PROVEDOR] ([PROV_ID], [PROV_NOMBRE], [PROV_RUC]) VALUES (CAST(3 AS Numeric(18, 0)), N'TAMBO', CAST(789546456 AS Numeric(18, 0)))
INSERT [dbo].[USUARIO] ([USR_ID], [USR_NOMBRE], [USR_APELLIDO], [USR_CLAVE], [USR_ESTADO]) VALUES (N'16001', N'JUAN', N'PEREZ', N'09090909', N'A')
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_CATEGORIA]    Script Date: 1/04/2017 18:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTA_CATEGORIA]
@TIPO CHAR(1),  
@CAT_ID CHAR(2)
AS
IF @TIPO='N' 
	SELECT CASE WHEN MAX(CAT_ID)>0 THEN CONVERT(INT,MAX(CAT_ID))+1 ELSE 1 END AS NUEVO_ID FROM CATEGORIA
	IF @TIPO='B'
		SELECT * FROM CATEGORIA WHERE CAT_ID=@CAT_ID
	ELSE
		SELECT * FROM CATEGORIA

--- EJECUTAR PROCEDIMIENTO ALMACENADO SP_CONSULTA_CATEGORIA
EXECUTE SP_CONSULTA_CATEGORIA 'N',''

--- =============================================================================================
--- CREAR PROCEDIMIENTO ALMACENADO SP_MANT_CATEGORIA
IF EXISTS(SELECT * FROM SYSOBJECTS WHERE XTYPE='P' AND NAME = 'SP_MANT_CATEGORIA')
      DROP PROCEDURE SP_MANT_CATEGORIA

GO
/****** Object:  StoredProcedure [dbo].[SP_MANT_CATEGORIA]    Script Date: 1/04/2017 18:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MANT_CATEGORIA]
@TIPO CHAR(1), 
@CAT_ID CHAR(2),
@CAT_DESCRIPCION VARCHAR(100),
@CAT_ORDEN INT,
@CAT_ESTADO CHAR(1)
AS
IF @TIPO='I'
	INSERT INTO CATEGORIA (CAT_ID,CAT_DESCRIPCION,CAT_ORDEN,CAT_ESTADO) VALUES (@CAT_ID,@CAT_DESCRIPCION,@CAT_ORDEN,@CAT_ESTADO)
ELSE
	IF @TIPO='U'
		UPDATE CATEGORIA SET CAT_DESCRIPCION=@CAT_DESCRIPCION, CAT_ORDEN=@CAT_ORDEN, CAT_ESTADO=@CAT_ESTADO WHERE CAT_ID=@CAT_ID
	ELSE
		DELETE FROM CATEGORIA WHERE CAT_ID=@CAT_ID

--- EJECUTAR PROCEDIMIENTO ALMACENADO SP_MANT_CATEGORIA
EXECUTE SP_MANT_CATEGORIA 'U','03','wwwww',10,'A'


GO
