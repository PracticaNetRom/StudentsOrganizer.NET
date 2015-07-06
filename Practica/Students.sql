CREATE TABLE STUDENTS
(
        ID INT,
	ID_Student INT  PRIMARY KEY,
	First_Name VARCHAR(50),
	Last_Name VARCHAR(100),
        Gender VARCHAR (200),
        Birth_date Date,
        Email VARCHAR(100),
        Phone_Numbers VARCHAR(10),
        Faculty VARCHAR(200),
        Faculty_start_year INT,
	
) ;
  

CREATE TABLE EVENT
(
   Nume int ,
  ID_Event INT PRIMARY KEY,
 
  
   foreign key(ID_Event) references STUDENTS(ID_Student)
);


CREATE TABLE TASK
(
   ID_ int ,
   ID_STUDENT INT,
   ID_Event INT PRIMARY KEY,
  PERIOD DATE,
  DEPARTAMENT  VARCHAR (200),
  Task_Name VARCHAR (100),
  Remarks VARCHAR (200)

    foreign key(ID_Event) references EVENT(ID_Event)
    foreign key(ID_Student) references STUDENTS(ID_Student)
);