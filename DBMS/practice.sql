Create database collegedb;
go
use collegedb;
go
create table student( student_id int, name varchar(30), age int, department varchar(30), marks varchar(30));
go 
create table course(course_name varchar(30),course_id int,student_id int);

insert into student values(101,'aditi',21,'computer science',99);
select * from student;
select name,marks from student;
insert into student values(102,'vijay',25,'mechanical',97);
insert into student values(102,'sagar',25,'civil',08);
select * from student;
select * from student where(department='computer science');
select * from student where(marks>=80);
select * from student where(age<=21);
insert into student values(103,'jack',25,'it',76);
insert into student values(104,'sagar',25,'civil',08);
update student set student_id=105 where name='sagar';
select * from student;
delete from student where name='sagar';
select * from student;
insert into student values(104,'sagar',25,'civil',08);
select * from student where (marks>70 and marks<90);
select * from student where(department='computer science' or department='it');
select * from student where(department!='computer science');
select * from student where(name like 'a%');
select * from student where(name like '%i');
select * from student order by marks asc;
alter table student alter column marks int;
select * from student order by marks asc;
select * from student order by marks desc;
select count(*) from student ;
select avg(marks) from student;
select max(marks),name from student;
select min(marks) from student;
select department,count(*) as studentcount from student group by department;
select department,avg(marks) from student group by department;
select department,avg(marks) from student group by department having (avg(marks)>80) ;
select name,marks from student where marks=(select max(marks) from student);
SELECT name, marks FROM student WHERE marks =(SELECT MAX(marks)FROM student WHERE marks < (SELECT MAX(marks) FROM student));
update student set marks=marks+5 where department='computer science';
select * from student where department='computer science';
delete from student where (marks<40);
delete from student where (marks<80);
select * from student;
select distinct department from student;

