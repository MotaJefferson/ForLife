alter VIEW MovimentoInsumoEstoqueW
AS
select idMovimentoProduto = id_estoque, 
	   nome = i.nome + ' - ' + i.tipo,
	   descrMovimento = CASE WHEN ie.tipoMovimento = 'E' THEN '[+] - Entrada' ELSE '[-] - Saída' END,
	   ie.quantidade_anterior, 
	   quantidadeMovimento =  CASE WHEN ie.tipoMovimento = 'E' THEN quantidade_entrada ELSE (quantidade_saida)*-1 END,
	   quantidade_atual,
	   datamovimento
from InsumoEstoque ie
	 Join Insumo i ON i.id_insumo = ie.insumo_id


	 