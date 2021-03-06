USE [master]
GO
/****** Object:  Database [problemas]    Script Date: 10/09/2018 09:06:00 p.m. ******/
CREATE DATABASE [problemas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'problemas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\problemas.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'problemas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\problemas_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [problemas] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [problemas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [problemas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [problemas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [problemas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [problemas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [problemas] SET ARITHABORT OFF 
GO
ALTER DATABASE [problemas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [problemas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [problemas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [problemas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [problemas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [problemas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [problemas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [problemas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [problemas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [problemas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [problemas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [problemas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [problemas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [problemas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [problemas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [problemas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [problemas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [problemas] SET RECOVERY FULL 
GO
ALTER DATABASE [problemas] SET  MULTI_USER 
GO
ALTER DATABASE [problemas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [problemas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [problemas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [problemas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [problemas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'problemas', N'ON'
GO
USE [problemas]
GO
/****** Object:  Table [dbo].[problema]    Script Date: 10/09/2018 09:06:00 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[problema](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_problema] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[solucion]    Script Date: 10/09/2018 09:06:00 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[solucion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProblema] [int] NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_solucion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[solucion]  WITH CHECK ADD  CONSTRAINT [FK_solucion_problema] FOREIGN KEY([idProblema])
REFERENCES [dbo].[problema] ([id])
GO
ALTER TABLE [dbo].[solucion] CHECK CONSTRAINT [FK_solucion_problema]
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAPROBLEMA]    Script Date: 10/09/2018 09:06:00 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LISTAPROBLEMA]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT p.id as ID, p.descripcion as Descripcion FROM problema p
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LISTASOLUCION]    Script Date: 10/09/2018 09:06:00 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LISTASOLUCION](
	@ProblemaId int
)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT s.id as ID, s.descripcion as Solucion FROM solucion s where s.idProblema=@ProblemaId
END

GO
/****** Object:  StoredProcedure [dbo].[SP_NUEVASOLUCION]    Script Date: 10/09/2018 09:06:00 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_NUEVASOLUCION](
	@IPR int,
	@DES varchar(50)
)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO solucion
		VALUES(@IPR,@DES)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_NUEVOPROBLEMA]    Script Date: 10/09/2018 09:06:00 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_NUEVOPROBLEMA](
	@DES varchar(50),
	@TIP varchar(50)
)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO problema
		VALUES(@DES,@TIP)
END

GO
USE [master]
GO
ALTER DATABASE [problemas] SET  READ_WRITE 
GO
