CREATE DATABASE BB201

USE BB201

CREATE TABLE Students
(
	Id INT,
	Name NVARCHAR(20),
	Surname NVARCHAR(25),
	Username NVARCHAR(30),
	Email NVARCHAR(35)
)

ALTER TABLE Students
DROP COLUMN Email

ALTER TABLE Students
ADD Email NVARCHAR(35)

ALTER TABLE Students
ALTER COLUMN Email NVARCHAR(30)

DROP TABLE Students

TRUNCATE TABLE Students



CREATE TABLE Students
(
	Id INT,
	Name NVARCHAR(20),
	Surname NVARCHAR(25),
	Username NVARCHAR(30),
	Email NVARCHAR(35)
)

SELECT * FROM Students

INSERT INTO Students
VALUES
(1,'Murad','Eliyev','murad123','murad@gmail.com')


SELECT * FROM Students

INSERT INTO Students
VALUES
(2,'Jeyhun','Veliyev','jeki','jeki@mail.ru'),
(3,'hun','iyev','jekiev','jekiev@mail.ru')


UPDATE Students
SET Name = 'Hun'

UPDATE Students
SET Username = 'murad1234'
WHERE Username = 'murad123'


DELETE FROM Students
WHERE Id = 1


INSERT INTO Students
VALUES
(1,'Jeyhun','Veliyev','jeki','jeki@mail.ru'),
(1,'hun','iyev','jekiev','jekiev@mail.ru')

DROP TABLE Students

CREATE TABLE Students
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(20) NOT NULL,
	Surname NVARCHAR(25),
	Username NVARCHAR(30) UNIQUE,
	Email NVARCHAR(35) UNIQUE
)

INSERT INTO Students
VALUES
('assaassa','Veliyev','jeki1','jeki@mail.rus'),
('hun','iyev','jekiev1','jekiev@mail.rus')


INSERT INTO Students(Username,Email,Name,Surname)
VALUES
('assaassa','Veliyev','jeki1','jeki@mail.rus'),
('hun','iyev','jekiev1','jekiev@mail.rus')



CREATE TABLE Teachers
(
	Id INT IDENTITY CONSTRAINT PK_TEACHERS PRIMARY KEY,
	Name NVARCHAR(25) CONSTRAINT CK_LEN_TCHNAME CHECK(LEN(Name) >3),
	SurName NVARCHAR(30) NOT NULL
)

INSERT INTO Teachers(Name,SurName)
VALUES
('ALIS','ALI')

ALTER TABLE Teachers
ADD CONSTRAINT CK_LEN_TCHSURNAME CHECK(LEN(SurName) >3)



ALTER TABLE Teachers
DROP CONSTRAINT DF__Teachers__SurNam__5070F446