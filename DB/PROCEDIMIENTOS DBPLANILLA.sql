USE Planilla_lct
GO
/*    PROCEDIMIENTOD ALMACENADOS     */

--INSERT CARGO
CREATE PROC SP_REGISTRAR_CARGO
@nom varchar(40),
@descripcion nvarchar(100)
AS BEGIN
INSERT INTO Cargo(nombre_cargo,descripcion)
VALUES(@nom,@descripcion) 
END 
GO

--UPDATE CARGO
CREATE PROC SP_UPDATE_CARGO
@idcargo int,
@nom varchar(40),
@descripcion nvarchar(100)
AS BEGIN
UPDATE Cargo SET nombre_cargo=@nom, descripcion=@descripcion WHERE id_cargo=@idcargo
END
GO

--DELETE CARGO
CREATE PROC SP_DELETE_CARGO
@idcargo int,
@message varchar(100) output
AS BEGIN
IF(EXISTS(SELECT c.id_cargo FROM Empleado E join Cargo C on E.id_cargo=C.id_cargo WHERE C.id_cargo=@idcargo))
	BEGIN
	DECLARE @resul VARCHAR(20)
	SET @resul=(SELECT c.nombre_cargo FROM Cargo c WHERE c.id_cargo=@idcargo)
	SET @message='CARGO ( '+@resul+' ) ESTA EN USO'
	END
ELSE
	BEGIN
	DELETE FROM Cargo WHERE id_cargo=@idcargo
	SET @message='SE ELIMINO CARGO CORRECTAMENTE!'
	END	
END
GO

--SHOW CARGO
alter PROC SP_SELECT_CARGO 
AS BEGIN
SELECT id_cargo, nombre_cargo, descripcion 
FROM Cargo order by id_cargo asc
END
GO


/*    PROCEDIMIENTO TIPO DE DOCUMENTO     */

--INSERT TIPO DOCUMENTO
CREATE PROC SP_REGISTRAR_DOCUMENTO
@nom varchar(50),
@descripcion nvarchar(100)
AS BEGIN
INSERT INTO Tipo_documento(nombre,descripcion)
VALUES(@nom,@descripcion)
END
GO

--UPDATE DOCUMENTO
CREATE PROC SP_UPDATE_DOCUMENTO
@iddocumento int,
@nom varchar(50),
@descripcion nvarchar(100)
AS BEGIN
UPDATE Tipo_documento SET nombre=@nom, descripcion=@descripcion WHERE id_documento=@iddocumento
END
GO

--DELETE DOCUMENTO
CREATE PROC SP_DELETE_DOCUMENTO
@iddocumento int,
@message varchar(100) output
AS BEGIN
IF(EXISTS(SELECT t.id_documento FROM Empleado E join Tipo_documento t on E.id_documento=t.id_documento WHERE t.id_documento=@iddocumento))
	BEGIN
	DECLARE @resul VARCHAR(20)
	SET @resul=(SELECT t.nombre FROM dbo.Tipo_documento t WHERE t.id_documento=@iddocumento)
	SET @message='DOCUMENTO ( '+@resul+' ) ESTA EN USO'
	END
ELSE
	BEGIN
	DELETE FROM Tipo_documento WHERE id_documento=@iddocumento
	SET @message='SE ELIMINO DOCUMENTO CORRECTAMENTE!'
	END	
END
GO

--SHOW DOCUMENTO
ALTER PROC SP_SELECT_DOCUMENTO 
AS BEGIN
SELECT id_documento,nombre,descripcion FROM 
Tipo_documento 
END
GO

--Agregar empleado
ALTER PROC SP_AGR_EMPL
(@id_empleado int,
@codigo varchar(20),--sera n�mero de documento.
@nom_emp varchar(50),
@ape_pat varchar(50),
@ape_mat varchar(50),
@fec_nac date,
@nacionalidad varchar(30),
@tip_ge varchar(12),
@direccion varchar(250),
@telefono varchar(15),
@num_doc varchar(20),
@estado varchar(20),
@codigo_regimen int,
@id_documento int,
@id_cargo int,
@id_empresa_maestra int,
@mensaje varchar(100) output)
AS BEGIN 
IF(EXISTS(SELECT e.numero_documento FROM Empleado e WHERE e.numero_documento=@num_doc))
	BEGIN 
	SET @mensaje ='El n�mero de documento ('+@num_doc+') ya se encuentra registrado'
	END
ELSE 
	BEGIN
		INSERT INTO dbo.Empleado(id_empleado,codigo,nombre_empleado, ape_paterno, ape_materno, fecha_nacimiento, nacionalidad, 
		tipo_genero,direccion,telefono, numero_documento, estado, codigo_regimen, id_documento, id_cargo, id_em_maestra, eliminado_estado) 
		VALUES (@id_empleado, @codigo, @nom_emp, @ape_pat, @ape_mat, @fec_nac, @nacionalidad, @tip_ge, @direccion, @telefono, @num_doc, @estado,
		@codigo_regimen, @id_documento, @id_cargo, @id_empresa_maestra, 'NO ANULADO')
		SET @mensaje= '�Empleado registrado correctamente!'
	END	
