CREATE TABLE Students (
    name varchar(max),
    gender varchar(max),
    program varchar(max),
	age int,
	mobile bigint,
	teacher varchar(max),
);



select * from Students
delete from Students where name='Muzamil';

ALTER TABLE Students
ADD roll varchar(max) ;