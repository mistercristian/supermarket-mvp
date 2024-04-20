use Supermarket
create table Product
(
Product_Id int identity (20, 1) primary key,
Product_Name nvarchar (50) not null,
Product_Observation nvarchar (50) not null,
)
go
insert into  Product values ('Coca-Cola','Lo mejor de lo mejor')
insert into Product values ('Chocolatina Yet', 'Chocolatina para tomar calorias')
insert into Product values ('Cerveza Corona', 'Cerveza por excelencia')