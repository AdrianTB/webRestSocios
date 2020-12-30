USE [bd_socios]
GO
/****** Object:  Table [dbo].[tb_socios]    Script Date: 30/12/2020 15:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_socios](
	[id_socio] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[edad] [varchar](50) NOT NULL,
	[estado_civil] [varchar](50) NOT NULL,
	[profesion] [varchar](50) NOT NULL,
	[domicilio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_socios] PRIMARY KEY CLUSTERED 
(
	[id_socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
