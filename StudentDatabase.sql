create table student (
	studentID int not null,
	firstName varchar(50),
	lastName varchar(50),
	gender varchar(10),
	birthdate date,
	phoneNo varchar(15),
	faculty varchar(50),
	facultyStartYear varchar(50),
	
	primary key(studentID)
);


create table event (
	eventID int not null,
	eventName varchar(50),
	
	primary key(eventID)
);


create table event_participants (
	participantID int not null,
	studentID int not null,
	eventID int not null,
	eventPeriod varchar(50),
	eventDept varchar(50),
	assignedTask varchar(50),
	remarks varchar(200),
	
	primary key(participantID),
	foreign key(studentID) references student(studentID),
	foreign key(eventID) references event(eventID)
)



insert into student values (
	1,
	'Andrei',
	'Bolovan',
	'Male',
	'1994-09-27',
	'0745757502',
	'ACE',
	'2013'
)

insert into student values (
	2,
	'Petre',
	'Mazilu',
	'Male',
	'1993-07-21',
	'0741234567',
	'ACE',
	'2012,
)

insert into student values (
	3,
	'Andrei',
	'Tenea',
	'Male',
	'1993-02-17',
	'0728123456',
	'ACE',
	'2012'
)
insert into student values (
	4,
	'Andreea',
	'Popescu',
	'Female',
	'1992-01-08',
	'0781234890',
	'ACE',
	'2011'
)

insert into event values (
	101,
	'Practica NETRom'
)

insert into event values (
	102,
	'Internship NETRom'
)

insert into event values (
	103,
	'NETRom Software Academy'
)

insert into event_participants values (
	201501,
	1,
	101,
	'01-07-2015 > 15-07-2015'
	'DotNet'
	'Student Organizer',
	'-'
)

insert into event_participants values (
	201502,
	2,
	101,
	'01-07-2015 > 15-07-2015'
	'DotNet'
	'Student Organizer',
	'-'
)

insert into event_participants values (
	201503,
	3,
	101,
	'01-07-2015 > 15-07-2015'
	'DotNet'
	'Student Organizer',
	'-'
)

insert into event_participants values (
	201504,
	4,
	102,
	'01-08-2015 > 30-09-2015'
	'Mobile'
	'Management solution for small enterprise',
	'Participant of Practica NETRom'
)

select student.firstName, student.lastName, event_participants.eventDept from student, event, event_participants where event_participants.studentID = student.studentID and event_participants.eventID = event.eventID;