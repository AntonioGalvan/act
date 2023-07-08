use actDB
go
create table UseCases
(
  id int identity (100000,1) primary key,
  name nvarchar (50) not null,
  keyN nvarchar (50) not null,
  projectId int not null,
)
go
insert into UseCases values(1,'CU01','Abrir caja','sdbshbf',0,0)
insert into UseCases values('Vender boletos','CU02',1)
go