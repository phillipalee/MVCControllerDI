USE [RecordDB]
GO

/****** Object:  Table [dbo].[Records]    Script Date: 1/29/2020 8:33:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordsDos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[howMany] [int] NULL,
	[tooMany] [bit] NULL,
	[comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_RecordsDos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
))