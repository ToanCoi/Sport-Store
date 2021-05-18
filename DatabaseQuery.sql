create table Sports (
	ID int identity(1,1) primary key,
	Name nvarchar(50) not null
);

create table Categories (
	ID int identity(1,1) primary key,
	Name nvarchar(50),
	SportID int not null foreign key references Sports(ID)
);

create table Brands (
	ID int identity(1,1) primary key,
	Name nvarchar(50),
);

create table Products (
	ID int identity(1,1) primary key,
	Name nvarchar(50) not null,
	Description text not null,
	Price decimal not null,
	Discount decimal not null,
	Gender nvarchar(10) not null,
	IsFeature bit,
	CategoryID int foreign key references Categories(ID),
	BrandID int foreign key references Brands(ID)
);

create table ProductImages (
	ID int identity(1,1) primary key,
	ImageUrl text not null,
	ProductID int foreign key references Products(ID)
);

create table Sizes (
	ID int identity(1,1) primary key,
	Size nvarchar(10) not null
);

create table ProductSizes (
	ID int identity(1,1) primary key,
	Amount int not null,
	ProductID int foreign key references Products(ID),
	SizeID int foreign key references Sizes(ID)
);

insert into Sports(Name)
values ('Running'), ('Basketball'), ('Volleyball'), ('Tennis');

insert into Categories(Name, SportID)
values ('Running shoes', 1), ('Running clothing', 1), ('Running underwear', 1), ('Running socks', 1), ('Running accessories', 1), ('Sale', 1);

insert into Categories(Name, SportID)
values ('Basketball shoes', 2), ('Basketballs', 2), ('Basketball clothing', 2), ('Braces and protection', 2), ('Other articles', 2), ('Sale', 2);

insert into Categories(Name, SportID)
values ('Volleyball shoes', 3), ('Volleyballs', 3), ('Clothing', 3), ('Protection and braces', 3), ('Beach volleyball', 3), ('Sale', 3);