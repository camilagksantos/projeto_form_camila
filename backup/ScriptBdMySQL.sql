-- Criação do Banco de Dados
CREATE DATABASE bd_projeto_form_camila;
GO

USE bd_projeto_form_camila;
GO

-- Criação da Tabela disciplina
CREATE TABLE disciplina (
 id_disciplina INT IDENTITY(1,1) NOT NULL,
 designacao NVARCHAR(45) NOT NULL,
 CONSTRAINT PK_disciplina PRIMARY KEY (id_disciplina)
);
GO

-- Criação da Tabela login
CREATE TABLE login (
 id_login INT IDENTITY(1,1) NOT NULL,
 username NVARCHAR(45) NOT NULL,
 password NVARCHAR(45) NOT NULL,
 role NVARCHAR(45) NOT NULL,
 CONSTRAINT PK_login PRIMARY KEY (id_login),
 CONSTRAINT UQ_login_user UNIQUE (username)
);
GO


-- Criação da Tabela funcionario
CREATE TABLE funcionario (
 id_funcionario INT IDENTITY(1,1) NOT NULL,
 nome NVARCHAR(45) NOT NULL,
 login_id INT NOT NULL,
 CONSTRAINT PK_funcionario PRIMARY KEY (id_funcionario),
 CONSTRAINT FK_funcionario_login FOREIGN KEY (login_id) REFERENCES login(id_login)
);
GO

-- Criação da Tabela turma
CREATE TABLE turma (
 id_turma INT IDENTITY(1,1) NOT NULL,
 designacao NVARCHAR(45) NOT NULL,
 professor_id INT NOT NULL,
 CONSTRAINT PK_turma PRIMARY KEY (id_turma),
 CONSTRAINT FK_turma_funcionario FOREIGN KEY (professor_id) REFERENCES funcionario(id_funcionario)
);
GO

-- Criação da Tabela aluno
CREATE TABLE aluno (
 id_aluno INT IDENTITY(1,1) NOT NULL,
 nome NVARCHAR(45) NOT NULL,
 apelido NVARCHAR(45) NOT NULL,
 idade INT NOT NULL,
 email NVARCHAR(45) NOT NULL,
 turma_id INT NOT NULL,
 login_id INT NULL,
 CONSTRAINT PK_aluno PRIMARY KEY (id_aluno),
 CONSTRAINT FK_aluno_login FOREIGN KEY (login_id) REFERENCES login(id_login),
 CONSTRAINT FK_aluno_turma FOREIGN KEY (turma_id) REFERENCES turma(id_turma)
);
GO


-- Criação da Tabela nota
CREATE TABLE nota (
 id_nota INT IDENTITY(1,1) NOT NULL,
 aluno_id INT NOT NULL,
 disciplina_id INT NOT NULL,
 data_atribuicao DATETIME NOT NULL,
 nota DECIMAL(30,0) NOT NULL,
 CONSTRAINT PK_nota PRIMARY KEY (id_nota),
 CONSTRAINT FK_nota_aluno FOREIGN KEY (aluno_id) REFERENCES aluno(id_aluno),
 CONSTRAINT FK_nota_disciplina FOREIGN KEY (disciplina_id) REFERENCES disciplina(id_disciplina)
);
GO