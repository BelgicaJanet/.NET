USE [testdatabase]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 1/04/2017 18:07:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[CAT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETPEDIDO]    Script Date: 1/04/2017 18:07:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[DET_ITEM] ASC,
	[PED_ID] ASC,
	[PROD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 1/04/2017 18:07:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[PED_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 1/04/2017 18:07:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[PROD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 1/04/2017 18:07:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[USR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_CATEGORIA]    Script Date: 1/04/2017 18:07:42 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_MANT_CATEGORIA]    Script Date: 1/04/2017 18:07:43 ******/
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
