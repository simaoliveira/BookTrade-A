CREATE TABLE Livro (
  Id              int IDENTITY NOT NULL, 
  Nome            varchar(50) NOT NULL, 
  Sinopse         varchar(255) NOT NULL, 
  AnoLanc         int NOT NULL, 
  Autor           int NOT NULL, 
  Capa            int NOT NULL, 
  editora         varchar(50) NOT NULL, 
  idioma          varchar(50) NOT NULL, 
  numerodepaginas int NOT NULL, 
  AutorId         int NOT NULL, 
  PRIMARY KEY (Id));
CREATE TABLE Comentarios (
  Id           int IDENTITY NOT NULL, 
  Texto        varchar(255) NOT NULL, 
  Data         date NOT NULL, 
  LivroId      int NOT NULL, 
  UtilizadorId int NOT NULL, 
  PRIMARY KEY (Id));
CREATE TABLE Categorias (
  Id   int IDENTITY NOT NULL, 
  Nome varchar(50) NOT NULL, 
  PRIMARY KEY (Id));
CREATE TABLE Autor (
  Id        int IDENTITY NOT NULL, 
  Nome      varchar(50) NOT NULL, 
  DataNasc  date NOT NULL, 
  Descricao int NULL, 
  PRIMARY KEY (Id));
CREATE TABLE LIvro_Categoria (
  LivroId      int NOT NULL, 
  CategoriasId int NOT NULL, 
  PRIMARY KEY (LivroId, 
  CategoriasId));
CREATE TABLE Utilizador (
  Id           int IDENTITY NOT NULL, 
  UserName     varchar(50) NOT NULL UNIQUE, 
  DataNasc     date NOT NULL, 
  Password     varchar(15) NOT NULL, 
  email        varchar(20) NOT NULL UNIQUE, 
  NomeCompleto varchar(50) NOT NULL, 
  PRIMARY KEY (Id));
ALTER TABLE Comentarios ADD CONSTRAINT FKComentario642485 FOREIGN KEY (LivroId) REFERENCES Livro (Id);
ALTER TABLE Livro ADD CONSTRAINT FKLivro420597 FOREIGN KEY (AutorId) REFERENCES Autor (Id);
ALTER TABLE Comentarios ADD CONSTRAINT FKComentario68317 FOREIGN KEY (UtilizadorId) REFERENCES Utilizador (Id);
ALTER TABLE LIvro_Categoria ADD CONSTRAINT FKLIvro_Cate937076 FOREIGN KEY (LivroId) REFERENCES Livro (Id);
ALTER TABLE LIvro_Categoria ADD CONSTRAINT FKLIvro_Cate443830 FOREIGN KEY (CategoriasId) REFERENCES Categorias (Id);
