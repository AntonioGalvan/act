use actDB
go
create table Rules
(
  id int identity (100000,1) primary key,
  keyN nvarchar (50) not null,
  description nvarchar (50) not null,
  projectId int not null,
)
go
insert into Rules values('rn','El sistema realiza un corte a las 2pm y 7pm',2)
insert into Rules values('rn','El sistema solo puede realizar ventas hasta 6:50pm',1)
go