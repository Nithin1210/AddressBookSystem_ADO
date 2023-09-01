--UC1
create database AddressBookService;

Use AddressBookService;

--UC2
Create table AddressBook(
id int primary key identity(1,1),
firstName varchar(20),
lastName varchar(20),
address varchar(30), 
city varchar(20),
state varchar(20), 
zip bigint, 
phone varchar(10),
email varchar(30),
)

--UC3
--Create Stored Procedures
create Procedure AddContactDetails
(
@firstName varchar(20),
@lastName varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20),
@zip bigint,
@phonenumber varchar(10), 
@email varchar(30) 
)
As
begin insert Into AddressBook values(@firstName,@lastName,@address,@city,@state,@zip,@phonenumber,@email)
End

select * from AddressBook;

--UC4
Create Procedure EditContactDetails(
@firstName varchar(20),
@lastName varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20),
@zip bigint,
@phonenumber varchar(10), 
@email varchar(30) 
)
As
begin
update AddressBook set firstName=@firstName,lastName=@lastName,address=@address,city=@city,state=@state,zip=@zip,phone=@phonenumber,email=@email where firstName=@firstName
End

select * from AddressBook;


