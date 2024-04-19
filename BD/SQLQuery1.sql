use Supermarket
create table Providers
(
Provider_Id int identity (10, 1) primary key,
Provider_Name nvarchar (50) not null,
Provider_Observation nvarchar (50) not null,
)
go
insert into  Providers values ('Cristian Guzman','Proveedor Tecnologia')
insert into Providers values ('Estefania Guerrero', 'Proveedor Hogar')
insert into Providers values ('Lyan Guzman', 'Proveedor VideoJuegos')