create database ACasota;

use ACasota;

create table Tipo_Utilizador(
	id int identity(1,1) not null,
	nome varchar(100) not null,
	descricao varchar(255) not null,
	PRIMARY KEY(id)
);

create table Utilizador(
	id int identity(1,1) not null,
	nome varchar(100) not null,
	email varchar(100) not null,
	morada varchar(200),
	data_nasc date not null,
	num_cidadao varchar(15),
	nif int,
	num_telemovel int,
	tipo int not null,

	PRIMARY KEY(id),
	FOREIGN KEY(tipo) REFERENCES Tipo_Utilizador(id)
);

insert into Tipo_Utilizador(nome, descricao) values ('Utilizador', 'Utilizador normal'),
													('Socio', 'Socio da organizacao'),
													('Admin', 'Administrador da aplicacao, funcionario da organizacao');

select * from dbo.Tipo_Utilizador