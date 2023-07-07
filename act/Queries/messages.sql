use actDB
go
create table Messages
(
  id int identity (100000,1) primary key,
  keyN nvarchar (50) not null,
  description nvarchar (50) not null,
  projectId int not null,
)
go
insert into Messages values('MSJ123','El registro no se pudo crear',2)
insert into Messages values('MSJ124','Registro creado con éxito',1)
go