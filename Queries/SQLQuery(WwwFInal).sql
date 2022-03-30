--CREATE TABLE teacher (
--    teacherID int IDENTITY(1,1) PRIMARY KEY,
--    firstName varchar(255) not null,
--	lastName varchar(255) not null,
--	password varchar(255) not null,
--	email varchar(255) not null
--);

--CREATE TABLE student (
--    studentID int IDENTITY(1,1) PRIMARY KEY,
--    firstName varchar(255) not null,
--	lastName varchar(255) not null,
--	password varchar(255) not null,
--	email varchar(255) not null
--	);

--create table teacher_student (
--	teacher_studentID int Identity(1,1) primary key,
--	teacherID int FOREIGN KEY REFERENCES teacher(teacherID),
--	studentID int FOREIGN KEY REFERENCES student(studentID)
--	);

--create table enrolled (
--	enrolledID int Identity(1,1) primary key,
--	teacherID int FOREIGN KEY REFERENCES teacher(teacherID),
--	studentID int FOREIGN KEY REFERENCES student(studentID)
--	);

--CREATE TABLE exam (
--    examID int IDENTITY(1,1) PRIMARY KEY,
--    title varchar(255) not null,
--	status varchar(15) null,
--	teacherID int FOREIGN KEY REFERENCES teacher(teacherID)
--	);

--CREATE TABLE question (
--    questionID int IDENTITY(1,1) PRIMARY KEY,
--    question text not null,
--	Canswer text not null,
--	Ranswer01 text not null,
--	Ranswer02 text not null,
--	Ranswer03 text null
--	);

--ALTER TABLE question
--	ADD teacherID int FOREIGN KEY REFERENCES teacher(teacherID);

--create table exam_question (
--	exam_questionID int IDENTITY(1,1) PRIMARY KEY,
--	examID int FOREIGN KEY REFERENCES exam(examID),
--	questionID int FOREIGN KEY REFERENCES question(questionID)
--	);

--CREATE TABLE mark (
--    markID int IDENTITY(1,1) PRIMARY KEY,
--    mark float null,
--	examID int FOREIGN KEY REFERENCES exam(examID),
--	studentID int FOREIGN KEY REFERENCES student(studentID)
--	);

--insert into teacher values
--	('ayman', 'jawhar', '12345678', 'ayman@jawhar.com'),
--	('teacher', 'lastName', '87654321', 'teacher@lastName.com')

--insert into student values
--	('ayman', 'jawhar', '12345678', 'ayman.jawhar@uni.com'),
--	('student', 'lastName', '87654321', 'student.lastName@uni.com'),
--	('door', 'window', '23456789', 'door.window@uni.com'),
--	('bed', 'sofa', '98765432', 'bed.sofa@uni.com')

--insert into student values
--	('rawa', 'salman', '12345678', 'rawa.salman@uni.com'),
--	('ahmed', 'sami', '12345678', 'ahmed.sami@uni.com'),
--	('zhiyar', 'abdullah', '12345678', 'zhiyar.abdullah@uni.com'),
--	('huda', 'abdullah', '12345678', 'huda.abdullah@uni.com'),
--	('younis', 'shakir', '12345678', 'younis.shakir@uni.com'),
--	('muhammed', 'syamand', '12345678', 'muhammed.syamand@uni.com'),
--	('masude', 'eesa', '12345678', 'masude.eesa@uni.com')


--DELETE FROM student WHERE studentID = 6;

--select * from student
--select * from teacher

--select * from enrolled

--insert into enrolled values
--	(1, 1)

--insert into enrolled values
--	(1, 2),
--	(1, 4),
--	(1, 5),
--	(1, 9),
--	(1, 10),
--	(1, 11),
--	(2, 12),
--	(2, 13),
--	(2, 14),
--	(2, 15)

--select * from student


--insert into question values
--	('what is your name', 'ayman', 'who?', 'no', 'ok'),
----	('what is your name', 'james', 'who?', 'no', 'ok'),
----	('what is your name', 'kamel', 'who?', 'no', 'ok'),
----  ('what is your name', 'masude', 'who?', 'no', 'ok'),
--('what si the color of red', 'red', 'blue', 'green', 'brown'),
--('what si the color of blue', 'blue', 'red', 'brown', 'green'),
--('what is the color of green', 'green', 'blue', 'red', 'brown')

--insert into exam values
--	('math_unit01', 'not_available', 1),
--	('english_story_01', 'not_available', 2)

--select s.StudentID, s.firstname, s.lastname, s.email from student as s join enrolled as e on s.studentID = e.studentID where e.teacherID = 1

--delete from enrolled where studentID = 11 and teacherID = 1

--select * from enrolled
--select * from student

--insert into exam_question values 
--	--(1, 1),
--	--(1, 2)
--	(1, 4),
--	(1, 6),
--	(1, 7),
--	(2, 8),
--	(2, 9),
--	(2, 10)

--select * from question



--select * from question where questionID=(select max(questionID) from question)

--insert into exam_question values (null, 14)

--delete from question where QuestionID = 6
--delete from exam_question where questionID = 6

--select * from question where teacherID is null or teacherID = 1
--select * from exam_question

--select q.questionID, q.question, q.Canswer, q.Ranswer01, q.Ranswer02, q.Ranswer03, q.teacherID  from question as q left join exam_question as eq on q.questionID = eq.questionID
--	left join exam as e on eq.examID = e.examID where e.teacherID = 1 or q.teacherID = 1 and eq.examID = 1

--select * from mark
--update exam set status = 'available' where examID = 1

--select distinct e.examID, e.title, e.status, e.teacherID from exam as e join teacher as t on e.teacherID = t.teacherID join enrolled as en on t.teacherID = en.teacherID where en.studentID = 1

--select * from student where email = 'ayman.jawhar@uni.com' and password = '12345678'

--select * from exam as e join teacher as t on e.teacherID = t.teacherID
--	join enrolled as en on t.teacherID = en.teacherID where en.studentID = 1

