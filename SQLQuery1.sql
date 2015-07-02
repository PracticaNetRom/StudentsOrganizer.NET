
CREATE DATABASE Students_Organizer

CREATE TABLE Applicants1
(
ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
First_Name VARCHAR(100) NOT NULL,
Last_Name VARCHAR(100) NOT NULL,
Gender VARCHAR(20) NOT NULL,
Birth_date VARCHAR(50) NOT NULL,
Email VARCHAR(100) NOT NULL,
Phone_number VARCHAR(100) NOT NULL,
Faculty VARCHAR(100) NOT NULL,
Faculty_start_year VARCHAR(100) NOT NULL,
Event1 VARCHAR(100) NOT NULL,
Period_of_event VARCHAR(100) NOT NULL,
Department_Technology VARCHAR(100) NOT NULL,
Task_received VARCHAR(1000) NOT NULL,
Remarks VARCHAR(1000) NOT NULL,
);

INSERT INTO Applicants1 values('Tenea','Andrei','M','01.09.1993','andrei.tenea93@gmail.com','0741248489','ACE','2012','Internship','01.09.2015-30.11.2015','PHP','To make a database','Good guy');
INSERT INTO Applicants1 values('Tenea','Andrei','M','01.09.1993','andrei.tenea93@gmail.com','0741248489','ACE','2012','Internship','01.09.2016-30.11.2016','PHP','To make a database','Good guy');
INSERT INTO Applicants1 values('Tenea','Andrei','M','01.09.1993','andrei.tenea93@gmail.com','0741248489','ACE','2012','Internship','01.09.2017-30.11.2017','PHP','To make a database','Good guy');

SELECT *FROM Applicants1 WHERE Period_of_event LIKE '%2016%';
