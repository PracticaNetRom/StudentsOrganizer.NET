create table student (
	idstudent NUMBER NOT NULL,
	Ftname VARCHAR(15),
	Lname VARCHAR(15),
	Gender NUMBER,
	Birthdate DATE,
	Email VARCHAR(10),
	PhoneNumbers VARCHAR(22),
	Faculty VARCHAR(50),
	FacultyStartYear VARCHAR(30),
	CONSTRAINT participants_id_pk PRIMARY KEY(idparticipant)
);

create table event(
	id_event NUMBER NOT NULL,
	Period VARCHAR(20),
	Department VARCHAR(50),
	Tasks VARCHAR(100),
	Remarks VARCHAR(200),
	Event
	CONSTRAINT event_id_pk PRIMARY KEY(id_event)
);

create table students_event(
	id NUMBER NOT NULL,
	idstudent NUMBER ,
	idevent NUMBER,
	period DATE,
	department VARCHAR(100),
	task VARCHAR(100),
	remarks VARCHAR(200)
	CONSTRAINT students_event_id_pk PRIMARY KEY(id)	
);

ALTER TABLE students_event 
ADD(CONSTRAINT students_event_fk FOREIGN KEY(idstudent) 
REFERENCES students(idstudent));
ADD(CONSTRAINT participants_event_fk FOREIGN KEY(idevent) 
REFERENCES event(idevent));


