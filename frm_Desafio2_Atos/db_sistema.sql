create database db_sistema

go

---------------------------------------------
select name 
From sys.databases;

go
---------------------------------------------
use [db_sistema]
----------------------------------
create table Tbfornecedores
(
idFornecedor int identity not null,
nome_fornecedor varchar (50) not null,
idProduto int not null,
primary key (idFornecedor),
constraint fk_Tbfornecedores_Tbproduto
foreign key (idProduto)
references Tbproduto (idProduto)

on delete no action
on update no action
);

create table Tbproduto
(
idProduto int identity (1,1) not null,
nome_prod varchar (50) not null,
valor_prod decimal not null,
quantidade_prod int,
primary key (idProduto)
);

create table Tbvendas
(
idVenda int identity(1,1) not null,

)

create table Tbcliente
(
idCliente int identity(1,1) not null,
nome_cliente varchar (50) not null,
primary key (idCliente)
);

select * from Tbproduto
select * from Tbfornecedores
select * from Tbcliente

drop table Tbfornecedores	
drop table Tbproduto
drop table Tbcliente

delete from Tbproduto

delete from Tbfornecedores

delete from Tbcliente
