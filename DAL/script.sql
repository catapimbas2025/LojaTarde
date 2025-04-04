USE [master]
GO
/****** Object:  Database [LOJADB]    Script Date: 24/03/2025 14:35:27 ******/
CREATE DATABASE [LOJADB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LOJADB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LOJADB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LOJADB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LOJADB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LOJADB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LOJADB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LOJADB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LOJADB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LOJADB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LOJADB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LOJADB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LOJADB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LOJADB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LOJADB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LOJADB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LOJADB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LOJADB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LOJADB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LOJADB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LOJADB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LOJADB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LOJADB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LOJADB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LOJADB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LOJADB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LOJADB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LOJADB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LOJADB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LOJADB] SET RECOVERY FULL 
GO
ALTER DATABASE [LOJADB] SET  MULTI_USER 
GO
ALTER DATABASE [LOJADB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LOJADB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LOJADB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LOJADB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LOJADB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LOJADB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LOJADB', N'ON'
GO
ALTER DATABASE [LOJADB] SET QUERY_STORE = ON
GO
ALTER DATABASE [LOJADB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LOJADB]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](100) NULL,
	[EMAIL] [varchar](100) NULL,
	[TELEFONE] [varchar](80) NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUTOS]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUTOS](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](100) NULL,
	[PRECO] [decimal](10, 2) NULL,
	[ESTOQUE] [int] NULL,
 CONSTRAINT [PK_PRODUTOS] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENDAS]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENDAS](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[DATA] [datetime] NULL,
	[QUANTIDADE] [int] NULL,
	[FATURADO] [bit] NULL,
	[CODIGOCLIENTE] [int] NULL,
	[CODIGOPRODUTO] [int] NULL,
 CONSTRAINT [PK_VENDAS] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VENDAS]  WITH CHECK ADD  CONSTRAINT [FK_CODIGO_CLIENTE] FOREIGN KEY([CODIGOCLIENTE])
REFERENCES [dbo].[CLIENTES] ([CODIGO])
GO
ALTER TABLE [dbo].[VENDAS] CHECK CONSTRAINT [FK_CODIGO_CLIENTE]
GO
ALTER TABLE [dbo].[VENDAS]  WITH CHECK ADD  CONSTRAINT [FK_CODIGO_PRODUTO] FOREIGN KEY([CODIGOPRODUTO])
REFERENCES [dbo].[PRODUTOS] ([CODIGO])
GO
ALTER TABLE [dbo].[VENDAS] CHECK CONSTRAINT [FK_CODIGO_PRODUTO]
GO
/****** Object:  StoredProcedure [dbo].[Altera_Clientes]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Altera_Clientes]
@codigo int,
@nome varchar (100),
@email varchar (100),
@telefone varchar (80)
AS
UPDATE CLIENTES SET nome = @nome, email = @email, telefone = @telefone WHERE codigo = @codigo
GO
/****** Object:  StoredProcedure [dbo].[Altera_Produtos]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Altera_Produtos]
@codigo int,
@nome varchar (100),
@preco decimal (10,2),
@estoque int
AS
UPDATE PRODUTOS SET nome = @nome, preco = @preco, estoque = @estoque WHERE codigo = @codigo
GO
/****** Object:  StoredProcedure [dbo].[Altera_Vendas]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Altera_Vendas]
@codigo int,
@data date ,
@quantidade int,
@faturado bit,
@codigocliente int,
@codigoproduto int
AS
UPDATE VENDAS SET data = @data, quantidade = @quantidade, faturado = @faturado, codigocliente = @codigocliente, codigoproduto = @codigoproduto  WHERE codigo = @codigo
GO
/****** Object:  StoredProcedure [dbo].[Exclui_Clientes]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Exclui_Clientes]
@codigo int
AS
DELETE FROM CLIENTES WHERE codigo = @codigo 
GO
/****** Object:  StoredProcedure [dbo].[Exclui_Produtos]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Exclui_Produtos]
@codigo int
AS
DELETE FROM PRODUTOS WHERE codigo = @codigo 
GO
/****** Object:  StoredProcedure [dbo].[Exclui_Vendas]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Exclui_Vendas]
@codigo int
AS
DELETE FROM VENDAS WHERE codigo = @codigo 
GO
/****** Object:  StoredProcedure [dbo].[Insere_Clientes]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insere_Clientes]
@codigo int output,
@nome varchar (100),
@email varchar (100),
@telefone varchar (80)
AS
INSERT INTO CLIENTES(nome, email, telefone)
VALUES (@nome, @email, @telefone)
SET @codigo = (SELECT @@IDENTITY )
GO
/****** Object:  StoredProcedure [dbo].[Insere_Produtos]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insere_Produtos]
@codigo int output,
@nome varchar (100),
@preco decimal (10,2),
@estoque int 
AS
INSERT INTO PRODUTOS(nome, preco, estoque)
VALUES (@nome, @preco, @estoque)
SET @codigo = (SELECT @@IDENTITY )
GO
/****** Object:  StoredProcedure [dbo].[Insere_Vendas]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insere_Vendas]
@codigo int output,
@data date,
@quantidade int, 
@faturado bit,
@codigocliente int,
@codigoproduto int
AS
INSERT INTO VENDAS (data, quantidade, faturado, codigocliente, codigoproduto)
VALUES (@data, @quantidade, @faturado, @codigocliente, @codigoproduto)
SET @codigo = (SELECT @@IDENTITY )
GO
/****** Object:  StoredProcedure [dbo].[Seleciona_Clientes]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Seleciona_Clientes]
@filtro varchar (100) = NULL
AS
BEGIN 
    IF @filtro IS NULL 
	SELECT * FROM CLIENTES
ELSE 
	SELECT * FROM CLIENTES
	WHERE NOME LIKE '%' + @filtro + '%'
	OR EMAIL LIKE '%' + @filtro + '%'
	OR TELEFONE LIKE '%' + @filtro + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Seleciona_Produtos]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Seleciona_Produtos]
@filtro varchar (100) = NULL
AS
BEGIN 
    IF @filtro IS NULL 
	SELECT * FROM PRODUTOS
ELSE 
	SELECT * FROM PRODUTOS
	WHERE NOME LIKE '%' + @filtro + '%'
	OR PRECO LIKE '%' + @filtro + '%'
	OR ESTOQUE LIKE '%' + @filtro + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Seleciona_Vendas]    Script Date: 24/03/2025 14:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Seleciona_Vendas]
@filtro varchar (100) = NULL
AS
BEGIN 
    IF @filtro IS NULL 
	SELECT * FROM VENDAS
ELSE 
	SELECT * FROM VENDAS
	WHERE DATA LIKE '%' + @filtro + '%'
	OR QUANTIDADE LIKE '%' + @filtro + '%'
	OR FATURADO LIKE '%' + @filtro + '%'
	OR CODIGOCLIENTE LIKE '%' + @filtro + '%'
	OR CODIGOPRODUTO LIKE '%' + @filtro + '%'
END
GO
USE [master]
GO
ALTER DATABASE [LOJADB] SET  READ_WRITE 
GO
