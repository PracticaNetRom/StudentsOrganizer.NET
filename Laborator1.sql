CREATE TABLE STUDENTS
(
        
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
  ID int primary key,
  Event_Type_ID INT ,
  Period  VARCHAR(50),
  Departament VARCHAR(50),
  Tasks  VARCHAR(50),
  Remarks VARCHAR(50),

  foreign key(Event_Type_ID) references EVENT_TYPE(ID)
    
);




CREATE TABLE Student_Event
(
   
   ID_Student INT,
   ID_Event INT,
 
 CONSTRAINT pk_Student_Event PRIMARY KEY (ID_Student,ID_Event)
    
);


CREATE TABLE EVENT_TYPE
(
   ID int PRIMARY KEY ,
   Description varchar (60)
   )

   CREATE TABLE Login
(
    Username varchar (100) ,
   Password varchar (60)
   )


