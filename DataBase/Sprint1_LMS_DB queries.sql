create database Sprint1_LMS_DB

create table Users(UserId numeric(10,2) primary key,
UserName varchar(20) unique,
UserPassword varchar(30) check((len(UserPassword)>=8) and (len(UserPassword)>=15)),
UserFirstName varchar(30) not null,
UserLastName varchar(30) not null,
Gender char check(Gender in('M','F','T')),
UserEmail varchar(30),
Address varchar(30))

create table Author(AuthorId numeric(10,2) primary key,
AuthorFirstName varchar(20) not null,
AuthorLastName varchar(20),
Gender char check(Gender in('M','F','T')),
AuthorEmail varchar(20))


create table Courses(CourseId numeric(10,2) primary key,
CourseTitle varchar(30) not null,
CourseDescription varchar(100) not null,
AuthorId numeric(10,2) foreign key references Author(AuthorId),
CourseOutcomes varchar(100))

create table CourseEnroll(EnrollId numeric(10,2) primary key,
UserId numeric(10,2) foreign key references Users(UserId),
CourseId numeric(10,2) foreign key references Courses(CourseId),
DateOfEnrollment datetime default getdate(),
DateOfCompletion datetime )

create table Question(QuestionId numeric(10,2) primary key,
CourseId numeric(10,2) foreign key references Courses(CourseId),
QuestionDescription varchar(100) not null)

create table Answer(AnswerId numeric(10,2),
QuestionId numeric(10,2) foreign key references Question(QuestionId),
Answer varchar(100) not null)


drop table Author