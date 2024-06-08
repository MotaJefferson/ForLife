

		/*EXEMPLO DE EXCUÇÃO MOVIMENTO DE ENTRADA*/
		 EXEC AtualizaEstoqueProdutoMovimento 'E', 50, 1, '2024-06-05', '2024-08-05', NULL 

		/*EXEMPLO DE EXCUÇÃO MOVIMENTO DE SAÍDA*/
		 EXEC AtualizaEstoqueProdutoMovimento 'S', 50, 1, NULL, '2024-08-05', '2024-06-08'

		select * from ProdutoEstoque


		
		/*EXEMPLO DE EXCUÇÃO MOVIMENTO DE ENTRADA*/
		 EXEC AtualizaEstoqueInsumoMovimento 'E', 50, 1, '2024-06-05', '2024-08-05', NULL 

		/*EXEMPLO DE EXCUÇÃO MOVIMENTO DE SAÍDA*/
		 EXEC AtualizaEstoqueInsumoMovimento 'S', 50, 1, NULL, '2024-08-05', '2024-06-08'