END
GO


ALTER PROC SP_UPDATE_EMPLEADO
(@codigo varchar(20),
@nom_emp varchar(50),
@ape_pat varchar(50),
@ape_mat varchar(50),
@fec_nac date,
@nacionalidad varchar(30),
@tip_ge varchar(12),
@direccion varchar(250),
@telefono varchar(15),
@num_doc varchar(20),
@estado varchar(20),
@codigo_regimen int,
@id_documento int,
@id_cargo int,
@id_empleado int)
AS BEGIN 
 UPDATE Empleado SET codigo=@codigo, nombre_empleado=@nom_emp, ape_paterno=@ape_pat, ape_materno=@ape_mat,
 fecha_nacimiento=@fec_nac, nacionalidad=@nacionalidad, tipo_genero=@tip_ge, direccion=@direccion,
 telefono=@telefono, numero_documento=@num_doc, estado=@estado ,codigo_regimen=@codigo_regimen,
 id_documento=@id_documento, id_cargo=@id_cargo WHERE id_empleado=@id_empleado
END
GO


--ELIMINAR EMPLEADO ---> MODIFICAR
CREATE PROC SP_ELIM_EMPLEADO
(@id_emp int)
AS BEGIN 
UPDATE dbo.Empleado SET eliminado_estado='ANULADO' WHERE id_empleado=@id_emp;
END
GO

--MOSTRAR EMPLEADO Y AL SELECCIONAR MOSTRAR CONTRATO-- CONCAT(e.ape_paterno,SPACE(2), e.ape_materno,SPACE(2), e.nombre_empleado)
ALTER PROC SP_SHOW_EMP
@codigo_empresa int
AS BEGIN 
SELECT e.id_empleado, e.ape_paterno, e.ape_materno, e.nombre_empleado,
em.id_em_maestra ,em.razon_social AS 'EMPRESA' FROM Empleado e INNER JOIN Empresa_maestra em 
on(e.id_em_maestra=em.id_em_maestra) WHERE e.eliminado_estado='NO ANULADO' AND e.id_em_maestra=@codigo_empresa 
ORDER BY e.id_empleado DESC
END
GO

CREATE PROC SP_SHOW_EMPLEADO_CONTRATO
@codigo_empleado int
AS BEGIN 
SELECT e.codigo, e.nombre_empleado, e.ape_paterno, e.ape_materno,e.fecha_nacimiento,
e.nacionalidad, e.tipo_genero, e.direccion, e.telefono, e.numero_documento, e.estado, e.codigo_regimen, 
r.descripcion, e.id_documento, t.nombre, e.id_cargo, c.nombre_cargo, co.id_banco, b.nombre_banco,
co.id_tipocontrato, ti.tiempo_contrato, co.fecha_inicio, co.fecha_fin, co.numero_cuenta, 
co.remuneracion_basica, co.asignacion_familiar, co.regimen_salud, co.tipo_pago, co.periodicidad, 
co.tipo_moneda, co.cuenta_cts, co.cussp 
FROM Empleado e JOIN RegimenPensionario r on(e.codigo_regimen = r.codigo_regimen) JOIN Tipo_documento t
on(e.id_documento = t.id_documento) JOIN Cargo c on(e.id_cargo = c.id_cargo) JOIN Contrato co
on(e.id_empleado = co.id_empleado) JOIN Banco b on(b.id_banco = co.id_banco) JOIN Tipo_contrato ti
on(co.id_tipocontrato = ti.id_tipocontrato) WHERE e.id_empleado=@codigo_empleado
END
GO


-- CONTRATO SEGUN EMPLEADO REGISTRADO

ALTER PROCEDURE SP_INSERT_CONTRATO
(@id_contrato int,
@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami money,
@regimen_salud varchar(80),
@tipo_pago varchar(30),
@periodicidad varchar(70),
@tipo_modeda varchar(10),
@cuenta_cts nvarchar(50),
@cussp nvarchar(70))
AS BEGIN
INSERT INTO dbo.Contrato(id_contrato, id_empleado, id_banco, id_tipocontrato, fecha_inicio,
fecha_fin, numero_cuenta, remuneracion_basica, asignacion_familiar, regimen_salud, tipo_pago, 
periodicidad, tipo_moneda, cuenta_cts, cussp)
VALUES(@id_contrato, (SELECT TOP(1)id_empleado FROM Empleado ORDER BY id_empleado DESC), @id_banco, 
@id_tcontrato, @fecha_inicio, @fecha_fin, @num_cuenta, @remu_basica, @asig_fami, @regimen_salud, @tipo_pago, 
@periodicidad, @tipo_modeda, @cuenta_cts, @cussp)
END
GO


