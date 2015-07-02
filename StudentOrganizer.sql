create table person(
	personID int not null,
	firstName varchar(20),
	lastName varchar(20),
	gender varchar(10),
	birthDate date,
	email varchar(25),
	phoneNr varchar(15),

	primary key(personID)
);

create table participant(
	participantID int not null,
	faculty varchar(30),
	facultyStartYear int,

	primary key(participantID),
	foreign key(participantID) references person(personID)
);

create table event(
	eventType varchar(20) not null,--name of event
	eventPeriod varchar(40),--period , ex : 1.07.2015-15.07.2015
	primary key(eventType)
);

create table work(
	departament varchar(20),
	eventType varchar (20) not null,
	participantID int not null,
	taskRecieved varchar(50) ,
	remarks varchar(50),

	primary key(participantID),
	foreign key(participantID) references participant(participantID),
	foreign key(eventType) references event(eventType)
);


insert into person values(
	1,
	'Petre',
	'Mazilu',
	'M',
	'1994-06-01',
	'mazilu_petre@yahoo.ro',
	'0760073998'
);

insert into person values(
	2,
	'Andrei',
	'Bolovan',
	'M',
	'1994-09-07',
	'-',
	'0745757502'
);

insert into person values(
	3,
	'Marina',
	'Marinescu',
	'F',
	'1993-06-11',
	'-',
	'0761147515'
);

insert into participant values(
	1,
	'ACE',
	2012
);

insert into participant values(
	2,
	'ACE',
	2013
);

insert into participant values(
	3,
	'ACE',
	2012
);

insert into event values(
	'practica',
	'01/07/2015-15/07/2015'
);

insert into work values(
	'dotNet',
	'practica',
	1,
	'StudentOrganizer',
	'-'
);

insert into work values(
	'dotNet',
	'practica',
	2,
	'StudentOrganizer',
	'-'
);

insert into work values(
	'dotNet',
	'practica',
	3,
	'StudentOrganizer',
	'-'
);


select person.firstName,person.lastName,work.departament,event.eventType,event.eventPeriod from work,person,event where work.participantID = person.personID and work.eventType=event.eventType;