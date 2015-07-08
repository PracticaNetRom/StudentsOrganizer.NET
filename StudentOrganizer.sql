create table USER_Table(
	userName varchar(100),
	pass varchar(500),

	primary key(userName)
);

insert into USER_Table values('petre','WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=');

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


create table EventTypes(
	id int IDENTITY(1,1) not null,
	description varchar(200),
	primary key(id)
);

create table Event(
	id int IDENTITY(1,1) NOT NULL,
	eventTypes_ID int not null,
	perioada date,
	Departament varchar(200),
	Task varchar(200),
	Remarks varchar(200),

	primary key(id),
	foreign key(eventTypes_ID) references eventTypes(id)
);

create table StudentEvent(
	id_Student int not null,
	id_Event int not null,

	primary key(id_Student,id_Event),
	foreign key (id_Student) references Student(id),
	foreign key (id_Event) references Event(id)
);
