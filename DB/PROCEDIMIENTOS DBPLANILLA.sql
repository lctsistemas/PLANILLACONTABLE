USE Planilla_lct
GO

/*    PROCEDIMIENTOD ALMACENADOS PARA CARGO    */
CREATE PROC SP_REGISTRAR_CARGO
@nom varchar(40),
@descripcion nvarchar(100)
AS BEGIN
INSERT INTO Cargo(nombre_cargo,descripcion)
VALUES(@nom,@descripcion) 
END 
GO

CREATE PROC SP_UPDATE_CARGO
@idcargo int,
@nom varchar(40),
@descripcion nvarchar(100)
AS BEGIN
UPDATE Cargo SET nombre_cargo=@nom, descripcion=@descripcion WHERE id_cargo=@idcargo
END
GO

ALTER PROC SP_DELETE_CARGO
@idcargo int,
@message varchar(100) output
AS BEGIN
IF(EXISTS(SELECT c.id_cargo FROM Empleado E join Cargo C on E.id_cargo=C.id_cargo WHERE C.id_cargo=@idcargo))
	BEGIN
	DECLARE @resul VARCHAR(20)
	SET @resul=(SELECT c.nombre_cargo FROM Cargo c WHERE c.id_cargo=@idcargo)
	SET @message='Cargo( '+@resul+' ) esta en uso'
	END
ELSE
	BEGIN
	DELETE FROM Cargo WHERE id_cargo=@idcargo
	SET @message='¡Eliminado!'
	END	
END
GO


ALTER PROC SP_SELECT_CARGO 
AS BEGIN
SELECT id_cargo, nombre_cargo, descripcion 
FROM Cargo order by id_cargo desc
END
GO


/*    PROCEDIMIENTO TIPO DE DOCUMENTO     */
ALTER PROC SP_REGISTRAR_DOCUMENTO
@nom varchar(50),
@descripcion nvarchar(100),
@cod_doc char(2),
@mensaje varchar(25) OUTPUT
AS BEGIN
IF(EXISTS(SELECT t.codigo_doc  FROM Tipo_documento t WHERE t.codigo_doc = @cod_doc)) -- crear index
	SET @mensaje ='Codigo  ya existe'
ELSE 
BEGIN
	INSERT INTO Tipo_documento(nombre,descripcion,codigo_doc)
	VALUES(@nom,@descripcion,@cod_doc)
	SET @mensaje = '¡Registrado!'
END

END
GO


alter PROC SP_UPDATE_DOCUMENTO
@iddocumento int,
@cod_doc char(2),
@nom varchar(50),
@descripcion nvarchar(100)
AS BEGIN
UPDATE Tipo_documento SET nombre=@nom, descripcion=@descripcion,codigo_doc=@cod_doc
WHERE id_documento=@iddocumento
END
GO


ALTER PROC SP_DELETE_DOCUMENTO
@iddocumento int,
@message varchar(100) output
AS BEGIN
IF(EXISTS(SELECT t.id_documento FROM Empleado E join Tipo_documento t on E.id_documento=t.id_documento WHERE t.id_documento=@iddocumento))
	BEGIN
	DECLARE @resul VARCHAR(20)
	SET @resul=(SELECT t.nombre FROM dbo.Tipo_documento t WHERE t.id_documento=@iddocumento)
	SET @message='Documento ( '+@resul+' ) esta en uso.'
	END
ELSE
	BEGIN
	DELETE FROM Tipo_documento WHERE id_documento=@iddocumento
	SET @message='¡Eliminado!'
	END	
END
GO


ALTER PROC SP_SELECT_DOCUMENTO 
AS BEGIN
SELECT id_documento,codigo_doc,nombre,descripcion FROM 
Tipo_documento 
END
GO


/*        PROCEDIMIENTO ALMACENADO PARA EMPLEADO      */
ALTER PROC SP_ADD_EMPLEADO(
@codigo varchar(20),--sera número de documento.
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
@jornada_laboral varchar(11),
--PARAMETROS DE CONTRATO
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
@id_salud int,
@mensaje varchar(200) output)
AS BEGIN 	
DECLARE @RazonSocial VARCHAR(50)
SET @RazonSocial =(SELECT em.razon_social from Empleado e JOIN  Empresa_maestra em ON (e.id_em_maestra=em.id_em_maestra) 
WHERE e.estado='ACTIVO' AND e.codigo=@codigo) --FALTA CREAR UN INDEX PARA ESTA CONSULTA

IF(@RazonSocial != '')
	SET @mensaje = 'Colaborador está (ACTIVO) EN: '+ @RazonSocial
ELSE 		
BEGIN
	DECLARE @idempleado int
	SET @idempleado=(SELECT count(e.id_empleado) FROM dbo.Empleado e)
	IF(@idempleado=0)	
		SET @idempleado=1	
	ELSE
		SET @idempleado=(SELECT MAX(e.id_empleado)+1 FROM dbo.Empleado e)
	BEGIN TRANSACTION 
		BEGIN TRY	
			INSERT INTO dbo.Empleado(id_empleado,codigo,nombre_empleado, ape_paterno, ape_materno, fecha_nacimiento, nacionalidad, 
			tipo_genero,direccion,telefono, numero_documento, estado, codigo_regimen, id_documento, id_cargo, id_em_maestra,
			jornada_laboral ,eliminado_estado) 
			VALUES (@idempleado, @codigo, @nom_emp, @ape_pat, @ape_mat, @fec_nac, @nacionalidad, @tip_ge, @direccion, @telefono, @num_doc, @estado,
			@codigo_regimen, @id_documento, @id_cargo, @id_empresa_maestra, @jornada_laboral, 'NO ANULADO')			

			INSERT INTO dbo.Contrato(id_contrato, id_empleado, id_banco, id_tipocontrato, fecha_inicio,
			fecha_fin, numero_cuenta, remuneracion_basica, asignacion_familiar, tipo_pago, 
			periodicidad, tipo_moneda, cuenta_cts, cussp, id_rsalud)
			VALUES(@idempleado, @idempleado, @id_banco,
			@id_tcontrato, @fecha_inicio, @fecha_fin, @num_cuenta, @remu_basica, @asig_fami, @tipo_pago, 
			@periodicidad, @tipo_modeda, @cuenta_cts, @cussp, @id_salud)
			SET @mensaje= '¡Colaborador registrado!'
			COMMIT TRANSACTION

		END TRY
		BEGIN CATCH
			SET @mensaje= ERROR_MESSAGE()
			ROLLBACK TRANSACTION
		END CATCH
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
@jornada_laboral varchar(11),
@codigo_regimen int,
@id_documento int,
@id_cargo int,
@id_empleado int,
--PARAMETROS DE CONTRATO
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
BEGIN TRANSACTION
	BEGIN TRY
		UPDATE Empleado SET codigo=@codigo, nombre_empleado=@nom_emp, ape_paterno=@ape_pat, ape_materno=@ape_mat,
		fecha_nacimiento=@fec_nac, nacionalidad=@nacionalidad, tipo_genero=@tip_ge, direccion=@direccion,
		telefono=@telefono, numero_documento=@num_doc, estado=@estado, jornada_laboral=@jornada_laboral, codigo_regimen=@codigo_regimen,
		id_documento=@id_documento, id_cargo=@id_cargo WHERE id_empleado=@id_empleado

		UPDATE Contrato SET id_banco=@id_banco, id_tipocontrato=@id_tcontrato, fecha_inicio=@fecha_inicio,
		fecha_fin=@fecha_fin, numero_cuenta=@num_cuenta, remuneracion_basica=@remu_basica, 
		asignacion_familiar=@asig_fami, tipo_pago=@tipo_pago, periodicidad=@periodicidad, 
		tipo_moneda=@tipo_modeda, cuenta_cts=@cuenta_cts, cussp=@cussp, id_rsalud=@id_salud 
		WHERE id_empleado=@id_empleado
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		print ERROR_MESSAGE()
		ROLLBACK TRANSACTION
	END CATCH
END
GO

