USE [Practica]
GO

/****** Object:  Table [dbo].[event]    Script Date: 05.07.2015 21:01:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[event](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_event] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-----

USE [Practica]
GO

/****** Object:  Table [dbo].[student]    Script Date: 05.07.2015 21:02:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Gender] [varchar](50) NULL,
	[BirthDate] [date] NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Faculty] [varchar](50) NULL,
	[FacultyStartYear] [int] NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


----

USE [Practica]
GO

/****** Object:  Table [dbo].[StudentEvent]    Script Date: 05.07.2015 21:02:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[StudentEvent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Student] [int] NULL,
	[Id_Event] [int] NULL,
	[Period] [date] NULL,
	[Departament] [varchar](50) NULL,
	[Task] [varchar](200) NULL,
	[Remarks] [varchar](200) NULL,
 CONSTRAINT [PK_StudentEvent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[StudentEvent]  WITH CHECK ADD FOREIGN KEY([Id_Event])
REFERENCES [dbo].[event] ([id])
GO

ALTER TABLE [dbo].[StudentEvent]  WITH CHECK ADD FOREIGN KEY([Id_Student])
REFERENCES [dbo].[student] ([id])
GO

create table USER_Table(
	userName varchar(100),
	pass varchar(500),

	primary key(userName)
);

insert into USER_Table values('petre','WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=');


