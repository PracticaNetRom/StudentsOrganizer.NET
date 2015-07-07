USE [master]
GO

CREATE DATABASE [NetRom.Practica0] 
GO

USE [NetRom.Practica0]
GO

/****** Object:  Table [dbo].[EVENT]    Script Date: 07/07/2015 16:13:03 ******/
CREATE TABLE [dbo].[EVENT](
	[ID_Event] [int] NOT NULL,
	[NAME] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Event] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Students]    Script Date: 07/07/2015 16:13:15 ******/

CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](200) NOT NULL,
	[LastName] [varchar](200) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Birthdate] [date] NOT NULL,
	[Email] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Faculty] [varchar](50) NULL,
	[FacultyStart] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



/****** Object:  Table [dbo].[STUDENT_EVENT]    Script Date: 07/07/2015 16:13:10 ******/

CREATE TABLE [dbo].[STUDENT_EVENT](
	[ID] [int] NOT NULL,
	[ID_Student] [int] NULL,
	[ID_Event] [int] NULL,
	[Period] [date] NULL,
	[Departament] [varchar](200) NULL,
	[TASK] [varchar](200) NULL,
	[REMARKS] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[STUDENT_EVENT]  WITH CHECK ADD FOREIGN KEY([ID_Event])
REFERENCES [dbo].[EVENT] ([ID_Event])
GO

ALTER TABLE [dbo].[STUDENT_EVENT]  WITH CHECK ADD FOREIGN KEY([ID_Student])
REFERENCES [dbo].[Students] ([Id])
GO


