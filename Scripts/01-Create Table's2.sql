CREATE DATABASE ForLife
USE ForLife

--Create

-- Tabela Usuario
CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(255) NOT NULL,
    cod_usuario INT NOT NULL,
    senha VARCHAR(255) NOT NULL,
    cargo VARCHAR(255) NOT NULL,
    data_cadastro DATE NOT NULL
);

-- Tabela Fornecedor
CREATE TABLE Fornecedor (
    id_fornecedor INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT,
    CNPJ  varchar (18) NULL,
    nome VARCHAR(255) NOT NULL,
    razao_social VARCHAR(255) NOT NULL,
    CPF varchar (14) NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

--alter table fornecedor alter column cnpj varchar (18) NULL
--alter table fornecedor alter column cpf varchar (14)  null

-- Tabela Cliente
alter TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    CPF varchar (14) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    endereco VARCHAR(255) NOT NULL
);

--alter table cliente alter column cpf varchar (14) not null

-- Tabela Insumo
CREATE TABLE Insumo (
    id_insumo INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    ativo BIT NOT NULL,
    periodo_vencimento INT NOT NULL,
    usuario_id INT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

--ALTER TABLE insumo DROP COLUMN descricao;
--GO

--select * from Insumo

-- Tabela InsumoCompra
create TABLE InsumoCompra (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    insumo_id INT NOT NULL,
    fornecedor_id INT NOT NULL,
    usuario_id INT NOT NULL,
    quantidade INT NOT NULL,
    preco_unitario DECIMAL (10,2) NOT NULL,
    valor_compra DECIMAL (10,2) NOT NULL,
	NomeInsumo VARCHAR(100) NOT NULL
    FOREIGN KEY (insumo_id) REFERENCES Insumo(id_insumo),
	FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario),
    FOREIGN KEY (fornecedor_id) REFERENCES Fornecedor(id_fornecedor)
	
);

--ALTER TABLE InsumoCompra --drop column NomeInsumo 

-- Tabela InsumoEstoque



 drop table InsumoEstoque

CREATE TABLE InsumoEstoque (
    id_estoque INT IDENTITY(1,1) PRIMARY KEY,
    insumo_id INT NOT NULL,
    fornecedor_id INT NOT NULL,
    usuario_id INT NOT NULL,
    quantidade_anterior INT NOT NULL,
    quantidade_entrada INT NULL,
    quantidade_saida INT NULL,
    quantidade_atual INT NOT NULL,
	tipoMovimento CHAR NOT NULL, 
	dataMovimento DATETIME NOT NULL,
	data_entrada DATE NULL,
    data_saida DATE NULL,
    data_vencimento_estimado DATE  NULL,
    FOREIGN KEY (insumo_id) REFERENCES Insumo(id_insumo),
	FOREIGN KEY (fornecedor_id) REFERENCES Fornecedor(id_fornecedor),
	FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

-- Tabela Produto
CREATE TABLE Produto (
    id_produto INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    insumo_id INT NOT NULL,
    periodo_colheita INT NOT NULL,
    periodo_vencimento INT NOT NULL,
    periodo_limite_colheita INT NOT NULL,
    usuario_id INT NOT NULL,
    FOREIGN KEY (insumo_id) REFERENCES Insumo(id_insumo),
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

-- Tabela Plantio
CREATE TABLE Plantio (
    id_plantio INT IDENTITY(1,1) PRIMARY KEY,
    insumo_id INT NOT NULL,
    produto_id INT NOT NULL,
    quantidade_plantio INT NOT NULL,
    data_plantio DATE NOT NULL,
    data_colheita DATE NOT NULL,
    data_vencimento_estimado DATE NOT NULL,
    data_baixa DATE NULL,
    data_registro DATE NOT NULL,
    FOREIGN KEY (insumo_id) REFERENCES Insumo(id_insumo),
	FOREIGN KEY (produto_id) REFERENCES Produto(id_produto)
);

drop table ProdutoEstoque

-- Tabela ProdutoEstoque
CREATE TABLE ProdutoEstoque (
    id_estoque INT IDENTITY(1,1) PRIMARY KEY,
    produto_id INT NOT NULL,
	tipoMovimento CHAR NOT NULL, 
	quantidade_anterior INT NOT NULL,
    quantidade_atual INT NULL,
    quantidade_colheita INT  NULL,
    quantidade_saida INT NULL,
    data_colheita DATE  NULL,
    data_vencimento_estimado DATE NULL,
    data_saida DATE NULL,
    data_movimento DATEtime NULL,
    FOREIGN KEY (produto_id) REFERENCES Produto(id_produto)
);

-- Tabela Venda
CREATE TABLE Venda (
    id_venda INT IDENTITY(1,1) PRIMARY KEY,
    produto_id INT NOT NULL,
	cliente_id INT NOT NULL,
    usuario_id INT NOT NULL,
    numero_venda INT NOT NULL,
    quantidade_venda INT NOT NULL,
    data_venda DATE NOT NULL,
    data_registro DATE NOT NULL,
    valor_venda DECIMAL (10,2) NOT NULL,
    preco_unitario DECIMAL (10,2) NOT NULL,    
    FOREIGN KEY (produto_id) REFERENCES Produto(id_produto),
    FOREIGN KEY (cliente_id) REFERENCES Cliente(id_cliente),
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

