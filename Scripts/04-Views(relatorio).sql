 CREATE VIEW RelatorioVendasW
AS
SELECT 
	v.numero_venda,
    v.data_venda,
    v.quantidade_venda,
    v.valor_venda,
    v.preco_unitario,
    p.nome AS nome_produto,
    c.nome AS nome_cliente,
    c.CPF AS cpf_cliente,
    u.nome AS nome_usuario
FROM  Venda v
	JOIN Produto p ON v.produto_id = p.id_produto
	JOIN Cliente c ON v.cliente_id = c.id_cliente
	JOIN Usuario u ON v.usuario_id = u.id_usuario

-----------------------------------------------------------------------------------

  CREATE VIEW RelatorioCompraInsumoW
AS
 Select
		 i.nome AS nomeInsumo,
		 f.CNPJ, 
		 f.nome AS Fornecedor, 
		 ic.quantidade, 
		 ic.preco_unitario, 
		 ic.valor_compra, 
		 u.nome AS nome_usuario
 From InsumoCompra ic
		Join Insumo i ON i.id_insumo = ic.insumo_id
		Join Usuario u ON i.usuario_id = u.id_usuario
		Join Fornecedor f ON f.id_fornecedor = ic.fornecedor_id

----------------------------------------------------------------------------------------

CREATE VIEW RelatorioControleEstoqueInsumoW
AS
Select  i.nome AS nomeInsumo,
		i.tipo,
		ie.quantidade_entrada,
		ie.quantidade_saida,
		ie.quantidade_atual,
		f.nome AS Nome_Fornecedor
From InsumoEstoque ie
		Join InsumoCompra ic ON ie.insumo_id = ic.insumo_id
		Join Insumo i ON i.id_insumo = ie.insumo_id
		Join Fornecedor f ON f.id_fornecedor = ie.fornecedor_id
		
----------------------------------------------------------------------------------------

CREATE VIEW RelatorioControleEstoqueProdutoW
AS
Select 
		p.nome AS nomeProduto,
		pe.data_colheita,
		pe.quantidade_saida,
		pe.data_saida,
		pe.quantidade_atual,
		p.periodo_vencimento	
From Produto p
		Join ProdutoEstoque pe ON p.id_produto = pe.produto_id
		