--UPDATE EMPLEADO.
ALTER PROCEDURE SP_UPDATE_CONTRATO
(@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami money,
@regimen_salud varchar(80),
@tipo_pago varchar(30),
@periodicidad varchar(70),
@tipo_modeda varchar(10),
@cuenta_cts nvarchar(50),
@cussp nvarchar(70),
@id_empleado int)
AS BEGIN
UPDATE Contrato SET id_banco=@id_banco, id_tipocontrato=@id_tcontrato, fecha_inicio=@fecha_inicio,
fecha_fin=@fecha_fin, numero_cuenta=@num_cuenta, remuneracion_basica=@remu_basica, 
asignacion_familiar=@asig_fami, regimen_salud=@regimen_salud, tipo_pago=@tipo_pago, 
periodicidad=@periodicidad, tipo_moneda=@tipo_modeda, cuenta_cts=@cuenta_cts, cussp=@cussp 
WHERE id_empleado=@id_empleado
END
GO

-- PROCED. ELIMINAR
CREATE PROC SP_DELETE_CONTRATO
@id_contrato int,
@mensaje varchar(100) OUTPUT
AS BEGIN
UPDATE dbo.Contrato SET estado='ANULADO' WHERE id_contrato=@id_contrato
END
GO

--		SHOW CONTRATO
CREATE PROC SP_SHOW_CONTRATO
@seach varchar(30)
AS BEGIN
SELECT * FROM dbo.Contrato c
END
GO
GO
----and e.id_em_maestra=@codigo_empresa
/*     EMPRESA AND SUCURSAL      */
ALTER PROC SP_INSERT_EMPRESA_MAESTRA
@razon_social varchar(50),
@direccion nvarchar(250),
@domicilio nvarchar(250),
@ruc char(11),
@regimen varchar(80),
@localidad varchar(50),
@cod_empresa_validar varchar(50),
@mesage varchar(100) output
AS BEGIN
IF(EXISTS(SELECT codigo_empresa FROM Empresa WHERE codigo_empresa=@cod_empresa_validar))
	BEGIN
		set @mesage='�Codigo Empresa Ya Exite!'
	END
ELSE IF(EXISTS(SELECT codigo_sucursal FROM Sucursal WHERE codigo_sucursal=@cod_empresa_validar))
	BEGIN
		set @mesage='�Codigo Sucursal Ya Exite!'
	END
ELSE
	BEGIN
		INSERT INTO dbo.Empresa_maestra(razon_social,direccion,domicilio_fiscal,ruc,regimen,estado_eliminado,localidad)
		VALUES(@razon_social,@direccion,@domicilio,@ruc,@regimen,'NO ANULADO', @localidad)
		set @mesage='�Registro Exitosamente!'
	END
END
GO


CREATE PROC SP_INSERT_EMPRESA
@cod_empresa varchar(8),
@id_usuario int
AS BEGIN
INSERT INTO dbo.Empresa(codigo_empresa,id_em_maestra,id_usuario)VALUES
(@cod_empresa,(SELECT TOP(1)id_em_maestra FROM dbo.Empresa_maestra ORDER BY id_em_maestra DESC),@id_usuario)		
END
GO


--INSERT SUCURSAL
CREATE PROC SP_INSERT_SUCURSAL
@cod_sucursal varchar(8),
@id_empresa int
AS BEGIN
INSERT INTO dbo.Sucursal(codigo_sucursal,id_em_maestra,id_empresa)VALUES
(@cod_sucursal,(SELECT TOP(1) id_em_maestra FROM dbo.Empresa_maestra ORDER BY id_em_maestra DESC),@id_empresa)		
END
GO

--DROP PROCEDURE SP_SUCURSAL

--UPDATE EMPRESA MAESTRA
CREATE PROC SP_UPDATE_EMPRESAMAESTRA
@razon_social varchar(50),
@direccion nvarchar(250),
@domicilio nvarchar(250),
@ruc char(11),
@regimen varchar(50),
@localidad varchar(50),
@id_emmaestra int
AS BEGIN
UPDATE dbo.Empresa_maestra SET razon_social=@razon_social, direccion=@direccion,
domicilio_fiscal=@domicilio, ruc=@ruc, regimen=@regimen,localidad=@localidad WHERE id_em_maestra=@id_emmaestra
END
GO


CREATE PROC SP_UPDATE_EMPRESA
@cod_empresa varchar(8),
@id_usuario int,
@id_emmaestra int	
AS BEGIN
UPDATE dbo.Empresa SET codigo_empresa=@cod_empresa, id_usuario=@id_usuario 
WHERE id_em_maestra=@id_emmaestra
END
GO

