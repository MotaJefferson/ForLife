
-- tabela Usuario
INSERT INTO Usuario (nome, usuario, senha, cargo, icBloqueado, data_cadastro)
VALUES ('Wender Rodrigues', 'wender.rodrigues', 'senha123', 1, 0, GETDATE()),
       ('Jaqueline Ferreira', 'jaqueline.ferreira', 'senha456', 2, 1, GETDATE()),
       ('Gabriel Rodrigues', 'gabriel.rodrigues', 'senha789', 1, 0, GETDATE()),
	   ('Jefferson Mota', 'jefferson.mota', 'senha456', 2, 1, GETDATE());

-- tabela Cliente 
INSERT INTO Fornecedor (usuario_id, CNPJ, nome, razao_social, CPF, status)
VALUES (1, '29220447000158', 'Bom Cultivo', 'BC Agro Comercial Eireli', NULL, 1),
       (2, '24517082000104', 'Agromania', 'Agro Comercial Agronomia', NULL, 1),
	   (3, '23797376000174', 'Bartofil', 'Bartofil Distribuidora SA', NULL, 1);
	    
-- tabela Cliente
INSERT INTO Cliente (nome, CPF, telefone, logadouro, numero, complemento, bairro, cidade, UF, status)
VALUES ('Maria', '123.456.789-01', '(11) 1234-5678', 'Rua A', 100, NULL, 'Centro', 'São Paulo', 'SP', 1),
       ('Pedro', '987.654.321-09', '(22) 9876-5432', 'Rua B', 200, 'Bloco 1', 'Centro', 'Rio de Janeiro', 'RJ', 1),
	   ('Luciano', '123.456.789-01', '(11) 1234-5678', 'Rua C', 100, NULL, 'Centro', 'São Paulo', 'SP', 1);

---- tabela Insumo
INSERT INTO Insumo (nome, tipo, ativo, usuario_id)
VALUES  ('Alface crespa', 'Muda', 1, 1),
		('Repolho', 'Semente', 1, 1),
		('Tomate', 'Semente', 1, 1),
		('Alface Americana', 'Muda', 1, 1),
        ('Almeirao', 'Semente', 1, 2);


-- tabela InsumoCompra
INSERT INTO InsumoCompra (insumo_id, fornecedor_id, usuario_id, quantidade, preco_unitario, valor_compra, NomeInsumo)
VALUES 	(1, 1, 1, 100, 2.50, 250.00, 'Alface crespa'),
		(2, 1, 1, 100, 3.20, 320.00, 'Repolho'),
		(3, 1, 1, 100, 1.50, 150.00, 'Tomate'),
		(4, 1, 1, 100, 3.50, 350.00, 'Alface Americana'),
		(5, 2, 2, 200, 4.00, 400.00, 'Almeirao');


--  tabela InsumoEstoque
INSERT INTO InsumoEstoque (insumo_id, fornecedor_id, usuario_id, quantidade_anterior, quantidade_atual, tipoMovimento, dataMovimento)
VALUES (1, 1, 1, 0, 100, 'E', GETDATE()),
	   (2, 1, 1, 0, 100, 'E', GETDATE()),
	   (3, 1, 1, 0, 100, 'E', GETDATE()),
	   (4, 1, 1, 0, 100, 'E', GETDATE()),
     (2, 2, 2, 0, 200, 'E', GETDATE());
    


--  tabela Produto
INSERT INTO Produto (nome, insumo_id, periodo_colheita, periodo_vencimento, usuario_id)
VALUES   ('Alface crespa', 1, 50, 60, 1),
		 ('Repolho', 2, 45, 55, 2),
		 ('Tomate', 3, 90, 100, 3),
		 ('Alface Americana', 4, 55, 65, 2),
		 ('Almeirao', 5, 65, 75, 2);

		

--  tabela Plantio
INSERT INTO Plantio (insumo_id, produto_id, quantidade_plantio, data_plantio, data_colheita, data_vencimento_estimado, data_baixa)
VALUES 
    (1, 2, 100, '2024-01-01', '2024-01-30', '2024-04-30', NULL),
	(2, 3, 200, '2024-01-01', '2024-01-30', '2024-04-30', NULL),
	(3, 4, 100, '2024-01-01', '2024-01-30', '2024-04-30', NULL),
	(4, 5, 100, '2024-01-01', '2024-01-30', '2024-04-30', NULL);
    


-- tabela ProdutoEstoque
INSERT INTO ProdutoEstoque (produto_id, tipoMovimento, quantidade_anterior, quantidade_atual, quantidade_colheita, data_colheita, data_vencimento_estimado, data_saida)
VALUES 
    (1, 'E', 0, 100, NULL, NULL, '2024-06-11', NULL),
	(2, 'E', 0, 100, NULL, NULL, '2024-06-11', NULL),
	(3, 'E', 0, 100, NULL, NULL, '2024-06-11', NULL),
	(4, 'E', 0, 100, NULL, NULL, '2024-06-11', NULL),
    (5, 'E', 0, 200, NULL, NULL, '2024-06-11', NULL);

-- Inserção de dados na tabela Venda
INSERT INTO Venda (produto_id, cliente_id, usuario_id, numero_venda, quantidade_venda, data_venda, valor_venda, preco_unitario)
VALUES 
		(2, 1, 1, 01, 50, '2024-06-10',  150.00, 2.50),
        (3, 2, 2, 02, 100, '2024-06-10',  320.00, 3.20);
