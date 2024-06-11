--CREATE TABLES

-- Tabela Usuario
CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(255) NOT NULL,
    usuario VARCHAR(255) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    cargo INT NOT NULL,
	icBloqueado BIT NULL,
    data_cadastro DATETIME DEFAULT GETDATE()
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

-- Tabela Cliente
CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    CPF varchar (14) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    endereco VARCHAR(255) NOT NULL
);

-- Tabela Insumo
CREATE TABLE Insumo (
    id_insumo INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    ativo BIT NOT NULL,
    usuario_id INT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

-- Tabela InsumoCompra
CREATE TABLE InsumoCompra (
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


-- Tabela InsumoEstoque
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
	dataMovimento DATETIME DEFAULT GETDATE(),
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
    data_registro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (insumo_id) REFERENCES Insumo(id_insumo),
	FOREIGN KEY (produto_id) REFERENCES Produto(id_produto)
);

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
    data_movimento DATETIME DEFAULT GETDATE(),
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
    data_registro DATETIME DEFAULT GETDATE(),
    valor_venda DECIMAL (10,2) NOT NULL,
    preco_unitario DECIMAL (10,2) NOT NULL,    
    FOREIGN KEY (produto_id) REFERENCES Produto(id_produto),
    FOREIGN KEY (cliente_id) REFERENCES Cliente(id_cliente),
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario)
);

