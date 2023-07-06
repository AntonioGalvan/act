use actDB
go
create table Roles
(
  id int identity (100000,1) primary key,
  name nvarchar (50) not null,
  keyN nvarchar (50) not null,
  purpose nvarchar (50) not null,
  projectId int not null,
)
go
insert into Roles values('admin','AD400','Administrador',2)
insert into Roles values('Cajero','CA500','Cajas',1)
go