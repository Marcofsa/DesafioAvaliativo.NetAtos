create database db_sistema

go

---------------------------------------------
select name 
From sys.databases;

go
---------------------------------------------
use [db_sistema]
----------------------------------
--- executar 2
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

-- executar 1
create table Tbproduto
(
idProduto int identity (1,1) not null,
nome_prod varchar (50) not null,
valor_prod decimal not null,
primary key (idProduto)
);

--- executar 4
create table Tbvendas
(
idVenda int identity(1,1) not null,
idProduto int not null,
idCliente int not null,
valorProd decimal not null,
constraint fk_Tbvendas_Tbproduto
foreign key (idProduto)
references Tbproduto,

constraint fk_Tbvendas_Tbcliente
foreign key (idCliente)
references Tbcliente
);

---- executar 3
create table Tbcliente
(
idCliente int identity(1,1) not null,
nome_cliente varchar (50) not null,
primary key (idCliente)
);

select * from Tbproduto
select * from Tbfornecedores
select * from Tbcliente
select * from Tbvendas

drop table Tbfornecedores	
drop table Tbproduto
drop table Tbcliente
drop table Tbvendas

delete from Tbproduto

delete from Tbfornecedores

delete from Tbcliente

delete from Tbvendas


alter table Tbvendas
drop column nomeProd
