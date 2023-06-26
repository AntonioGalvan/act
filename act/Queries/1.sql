create database ACTDB
go
use ACTDB
go
create table Projects
(
  id int identity (100000,1) primary key,
  name nvarchar (50) not null,
  description nvarchar (50) not null,
  startDate date not null,  
  endDate date not null,  
)
go
insert into Projects values('Project 1','project 1','04/12/2023','06/12/2023')
insert into Projects values('Project 2','project 2','04/12/2023','06/12/2023')
go