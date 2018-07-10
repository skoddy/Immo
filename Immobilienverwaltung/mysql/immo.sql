drop database if exists immo;
create database immo;
use immo;

create table verwalter(
	Id int primary key auto_increment,
    Vorname varchar(100),
    Nachname varchar(100)
);

create table liegenschaften(
	Id int primary key auto_increment,
    Name varchar(100)
);

insert into verwalter value(NULL, 'Hans', 'Wurst');
insert into verwalter value(NULL, 'Peter', 'Lustig');
insert into verwalter value(NULL, 'Paul', 'Panther');
insert into verwalter value(NULL, 'Hans', 'Wurst2');
insert into verwalter value(NULL, 'Hans', 'Wurst');
insert into verwalter value(NULL, 'Peter', 'Lustig');
insert into verwalter value(NULL, 'Paul', 'Panther');
insert into verwalter value(NULL, 'Hans', 'Wurst2');
insert into verwalter value(NULL, 'Hans', 'Wurst');
insert into verwalter value(NULL, 'Peter', 'Lustig');
insert into verwalter value(NULL, 'Paul', 'Panther');
insert into verwalter value(NULL, 'Hans', 'Wurst2');

insert into liegenschaften value(NULL, 'Liegenschaft 1');
insert into liegenschaften value(NULL, 'Liegenschaft 2');
insert into liegenschaften value(NULL, 'Liegenschaft 3');
insert into liegenschaften value(NULL, 'Liegenschaft 4');
insert into liegenschaften value(NULL, 'Liegenschaft 5');