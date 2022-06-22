create database CarRentSystem;

use CarRentSystem;

create table Employee(
	ID int identity(1, 1) primary key,
	fullName varchar(100),
	email varchar(255) unique,
	password varchar(20),
	role varchar(7) not null check(role in('Managar', 'Agent')),
	phoneNumber int,
	salary int
);
insert into Employee (fullName, email, password, role, phoneNumber, salary)
	values ('Admin', 'admin@admin.com', 'admin', 'Managar', 00000000, 00000000);

create table Customer(
	ID int identity(100, 1) primary key,
	fullName varchar(100),
	email varchar(255) unique,
	phoneNumber int,
	Gender varchar(6) not null check(Gender in('Male', 'Female')),
);

create table Car(
	ID int identity(100, 1) primary key,
	model varchar(100),
	registration varchar(100),
	dailyHirePrice int,
	YOM int,
	color varchar(100),
	capacity int,
	fual varchar(8) not null check(fual in('Electric', 'Gas')),
	transmission varchar(9) not null check(transmission in('Automatic', 'Manual')),
	status varchar(9) not null check(status in('Avaliable', 'In Use')),
);

create table Rent(
	ID int identity(100, 1) primary key,
	customerID int,
	carID int,
	EmployeeID int,
	startDate date,
	endDate date,
	rentCost int,
	status varchar(7) not null check(status in('Returnd', 'In Use')),
	Foreign key (customerID) references Customer(ID)
			on delete cascade on update cascade,
	Foreign key (carID) references Car(ID)
			on delete cascade on update cascade,
	Foreign key (EmployeeID) references Employee(ID)
			on delete cascade on update cascade,
);