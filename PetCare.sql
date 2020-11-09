create database PetCare

create table pet(
	id int identity(1,1) primary key,
	nome varchar(250) not null,
	sexo(250) not null,
	raca(250) not null,
	vermifugacao(250) not null,
	vacinas(250) not null,
	peso(250) not null,
	quantidade_refeicoes_dia(250) not null,
);

nome,sexo,raca,vermifugacao,vacinas,peso,quantidade_refeicoes_dia

select * from pet
