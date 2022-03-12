USE [dadoscadastro]
GO

/****** Object:  Table [dbo].[dadoscadastro]    Script Date: 12/03/2022 12:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dadoscadastro](
	[id] [nchar](10) NOT NULL,
	[login] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[senha] [varchar](20) NOT NULL,
	[data_cadastro] [datetime] NOT NULL,
	[nome_completo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_dadoscadastro] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

