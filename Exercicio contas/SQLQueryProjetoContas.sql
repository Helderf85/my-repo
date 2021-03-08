use master
go
create database Db_Contas
go
use Db_Contas

--Criar store procedures

--Criar contas receber 

create procedure RegistarReceber
	@DataVencimento date,
	@ClienteId int,
	@Valor money

	as
	begin
		insert into ContasReceber
		(
			DataVencimento,
			ClienteId,
			Valor
		)
		values
		(
			@DataVencimento,
			@ClienteId,
			@Valor
		)
end 

--alterar cliente

alter procedure AlterarCliente
	@ClienteId int,
	@Nome nvarchar(80),
	
	@Morada nvarchar(80),
	@Telefone int,
	@Email nvarchar(80)

	as 
	begin
		Update Clientes set
		
			
			Nome=@Nome,
			
			Morada=@Morada,
			Telefone=@Telefone,
			Email=@Email
		

		where ClienteId=@ClienteId 
	end

--criar procedure incluir cliente

create procedure IncluirCliente

	@Nome nvarchar(80),
	@Email nvarchar(80),
	@Telefone int,
	@Morada nvarchar(80)

	as 
	begin
		insert into Clientes
		(
			Nome,
			Email,
			Telefone,
			Morada
		)
		values
		(
			@Nome,
			@Email,
			@Telefone,
			@Morada
		)
end 

--alterar fornecedor

create procedure AlterarFornecedor
	@FornecedorId int,
	@Nome nvarchar(80),
	
	@Morada nvarchar(80),
	@Telefone int,
	@Email nvarchar(80)

	as 
	begin
		Update Fornecedores set
		
			
			Nome=@Nome,
			
			Morada=@Morada,
			Telefone=@Telefone,
			Email=@Email
		

		where FornecedorId=@FornecedorId 
	end

--incluir Fornecedor 

create procedure IncluirFornecedor
	@Nome nvarchar(80),
	@Morada nvarchar(80),
	@Email nvarchar(80),
	@Telefone int

	as
	begin
		insert into Fornecedores
		(
			Nome,
			Morada,
			Email,
			Telefone
		)
		values
		(
			@Nome,
			@Morada,
			@Email,
			@Telefone
		)
end

---crirar tabela cliente

create table Clientes
(
	ClienteId int not null identity(1,1),
	Nome nvarchar(80) not null,
	
	Email nvarchar(80) not null,
	Telefone int not null
)

alter table Clientes
ADD Morada nvarchar(80) not null

alter table Clientes

	add constraint PK_CLIE
	primary Key clustered (ClienteId asc)

--Criar tabela fornecedores 

create table Fornecedores 
(
	FornecedorId int not null identity(1,1),
	Nome nvarchar(80) not null,
	Morada nvarchar(80) not null,
	Email nvarchar(80) not null,
	Telefone int not null
)

alter table Fornecedores
	add constraint PK_FORN
	primary Key Clustered (FornecedorId asc)

--Criar table contas a Pagar

create table ContasPagar
(
	FaturaId int not null identity(1,1),
	DataVencimento Date not null,
	DataPgamento date not null,
	FornecedorId int not null,
	Valor money not null,
	ValorPago money not null
)

alter table ContasPagar
	add constraint PK_CAP
	primary key clustered (FaturaId asc)

alter table ContasPagar
	add constraint FK_CAP_FORN_01
	foreign key (FornecedorId) references Fornecedores(FornecedorId)

--Criar table contas a receber

create table ContasReceber
(
	FaturaId int not null identity(1,1),
	DataVencimento Date not null,
	DataPgamento date ,
	ClienteId int not null,
	Valor money not null,
	ValorPago money 
)

alter table ContasReceber
add ValorReceber money

alter table ContasReceber
	add constraint PK_CAR
	primary key clustered (FaturaId asc)

alter table ContasReceber
	add constraint FK_CAR_CLIE_01
	foreign key (ClienteId) references Clientes(ClienteId)


Insert into Clientes
(
	Nome, Email, Telefone, Morada
)
values
(
	'Helder', 'helderf85@gmail.com', '916422588', 'Aveiro'	
);

select *
from Clientes 

select ClienteId, Nome, Morada, Telefone, Email from dbo.CLientes where ClienteId=1

