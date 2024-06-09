CREATE TRIGGER ValidarPrecoVenda
ON Venda
FOR INSERT
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
        -- Obt�m o pre�o de compra do insumo
        SELECT @PrecoCompra = preco_unitario
        FROM InsumoCompra
        WHERE insumo_id = @InsumoID

        -- Calcula o pre�o m�nimo permitido (pre�o de compra + 30%)
        SET @PrecoMinimo = @PrecoCompra * 1.30

        -- Se o pre�o de venda for menor que o pre�o m�nimo permitido, lan�a um erro
        IF @PrecoUnitario < @PrecoMinimo
        BEGIN
            RAISERROR ('O pre�o de venda n�o pode ser menor que o pre�o de compra acrescido de 30%.', 16, 1)
            ROLLBACK TRANSACTION
            RETURN
        END

        FETCH NEXT FROM cursorVenda INTO @InsumoID, @PrecoUnitario
    END

    CLOSE cursorVenda
    DEALLOCATE cursorVenda
END
