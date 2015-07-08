

create table student (
	id_student int NOT NULL,
	Fname VARCHAR(15),
	Lname VARCHAR(15),
	Gender int,
	Birthdate DATE,
	Email VARCHAR(10),
	PhoneNumbers VARCHAR(22),
	Faculty VARCHAR(50),
	FacultyStartYear VARCHAR(30),
	CONSTRAINT participants_id_pk PRIMARY KEY(id_student)
);

create table event(
	id_event int NOT NULL,
	Period VARCHAR(20),
	Department VARCHAR(50),
	Tasks VARCHAR(100),
	Remarks VARCHAR(200),
	Event_Type_id int,
	CONSTRAINT event_id_pk PRIMARY KEY(id_event)
);

create table student_event(
	id_student int  NOT NULL ,
	id_event int NOT NULL ,
	CONSTRAINT Studentevent_id_pk PRIMARY KEY(id_student, id_event)
);

create table EventTypes(
	Event_Type_id int NOT NULL PRIMARY KEY,
	Description VARCHAR(200)
);

ALTER TABLE student_event 
ADD CONSTRAINT student_event_fk FOREIGN KEY (id_student) REFERENCES student(id_student)
ALTER TABLE student_event
ADD CONSTRAINT student_event_fk2 FOREIGN KEY(id_event) REFERENCES event(id_event)

ALTER TABLE event
ADD FOREIGN KEY (Event_Type_id) 
REFERENCES EventTypes(Event_Type_id)




