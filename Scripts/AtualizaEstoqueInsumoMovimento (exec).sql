DECLARE @TipoMovimento CHAR = 'X', 
		@quantidade INT = 800, 
		@insumo_id INT = 1, 
		@fornecedor_id INT = 6, 
		@usuario_id INT = 2, 
		@data_Entrada DATETIME = '2024-06-05',
		@data_vencimento_estimado DATETIME = '2024-08-05', 
		@data_saida DATETIME = '2024-06-08'



		/*EXEMPLO DE EXCUÇÃO MOVIMENTO DE ENTRADA*/
		 EXEC AtualizaEstoqueInsumoMovimento 'E', 50, 1, 6, 2, '2024-06-05', '2024-08-05', NULL

		/*EXEMPLO DE EXCUÇÃO MOVIMENTO DE SAÍDA*/
		 EXEC AtualizaEstoqueInsumoMovimento 'S', 50, 1, 6, 2, NULL, '2024-08-05', '2024-06-07'

		select * from InsumoEstoque