ALTER PROC SP_ANULAR_EMPLEADO
(@id_emp int,
@mensaje varchar(100) OUTPUT)
AS BEGIN 
IF(EXISTS(SELECT ds.id_empleado FROM Det_subsidios ds JOIN Empleado e ON (ds.id_empleado=e.id_empleado) 
WHERE ds.id_empleado=@id_emp))
SET @mensaje='No puedes Anular, Otra tabla hace refencia al colaborador'
ELSE
BEGIN
UPDATE dbo.Empleado SET eliminado_estado='ANULADO' WHERE id_empleado=@id_emp;
SET  @mensaje='!Colaborador Anulado!'
END
END
GO

--empleado tener que eliminar ya no ese estado, y mostrar cesado y activos.
ALTER PROC SP_SHOW_EMPLEADO --MOSTRAR EMPLEADO Y AL SELECCIONAR MOSTRAR CONTRATO-- CONCAT(e.ape_paterno,SPACE(2), e.ape_materno,SPACE(2), e.nombre_empleado)
@codigo_empresa int
AS BEGIN 
SELECT e.id_empleado, e.codigo, e.ape_paterno, e.ape_materno, e.nombre_empleado,
em.id_em_maestra ,em.razon_social AS 'EMPRESA' FROM Empleado e INNER JOIN Empresa_maestra em 
on(e.id_em_maestra=em.id_em_maestra) WHERE e.eliminado_estado='NO ANULADO' AND e.id_em_maestra=@codigo_empresa 
ORDER BY e.id_empleado DESC
END
GO

ALTER PROC SP_SHOW_EMPLEADO_CONTRATO
@codigo_empleado int
AS BEGIN 
SELECT e.codigo, e.nombre_empleado, e.ape_paterno, e.ape_materno,e.fecha_nacimiento,
e.nacionalidad, e.tipo_genero, e.direccion, e.telefono, e.numero_documento, e.estado, e.codigo_regimen, 
r.descripcion, e.id_documento, t.nombre, e.id_cargo, c.nombre_cargo, e.Jornada_laboral, co.id_banco, b.nombre_banco,
co.id_tipocontrato, ti.tiempo_contrato, co.fecha_inicio, co.fecha_fin, co.numero_cuenta, 
co.remuneracion_basica, co.asignacion_familiar, co.id_rsalud, re.descripcion_rsalud, co.tipo_pago, co.periodicidad, 
co.tipo_moneda, co.cuenta_cts, co.cussp 
FROM Empleado e JOIN RegimenPensionario r on(e.codigo_regimen = r.codigo_regimen) JOIN Tipo_documento t
on(e.id_documento = t.id_documento) JOIN Cargo c on(e.id_cargo = c.id_cargo) JOIN Contrato co
on(e.id_empleado = co.id_empleado) JOIN Banco b on(b.id_banco = co.id_banco) JOIN Tipo_contrato ti 
on(co.id_tipocontrato = ti.id_tipocontrato) JOIN Regimen_salud re on(co.id_rsalud=re.id_regimen_salud)
WHERE e.id_empleado=@codigo_empleado
END
GO
                                                                                                                                                                                                                                               
GO
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
		set @mesage='¡Codigo Empresa Ya Exite!'
	END
ELSE IF(EXISTS(SELECT codigo_sucursal FROM Sucursal WHERE codigo_sucursal=@cod_empresa_validar))
	BEGIN
		set @mesage='¡Codigo Sucursal Ya Exite!'
	END
ELSE
	BEGIN
	DECLARE @codigo int
	SET @codigo=(SELECT count(epm.id_em_maestra) FROM dbo.Empresa_maestra epm)
		IF(@codigo=0)
			SET @codigo=1	
		ELSE
			SET @codigo=(SELECT MAX(epm.id_em_maestra)+1 FROM dbo.Empresa_maestra epm)	

		INSERT INTO dbo.Empresa_maestra(id_em_maestra, razon_social,direccion,domicilio_fiscal,ruc,regimen,estado_eliminado,localidad)
		VALUES(@codigo, @razon_social,@direccion,@domicilio,@ruc,@regimen,'NO ANULADO', @localidad)
		set @mesage='¡Se registro Exitosamente!'
	END
END
GO

--SELECT * FROM DBO.Empresa_maestra

ALTER PROC SP_INSERT_EMPRESA
@cod_empresa varchar(8),
@id_usuario int
AS BEGIN
DECLARE @cod_emp int
SET @cod_emp=(SELECT count(emp.id_empresa) FROM dbo.Empresa emp)
IF(@cod_emp=0)
	SET @cod_emp=1	
ELSE
	SET @cod_emp=(SELECT MAX(emp.id_empresa)+1 FROM dbo.Empresa emp)
	
INSERT INTO dbo.Empresa(id_empresa ,codigo_empresa,id_em_maestra,id_usuario)VALUES
(@cod_emp ,@cod_empresa,(SELECT TOP(1)id_em_maestra FROM dbo.Empresa_maestra ORDER BY id_em_maestra DESC),@id_usuario)		
END
GO


ALTER PROC SP_INSERT_SUCURSAL
@cod_sucursal varchar(8),
@id_empresa int
AS BEGIN
DECLARE @cod_sucur int
SET @cod_sucur=(SELECT count(suc.id_sucursal) FROM dbo.Sucursal suc)
IF(@cod_sucur=0)
	SET @cod_sucur=1	
ELSE
	SET @cod_sucur=(SELECT MAX(suc.id_sucursal)+1 FROM dbo.Sucursal suc)

INSERT INTO dbo.Sucursal(id_sucursal ,codigo_sucursal,id_em_maestra,id_empresa)VALUES
(@cod_sucur ,@cod_sucursal,(SELECT TOP(1) id_em_maestra FROM dbo.Empresa_maestra ORDER BY id_em_maestra DESC),@id_empresa)		
END
GO


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


CREATE PROC SP_UPDATE_SUCURSAL
@cod_sucursal varchar(8),
@id_empresa int,
@id_emmaestra int
AS BEGIN
UPDATE dbo.Sucursal SET codigo_sucursal=@cod_sucursal, id_empresa=@id_empresa
WHERE id_em_maestra=@id_emmaestra
END
GO


ALTER PROC SP_REMOVE_EMPRESA
@id_maestra int,
@mesage varchar(50) OUTPUT
AS BEGIN	
	IF(EXISTS(SELECT e.id_em_maestra FROM dbo.Empresa_maestra em join dbo.Empleado e on em.id_em_maestra= e.id_em_maestra
	WHERE em.id_em_maestra=@id_maestra))
		BEGIN
			SET @mesage ='Acceso denagado, Empresa tiene colaboradores.'
		END
	ELSE
		BEGIN
			UPDATE dbo.Empresa_maestra SET estado_eliminado='ANULADO' WHERE id_em_maestra=@id_maestra
			SET @mesage='¡Anulado!'
		END
END
GO



ALTER PROC SP_REMOVE_SUCURSAL
@id_maestra int,
@mesage varchar(50) OUTPUT
AS BEGIN	
	IF(EXISTS(SELECT e.id_em_maestra FROM dbo.Empresa_maestra em join dbo.Empleado e on 
	em.id_em_maestra= e.id_em_maestra WHERE em.id_em_maestra=@id_maestra))
		BEGIN
			SET @mesage ='Acceso denagado, Sucursal tiene colaboradores.'
		END
	ELSE
		BEGIN
			UPDATE dbo.Empresa_maestra SET estado_eliminado='ANULADO' WHERE id_em_maestra=@id_maestra
			SET @mesage='¡Anulado!'
		END
END
GO


ALTER PROC SP_SHOW_EMPRESA
AS BEGIN
SELECT TOP(200) em.id_em_maestra, em.estado_eliminado, u.id_usuario, e.id_em_maestra,e.id_empresa, e.codigo_empresa, em.razon_social, em.localidad,
direccion, domicilio_fiscal, em.ruc, em.regimen, u.nombre_usuario
FROM dbo.Empresa_maestra em right join dbo.Empresa e on em.id_em_maestra=e.id_em_maestra join dbo.Usuario u 
on e.id_usuario=u.id_usuario WHERE em.estado_eliminado ='NO ANULADO' ORDER BY e.id_empresa DESC
END
GO


