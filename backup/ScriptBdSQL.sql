USE [master]
GO
/****** Object:  Database [bd_projeto_form_camila]    Script Date: 4/7/2024 10:43:54 PM ******/
CREATE DATABASE [bd_projeto_form_camila]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_projeto_form_camila', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\bd_projeto_form_camila.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_projeto_form_camila_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\bd_projeto_form_camila_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd_projeto_form_camila] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_projeto_form_camila].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_projeto_form_camila] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bd_projeto_form_camila] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_projeto_form_camila] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_projeto_form_camila] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bd_projeto_form_camila] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_projeto_form_camila] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bd_projeto_form_camila] SET  MULTI_USER 
GO
ALTER DATABASE [bd_projeto_form_camila] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_projeto_form_camila] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_projeto_form_camila] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_projeto_form_camila] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_projeto_form_camila] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_projeto_form_camila] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [bd_projeto_form_camila] SET QUERY_STORE = OFF
GO
USE [bd_projeto_form_camila]
GO
/****** Object:  Table [dbo].[aluno]    Script Date: 4/7/2024 10:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aluno](
	[id_aluno] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](45) NOT NULL,
	[apelido] [nvarchar](45) NOT NULL,
	[idade] [int] NOT NULL,
	[email] [nvarchar](45) NOT NULL,
	[turma_id] [int] NOT NULL,
	[login_id] [int] NULL,
 CONSTRAINT [PK_aluno] PRIMARY KEY CLUSTERED 
(
	[id_aluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[disciplina]    Script Date: 4/7/2024 10:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[disciplina](
	[id_disciplina] [int] IDENTITY(1,1) NOT NULL,
	[designacao] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_disciplina] PRIMARY KEY CLUSTERED 
(
	[id_disciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 4/7/2024 10:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionario](
	[id_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](45) NOT NULL,
	[login_id] [int] NOT NULL,
 CONSTRAINT [PK_funcionario] PRIMARY KEY CLUSTERED 
(
	[id_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 4/7/2024 10:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](45) NOT NULL,
	[password] [nvarchar](45) NOT NULL,
	[role] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_login_user] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nota]    Script Date: 4/7/2024 10:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nota](
	[id_nota] [int] IDENTITY(1,1) NOT NULL,
	[aluno_id] [int] NOT NULL,
	[disciplina_id] [int] NOT NULL,
	[data_atribuicao] [datetime] NOT NULL,
	[nota] [decimal](30, 0) NOT NULL,
 CONSTRAINT [PK_nota] PRIMARY KEY CLUSTERED 
(
	[id_nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turma]    Script Date: 4/7/2024 10:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turma](
	[id_turma] [int] IDENTITY(1,1) NOT NULL,
	[designacao] [nvarchar](45) NOT NULL,
	[professor_id] [int] NOT NULL,
 CONSTRAINT [PK_turma] PRIMARY KEY CLUSTERED 
(
	[id_turma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aluno]  WITH CHECK ADD  CONSTRAINT [FK_aluno_login] FOREIGN KEY([login_id])
REFERENCES [dbo].[login] ([id_login])
GO
ALTER TABLE [dbo].[aluno] CHECK CONSTRAINT [FK_aluno_login]
GO
ALTER TABLE [dbo].[aluno]  WITH CHECK ADD  CONSTRAINT [FK_aluno_turma] FOREIGN KEY([turma_id])
REFERENCES [dbo].[turma] ([id_turma])
GO
ALTER TABLE [dbo].[aluno] CHECK CONSTRAINT [FK_aluno_turma]
GO
ALTER TABLE [dbo].[funcionario]  WITH CHECK ADD  CONSTRAINT [FK_funcionario_login] FOREIGN KEY([login_id])
REFERENCES [dbo].[login] ([id_login])
GO
ALTER TABLE [dbo].[funcionario] CHECK CONSTRAINT [FK_funcionario_login]
GO
ALTER TABLE [dbo].[nota]  WITH CHECK ADD  CONSTRAINT [FK_nota_aluno] FOREIGN KEY([aluno_id])
REFERENCES [dbo].[aluno] ([id_aluno])
GO
ALTER TABLE [dbo].[nota] CHECK CONSTRAINT [FK_nota_aluno]
GO
ALTER TABLE [dbo].[nota]  WITH CHECK ADD  CONSTRAINT [FK_nota_disciplina] FOREIGN KEY([disciplina_id])
REFERENCES [dbo].[disciplina] ([id_disciplina])
GO
ALTER TABLE [dbo].[nota] CHECK CONSTRAINT [FK_nota_disciplina]
GO
ALTER TABLE [dbo].[turma]  WITH CHECK ADD  CONSTRAINT [FK_turma_funcionario] FOREIGN KEY([professor_id])
REFERENCES [dbo].[funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[turma] CHECK CONSTRAINT [FK_turma_funcionario]
GO
USE [master]
GO
ALTER DATABASE [bd_projeto_form_camila] SET  READ_WRITE 
GO
