use ACTDB

insert into Projects values('Proyecto 1','Eh un proyecto de prueba','01/01/2023','02/02/2023')

insert into ElementStates values('Sin aplicar')
insert into ElementStates values('Aplicado')
insert into ElementStates values('Tentativo')
insert into ElementStates values('No aplica')

insert into UseCaseStates values('Pendiente')
insert into UseCaseStates values('Completo')

insert into ObjectTypes values('Empleado','Personal que trabaja en la empresa')
insert into ObjectTypes values('Actor','Personal que interactúa con la empresa como un proveedor o cliente, etc.')
insert into ObjectTypes values('Cosa','Cualquier objeto tangible.')
insert into ObjectTypes values('Reporte','Listado de folios como reporte de gastos, facturas, etc.')
insert into ObjectTypes values('Formato','Diseño de un formato que muestra el alta, modificación o baja de un gasto')
insert into ObjectTypes values('Estadística','Muestra indicadores de manera gráfica')
insert into ObjectTypes values('Dashboard','Muestra indicadores a manera de objetos visuales')
