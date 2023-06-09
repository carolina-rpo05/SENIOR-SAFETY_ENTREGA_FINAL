USE [master]
GO
/****** Object:  Database [Trabajo_Programación]    Script Date: 28/03/2023 9:18:56 p. m. ******/
CREATE DATABASE [Trabajo_Programación]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Trabajo_Programación', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Programación.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Trabajo_Programación_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Programación_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Trabajo_Programación] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trabajo_Programación].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Trabajo_Programación] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET ARITHABORT OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Trabajo_Programación] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Trabajo_Programación] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Trabajo_Programación] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Trabajo_Programación] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Trabajo_Programación] SET  MULTI_USER 
GO
ALTER DATABASE [Trabajo_Programación] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Trabajo_Programación] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Trabajo_Programación] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Trabajo_Programación] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Trabajo_Programación] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Trabajo_Programación] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Trabajo_Programación] SET QUERY_STORE = OFF
GO
USE [Trabajo_Programación]
GO
/****** Object:  Table [dbo].[AlergiaMedicamentos]    Script Date: 28/03/2023 9:18:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlergiaMedicamentos](
	[idmedicamentos] [int] IDENTITY(1,1) NOT NULL,
	[idhistoriaclinica] [int] NULL,
	[Alergico_a_medicamentos] [bit] NOT NULL,
	[tratamiento_medicamnetos] [varchar](40) NOT NULL,
	[Dosis_frecuencia] [nvarchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idmedicamentos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Antecedentes]    Script Date: 28/03/2023 9:18:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Antecedentes](
	[idAntecedentes] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](40) NOT NULL,
	[tipo_de_documento] [varbinary](max) NOT NULL,
	[numero_de_documento] [int] NOT NULL,
	[fecha_de_nacimiento] [date] NOT NULL,
	[Dirección] [nvarchar](40) NOT NULL,
	[tipo_de_sangre] [nvarchar](10) NOT NULL,
	[contacto_de_emergencia] [varchar](15) NOT NULL,
	[Parentesco] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAntecedentes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Datospersonales]    Script Date: 28/03/2023 9:18:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datospersonales](
	[idUsuario] [int] NULL,
	[PrimerNombre] [varchar](30) NULL,
	[SegundoNombre] [varchar](30) NULL,
	[PrimerApellido] [varchar](30) NULL,
	[SegundoApellido] [varchar](30) NULL,
	[Tipo_Identificacion] [varbinary](max) NOT NULL,
	[Numero_de_Identificacion] [int] IDENTITY(1,1) NOT NULL,
	[Genero] [bit] NULL,
	[Fecha_de_Nacimiento] [date] NOT NULL,
	[Dirección_de_Residencia] [nvarchar](40) NOT NULL,
	[Telefono_Contacto] [int] NULL,
	[Nivel_Escolaridad] [nvarchar](15) NULL,
	[EPS] [varchar](40) NULL,
	[Regimen] [bit] NULL,
	[Correo_Electronico] [nvarchar](80) NULL,
	[Contacto_en_de_emergencia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero_de_Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historia_clinica]    Script Date: 28/03/2023 9:18:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historia_clinica](
	[idhistoriaclinica] [int] IDENTITY(1,1) NOT NULL,
	[idAntecedentes] [int] NULL,
	[Fecha_ultima_consulta] [date] NULL,
	[Enfermedades_hereditarias] [varchar](80) NOT NULL,
	[Enfermedades_ultimos_tres_meses] [varchar](40) NOT NULL,
	[cirugias_tratamientos_activos] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idhistoriaclinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 28/03/2023 9:18:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[Numero_de_Orden] [int] IDENTITY(1,1) NOT NULL,
	[idmedicamentos] [int] NULL,
	[Nombre_del_Profesional_de_Salud_que_prescribe] [varchar](40) NULL,
	[Fecha_de_Prescripcion] [date] NULL,
	[Tipo_de_Medicamentos] [varchar](40) NULL,
	[Forma_Farmaceutica] [varchar](40) NULL,
	[Periodo_de_Duracion_del_Tratamiento] [nvarchar](45) NULL,
	[Via_de_Administración] [varchar](40) NULL,
	[Cantidad_Total_de_Unidades_Farmaceuticas] [int] NULL,
	[Vigencia_de_la_Prescripcion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero_de_Orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/03/2023 9:18:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](30) NULL,
	[contrasena] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AlergiaMedicamentos]  WITH CHECK ADD FOREIGN KEY([idhistoriaclinica])
REFERENCES [dbo].[historia_clinica] ([idhistoriaclinica])
GO
ALTER TABLE [dbo].[Antecedentes]  WITH CHECK ADD FOREIGN KEY([numero_de_documento])
REFERENCES [dbo].[Datospersonales] ([Numero_de_Identificacion])
GO
ALTER TABLE [dbo].[Datospersonales]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[historia_clinica]  WITH CHECK ADD FOREIGN KEY([idAntecedentes])
REFERENCES [dbo].[Antecedentes] ([idAntecedentes])
GO
ALTER TABLE [dbo].[Medicamentos]  WITH CHECK ADD FOREIGN KEY([idmedicamentos])
REFERENCES [dbo].[AlergiaMedicamentos] ([idmedicamentos])
GO
USE [master]
GO
ALTER DATABASE [Trabajo_Programación] SET  READ_WRITE 
GO