--UPDATE SUCURSAL
CREATE PROC SP_UPDATE_SUCURSAL
@cod_sucursal varchar(8),
@id_empresa int,
@id_emmaestra int
AS BEGIN
UPDATE dbo.Sucursal SET codigo_sucursal=@cod_sucursal, id_empresa=@id_empresa
WHERE id_em_maestra=@id_emmaestra
END
GO

--REMOVE EMPRESA MAESTRA
CREATE PROC SP_REMOVE_EMPRESA
@id_maestra int,
@mesage varchar(50) OUTPUT
AS BEGIN	
	IF(EXISTS(SELECT * FROM dbo.Empresa_maestra em join dbo.Empleado e on em.id_em_maestra= e.id_em_maestra WHERE em.id_em_maestra=@id_maestra))
		BEGIN
			SET @mesage ='ACCESO DENEGADO'
		END
	ELSE
		BEGIN
			UPDATE dbo.Empresa_maestra SET estado_eliminado='ANULADO' WHERE id_em_maestra=@id_maestra
			SET @mesage='EMPRESA ELIMINADO'
		END
END
GO


CREATE PROC SP_REMOVE_SUCURSAL
@id_maestra int,
@mesage varchar(50) OUTPUT
AS BEGIN	
	IF(EXISTS(SELECT * FROM dbo.Empresa_maestra em join dbo.Empleado e on em.id_em_maestra= e.id_em_maestra WHERE em.id_em_maestra=@id_maestra))
		BEGIN
			SET @mesage ='ACCESO DENEGADO'
		END
	ELSE
		BEGIN
			UPDATE dbo.Empresa_maestra SET estado_eliminado='ANULADO' WHERE id_em_maestra=@id_maestra
			SET @mesage='SUCURSAL ELIMINADO'
		END
END
GO

--PROCEDIMIENTO MOSTRAR EMPRESA
ALTER PROC SP_SHOW_EMPRESA
AS BEGIN
SELECT TOP(200) em.id_em_maestra, em.estado_eliminado, u.id_usuario, e.id_em_maestra,e.id_empresa, e.codigo_empresa, em.razon_social,em.localidad,
direccion, domicilio_fiscal, em.ruc, em.regimen, u.referencia
FROM dbo.Empresa_maestra em right join dbo.Empresa e on em.id_em_maestra=e.id_em_maestra join dbo.Usuario u 
on e.id_usuario=u.id_usuario WHERE em.estado_eliminado ='NO ANULADO' ORDER BY e.id_empresa DESC
END
GO

