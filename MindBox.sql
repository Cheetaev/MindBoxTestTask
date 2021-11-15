create table Categories (
	Id int primary key,
	"Name" text
);

insert into Categories
values
	(1, 'Electric car'),
	(2, 'Regular car');

create table Products (
	Id int primary key,
	"Name" text
);

insert into Products
values
	(1, 'Tesla'),
	(2, 'Skoda Rapid'),
	(3, 'Kia Rio'),
	(4, 'Toyota Prius'),
	(5, 'IPhone X');

create table ProductCategories (
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Categories(Id),
	primary key (ProductId, CategoryId)
);

insert into ProductCategories
values
	(1, 1),
	(2, 2),
	(3, 2),
	(4, 1),
	(4, 2);

select C."Name", P."Name"
from Products P
	left join ProductCategories PC on P.Id = PC.ProductId
	left join Categories C on PC.CategoryId = C.Id;