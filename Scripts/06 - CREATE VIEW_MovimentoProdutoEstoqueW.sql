CREATE VIEW MovimentoProdutoEstoqueW
AS
SELECT idMovimentoProduto = id_estoque, 
	   p.nome,
	   descrMovimento = CASE WHEN pe.tipoMovimento = 'E' THEN '[+] - Entrada' ELSE '[-] - Saída' END,
	   pe.quantidade_anterior, 
	   quantidadeMovimento =  CASE WHEN pe.tipoMovimento = 'E' THEN quantidade_colheita ELSE (quantidade_saida)*-1 END,
	   quantidade_atual,
	   data_movimento
FROM ProdutoEstoque pe
	 Join Produto p ON p.id_produto = pe.produto_id