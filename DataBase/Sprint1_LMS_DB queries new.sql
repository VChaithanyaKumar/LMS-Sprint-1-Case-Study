--created database
create database Sprint1_LMS_DB


--created table named Admin
create table Admin(AdminId numeric(10,2),
AdminPassword varchar(30) check((len(AdminPassword)>=8) and (len(AdminPassword)<=15)))

--inserting into admin table
insert into Admin values(1234,'Admin@1234')


--created a table named Users
create table Users(UserId numeric(10,2) primary key,
UserName varchar(20) unique,
UserPassword varchar(30) check((len(UserPassword)>=8) and (len(UserPassword)>=15)),
UserFirstName varchar(30) not null,
UserLastName varchar(30) not null,
Gender char check(Gender in('M','F','T')),
UserEmail varchar(30),
Address varchar(30))


--created a table named Author
create table Author(AuthorId numeric(10,2) primary key,
AuthorFirstName varchar(20) not null,
AuthorLastName varchar(20),
Gender char check(Gender in('M','F','T')),
AuthorEmail varchar(20))


--inserting into author table
insert into Author values(10001,'P.J. Allen',' ','M','p.j.allen@gmail.com')
insert into Author values(10002,'H. Schild',' ','M','h.schild@gmail.com')
insert into Author values(10003,'B. C Desai',' ','F','b.c.desai@gmail.com')
insert into Author values(10004,'Cormen',' ','M','cormen@gmail.com')
insert into Author values(10005,'Millan',' ','F','millan@gmail.com')


--created a table named Courses
create table Courses(CourseId numeric(10,2) primary key,
CourseTitle varchar(30) not null,
CourseDescription varchar(100) not null,
AuthorId numeric(10,2) foreign key references Author(AuthorId),
CourseOutcomes varchar(100))


--inserting into courses table
insert into Courses values(10011,'Learn c#','Learn c# with ease. Note: No pre-requisites',10001,'By the end of this course, you will learn c# from scratch.')
insert into Courses values(10012,'Learn ADO.NET','Learn ADO.NET with ease. Note: Prior knowledge in c# is required',10002,'By the end of this course, you will learn ADO.NET from scratch.')
insert into Courses values(10013,'Learn JAVA','Learn JAVA with ease. Note: No pre-requisites',10003,'By the end of this course, you will learn JAVA from scratch.')
insert into Courses values(10014,'Learn Python','Learn Python with ease. Note: No pre-requisites',10004,'By the end of this course, you will learn Python from scratch.')
insert into Courses values(10015,'Learn C++','Learn C++ with ease. Note: No pre-requisites',10005,'By the end of this course, you will learn C++ from scratch.')


--created a table named CourseEroll
create table CourseEnroll(EnrollId numeric(10,2) primary key,
UserId numeric(10,2) foreign key references Users(UserId),
CourseId numeric(10,2) foreign key references Courses(CourseId),
DateOfEnrollment datetime default getdate(),
DateOfCompletion datetime ,
CourseStatus bit)


--created a table named Question
create table Question(QuestionId numeric(10,2) primary key,
CourseId numeric(10,2) foreign key references Courses(CourseId),
QuestionDescription varchar(100) not null)

--inserting into Question table
insert into Question values(10021,10011,'The ____ language allows more than one method in a single class.')
insert into Question values(10022,10011,'All C# applications begin execution by calling the _____ method.')
insert into Question values(10023,10011,'A _______ is an identifier that denotes a storage location.')

insert into Question values(10024,10012,'In a connection string _____________ represents name of the database.')
insert into Question values(10025,10012,'Which ado.net class provide a disconnected environment?')
insert into Question values(10026,10012,'Which database is the ADO.NET SqlConnection object designed for?')

insert into Question values(10027,10013,'_____ is used to find and fix bugs in the Java programs.')
insert into Question values(10028,10013,'What is the return type of the hashCode() method in the Object class?')
insert into Question values(10029,10013,'In which process, a local variable has the same name as one of the instance variables?')

insert into Question values(10130,10014,'Who developed the Python language?')
insert into Question values(10131,10014,'In which year was the Python language developed?')
insert into Question values(10132,10014,'In which language is Python written?')

insert into Question values(10133,10015,'The programming language that has the ability to create new data types is called___.')
insert into Question values(10134,10015,'Which of the following is the original creator of the C++ language?')
insert into Question values(10135,10015,'The C++ language is ______ object-oriented language.')

--created a table named Answer
create table Answer(AnswerId numeric(10,2),
QuestionId numeric(10,2) foreign key references Question(QuestionId),
AnswerDescription varchar(100) not null)

--inserting into Answer table
insert into Answer values(10031,10021,'C#'	)
insert into Answer values(10032,10022,'Main()')
insert into Answer values(10033,10023,'Variable')

insert into Answer values(10034,10024,'Initial Catalog')
insert into Answer values(10035,10025,'DataSet')
insert into Answer values(10036,10026,'Microsoft SQL Server')

insert into Answer values(10037,10027,'JDB')
insert into Answer values(10038,10028,'int')
insert into Answer values(10039,10029,'Variable Shadowing')


insert into Answer values(10140,10130,'Guido van Rossum')
insert into Answer values(10141,10131,'1989')
insert into Answer values(10142,10132,'C')

insert into Answer values(10143,10133,'Extensible')
insert into Answer values(10144,10134,'Bjarne Stroustrup')
insert into Answer values(10145,10135,'Semi Object-oriented or Partial Object-oriented')