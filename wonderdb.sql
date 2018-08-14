create database wonderdb
use wonderdb
drop database wonderdb

create table addauth
(login_user varchar(15),
login_pass varchar(15),
primary key(login_user))

insert into addauth values ('wonder','wonder');
create table addauthor
(author_id int identity (01,1),
first_name varchar(10),

last_name varchar(10),
primary key (author_id))

INSERT INTO addauthor
VALUES ('Lars','Monsen');
create table addcategory
(author_id int,
category_name varchar (15),
foreign key (author_id) references addauthor)


select * from addcategory
select * from addauthor
select * from addauth

drop table addcategory
drop table addauthor
drop table addauth







