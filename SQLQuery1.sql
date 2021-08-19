-- Create Database : 

create database addressbook;

-- Use Database : 
use addressbook;

-- Creating Table :
create table addressBook
(
	Id int identity primary key,
	FirstName varchar(50),
	LastName varchar(50),
	Address varchar(100),
	City varchar(50),
	State varchar(50),
	ZipCode varchar(6),
	PhoneNumber varchar(11),
	EmailId varchar(50)
);

select * from addressBook;