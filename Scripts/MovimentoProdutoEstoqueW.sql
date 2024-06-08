CREATE VIEW MovimentoProdutoEstoqueW
AS
select idMovimentoProduto = id_estoque, 
	   p.nome,
	   descrMovimento = CASE WHEN pe.tipoMovimento = 'E' THEN '[+] - Entrada' ELSE '[-] - Saída' END,
	   pe.quantidade_anterior, 
	   quantidadeMovimento =  CASE WHEN pe.tipoMovimento = 'E' THEN quantidade_colheita ELSE (quantidade_saida)*-1 END,
	   quantidade_atual,
	   data_movimento
from ProdutoEstoque pe
	 Join Produto p ON p.id_produto = pe.produto_id


	 select * from MovimentoProdutoEstoqueW