--PROCEDIMIENTO MOSTRAR SUCURSAL
ALTER PROC SP_SHOW_SUCURSAL
AS BEGIN
SELECT TOP(200) em.estado_eliminado,s.id_em_maestra, e.id_empresa, s.codigo_sucursal, em.razon_social AS SUCURSAL, em.localidad,
direccion, domicilio_fiscal, em.ruc, em.regimen, usu.referencia AS USUARIO,
(SELECT ema.razon_social FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS EMPRESA 
FROM dbo.Empresa_maestra em join dbo.Sucursal s on em.id_em_maestra=s.id_em_maestra join 
dbo.Empresa e on e.id_empresa=s.id_empresa join dbo.Usuario usu on e.id_usuario=usu.id_usuario
WHERE em.estado_eliminado='NO ANULADO' ORDER BY S.id_sucursal DESC 
END
GO

/*   PROCEDIMIENTO PARA USUARIO*/
CREATE PROC SP_INSERT_USUARIO
(@idusu int,
@codigo_usu varchar(20),
@referencia varchar(50),
@passwor varchar(10),
@id_rol int,
@mesage varchar(100) output)
AS BEGIN
IF(EXISTS(SELECT u.codigo_usuario FROM dbo.Usuario u WHERE U.codigo_usuario=@codigo_usu))
	BEGIN
	SET @mesage= 'USUARIO ('+@codigo_usu+' ) SE ENCUENTRA REGISTRADO'
	END
ELSE
	BEGIN
	INSERT INTO dbo.Usuario(id_usuario, codigo_usuario, referencia, contrasena, id_rol)VALUES
	(@idusu, @codigo_usu, @referencia, @passwor, @id_rol)
	SET @mesage= 'USUARIO REGISTRADO'
	END
END
GO


 --UPDATE USUARIO
ALTER PROC SP_UPDATE_USUARIO
(@codigo_usu varchar(20),
@referencia varchar(50),
@passwor varchar(10),
@id_rol int,
@idusu int)
AS BEGIN
UPDATE dbo.Usuario SET codigo_usuario=@codigo_usu, referencia=@referencia, contrasena=@passwor, id_rol=@id_rol 
WHERE id_usuario=@idusu
END
GO

--REMOVE USUARIO
CREATE PROC SP_REMOVE_USUARIO
(@idusu int,
@mesage varchar(100) output)
AS BEGIN
IF(EXISTS(SELECT e.id_usuario FROM Usuario u join dbo.Empresa e on u.id_usuario=e.id_usuario WHERE u.id_usuario=@idusu))
BEGIN
	DECLARE @cod_usu varchar(20)
	SET @cod_usu=(SELECT u.codigo_usuario FROM Usuario u WHERE U.id_usuario=@idusu)
	SET @mesage='USUARIO ( '+@cod_usu+' ) ESTA SIENDO USADO'
END
ELSE
BEGIN
	DELETE FROM dbo.Usuario WHERE id_usuario=@idusu
	SET @mesage='USUARIO ELIMINADO'
END
END
GO

--ELIMINAR EMPLEADO
CREATE PROC SP_ELIM_EMPL
(@id_emp int)
AS BEGIN 
UPDATE dbo.Empleado SET eliminado_estado='ANULADO' WHERE id_empleado=@id_emp;
END
GO

--MOSTRAR USUARIO
ALTER PROC SP_SHOW_USER
AS BEGIN	
SELECT u.id_usuario, u.codigo_usuario, u.referencia, u.contrasena, u.id_rol, r.rol FROM 
dbo.Usuario u join Rol r on u.id_rol=r.id_rol ORDER BY u.id_usuario DESC
END
GO

/*     PROCEDIMIENTO ROL     */
CREATE PROC SP_INSERT_ROL
(@rol varchar(30))
AS BEGIN
INSERT INTO dbo.Rol(rol)VALUES(@rol)
END
GO

--UPDATE ROL
CREATE PROC SP_UPDATE_ROL
(@rol varchar(30),
@idrol int)
AS BEGIN
UPDATE dbo.Rol SET rol=@rol WHERE id_rol=@idrol
END
GO

--REMOVE ROL
--preparar condicion para rol=another user, que nadie elimine
CREATE PROC SP_REMOVE_ROL
(@idrol int,
@mesage varchar(100) output)
AS BEGIN
IF(EXISTS(SELECT u.id_rol FROM dbo.Rol r join dbo.Usuario u on r.id_rol=u.id_rol WHERE R.id_rol=@idrol))
BEGIN
	DECLARE @nom varchar(20)
	SET @nom= (select r.rol from Rol r where r.id_rol=@idrol)
	SET @mesage='ROL ( '+@nom+' ) ESTA EN USO'
END
ELSE
BEGIN
	DELETE FROM dbo.Rol WHERE id_rol=@idrol
	SET @mesage='ROL ELIMINADO'
END
END
GO

--MOSTRAR ROL
CREATE PROC SP_SHOW_ROL
AS
SELECT id_rol, rol FROM dbo.Rol ORDER BY id_rol DESC
GO

---------- PROCEDIMIENTOS GENERAR CODIGO AUTOMATICO ------------
CREATE PROC SP_GENERAR_USUARIO
(@usuario int output)
AS BEGIN
--DECLARE @usu int
SET @usuario=(SELECT count(u.id_usuario) FROM dbo.Usuario u)
IF(@usuario=0)
	BEGIN
		SET @usuario=1
	END
ELSE
	BEGIN
		SET @usuario=(SELECT MAX(u.id_usuario)+1 FROM dbo.Usuario u)
	END
END
GO

CREATE PROC SP_GENERAR_EMP
(@empleado int output)
AS BEGIN
SET @empleado=(SELECT count(e.id_empleado) FROM dbo.Empleado e)
IF(@empleado=0)
	BEGIN
		SET @empleado=1
	END
ELSE
	BEGIN
		SET @empleado=(SELECT MAX(e.id_empleado)+1 FROM dbo.Empleado e)
	END
END
GO

CREATE PROC SP_GENERAR_BANCO
(@Banco int output)
AS BEGIN
SET @Banco=(SELECT count(b.id_banco) FROM Banco b)
IF(@Banco=0)
	BEGIN
		SET @Banco=1
	END
ELSE
	BEGIN
		SET @Banco=(SELECT MAX(b.id_banco)+1 FROM Banco b)
	END
END
GO

CREATE PROC SP_GEN_TIPO_CONT
(@Tipocont int output)
AS BEGIN
SET @Tipocont=(SELECT COUNT(t.id_tipo_contrato) FROM Tipo_contrato t)
IF(@Tipocont=0)
	BEGIN
		SET @Tipocont=1
	END
ELSE
	BEGIN
		SET @Tipocont=(SELECT MAX(t.id_tipo_contrato)+1 FROM Tipo_contrato t)
	END
END
GO

CREATE PROC SP_GENERAR_CONTRATO
(@contrato int output)
AS BEGIN
SET @contrato=(SELECT count(c.id_contrato) FROM dbo.Contrato c)
IF(@contrato=0)
	BEGIN
		SET @contrato=1		
	END
ELSE
	BEGIN
		SET @contrato=(SELECT MAX(c.id_contrato)+1 FROM dbo.Contrato c)		
	END
END
GO

--GENERAR CODIGO MESES_MAESTRA
CREATE PROC SP_GENERAR_MESESMAESTRA
(@mesesm int output)
AS BEGIN
SET @mesesm=(SELECT count(mm.id_meses_maestra) FROM dbo.Meses_maestra mm)
IF(@mesesm=0)
	BEGIN
		SET @mesesm=1		
	END
ELSE
	BEGIN
		SET @mesesm=(SELECT MAX(mm.id_meses_maestra)+1 FROM dbo.Meses_maestra mm)		
	END
END
GO

--GENERAR CODIGO GRATI_MANTO
CREATE PROC SP_GENERAR_GRATIMANTO
(@gratimant int output)
AS BEGIN
SET @gratimant=(SELECT count(gm.id_grati) FROM dbo.Grati_manto gm)
IF(@gratimant=0)
	BEGIN
		SET @gratimant=1		
	END
ELSE
	BEGIN
		SET @gratimant=(SELECT MAX(gm.id_grati)+1 FROM dbo.Grati_manto gm)		
	END
END
GO

--GENERAR CODIGO FALTAS
CREATE PROC SP_GENERAR_FALTAS
(@faltas int output)
AS BEGIN
SET @faltas=(SELECT count(f.id_falta) FROM dbo.Faltas f)
IF(@faltas=0)
	BEGIN
		SET @faltas=1		
	END
ELSE
	BEGIN
		SET @faltas=(SELECT MAX(f.id_falta)+1 FROM dbo.Faltas f)
	END
END
GO

--GENERAR CODIGO CTS
CREATE PROC SP_GENERAR_CTS
(@cts int output)
AS BEGIN
SET @cts=(SELECT count(ct.id_cts) FROM dbo.cts ct)
IF(@cts=0)
	BEGIN
		SET @cts=1		
	END
ELSE
	BEGIN
		SET @cts=(SELECT MAX(c.id_cts)+1 FROM dbo.cts c)
	END
END
GO

--GENERAR CODIGO GRATIFICACIONES
CREATE PROC SP_GENERAR_GRATI
(@grati int output)
AS BEGIN
SET @grati=(SELECT count(g.id_grati) FROM dbo.Gratificaciones g)
IF(@grati=0)
	BEGIN
		SET @grati=1		
	END
ELSE
	BEGIN
		SET @grati=(SELECT MAX(c.id_grati)+1 FROM dbo.Gratificaciones c)
	END
END
GO

--GENERAR CODIGO CTS_MANTO
CREATE PROC SP_GENERAR_CTSMANTO
(@ctsmanto int output)
AS BEGIN
SET @ctsmanto=(SELECT count(cm.id_cts_manto) FROM dbo.cts_manto cm)
IF(@ctsmanto=0)
	BEGIN
		SET @ctsmanto=1		
	END
ELSE
	BEGIN
		SET @ctsmanto=(SELECT MAX(cm.id_cts_manto)+1 FROM dbo.cts_manto cm)
	END
END
GO

--GENERAR CODIGO Descuentos
CREATE PROC SP_GENERAR_Descuentos
(@desc int output)
AS BEGIN
SET @desc=(SELECT count(d.id_descuentos) FROM dbo.Descuentos d)
IF(@desc=0)
	BEGIN
		SET @desc=1		
	END
ELSE
	BEGIN
		SET @desc=(SELECT MAX(d.id_descuentos)+1 FROM dbo.Descuentos d)
	END
END
GO

--GENERAR CODIGO Planilla
CREATE PROC SP_GENERAR_Planilla
(@plani int output)
AS BEGIN
SET @plani=(SELECT count(p.id_planilla) FROM dbo.Planilla p)
IF(@plani=0)
	BEGIN
		SET @plani=1		
	END
ELSE
	BEGIN
		SET @plani=(SELECT MAX(p.id_planilla)+1 FROM dbo.Planilla p)
	END
END
GO

--GENERAR CODIGO Tipo Planilla
CREATE PROC SP_GENERAR_TipoPlanilla
(@tipoPlan int output)
AS BEGIN
SET @tipoPlan=(SELECT count(tp.id_tipo_planilla) FROM dbo.tipo_planilla tp)
IF(@tipoPlan=0)
	BEGIN
		SET @tipoPlan=1		
	END
ELSE
	BEGIN
		SET @tipoPlan=(SELECT MAX(tp.id_tipo_planilla)+1 FROM dbo.tipo_planilla tp)
	END
END
GO

--GENERAR CODIGO REGIMEN

CREATE PROC SP_GENERAR_REGIMEN
(@regimen int output)
AS BEGIN
SET @regimen=(SELECT count(r.codigo_regimen) FROM RegimenPensionario r)
IF(@regimen=0)
	BEGIN
		SET @regimen=1
	END
ELSE
	BEGIN
		SET @regimen=(SELECT MAX(r.codigo_regimen)+1 FROM dbo.RegimenPensionario r)
	END
END
GO

----	PROCEDIMIENTOS PARA LLENAR COMBOMBOX

CREATE PROC SP_EMPR
AS BEGIN
SELECT e.id_em_maestra,em.razon_social
FROM Empresa e
INNER JOIN Empresa_maestra em
on(em.id_em_maestra=e.id_em_maestra)
END
GO

--PROCEDIMENTO PARA REGISTRAR BANCO
CREATE PROC SP_INSERT_BANCO(
@id_banco int,
@nombre_banco varchar(25),
@mensaje varchar(100) output
)
AS BEGIN
	INSERT INTO BANCO(id_banco,nombre_banco) VALUES(@id_banco,@nombre_banco)
	SET @mensaje= 'BANCO REGISTRADO CORRECTAMENTE'
END
GO


--PROCEDIMENTO PARA ACTUALIZAR BANCO
CREATE PROC SP_UPDATE_BANCO(
@id_banco int,
@nombre_banco varchar(25)
)
AS BEGIN 
UPDATE Banco SET id_banco=@id_banco,nombre_banco=@nombre_banco where id_banco=@id_banco
END;
GO

--PROCEDIMENTO PARA ELIMINAR BANCO
CREATE PROC SP_DEL_BANCO(
@id_banco int,
@message varchar(100) output
)
AS BEGIN 
IF(EXISTS(SELECT b.id_banco from Banco b join Contrato c on(c.id_banco=b.id_banco) where c.id_banco=@id_banco))
	BEGIN
		DECLARE @cod_banco varchar(20);
		SET @cod_banco=(SELECT b.nombre_banco from Banco b WHERE b.id_banco=@id_banco)
		SET @message='EL BANCO ('+@cod_banco+') ESTA SIENDO USADO'  
	END
ELSE
	BEGIN 
		DELETE from Banco where id_banco=@id_banco
		SET @message='EL BANCO FUE ELIMINADO'
	END
END
GO

--PROCEDIMIENTO PARA MOSTRAR BANCO 
ALTER PROC SP_SHOW_BANCO
AS BEGIN 
SELECT b.id_banco,b.nombre_banco from Banco b; 
END;
GO

EXEC SP_SHOW_BANCO

--PROCEDIMIENTO PARA REGISTRAR TIPO CONTRATO
CREATE PROC SP_INSERT_TIP_CONT(
@id_tip_cont int,
@tiempo_contrato varchar(30),
@mensaje varchar(100) output
)
AS BEGIN
INSERT INTO Tipo_contrato(id_tipo_contrato, tiempo_contrato) VALUES(@id_tip_cont,@tiempo_contrato)
SET @mensaje= 'TIPO DE CONTRATO REGISTRADO CORRECTAMENTE'
END
GO

--sp_rename 'Tipo_contrato.tiempo_contato','tiempo_contrato'

--PROCEDIMIENTO PARA ACTUALIZAR TIPO CONTRATO 
alter PROC SP_UPDATE_TIP_CONT(
@id_tip_cont int,
@tipo_contrato varchar(30)
)
AS BEGIN 
UPDATE Tipo_contrato SET tiempo_contrato=@tipo_contrato where id_tipo_contrato=@id_tip_cont
END;
GO

exec SP_UPDATE_TIP_CONT 1 ,'Contrato Indefinidos'

--PROCEDIMIENTO PARA MOSTRAR TIPO CONTRATO 
ALTER PROC SP_SHOW_TIP_CONT
AS BEGIN 
SELECT id_tipocontrato, tiempo_contrato from Tipo_contrato;
END
GO

 ------------------------------------PROCEDIMIENTO PARA LOGIN--------------------------------------------
 
 --PROCEDIMIENTO LOGIN USUARIO
 CREATE PROC SP_LOGIN_USUARIO
 @user varchar(50),
 @pass varchar(10)
 AS BEGIN
 select u.id_usuario, u.codigo_usuario,u.referencia,r.rol from Usuario u join Rol r on u.id_rol=r.id_rol 
 WHERE (u.codigo_usuario=@user or referencia=@user) and contrasena=@pass
 END
 GO


 -- SEGUN EL CODIGO DE USUARIO MOSTRAR LAS EMPRESAS QUE EL USUARIO TIENE A CARGO TAMBIEN LAS SUCURSALES.
CREATE PROC SP_EMPRESAS_USUARIO
@codigo_user int
AS BEGIN
SELECT (SELECT ema.razon_social FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS EMPRESA, 
e.id_em_maestra AS [codigo_empresa],
(SELECT ema.localidad FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS [LOCALIDAD_EMPRESA],
em.razon_social AS SUCURSAL,s.id_em_maestra AS[codigo_sucursal], em.localidad AS [LOCALIDAD_SUCURSAL]
FROM dbo.Empresa_maestra em join dbo.Sucursal s on em.id_em_maestra=s.id_em_maestra  right join 
dbo.Empresa e on e.id_empresa=s.id_empresa where e.id_usuario=@codigo_user
END
GO
------------------------------------------------------FIN LOGIN ---------------------------------------------------------------------

--PROCEDIMIENTO PARA AGREGAR REGIMEN PENSIONARIO
CREATE PROCEDURE SP_ADD_REGIMEN(
@descripcion_corta varchar(30),
@descripcion varchar(100),
@tipo_regimen varchar(10),
@mensaje varchar(100) output)
AS BEGIN
INSERT INTO RegimenPensionario(descripcion_corta,descripcion,tipo_regimen)
VALUES(@descripcion,@descripcion_corta,@tipo_regimen)
SET @mensaje= 'REGIMEN REGISTRADO CORRECTAMENTE'
END
GO

CREATE PROCEDURE SP_SHOW_REGIMENPENSIONARIO
AS BEGIN 
SELECT r.codigo_regimen,r.descripcion,r.descripcion_corta,r.tipo_regimen 
from RegimenPensionario r
END
GO


alter PROC SP_UPDATE_REGIMEN
@codigo_regimen int,
@descripcion_corta varchar(30),
@descripcion varchar(100),
@tipo_regimen varchar(30)
AS BEGIN
UPDATE RegimenPensionario SET descripcion_corta=@descripcion_corta, descripcion=@descripcion, tipo_regimen=@tipo_regimen WHERE codigo_regimen=@codigo_regimen
END
GO

alter PROC SP_DELETE_REGIMEN
@codigo_regimen int,
@mensaje varchar(100) output
AS BEGIN
DELETE from RegimenPensionario where codigo_regimen=@codigo_regimen
SET @mensaje= 'REGIMEN ELIMINADO CORRECTAMENTE'
END
GO



--PROCEDIMIENTO PARA INSERTAR PLANILLA
alter PROC SP_INSERT_PLANILLA
@id_planilla int,
--@id_tipo_planilla varchar(20),
@id_periodo int,
--@id_mes varchar(50),
@fecha_inicial date,
@fecha_final date,
@fecha_pago date,
@dias_mes int,
@horas_mes int,
@remu_basica decimal(10,2),
@asig_familiar decimal(10,2),
@tope_horario_nocturno int,
@mesage varchar(100) output
AS BEGIN
	INSERT INTO dbo.Planilla(id_planilla,id_periodo,fecha_inicial , fecha_final,fecha_pago, dias_mes,horas_mes,remu_basica,asig_familiar,tope_horario_nocturno)VALUES
	(@id_planilla,@id_periodo,@fecha_inicial, @fecha_final, @fecha_pago, @dias_mes,@horas_mes,@remu_basica,@asig_familiar,@tope_horario_nocturno)
	SET @mesage= 'PLANILLA REGISTRADO'
	
END
GO


create PROC SP_UPDATE_PLANILLA
@id_planilla int,
@id_periodo int,
@fecha_inicial date,
@fecha_final date,
@fecha_pago date,
@dias_mes int,
@horas_mes int,
@remu_basica decimal(10,2),
@asig_familiar decimal(10,2),
@tope_horario_nocturno int
AS BEGIN
UPDATE Planilla SET id_periodo=@id_periodo, @fecha_inicial=@fecha_inicial, fecha_final=@fecha_final,fecha_pago=@fecha_pago,
dias_mes=@dias_mes,horas_mes=@horas_mes,remu_basica=@remu_basica,asig_familiar=@asig_familiar
WHERE id_planilla=@id_planilla
END
GO

create PROC SP_SHOW_PLANILLA
AS BEGIN
	SELECT pe.periodo, p.fecha_inicial , p.fecha_final,p.fecha_pago, p.dias_mes,p.horas_mes,p.remu_basica,p.asig_familiar,p.tope_horario_nocturno
	FROM Planilla p 
	inner join Periodo pe
	on(pe.id_periodo=p.id_periodo)
	END
GO



/*   SCRIP PARA PERIODO       */
ALTER PROC SP_SHOW_PERIODO
@periodo int,
@idperiodo int output
AS BEGIN
	SET @idperiodo=(SELECT p.id_periodo FROM dbo.Periodo p WHERE p.periodo=@periodo)		
END
GO

exec SP_SHOW_PERIODO 1,2019
