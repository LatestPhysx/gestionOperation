create database gestionOperation
use gestionOperation

create table Client(
	NumClient int primary key,
	Nom varchar(250),
	Adresse varchar(500),
	Telephone varchar(250)
);

create table Operation(
	Code int primary key,
	libelle varchar(250),
	dateOperation date,
	Montant float,
	NumClient int foreign key references Client(NumClient)
);

select * from Client;
select * from Operation;