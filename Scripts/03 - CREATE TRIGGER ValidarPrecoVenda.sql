

CREATE TRIGGER ValidarPrecoVenda  
ON Venda  
FOR INSERT,	UPDATE 
AS  
BEGIN  
    DECLARE @InsumoID INT, @PrecoUnitario DECIMAL(10,2), @PrecoCompra DECIMAL(10,2), @PrecoMinimo DECIMAL(10,2)  
  
    -- Percorre as linhas inseridas na tabela Venda  
    DECLARE cursorVenda CURSOR FOR  
    SELECT produto_id, preco_unitario  
    FROM inserted  
  
    OPEN cursorVenda  
  
    FETCH NEXT FROM cursorVenda INTO @InsumoID, @PrecoUnitario  
  
    WHILE @@FETCH_STATUS = 0  
    BEGIN  
        -- Obtém o preço de compra do insumo  
        SELECT @PrecoCompra = preco_unitario  
        FROM InsumoCompra  
        WHERE insumo_id = @InsumoID  
  
        -- Calcula o preço mínimo permitido (preço de compra + 30%)  
        SET @PrecoMinimo = @PrecoCompra * 1.30  
  
        -- Se o preço de venda for menor que o preço mínimo permitido, lança um erro  
        IF @PrecoUnitario < @PrecoMinimo  
        BEGIN  
            RAISERROR ('O preço de venda não pode ser menor que o preço de compra acrescido de .', 16, 1)  
            ROLLBACK TRANSACTION  
            RETURN  
        END  
  
        FETCH NEXT FROM cursorVenda INTO @InsumoID, @PrecoUnitario  
    END  
  
    CLOSE cursorVenda  
    DEALLOCATE cursorVenda  
END  


-- INSERT para tabela Venda
INSERT INTO Venda (produto_id, cliente_id, usuario_id, numero_venda, quantidade_venda, data_venda, data_registro, valor_venda, preco_unitario)VALUES 
(1, 2, 1, 1, 5, '2024-06-05', '2024-06-05', 16.50, 2.25)

