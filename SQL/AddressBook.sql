--UC1
create database AddressBookServiceDB
use AddressBookServiceDB

--UC2
create table AddressBookTable
(
id int identity (1,1) primary key, 
firstname varchar(150),
lastname varchar(150),
address varchar(150),
city varchar(150),
state varchar(150),
zip Bigint,
phonenumber bigint,
email varchar(150)
);


--UC3
insert into AddressBookTable(firstname,lastname,address,city,state,zip,phonenumber,email)
values('Ritik','Raj','78 Nandanvan','Nagpur','Maharashtra',440034,9842905050,'ritik@gmail.com'),
('Aditya','Kumar','83 Heritage Rd','Chennai','Tamil Nadu',134002,98402000,'aditya@gmail.com'),
('Mohan','Bakshi','19 Itwari','Lucknow','Uttar Pradesh',113201,87210505053,'bakshi@gmail.com'),
('Ritu','Kumari','35 Civillines','Bangalore','Karnataka',243001,9842905050,'ritu@gmail.com'),
('Aniket','Kumar','34 Manewada','Noida','Delhi',440024,7089805050,'aniket@gmail.com'),
('Avantika','Tiwari','92 Mahalgi','Kanpur','Uttar Pradesh',440034,9842905050,'avantika@gmail.com');


select * from AddressBookTable


--UC4
update AddressBookTable set email= 'ritik1234@gmail.com' where firstname='Ritik'


--UC5
delete from AddressBookTable where firstname='Aniket';

--UC6
select * from AddressBookTable where city='Nagpur' or state='Maharashtra'


--UC7
select Count(*) as count, state from AddressBookTable Group by state
select Count(*) as count, city from AddressBookTable Group by city

--UC8
select * from AddressBookTable where city='Nagpur' order by firstname 

--UC9
alter table AddressBookTable add name varchar(150), type varchar(150)
update AddressBookTable set name ='friendname', type = 'Friend' where firstname ='Avantika'
update AddressBookTable set name ='Sister', type = 'Family' where firstname ='Ritik'
update AddressBookTable set name ='Manager', type = 'Profession' where firstname ='Aniket'

--UC10
select Count(*) type from AddressBookTable group by type