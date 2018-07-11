drop database if exists immo;
create database immo;
use immo;

create table verwalter (
	Id int primary key auto_increment,
    Vorname varchar(100),
    Nachname varchar(100)
);

create table liegenschaft (
	Id int primary key auto_increment,
    Name varchar(100),
    Verwalter_id int,
    foreign key (Verwalter_id) references verwalter(Id)
);

create table haus (
	Id int primary key auto_increment,
	Strasse varchar(100),
    Hausnummer varchar(10),
    PLZ varchar(100),
    Ort varchar(50),
    Beschreibung varchar(1000),
    Liegenschaft_id int,
    foreign key (Liegenschaft_id) references liegenschaft(Id)
);

create table wohnung (
	Id int primary key auto_increment,
    Balkon bool,
    Terasse bool,
	Qm double,
	QmPreis double,
    Zimmer double,
    Haus_id int,
    foreign key (Haus_id) references haus(Id)
);

create table mieter (
	Id int primary key auto_increment,
    Vorname varchar(100),
    Nachname varchar(100),
    Gebdat date,
    Wohnungs_id int,
    foreign key (Wohnungs_id) references wohnung(Id)
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

insert into liegenschaft value(NULL, 'Liegenschaft 1', 1);
insert into liegenschaft value(NULL, 'Liegenschaft 2', 1);
insert into liegenschaft value(NULL, 'Liegenschaft 3', 2);
insert into liegenschaft value(NULL, 'Liegenschaft 4', 4);
insert into liegenschaft value(NULL, 'Liegenschaft 5', 6);

insert into haus value(NULL, 'Strasse', '22 B', '12345', 'Berlin', 'Haus voll toll und so weiter', 1);
insert into haus value(NULL, 'Strasse', '21 A', '12345', 'Berlin', 'Haus voll toll und so weiter', 2);
insert into haus value(NULL, 'Strasse', '50', '12345', 'Berlin', 'Haus voll toll und so weiter', 3);
insert into haus value(NULL, 'Strasse', '6', '12345', 'Berlin', 'Haus voll toll und so weiter', 4);
insert into haus value(NULL, 'Strasse', '19', '12345', 'Berlin', 'Haus voll toll und so weiter', 5);

insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 1);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 1);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 1);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 1);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 2);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 3);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 4);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 4);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 4);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 4);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 4);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);
insert into wohnung value(NULL, true, true, 53.2, 6.83, 1.5, 5);

insert into mieter value(NULL, 'Mieter 1', 'Mieter 1', '1999-12-31', 1);
insert into mieter value(NULL, 'Mieter 2', 'Mieter 2', '1999-12-31', 2);
insert into mieter value(NULL, 'Mieter 3', 'Mieter 3', '1999-12-31', 3);
insert into mieter value(NULL, 'Mieter 4', 'Mieter 4', '1999-12-31', 4);
insert into mieter value(NULL, 'Mieter 5', 'Mieter 5', '1999-12-31', 5);
insert into mieter value(NULL, 'Mieter 6', 'Mieter 6', '1999-12-31', 6);
insert into mieter value(NULL, 'Mieter 7', 'Mieter 7', '1999-12-31', 7);
insert into mieter value(NULL, 'Mieter 8', 'Mieter 8', '1999-12-31', 8);
insert into mieter value(NULL, 'Mieter 9', 'Mieter 9', '1999-12-31', 9);
