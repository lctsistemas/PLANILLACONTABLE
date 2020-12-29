/*      CONTRATO SEGUN EMPLEADO REGISTRADO     */
ALTER PROCEDURE SP_INSERT_CONTRATO(
@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami decimal(5,2),
@tipo_pago varchar(30),
@periodicidad varchar(70),
@tipo_modeda varchar(10),
@cuenta_cts nvarchar(50),
@cussp nvarchar(70),
@id_salud int)
AS BEGIN
	DECLARE @contrato int
	SET @contrato=(SELECT count(c.id_contrato) FROM dbo.Contrato c)
	IF(@contrato=0)
		SET @contrato=1		
	ELSE
		SET @contrato=(SELECT MAX(c.id_contrato)+1 FROM dbo.Contrato c)			
INSERT INTO dbo.Contrato(id_contrato, id_empleado, id_banco, id_tipocontrato, fecha_inicio,
fecha_fin, numero_cuenta, remuneracion_basica, asignacion_familiar, tipo_pago, 
periodicidad, tipo_moneda, cuenta_cts, cussp, id_rsalud)
VALUES(@contrato, (SELECT TOP(1)id_empleado FROM Empleado ORDER BY id_empleado DESC), @id_banco, 
@id_tcontrato, @fecha_inicio, @fecha_fin, @num_cuenta, @remu_basica, @asig_fami, @tipo_pago, 
@periodicidad, @tipo_modeda, @cuenta_cts, @cussp, @id_salud)
END
GO
--
ALTER PROCEDURE SP_UPDATE_CONTRATO
(@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami decimal(5,2),
@tipo_pago varchar(30),
@periodicidad varchar(70),
@tipo_modeda varchar(10),
@cuenta_cts nvarchar(50),
@cussp nvarchar(70),
@id_salud int,
@id_empleado int)
AS BEGIN
UPDATE Contrato SET id_banco=@id_banco, id_tipocontrato=@id_tcontrato, fecha_inicio=@fecha_inicio,
fecha_fin=@fecha_fin, numero_cuenta=@num_cuenta, remuneracion_basica=@remu_basica, 
asignacion_familiar=@asig_fami, tipo_pago=@tipo_pago, periodicidad=@periodicidad, 
tipo_moneda=@tipo_modeda, cuenta_cts=@cuenta_cts, cussp=@cussp, id_rsalud=@id_salud 
WHERE id_empleado=@id_empleado
END
GO

ALTER PROC SP_SHOW_CONTRATO
@seach varchar(30)
AS BEGIN
SELECT * FROM dbo.Contrato c
END
GO
GO

drop PROC SP_DELETE_CONTRATO  --revisar con validacion urgente.
@id_contrato int,
@mensaje varchar(100) OUTPUT
AS BEGIN
UPDATE dbo.Contrato SET estado='ANULADO' WHERE id_contrato=@id_contrato
END
GO

--NO BORRAR, ES PARA FUTURAS PRUEBAS.
ALTER PROC SP_INSERT_COMISIONES
@codigo_regimen int,
@comision decimal(6,2),
@saldo decimal(6,2) ,
@seguro decimal(6,2), 
@aporte decimal(6,2),
@tope  decimal(10,2),
@idmes int,
@idperiodo int
AS BEGIN
declare @men varchar(30)
IF(NOT EXISTS(SELECT top(1)  re.codigo_regimen FROM ComisionesPension co JOIN RegimenPensionario re ON(co.codigo_regimen = re.codigo_regimen) 
WHERE co.idmes=@idmes AND co.idperiodo=@idperiodo))
BEGIN
	DECLARE @idcomi int
	SET @idcomi=(SELECT count(c.idcomision) FROM dbo.ComisionesPension c)
	IF(@idcomi=0)
		SET @idcomi=1
	ELSE
		SET @idcomi=(SELECT MAX(c.idcomision)+1 FROM dbo.ComisionesPension c)

	INSERT INTO dbo.ComisionesPension(idcomision, codigo_regimen,
	comision, saldo, seguro, aporte, tope, idmes, idperiodo) VALUES
	(@idcomi, @codigo_regimen, @comision, @saldo, @seguro, @aporte, @tope, @idmes, @idperiodo)
END
ELSE
	SET @men='Ya esta registrado'
END
GO


---------------
GO
DECLARE @VAL INT
BEGIN TRY
 SET @VAL=1/0
 PRINT @VAL
END TRY
BEGIN CATCH
PRINT ERROR_MESSAGE()
END CATCH
GO

