USE [PIENSAJEDREZ]
GO
/****** Object:  Table [dbo].[ACTIVIDAD]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTIVIDAD](
	[IDActividad] [nvarchar](10) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[IDCurso] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ACTIVIDAD] PRIMARY KEY CLUSTERED 
(
	[IDActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALUMNO]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNO](
	[NumeroControl] [nvarchar](10) NOT NULL,
	[Nombre] [nvarchar](60) NOT NULL,
	[NombreEscuela] [nvarchar](60) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Telefono] [nvarchar](40) NOT NULL,
	[Correo] [nvarchar](100) NOT NULL,
	[Activo] [smallint] NOT NULL,
	[Tutor] [nvarchar](100) NOT NULL,
	[ApellidoPaterno] [nvarchar](60) NOT NULL,
	[ApellidoMaterno] [nvarchar](60) NOT NULL,
	[Grado] [smallint] NOT NULL,
	[Beca] [smallint] NULL,
 CONSTRAINT [PK_ALUMNO] PRIMARY KEY CLUSTERED 
(
	[NumeroControl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ASISTENCIA]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASISTENCIA](
	[NumeroControl] [nvarchar](10) NULL,
	[NombreEscuela] [nvarchar](60) NULL,
	[IDCurso] [nvarchar](10) NULL,
	[Fecha] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CURSO]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CURSO](
	[IDCurso] [nvarchar](10) NOT NULL,
	[NombreEscuela] [nvarchar](60) NOT NULL,
	[InicioCurso] [datetime] NOT NULL,
	[FinCurso] [datetime] NOT NULL,
	[Activo] [smallint] NOT NULL,
	[DiaClase] [nvarchar](10) NULL,
 CONSTRAINT [PK_CURSO] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESCUELA]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESCUELA](
	[NombreEscuela] [nvarchar](60) NOT NULL,
	[GradoActualizado] [smallint] NOT NULL,
	[Activo] [smallint] NULL,
 CONSTRAINT [PK_ESCUELA] PRIMARY KEY CLUSTERED 
(
	[NombreEscuela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fondos]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fondos](
	[FondosRestantes] [money] NULL,
	[IDCurso] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GASTO]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GASTO](
	[GastoID] [nvarchar](10) NOT NULL,
	[Razon] [nvarchar](50) NOT NULL,
	[Monto] [money] NOT NULL,
	[Nota] [nvarchar](100) NOT NULL,
	[NombreEscuela] [nvarchar](60) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[IDCurso] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_GASTO] PRIMARY KEY CLUSTERED 
(
	[GastoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGO]    Script Date: 05/06/2019 10:33:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGO](
	[NumeroRecibo] [nvarchar](20) NOT NULL,
	[NumeroControl] [nvarchar](10) NOT NULL,
	[Monto] [money] NOT NULL,
	[MesPagado] [nvarchar](100) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[MetodoPago] [nvarchar](50) NOT NULL,
	[Nota] [nvarchar](500) NULL,
	[Notificado] [smallint] NOT NULL,
	[Liquidado] [smallint] NOT NULL,
	[IDCurso] [nvarchar](10) NOT NULL,
	[Beca] [smallint] NULL,
	[CantidadBeca] [money] NULL,
 CONSTRAINT [PK_PAGO] PRIMARY KEY CLUSTERED 
(
	[NumeroRecibo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PAGO] ADD  CONSTRAINT [DF_PAGOS_FechaHora]  DEFAULT (getdate()) FOR [FechaHora]
GO
ALTER TABLE [dbo].[ACTIVIDAD]  WITH CHECK ADD  CONSTRAINT [FK_ACTIVIDAD_CURSO1] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[CURSO] ([IDCurso])
GO
ALTER TABLE [dbo].[ACTIVIDAD] CHECK CONSTRAINT [FK_ACTIVIDAD_CURSO1]
GO
ALTER TABLE [dbo].[ALUMNO]  WITH CHECK ADD  CONSTRAINT [FK_ALUMNO_ALUMNO] FOREIGN KEY([NumeroControl])
REFERENCES [dbo].[ALUMNO] ([NumeroControl])
GO
ALTER TABLE [dbo].[ALUMNO] CHECK CONSTRAINT [FK_ALUMNO_ALUMNO]
GO
ALTER TABLE [dbo].[ALUMNO]  WITH CHECK ADD  CONSTRAINT [FK_ALUMNO_ESCUELA] FOREIGN KEY([NombreEscuela])
REFERENCES [dbo].[ESCUELA] ([NombreEscuela])
GO
ALTER TABLE [dbo].[ALUMNO] CHECK CONSTRAINT [FK_ALUMNO_ESCUELA]
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD FOREIGN KEY([IDCurso])
REFERENCES [dbo].[CURSO] ([IDCurso])
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD FOREIGN KEY([IDCurso])
REFERENCES [dbo].[CURSO] ([IDCurso])
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD FOREIGN KEY([NombreEscuela])
REFERENCES [dbo].[ESCUELA] ([NombreEscuela])
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD FOREIGN KEY([NombreEscuela])
REFERENCES [dbo].[ESCUELA] ([NombreEscuela])
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD FOREIGN KEY([NumeroControl])
REFERENCES [dbo].[ALUMNO] ([NumeroControl])
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD FOREIGN KEY([NumeroControl])
REFERENCES [dbo].[ALUMNO] ([NumeroControl])
GO
ALTER TABLE [dbo].[CURSO]  WITH CHECK ADD  CONSTRAINT [FK_CURSO_ESCUELA] FOREIGN KEY([NombreEscuela])
REFERENCES [dbo].[ESCUELA] ([NombreEscuela])
GO
ALTER TABLE [dbo].[CURSO] CHECK CONSTRAINT [FK_CURSO_ESCUELA]
GO
ALTER TABLE [dbo].[Fondos]  WITH CHECK ADD FOREIGN KEY([IDCurso])
REFERENCES [dbo].[CURSO] ([IDCurso])
GO
ALTER TABLE [dbo].[GASTO]  WITH CHECK ADD  CONSTRAINT [FK_GASTO_CURSO] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[CURSO] ([IDCurso])
GO
ALTER TABLE [dbo].[GASTO] CHECK CONSTRAINT [FK_GASTO_CURSO]
GO
ALTER TABLE [dbo].[GASTO]  WITH CHECK ADD  CONSTRAINT [FK_GASTO_ESCUELA] FOREIGN KEY([NombreEscuela])
REFERENCES [dbo].[ESCUELA] ([NombreEscuela])
GO
ALTER TABLE [dbo].[GASTO] CHECK CONSTRAINT [FK_GASTO_ESCUELA]
GO
ALTER TABLE [dbo].[PAGO]  WITH CHECK ADD  CONSTRAINT [FK_PAGO_ALUMNO] FOREIGN KEY([NumeroControl])
REFERENCES [dbo].[ALUMNO] ([NumeroControl])
GO
ALTER TABLE [dbo].[PAGO] CHECK CONSTRAINT [FK_PAGO_ALUMNO]
GO
ALTER TABLE [dbo].[PAGO]  WITH CHECK ADD  CONSTRAINT [FK_PAGO_CURSO] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[CURSO] ([IDCurso])
GO
ALTER TABLE [dbo].[PAGO] CHECK CONSTRAINT [FK_PAGO_CURSO]
GO
