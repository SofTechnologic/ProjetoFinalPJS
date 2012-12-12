-- Criação do banco de dados para o projeto final
-- Alunos:
-- Bruno Oliveira, Felipe Querubin e Thiago Carvalho
-- 3º Módulo de Informática
-- IFSP - Campus - Campos do Jordão

Create Database dbSysMusicColletion
GO

Use dbSysMusicColletion
GO

CREATE TABLE Midias (
Cod_Midia int NOT NULL PRIMARY KEY,
Tipo_Midia Varchar(10) NOT NULL
)

CREATE TABLE Amigos (
Cod_Amigo int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome Varchar(40) NOT NULL ,
Telefone Varchar(14) NOT NULL,
Endereco Varchar(50)
)

CREATE TABLE Emprestimos (
Num_Emprestimo int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Data_Emprestimo Varchar(10) NOT NULL,
Cod_Amigo int,
FOREIGN KEY(Cod_Amigo) REFERENCES Amigos (Cod_Amigo)
)

CREATE TABLE Discos (
Cod_Disco int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Cod_Midia int NOT NULL ,
ID_Autor int,
ID_Interprete int NOT NULL,
ID_Album int NOT NULL ,
Data_Album Varchar(10),
Data_Compra Varchar(10),
Origem_Compra Varchar(30),
Observ Varchar(50),
Nota Varchar(2),
Emprestado bit,
FOREIGN KEY(Cod_Midia) REFERENCES Midias (Cod_Midia)
)

CREATE TABLE Itens_Emprestimo (
ID_itens int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Cod_Disco int,
Num_Emprestimo int,
Data_Devolucao Varchar(10),
FOREIGN KEY(Cod_Disco) REFERENCES Discos (Cod_Disco),
FOREIGN KEY(Num_Emprestimo) REFERENCES Emprestimos (Num_Emprestimo)
)

CREATE TABLE Autores (
ID_Autor int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Autor Varchar(40)
)

CREATE TABLE Interpretes (
ID_Interprete int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Interprete Varchar(40) NOT NULL
)

CREATE TABLE Albuns (
ID_Album int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Album Varchar(40) NOT NULL
)

CREATE TABLE Morto (
Cod_Morto int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Amigo Varchar(40) NOT NULL ,
Nome_Disco Varchar(40) NOT NULL,
Data_Emprestimo Varchar (10) NOT NULL,
Data_Devolucao Varchar (10) NOT NULL,
)
GO

ALTER TABLE Discos ADD FOREIGN KEY(ID_Autor) REFERENCES Autores (ID_Autor)
ALTER TABLE Discos ADD FOREIGN KEY(ID_Interprete) REFERENCES Interpretes (ID_Interprete)
ALTER TABLE Discos ADD FOREIGN KEY(ID_Album) REFERENCES Albuns (ID_Album)

GO

INSERT INTO Amigos (Nome,Telefone,Endereco)
VALUES (
'THIAGO CARVALHO',
'12-3666 - 9087',
'RUA DE TAL, Nº 23, CENTRO');
GO

Insert into Midias (Cod_Midia, Tipo_Midia) values (1,'Vinil'),(2,'K7'),(3,'CD'),(4,'DVD'), (5, 'Digital');

SELECT * FROM Amigos
GO
select * from Itens_Emprestimo;
go

select * from Discos;
go
select * from autores;
go