ALTER PROC SP_SHOW_SUCURSAL
AS BEGIN
SELECT TOP(200) em.estado_eliminado,s.id_em_maestra, e.id_empresa, s.codigo_sucursal, em.razon_social AS SUCURSAL, em.localidad,
direccion, domicilio_fiscal, em.ruc, em.regimen, usu.nombre_usuario AS USUARIO,
(SELECT ema.razon_social FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS EMPRESA 
FROM dbo.Empresa_maestra em join dbo.Sucursal s on em.id_em_maestra=s.id_em_maestra join 
dbo.Empresa e on e.id_empresa=s.id_empresa join dbo.Usuario usu on e.id_usuario=usu.id_usuario
WHERE em.estado_eliminado='NO ANULADO' ORDER BY S.id_sucursal DESC 
END
GO


/*         PROCEDIMIENTO PARA USUARIO            */
ALTER PROC SP_INSERT_USUARIO(
@codigo_usu varchar(20),
@nom_user varchar(50),
@passwor varchar(10),
@genero char(1),
@id_rol int,
@mesage varchar(100) output)
AS BEGIN
IF(EXISTS(SELECT u.codigo_usuario FROM dbo.Usuario u WHERE U.codigo_usuario=@codigo_usu))
	BEGIN
	SET @mesage= 'Usuario ('+@codigo_usu+' ) ya existe.'
	END
ELSE
	BEGIN
	DECLARE @usu int
	SET @usu=(SELECT count(u.id_usuario) FROM dbo.Usuario u)
	IF(@usu=0)
		SET @usu=1	
	ELSE
		SET @usu=(SELECT MAX(u.id_usuario)+1 FROM dbo.Usuario u)
	INSERT INTO dbo.Usuario(id_usuario, codigo_usuario, nombre_usuario, contrasena, genero, id_rol)VALUES
	(@usu, @codigo_usu, @nom_user, @passwor,@genero, @id_rol)
	SET @mesage= '¡Usuario registrado!'
	END
END
GO



ALTER PROC SP_UPDATE_USUARIO
(@codigo_usu varchar(20),
@nom_user varchar(50),
@passwor varchar(10),
@genero char(1),
@id_rol int,
@idusu int)
AS BEGIN
UPDATE dbo.Usuario SET codigo_usuario=@codigo_usu, nombre_usuario=@nom_user, 
contrasena=@passwor,genero=@genero, id_rol=@id_rol 
WHERE id_usuario=@idusu
END
GO


ALTER PROC SP_REMOVE_USUARIO
(@idusu int,
@mesage varchar(100) output)
AS BEGIN
IF(EXISTS(SELECT e.id_usuario FROM Usuario u join dbo.Empresa e on u.id_usuario=e.id_usuario WHERE u.id_usuario=@idusu))
BEGIN
	DECLARE @cod_usu varchar(20)
	SET @cod_usu=(SELECT u.codigo_usuario FROM Usuario u WHERE U.id_usuario=@idusu)
	SET @mesage='Usuario ( '+@cod_usu+' ) esta asignado'
END
ELSE
BEGIN
	DELETE FROM dbo.Usuario WHERE id_usuario=@idusu
	SET @mesage='¡Eliminado!'
END
END
GO


ALTER PROC SP_SHOW_USER
AS BEGIN	
SELECT u.id_usuario, u.codigo_usuario,u.nombre_usuario, u.contrasena, u.id_rol, r.descrip_rol, u.genero FROM 
dbo.Usuario u join Rol r on u.id_rol=r.id_rol ORDER BY u.id_usuario DESC
END
GO

/*     PROCEDIMIENTO ROL     */
ALTER PROC SP_INSERT_ROL
(@rol varchar(30))
AS BEGIN
INSERT INTO dbo.Rol(descrip_rol)VALUES(@rol)
END
GO

ALTER PROC SP_UPDATE_ROL
(@rol varchar(30),
@idrol int)
AS BEGIN
UPDATE dbo.Rol SET descrip_rol=@rol WHERE id_rol=@idrol
END
GO


ALTER PROC SP_REMOVE_ROL
(@idrol int,
@mesage varchar(100) output)
AS BEGIN
IF(EXISTS(SELECT u.id_rol FROM dbo.Rol r join dbo.Usuario u on r.id_rol=u.id_rol WHERE R.id_rol=@idrol))
BEGIN
	DECLARE @nom varchar(20)
	SET @nom= (select r.descrip_rol from Rol r where r.id_rol=@idrol)
	SET @mesage='Rol ( '+@nom+' ) esta en uso.'
END
ELSE
BEGIN
	DELETE FROM dbo.Rol WHERE id_rol=@idrol
	SET @mesage='¡Eliminado!'
END
END
GO


ALTER PROC SP_SHOW_ROL
AS
SELECT id_rol, descrip_rol FROM dbo.Rol ORDER BY id_rol DESC
GO


----	PROCEDIMIENTOS PARA LLENAR COMBOMBOX
alter PROC SP_REG_SALUD		
AS BEGIN
SELECT rs.id_regimen_salud,rs.descripcion_rsalud
FROM REGIMEN_SALUD rs
END
GO

--PROCEDIMIENTO PARA REGISTRAR TIPO DE PLANILLA
ALTER PROC SP_REGISTRAR_TipPLANILLA( 
@nombre_planilla varchar(30),
@mensaje varchar(20) OUTPUT
)
AS BEGIN
	DECLARE @TipPlan int
	SET @TipPlan=(SELECT count(tp.idtipo_planilla) FROM TIPO_PLANILLA tp)
	IF(@TipPlan=0)
		BEGIN
			SET @TipPlan=1
		END
	ELSE	
		SET @TipPlan=(SELECT MAX(tp.idtipo_planilla)+1 FROM TIPO_PLANILLA tp)	
INSERT INTO TIPO_PLANILLA(idtipo_planilla, nombre_planilla) VALUES(@TipPlan, @nombre_planilla)
SET @mensaje= '¡Registrado!'
END
GO

ALTER PROC SP_UPDATE_TIPOPLANILLA(
@nombre_planilla varchar(30),
@id_tipPlanilla int
)
AS BEGIN 
UPDATE TIPO_PLANILLA SET nombre_planilla=@nombre_planilla where idtipo_planilla=@id_tipPlanilla
END
GO

ALTER PROC SP_DELETE_TIP_PLANILLA
@idtipo_planilla int,
@mensaje varchar(50) output
AS BEGIN
IF(EXISTS(SELECT p.id_tipoplanilla from Planilla p join TIPO_PLANILLA tp on(p.id_tipoplanilla=tp.idtipo_planilla)
	WHERE p.id_tipoplanilla = @idtipo_planilla))
	BEGIN 
	SET @mensaje= 'Error, el tipo de planilla esta en uso'
	END 
ELSE 
	BEGIN
	DELETE from TIPO_PLANILLA where idtipo_planilla=@idtipo_planilla
	SET @mensaje= '¡Eliminado!'
	END
END
GO


CREATE PROC SP_SHOW_TIPO_PLAN
AS BEGIN 
SELECT tp.idtipo_planilla,tp.nombre_planilla from TIPO_PLANILLA tp;
END
GO

--PROCEDIMENTO PARA REGISTRAR BANCO
ALTER PROC SP_INSERT_BANCO(
@nombre_banco varchar(40),
@mensaje varchar(30) output
)
AS BEGIN
	DECLARE @idbanco int
	SET @idbanco=(SELECT count(b.id_banco) FROM Banco b)
	IF(@idbanco=0)
		BEGIN
			SET @idbanco=1
		END
	ELSE	
		SET @idbanco=(SELECT MAX(b.id_banco)+1 FROM Banco b)	
INSERT INTO BANCO(id_banco,nombre_banco) VALUES(@idbanco, @nombre_banco)
SET @mensaje= '¡Registrado!'
END
GO

--PROCEDIMENTO PARA ACTUALIZAR BANCO
ALTER PROC SP_UPDATE_BANCO(
@id_banco int,
@nombre_banco varchar(40)
)
AS BEGIN 
UPDATE Banco SET id_banco=@id_banco,nombre_banco=@nombre_banco where id_banco=@id_banco
END
GO

--PROCEDIMENTO PARA ELIMINAR BANCO
ALTER PROC SP_DEL_BANCO(
@id_banco int,
@message varchar(100) output
)
AS BEGIN 
IF(EXISTS(SELECT b.id_banco from Banco b join Contrato c on(b.id_banco=c.id_banco) where c.id_banco=@id_banco))
	BEGIN
		DECLARE @cod_banco varchar(20);
		SET @cod_banco=(SELECT b.nombre_banco from Banco b WHERE b.id_banco=@id_banco)
		SET @message='Denegado, ( '+@cod_banco+' ) esta  asignado.'  
	END
ELSE
	BEGIN 
		DELETE from Banco where id_banco=@id_banco
		SET @message='¡Eliminado!'
	END
END
GO



--PROCEDIMIENTO PARA MOSTRAR BANCO 
ALTER PROC SP_SHOW_BANCO
AS BEGIN 
SELECT b.id_banco,b.nombre_banco from Banco b
END
GO


--PROCEDIMIENTO PARA REGISTRAR TIPO CONTRATO
ALTER PROC SP_INSERT_TIP_CONT(
--@id_tip_cont int,
@tiempo_contrato varchar(30),
@mensaje varchar(100) output
)
AS BEGIN
DECLARE @Tipocont int
	SET @Tipocont=(SELECT COUNT(t.id_tipocontrato) FROM Tipo_contrato t)
	IF(@Tipocont=0)
		SET @Tipocont=1
	ELSE
		SET @Tipocont=(SELECT MAX(t.id_tipocontrato)+1 FROM Tipo_contrato t)
INSERT INTO Tipo_contrato(id_tipocontrato, tiempo_contrato) VALUES(@Tipocont,@tiempo_contrato)
SET @mensaje= '¡Registrado!'
END
GO

--PROCEDIMIENTO PARA ACTUALIZAR TIPO CONTRATO
ALTER PROC SP_UPDATE_TIP_CONT(
@id_tip_cont int,
@tipo_contrato varchar(30)
)
AS BEGIN 
UPDATE Tipo_contrato SET tiempo_contrato=@tipo_contrato where id_tipocontrato=@id_tip_cont
END;
GO

--PROCEDIMIENTO PARA MOSTRAR TIPO CONTRATO 
ALTER PROC SP_SHOW_TIP_CONT
AS BEGIN 
SELECT id_tipocontrato, tiempo_contrato from Tipo_contrato;
END
GO
exec SP_SHOW_TIP_CONT
GO

ALTER PROC SP_DELETE_TIPCONTRATO
@id_tcontrato int,
@message varchar(100) output
AS BEGIN 
IF(EXISTS(SELECT t.id_tipocontrato from Tipo_contrato t join Contrato c on(t.id_tipocontrato=c.id_tipocontrato) where t.id_tipocontrato = @id_tcontrato))
	BEGIN
		DECLARE @cod_Tcontrato varchar(20);
		SET @cod_Tcontrato=(SELECT t.tiempo_contrato FROM Tipo_contrato t WHERE t.id_tipocontrato=@id_tcontrato)
		SET @message='El ('+@cod_Tcontrato+') esta asignado.'  
	END
ELSE
	BEGIN 
		DELETE from Tipo_contrato where id_tipocontrato=@id_tcontrato
		SET @message='¡Eliminado!'
	END
END
GO

 ------------------------------------PROCEDIMIENTO PARA LOGIN-------------------------------------------- 
 
 --PROCEDIMIENTO LOGIN USUARIO
 ALTER PROC SP_LOGIN_USUARIO
 @user varchar(50),
 @descrip_rol varchar(30),
 @pass varchar(10)
 AS BEGIN
 select u.id_usuario, u.nombre_usuario, u.genero, r.descrip_rol from Usuario u join Rol r on u.id_rol=r.id_rol 
 WHERE (u.codigo_usuario=@user or nombre_usuario=@user)  and r.descrip_rol=@descrip_rol and u.contrasena=@pass
 END
 GO

 --select u.id_usuario, u.codigo_usuario from Usuario u
 -- SEGUN EL CODIGO DE USUARIO MOSTRAR LAS EMPRESAS QUE EL USUARIO TIENE A CARGO TAMBIEN LAS SUCURSALES.
ALTER PROC SP_EMPRESAS_USUARIO
@codigo_user int
AS BEGIN
SELECT (SELECT ema.ruc FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS [RUC], 
(SELECT ema.razon_social FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS EMPRESA, 
e.id_em_maestra AS [codigo_empresa],
(SELECT ema.localidad FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS [LOCALIDAD_EMPRESA],
em.razon_social AS SUCURSAL,s.id_em_maestra AS[codigo_sucursal], em.localidad AS [LOCALIDAD_SUCURSAL]
FROM dbo.Empresa_maestra em join dbo.Sucursal s on (em.id_em_maestra=s.id_em_maestra)  right join 
dbo.Empresa e on (e.id_empresa=s.id_empresa) where e.id_usuario=@codigo_user
END
GO
------------------------------------------------------FIN LOGIN ---------------------------------------------------------------------

--STAR PROCEDIMIENTO PARA AGREGAR REGIMEN PENSIONARIO
ALTER PROCEDURE SP_ADD_REGIMEN(
@descripcion_corta varchar(30),
@descripcion varchar(100),
@tipo_regimen varchar(10),
@mensaje varchar(20) output)
AS BEGIN
INSERT INTO RegimenPensionario(descripcion_corta,descripcion,tipo_regimen)
VALUES(@descripcion,@descripcion_corta,@tipo_regimen)
SET @mensaje= '¡Registrado!'
END
GO

CREATE PROCEDURE SP_SHOW_REGIMENPENSIONARIO
AS BEGIN 
SELECT r.codigo_regimen,r.descripcion,r.descripcion_corta,r.tipo_regimen 
from RegimenPensionario r
END
GO

CREATE PROC SP_UPDATE_REGIMEN
@codigo_regimen int,
@descripcion_corta varchar(30),
@descripcion varchar(100),
@tipo_regimen varchar(10)
AS BEGIN
UPDATE RegimenPensionario SET descripcion_corta=@descripcion_corta, 
descripcion=@descripcion, tipo_regimen=@tipo_regimen WHERE codigo_regimen=@codigo_regimen
END
GO

ALTER PROC SP_DELETE_REGIMEN 
@codigo_regimen int,
@mensaje varchar(100) output
AS BEGIN
IF(EXISTS(SELECT r.codigo_regimen FROM dbo.RegimenPensionario r INNER JOIN dbo.ComisionesPension co 
ON r.codigo_regimen=co.codigo_regimen WHERE r.codigo_regimen=@codigo_regimen)) 
OR (EXISTS(SELECT r.codigo_regimen FROM dbo.RegimenPensionario r INNER JOIN dbo.Empleado e ON 
r.codigo_regimen= e.codigo_regimen WHERE r.codigo_regimen=@codigo_regimen)) 
	SET @mensaje ='La operacion fue denegada, esta (asignado)'
ELSE 
BEGIN
	DELETE from RegimenPensionario where codigo_regimen=@codigo_regimen
	SET @mensaje= '¡Eliminado!'
END
END
GO

--STAR PROCEDIMIENTO PARA COMISIONES PENSIONES	
CREATE PROC SP_SHOW_MES
AS BEGIN
SELECT id_mes, nombre_mes FROM Mes
END
GO

ALTER PROCEDURE SP_SHOW_COMISIONPENSIONES
@idmes int =null,
@idperiodo int=null,
@tipo_regimen varchar(10)
AS BEGIN
	select r.codigo_regimen, r.descripcion, co.idcomision, co.comision, co.saldo, co.seguro, co.aporte, co.tope from 
	RegimenPensionario r  JOIN ComisionesPension co on (r.codigo_regimen=co.codigo_regimen) 
	WHERE (co.idmes=@idmes AND idperiodo=@idperiodo) AND r.tipo_regimen=@tipo_regimen
END
GO

CREATE PROC SP_SHOW_NUEVA_COMISION
AS BEGIN
select  r.codigo_regimen, r.descripcion from RegimenPensionario r
 LEFT JOIN ComisionesPension co on (r.codigo_regimen=co.codigo_regimen) where co.codigo_regimen is null
END
GO

CREATE PROC SP_INSERT_NUEVA_COMISIONES ---pendiente
@codigo_regimen int,
@comision decimal(6,2),
@saldo decimal(6,2) ,
@seguro decimal(6,2), 
@aporte decimal(6,2),
@tope  decimal(10,2),
@idmes int,
@idperiodo int
AS BEGIN

select max(id) +1 as canti from OPERA

	DECLARE @idcomi int
	
	IF(@idcomi=0)
		SET @idcomi=1
	ELSE
		SET @idcomi=(SELECT MAX(c.idcomision)+1 FROM dbo.ComisionesPension c)

	INSERT INTO dbo.ComisionesPension(idcomision, codigo_regimen,
	comision, saldo, seguro, aporte, tope, idmes, idperiodo) VALUES
	(@idcomi, @codigo_regimen, @comision, @saldo, @seguro, @aporte, @tope, @idmes, @idperiodo)
END		
GO


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
GO

ALTER PROC SP_INSERT_COMISION_ONP
@codigo_regimen int,
@comision decimal(6,2),
@idmes int,
@idperiodo int
AS BEGIN
DECLARE @idcomi int
	SET @idcomi=(SELECT count(c.idcomision) FROM dbo.ComisionesPension c)
	IF(@idcomi=0)
		SET @idcomi=1
	ELSE
		SET @idcomi=(SELECT MAX(c.idcomision)+1 FROM dbo.ComisionesPension c)

	INSERT INTO dbo.ComisionesPension(idcomision, codigo_regimen,
	comision, saldo, seguro, aporte, tope,idmes, idperiodo) VALUES
	(@idcomi, @codigo_regimen, @comision, 0, 0, 0, 0, @idmes, @idperiodo)
END
GO


CREATE PROC SP_UPDATE_COMISIONES
@comision decimal(6,2),
@saldo decimal(6,2) ,
@seguro decimal(6,2),
@aporte decimal(6,2),
@tope  decimal(10,2),
@idcomision int
AS BEGIN	
	UPDATE dbo.ComisionesPension SET comision=@comision, saldo=@saldo, seguro=@seguro, 
	aporte=@aporte, tope=@tope WHERE idcomision=@idcomision
END
GO

ALTER PROC SP_UPDATE_COMISIONES_ONP
@comision decimal(6,2),
@idcomision int
AS BEGIN	
	UPDATE dbo.ComisionesPension SET comision = @comision WHERE idcomision=@idcomision
END
GO



--  PROCEDIMIENTO PARA INSERTAR, UPDATE, DELETE, SHOW => PLANILLA
ALTER PROC SP_INSERT_PLANILLA
--@idtipo_planilla int,
@idtipo_planilla int,
@id_periodo int,
@id_empMaestra int,
@id_mes int,
@fecha_inicial date,
@fecha_final date,
@fecha_pago date,
@dias_mes int,
@horas_mes int,
@topehora_nocturno decimal(8,2),
@mesage varchar(50) output
AS BEGIN
	DECLARE @plani int
	SET @plani=(SELECT count(p.id_planilla) FROM dbo.Planilla p)
	IF(@plani=0)
		SET @plani=1
	ELSE
		SET @plani=(SELECT MAX(p.id_planilla)+1 FROM dbo.Planilla p)	
		
INSERT INTO Planilla(id_planilla, id_tipoplanilla, id_periodo, idempresa_maestra, id_mes, fecha_inicial, fecha_final, fecha_pago, 
dias_mes, horas_mes, tope_horario_nocturno)VALUES
(@plani, @idtipo_planilla, @id_periodo, @id_empMaestra, @id_mes, @fecha_inicial, @fecha_final, @fecha_pago, 
@dias_mes, @horas_mes, @topehora_nocturno) 
SET @mesage= '¡Registrado!'
END
GO

CREATE PROC SP_UPDATE_PLANILLA
@id_planilla int,
@fecha_pago date
AS BEGIN
UPDATE Planilla SET fecha_pago=@fecha_pago
WHERE id_planilla=@id_planilla
END
GO

ALTER PROC SP_DELETE_PLANILLA 
@idplanilla int,
@mensaje varchar(100) output
AS BEGIN
IF(EXISTS(SELECT pm.id_planilla FROM PlanillaManto pm JOIN Planilla p on (pm.id_planilla = p.id_planilla) 
WHERE p.id_planilla=@idplanilla)) BEGIN
	SET @mensaje = 'Error, la planilla tiene cálculo'
END
ELSE BEGIN
	DELETE from dbo.Planilla where id_planilla=@idplanilla
	SET @mensaje= '¡Eliminado!'
END
END
GO

ALTER PROC SP_SHOW_PLANILLA
@codigo_empresam int,
@periodo int
AS BEGIN
	SELECT p.id_planilla, pe.periodo, p.id_mes, p.idempresa_maestra, m.nombre_mes, p.fecha_inicial , p.fecha_final,p.fecha_pago,
	p.dias_mes, p.horas_mes, p.tope_horario_nocturno, tp.idtipo_planilla, tp.nombre_planilla
	FROM Planilla p inner join Periodo pe on(pe.id_periodo=p.id_periodo)
	inner join Mes m on(m.id_mes=p.id_mes) JOIN tipo_planilla tp on(p.id_tipoplanilla=tp.idtipo_planilla)
	where idempresa_maestra = @codigo_empresam and pe.id_periodo=@periodo
	order by m.id_mes asc
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


-- PROCEDIMIENTO PARA REGIMEN SALUD (ADD, UPDATE, DELETE Y SHOW)
ALTER PROCEDURE SP_ADD_REG_SAL(
@cod_regi_salud char(2),
@descripcion_rsalud nvarchar(100),
@mensaje varchar(100) output)
AS BEGIN
DECLARE @reg_salud int
SET @reg_salud=(SELECT count(rs.id_regimen_salud) FROM REGIMEN_SALUD rs)
IF(@reg_salud=0)	
	SET @reg_salud=1	
ELSE
	SET @reg_salud=(SELECT MAX(rs.id_regimen_salud)+1 FROM REGIMEN_SALUD rs)

INSERT INTO REGIMEN_SALUD(id_regimen_salud, cod_regi_salud, descripcion_rsalud)
VALUES(@reg_salud, @cod_regi_salud, @descripcion_rsalud)
SET @mensaje= '¡Registrado!'
END
GO


ALTER PROC SP_UPDATE_REG_SALUD
@id_regimen_salud int,
@cod_regimen_salud char(2),
@descripcion_rsalud nvarchar(100)
AS BEGIN
UPDATE REGIMEN_SALUD SET cod_regi_salud=@cod_regimen_salud, descripcion_rsalud=@descripcion_rsalud
WHERE id_regimen_salud=@id_regimen_salud
END
GO
select * from Regimen_salud
GO

GO


ALTER PROC SP_DELETE_REGSALUD 
@id_regimen_salud int,
@mensaje varchar(100) output
AS BEGIN
IF(EXISTS(SELECT  r.id_regimen_salud  from Contrato c join Regimen_salud r on(r.id_regimen_salud=c.id_rsalud)
	WHERE c.id_rsalud=@id_regimen_salud))
	BEGIN
		SET @mensaje= 'Error, Regimen Salud esta asignado a un contrato'
	END
ELSE
	BEGIN 
		DELETE from REGIMEN_SALUD where id_regimen_salud=@id_regimen_salud
		SET @mensaje= '¡Eliminado!'
	END
END
GO


ALTER PROC SP_SHOW_REG_SALUD 
AS BEGIN 
SELECT rs.id_regimen_salud,rs.cod_regi_salud,rs.descripcion_rsalud
from REGIMEN_SALUD rs
END
GO


/*     SCRIPT SUBSIDIOS  */
ALTER PROC SP_SHOW_DETSUBSIDIOS -- nos muestra lo que registramos
@idmes int,
@idperiodo int,
@idempleado int,
@tipoSubsidio varchar(30)
AS BEGIN
SELECT d.id_det_subsidios, s.cod_subsidio, CONCAT(s.cod_subsidio,' - ', s.tipo_suspension,' ', s.descripcion_corta) 
AS t_supension, d.dias FROM Det_subsidios d join Subsidios s on d.id_subsidios=s.id_subsidios 
WHERE (d.id_periodo=@idperiodo and d.id_mes=@idmes) and s.tipo_subsidio= @tipoSubsidio and d.id_empleado= @idempleado
END
GO


ALTER PROC SP_SHOW_SUBSIDIOS --MOSTRAR EN COMBOBOX SUBSIDIOS
@tipo_subsidio varchar(30)
AS BEGIN
SELECT s.id_subsidios, cod_subsidio, tipo_suspension, descripcion_corta FROM Subsidios s 
WHERE s.tipo_subsidio = @tipo_subsidio
END
GO

--MANTENIMIENTO DETALLE DE SUBSIDIOS (ADD,UPDATE,DELETE)
ALTER PROC SP_INSERT_SUBSIDIOS
@id_subsidios int,
@id_empleado int,
@id_mes int,
@id_periodo int,
@dias int
AS BEGIN
DECLARE @subsidio int
SET @subsidio=(SELECT count(ds.id_det_subsidios) FROM dbo.Det_subsidios ds)
IF(@subsidio=0)	
	SET @subsidio=1		
ELSE
	SET @subsidio=(SELECT MAX(ds.id_det_subsidios) + 1 FROM dbo.Det_subsidios ds)
INSERT INTO Det_subsidios(id_det_subsidios, id_subsidios, id_empleado, id_mes, id_periodo, dias)
VALUES(@subsidio, @id_subsidios, @id_empleado, @id_mes, @id_periodo, @dias)
END
GO

ALTER PROC SP_UPDATE_SUBSIDIOS
@dias int,
@id_detSubsidios int
AS BEGIN
UPDATE dbo.Det_subsidios SET dias=@dias WHERE id_det_subsidios=@id_detSubsidios
END
GO

ALTER PROC SP_DELETE_SUBSIDIOS
@id_detSubsidios int
AS BEGIN
DELETE FROM dbo.Det_subsidios WHERE id_det_subsidios=@id_detSubsidios
END
GO
------------------------------------------------------------------------
--MANTENIMIENTOS DE SUBSIDIO (ADD,UPDATE,DELETE,SHOW)

ALTER PROC SP_ADD_SUBSIDIOS
--@id_subsidios int,
@cod_subsidio char(2),
@tipo_suspension varchar(10),
@descripcion_corta nvarchar(70),
@descripcion_subsidio nvarchar(130),
@tipo_subsidio varchar(30),
@descuento bit,
@mensaje varchar(25) output
AS BEGIN
IF(EXISTS(SELECT s.cod_subsidio FROM Subsidios s WHERE s.cod_subsidio=@cod_subsidio))
	SET @mensaje='Codigo ya existe'
ELSE
BEGIN
	DECLARE @subsidio int
	SET @subsidio=(SELECT count(s.id_subsidios) FROM dbo.Subsidios s)
	IF(@subsidio=0)	
		SET @subsidio=1		
	ELSE
		SET @subsidio=(SELECT MAX(s.id_subsidios) + 1 FROM dbo.Subsidios s)
	INSERT INTO Subsidios(id_subsidios, cod_subsidio,tipo_suspension,descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
	VALUES(@subsidio, @cod_subsidio,@tipo_suspension,@descripcion_corta, @descripcion_subsidio, @tipo_subsidio, CAST(@descuento AS BIT))
	SET @mensaje= '¡Registrado!'
END
END
GO

ALTER PROC SP_MODIFY_SUBSIDIOS
@cod_subsidio char(2),
@tipo_suspension varchar(10),
@descripcion_corta nvarchar(70),
@descrip_subsidio nvarchar(130),
@tipo_subsidio varchar(30),
@descuento bit,
@id_subsidios int
AS BEGIN
UPDATE dbo.Subsidios SET cod_subsidio=@cod_subsidio, tipo_suspension=@tipo_suspension, 
descripcion_corta=@descripcion_corta, descripcion_subsidio=@descrip_subsidio,
tipo_subsidio=@tipo_subsidio, descuento=@descuento WHERE id_subsidios=@id_subsidios
END
GO

ALTER PROC SP_BORRAR_SUBSIDIOS
@id_subsidios int,
@mensaje varchar(60) output
AS BEGIN
IF(EXISTS(SELECT s.cod_subsidio FROM dbo.Subsidios s INNER JOIN dbo.Det_subsidios d ON(s.id_subsidios=d.id_subsidios) 
WHERE d.id_subsidios = @id_subsidios))
SET @mensaje ='Denegado, se encuentra asignado en empleado'
ELSE
	BEGIN
	DELETE FROM dbo.Subsidios WHERE id_subsidios=@id_subsidios
	SET @mensaje= '¡Eliminado!'
	END
END
GO

ALTER PROC SP_MOSTRAR_SUBSIDIOS
@tip_subsidio varchar(30)
AS BEGIN
SELECT id_subsidios, cod_subsidio,tipo_suspension, descripcion_corta, descripcion_subsidio, tipo_subsidio,descuento FROM Subsidios 
WHERE Subsidios.tipo_subsidio = @tip_subsidio
END
GO


/*         PROCEDIMIENTO PARA PLANILLA MANTO QUE ESTA TODO EL CALCULO             */
   --te mostrara empleados repetidos, es por las comisiones que estas registrando mensualmente es esta tabla es el where 
ALTER PROC SP_ShowPlanillaManto
@idplanilla int,
@idmes int,
@id_empresaMaestra int,
--@fechaini date,
@fechafin date
AS BEGIN
IF(NOT EXISTS(SELECT plam.id_planilla FROM dbo.PlanillaManto plam JOIN dbo.Planilla p ON(plam.id_planilla = p.id_planilla) WHERE p.id_planilla=@idplanilla))
BEGIN
SELECT co.id_contrato, e.jornada_laboral, do.codigo_doc, e.numero_documento, CONCAT(e.ape_paterno, ' ', e.ape_materno,', ',e.nombre_empleado) AS nombres, 
rp.descripcion,  cop.comision, cop.seguro, cop.aporte, ca.nombre_cargo, co.fecha_inicio, co.fecha_fin, co.remuneracion_basica, 
co.asignacion_familiar
FROM Empleado e JOIN RegimenPensionario rp on(e.codigo_regimen = rp.codigo_regimen) 
JOIN ComisionesPension cop on(cop.codigo_regimen=rp.codigo_regimen) 
JOIN Tipo_documento do on(e.id_documento=do.id_documento) 
JOIN Cargo ca on(ca.id_cargo = e.id_cargo) 
JOIN Contrato co on(co.id_empleado=e.id_empleado)
WHERE (cop.idmes =@idmes  AND e.id_em_maestra=@id_empresaMaestra) AND (co.fecha_inicio <=@fechafin)
END
/*ELSE
BEGIN
SELECT co.id_contrato, plama.idplanilla_manto, plama.jornadalaboral, do.codigo_doc, e.numero_documento, CONCAT(e.ape_paterno, ' ', e.ape_materno,', ',e.nombre_empleado) AS nombres, 
rp.descripcion,  cop.comision, cop.seguro, cop.aporte, ca.nombre_cargo, co.fecha_inicio, plama.basico, plama.dias, plama.dia_dominical, 
plama.horas_diarias, plama.asig_familiar, plama.hora_dvc, plama.minuto_dvc, plama.monto_dvc, plama.hora_dtc, plama.minuto_dtc, 
plama.monto_dtc, plama.hora_nvc, plama.minuto_nvc, plama.monto_nvc, plama.hora_ntc, plama.minuto_ntc, plama.monto_ntc, plama.hora_feriado, 
plama.minuto_feriado, plama.monto_feriado, plama.hora_boni, plama.monto_boni, plama.uno_mayo, plama.hora_tarde, plama.minuto_tarde, 
plama.monto_tarde, plama.dia_sub, plama.monto_sub, plama.dia_subnegativo, plama.monto_subnegativo, plama.dia_subpositivo, plama.monto_subpositivo, 
plama.total_horaex, plama.reintegro, plama.otro_reintegro, plama.pre_alimentaria, plama.gratiex, plama.boniex, plama.vacaciones, 
plama.vaca_trunca, plama.grati_trunca, plama.boni_trunca, plama.cts_trunca, plama.total_remuneracion, plama.descuento_onp, 
plama.des_comision, plama.des_seguro, plama.des_spp, plama.essalud_vida, plama.adelanto, plama.prestamo, plama.renta_quinta, 
plama.retencion_judicial, plama.otro_des, plama.total_desc, plama.total_pagar, plama.aporte_essalud, plama.transporte, plama.recargo_consumo, 
plama.reintegro_grati, plama.reintegro_boni
FROM Empleado e JOIN RegimenPensionario rp on(e.codigo_regimen = rp.codigo_regimen) 
JOIN ComisionesPension cop on(cop.codigo_regimen=rp.codigo_regimen) 
JOIN Tipo_documento do on(e.id_documento=do.id_documento) 
JOIN Cargo ca on(ca.id_cargo = e.id_cargo) 
JOIN Contrato co on(co.id_empleado=e.id_empleado) JOIN PlanillaManto  plama ON(plama.id_contrato=co.id_contrato)
WHERE (cop.idmes =@idmes  AND e.id_em_maestra=@id_empresaMaestra) --AND co.fecha_inicio  BETWEEN @fechaini AND @fechafin
END*/
END
GO

ALTER PROC SP_SHOW_PLANILLAMANTO_PRUEBA(
@idplanilla int,
@idmes int)
AS BEGIN
SELECT co.id_contrato, plama.idplanilla_manto, plama.jornadalaboral, do.codigo_doc, e.numero_documento, CONCAT(e.ape_paterno, ' ', e.ape_materno,', ',e.nombre_empleado) AS nombres, 
rp.descripcion,  plama.pvalor_comision, plama.pvalor_seguro, plama.pvalor_aporte, plama.pcargo, co.fecha_inicio, plama.basico, plama.dias, plama.dia_dominical, 
plama.horas_diarias, plama.sueldo_basico, plama.asig_familiar, plama.hora_dvc, plama.minuto_dvc, plama.monto_dvc, plama.hora_dtc, plama.minuto_dtc, 
plama.monto_dtc, plama.hora_nvc, plama.minuto_nvc, plama.monto_nvc, plama.hora_ntc, plama.minuto_ntc, plama.monto_ntc, plama.hora_feriado, 
plama.minuto_feriado, plama.monto_feriado, plama.hora_boni, plama.monto_boni, plama.uno_mayo, plama.hora_tarde, plama.minuto_tarde, 
plama.monto_tarde, plama.dia_sub, plama.monto_sub, plama.dia_subnegativo, plama.monto_subnegativo, plama.dia_subpositivo, plama.monto_subpositivo, 
plama.total_horaex, plama.reintegro, plama.otro_reintegro, plama.pre_alimentaria, plama.gratiex, plama.boniex, plama.vacaciones, 
plama.vaca_trunca, plama.grati_trunca, plama.boni_trunca, plama.cts_trunca, plama.total_remuneracion, plama.descuento_onp, 
plama.des_comision, plama.des_seguro, plama.des_spp, plama.essalud_vida, plama.adelanto, plama.prestamo, plama.renta_quinta, 
plama.retencion_judicial, plama.otro_des, plama.total_desc, plama.total_pagar, plama.aporte_essalud, plama.transporte, plama.recargo_consumo, 
plama.reintegro_grati, plama.reintegro_boni
FROM Empleado e JOIN RegimenPensionario rp on(e.codigo_regimen = rp.codigo_regimen) 
JOIN ComisionesPension cop on(cop.codigo_regimen=rp.codigo_regimen) 
JOIN Tipo_documento do on(e.id_documento=do.id_documento) 
JOIN Cargo ca on(ca.id_cargo = e.id_cargo) 
JOIN Contrato co on(co.id_empleado=e.id_empleado) 
JOIN PlanillaManto  plama ON(plama.id_contrato=co.id_contrato)
WHERE (cop.idmes = @idmes AND plama.id_planilla = @idplanilla)
END
GO

select * from PlanillaManto
delete from planillaManto

GO
ALTER PROCEDURE SP_REGISTRAR_PLANILLAMANTO( --73 campos
@id_contrato int,--1
@id_planilla int,--2
@id_tipo_planilla int,--3
@jornadalaboral varchar(11), --4
@pregimen_pension varchar(30),--5
@pvalor_comision decimal(6,2),--6
@pvalor_seguro decimal(6,2),--7
@pvalor_aporte decimal(6,2),--8
@pcargo varchar(40),--9
@basico money,--10
@dias int,--11
@dia_dominical int,--12
@horas_diarias money,--13
@sueldo_basico money = null,--14
@asig_familiar money = null,--15
@hora_dvc int = null,--16
@minuto_dvc int = null,--17
@monto_dvc money = null,--18
@hora_dtc int = null,--19
@minuto_dtc int = null,--20
@monto_dtc money = null,--21
@hora_nvc int = null,--22
@minuto_nvc int = null,--23
@monto_nvc money = null,--24
@hora_ntc int = null,--25
@minuto_ntc int = null,--26
@monto_ntc money = null,--27
@hora_feriado int = null,--28
@minuto_feriado int = null,--29
@monto_feriado money = null,--30
@hora_boni int = null,--31
@monto_boni money = null,--32
@uno_mayo money = null,--33
@hora_tarde int = null,--34
@minuto_tarde int = null,--35
@monto_tarde money = null,--36
@dia_sub int = null,--37
@monto_sub money = null,--38
@dia_subnegativo int= null,--39
@monto_subnegativo money = null,--40
@dia_subpositivo int = null,--41
@monto_subpositivo money = null,--42
@total_horaex money = null,--43---------------
@reintegro money = null,--44
@otro_reintegro money = null,--45
@pre_alimentaria money = null,--46
@gratiex money = null,--47
@boniex money = null,--48
@vacaciones money = null,--49
@vaca_trunca money = null,--50
@grati_trunca money = null,--51
@boni_trunca money = null,--52
@cts_trunca money = null,--53
@total_remuneracion money = null,--54------------------------
@descuento_onp money = null,--55-----
@des_comision money = null,--56----
@des_seguro money = null,--57----
@des_spp money = null,--58-------
@essalud_vida money = null,--59
@adelanto money = null,--60
@prestamo  money = null,--61
@renta_quinta money = null,--62
@retencion_judicial money = null,--63
@otro_des money = null,--64
@total_desc money = null,--65----------------
@total_pagar money = null,--66--------------------------
@aporte_essalud  money = null,--67 ---------------------------
@transporte money = null,--68
@recargo_consumo money = null,--69
@reintegro_grati money = null,--70
@reintegro_boni money = null,--71
@dia_vacaciones int = null)--72
AS BEGIN
	DECLARE @idplanilla_manto int
	SET @idplanilla_manto=(SELECT count(pm.idplanilla_manto) FROM dbo.PlanillaManto pm)
	IF(@idplanilla_manto=0)	
		SET @idplanilla_manto=1	
	ELSE
		SET @idplanilla_manto=(SELECT MAX(pm.idplanilla_manto)+1 FROM dbo.PlanillaManto pm)
--BEGIN TRANSACTION 
	--BEGIN TRY	
		INSERT INTO PlanillaManto (idplanilla_manto, id_contrato, id_planilla, id_tipo_planilla,
		jornadalaboral, pregimen_pension, pvalor_comision, pvalor_seguro, pvalor_aporte,
		pcargo, basico, dias, dia_dominical, horas_diarias, sueldo_basico, asig_familiar,
		hora_dvc, minuto_dvc, monto_dvc, hora_dtc, minuto_dtc, monto_dtc, hora_nvc, minuto_nvc,
		monto_nvc, hora_ntc, minuto_ntc, monto_ntc, hora_feriado, minuto_feriado, monto_feriado,
		hora_boni, monto_boni, uno_mayo, hora_tarde, minuto_tarde, monto_tarde, dia_sub, monto_sub,
		dia_subnegativo, monto_subnegativo, dia_subpositivo, monto_subpositivo, total_horaex, reintegro,
		otro_reintegro, pre_alimentaria, gratiex, boniex, vacaciones, vaca_trunca, grati_trunca, boni_trunca,
		cts_trunca, total_remuneracion, descuento_onp, des_comision, des_seguro, des_spp, essalud_vida, adelanto,
		prestamo, renta_quinta, retencion_judicial, otro_des, total_desc, total_pagar, aporte_essalud, transporte,
		recargo_consumo, reintegro_grati, reintegro_boni, dia_vacaciones)
		VALUES (@idplanilla_manto, @id_contrato, @id_planilla, @id_tipo_planilla,
		@jornadalaboral, @pregimen_pension, @pvalor_comision, @pvalor_seguro, @pvalor_aporte,
		@pcargo, @basico, @dias, @dia_dominical, @horas_diarias, @sueldo_basico, @asig_familiar,
		@hora_dvc, @minuto_dvc, @monto_dvc, @hora_dtc, @minuto_dtc, @monto_dtc, @hora_nvc, @minuto_nvc,
		@monto_nvc, @hora_ntc, @minuto_ntc, @monto_ntc, @hora_feriado, @minuto_feriado, @monto_feriado,
		@hora_boni, @monto_boni, @uno_mayo, @hora_tarde, @minuto_tarde, @monto_tarde, @dia_sub, @monto_sub,
		@dia_subnegativo, @monto_subnegativo, @dia_subpositivo, @monto_subpositivo, @total_horaex, @reintegro,
		@otro_reintegro, @pre_alimentaria, @gratiex, @boniex, @vacaciones, @vaca_trunca, @grati_trunca, @boni_trunca,
		@cts_trunca, @total_remuneracion, @descuento_onp, @des_comision, @des_seguro, @des_spp, @essalud_vida, @adelanto,
		@prestamo, @renta_quinta, @retencion_judicial, @otro_des, @total_desc, @total_pagar, @aporte_essalud, @transporte,
		@recargo_consumo, @reintegro_grati, @reintegro_boni, @dia_vacaciones)
		
		--COMMIT TRANSACTION
		
	--END TRY
		--BEGIN CATCH
			--print ERROR_MESSAGE()
			--ROLLBACK TRANSACTION
		--END CATCH
END
GO


/*   PROCEDIMIENTO PARA CONCEPTOS DE PLANILLA     */
ALTER PROC SP_RegistroConceptos
@id_conceptos int,
@id_mes int,
@id_planilla int,
@hextraDiurna bit,
@hextraNocturna bit,
@feriadoDomi bit,
@boniNocturna bit,
@primeroMayo bit,
@tarda bit, -- tardanza
@subsi bit,--subsidios
@thoraex bit, --total horas extras
@otroreinte bit, --otro reintegro
@prest_aliment bit, --prestacion alimentaria
@gratif bit, --gratificacion
@vaca bit, --vacaciones
@truncas bit,
@reinte_gratiboni bit, --reintegro grati y boni
@essa_vida bit , --essalud vida
@adela bit, --adelanto
@presta bit, --prestamo
@rentquinta bit, --renta de quinta categoria
@reten_judici bit, --retencion judicial
@otrodescu bit, --otro descuento
@recarg_consu bit --recargo consumo
AS BEGIN 
IF(NOT EXISTS(SELECT c.id_planilla FROM dbo.Conceptos c join Planilla p on c.id_planilla = p.id_planilla 
WHERE c.id_planilla= @id_planilla))
BEGIN
	--DECLARE @idconcepto int
	SET @id_conceptos=(SELECT count(c.id_conceptos) FROM dbo.Conceptos c)
	IF(@id_conceptos=0)	
		SET @id_conceptos=1		
	ELSE
	SET @id_conceptos=(SELECT MAX(c.id_conceptos) + 1 FROM dbo.Conceptos c)

	INSERT INTO dbo.Conceptos(id_conceptos, id_mes, id_planilla, hextraDiurna, hextraNocturna, feriadoDomi, 
	boniNocturna, primeroMayo, tarda, subsi, thoraex, otroreinte, prest_aliment, gratif, vaca, truncas, 
	reinte_gratiboni, essa_vida, adela, presta, rentquinta, reten_judici, otrodescu, recarg_consu) VALUES
	(@id_conceptos, @id_mes, @id_planilla, @hextraDiurna, @hextraNocturna, @feriadoDomi, @boniNocturna, @primeroMayo, 
	@tarda, @subsi, @thoraex, @otroreinte, @prest_aliment, @gratif, @vaca, @truncas, @reinte_gratiboni, @essa_vida, 
	@adela, @presta, @rentquinta, @reten_judici, @otrodescu, @recarg_consu)
END
ELSE
BEGIN
	UPDATE dbo.Conceptos SET hextraDiurna=@hextraDiurna, hextraNocturna=@hextraNocturna, feriadoDomi=@feriadoDomi, 
	boniNocturna=@boniNocturna, primeroMayo=@primeroMayo, tarda=@tarda, subsi=@subsi, thoraex=@thoraex, otroreinte=@otroreinte, 
	prest_aliment=@prest_aliment, gratif=@gratif, vaca=@vaca, truncas=@truncas, reinte_gratiboni=@reinte_gratiboni,
	essa_vida=@essa_vida, adela=@adela, presta=@presta, rentquinta=@rentquinta, reten_judici=@reten_judici,
	otrodescu=@otrodescu, recarg_consu=@recarg_consu WHERE id_conceptos=@id_conceptos
END
END
GO

ALTER PROC SP_SHOW_CONCEPTOS
@idmes int,
@idplanilla int
AS BEGIN
IF(EXISTS(SELECT c.id_planilla FROM dbo.Conceptos c join Planilla p on c.id_planilla = p.id_planilla 
WHERE c.id_planilla = @idplanilla))
BEGIN
	SELECT c.id_conceptos, c.hextraDiurna, c.hextraNocturna, c.feriadoDomi, c.boniNocturna, c.primeroMayo, 
	c.tarda, c.subsi, c.thoraex, c.otroreinte, c.prest_aliment, c. gratif, c.vaca, c.truncas, c.reinte_gratiboni, 
	c.essa_vida, c.adela, c.presta, c.rentquinta, c.reten_judici, c.otrodescu, c.recarg_consu FROM dbo.Conceptos c 
	WHERE c.id_mes = @idmes AND c.id_planilla=@idplanilla
END
END
GO
select * from Conceptos
delete from Conceptos
GO
---
--para leer las estadisticas, importante para ver el rendimiento de las consultas.
SET STATISTICS IO, TIME OFF
SET STATISTICS IO, TIME ON
-- para limpiar cache y memoria de plan de ejecucion
DBCC FREEPROCCACHE WITH NO_INFOMSGS
DBCC DROPCLEANBUFFERS WITH NO_INFOMSGS
--Inclue Actual Execution Plan
GO


/*PENDIENTE:
LINEA 845
*/
