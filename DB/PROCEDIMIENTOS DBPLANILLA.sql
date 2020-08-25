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
SELECT * FROM Cargo order by id_cargo asc
END
GO

declare @codigo int, @ncargo varchar(30)
set @codigo=8
set @ncargo='LIMPIEZA'
UPDATE Cargo SET  id_cargo=@codigo WHERE nombre_cargo=@ncargo
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
CREATE PROC SP_SELECT_DOCUMENTO 
@nom varchar(50)
AS BEGIN
SELECT * FROM Tipo_documento where nombre like @nom+'%' order by id_documento desc
END
GO

--Agregar empleado
ALTER PROC SP_AGR_EMPL(
@id_empleado int,
@nom_emp varchar(50),
@ape_pat varchar(50),
@ape_mat varchar(50),
@tipo_pension varchar(30),
@fec_nac date,
@nacion varchar(30),
@tip_ge varchar(12),
@direccion varchar(250),
@telefono varchar(15),
@num_doc varchar(20),
@estado varchar(20),
@id_afp int,
@id_documento int,
@id_cargo int,
@id_empresa_maestra int,
@mensaje varchar(100) output 
)
AS BEGIN 
IF(EXISTS(SELECT e.numero_documento FROM Empleado e WHERE e.numero_documento=@num_doc))
	BEGIN 
	SET @mensaje ='EL NUMERO DE DOCUMENTO ('+@num_doc+') YA SE ENCUENTRA REGISTRADO'
	END
ELSE 
	BEGIN
	IF(@tipo_pension='O.N.P')
		BEGIN
			INSERT INTO dbo.Empleado(id_empleado, nombre_empleado, ape_paterno, ape_materno, tipo_pension, fecha_nacimiento, nacionalidad, 
			tipo_genero,direccion,telefono, numero_documento,estado,id_afp,id_documento,id_cargo,id_em_maestra, eliminado_estado) 
			VALUES (@id_empleado,@nom_emp,@ape_pat,@ape_mat,@tipo_pension,@fec_nac, @nacion,@tip_ge,@direccion,@telefono,@num_doc,@estado,
				null,@id_documento,@id_cargo,@id_empresa_maestra, 'NO ANULADO')
			SET @mensaje= 'EMPLEADO REGISTRADO CORRECTAMENTE'
		END
	ELSE
		BEGIN
			INSERT INTO dbo.Empleado(id_empleado, nombre_empleado, ape_paterno, ape_materno, tipo_pension, fecha_nacimiento, nacionalidad, 
			tipo_genero,direccion,telefono, numero_documento,estado,id_afp,id_documento,id_cargo,id_em_maestra, eliminado_estado) 
			VALUES (@id_empleado,@nom_emp,@ape_pat,@ape_mat,@tipo_pension,@fec_nac, @nacion,@tip_ge,@direccion,@telefono,@num_doc,@estado,
					@id_afp,@id_documento,@id_cargo,@id_empresa_maestra, 'NO ANULADO')
			SET @mensaje= 'EMPLEADO REGISTRADO CORRECTAMENTE'
		END
	END
END;
go


EXEC SP_AGR_EMPL 7,'Pedro','Solorzano','Baldoceda','O.N.P','31-12-2020','Peru','Masculino','Jr. Direccion 1','956324466',
'09645645','ACTIVO',1,1,4,1;
go

select * from Empleado;
Select * from Afp;
select * from cargo;
select * from Tipo_documento;
select * from Empresa;

go
alter PROC SP_UPDATE_EMPLEADO
@id_empleado int,
@nom_emp varchar(50),
@ape_pat varchar(50),
@ape_mat varchar(50),
@tipo_pension varchar(30),
@fec_nac date,
@nacion varchar(30),
@tip_ge varchar(12),
@direccion varchar(250),
@telefono varchar(15),
@num_doc varchar(20),
@estado varchar(20),
@id_afp int,
@id_documento int,
@id_cargo int,
@id_empresa_maestra int
AS BEGIN 
	IF(@tipo_pension='O.N.P')
		BEGIN
			UPDATE Empleado SET id_empleado=@id_empleado, nombre_empleado=@nom_emp,ape_paterno=@ape_pat,
			ape_materno=@ape_mat,tipo_pension=@tipo_pension,fecha_nacimiento=@fec_nac,nacionalidad=@nacion,
			tipo_genero=@tip_ge,direccion=@direccion,telefono=@telefono,numero_documento=@num_doc,
			estado=@estado ,id_afp=null, id_documento=@id_documento,id_cargo=@id_cargo,
			id_em_maestra=@id_empresa_maestra
			WHERE id_empleado=@id_empleado
		END;
	ELSE
		BEGIN
			UPDATE Empleado SET id_empleado=@id_empleado, nombre_empleado=@nom_emp,ape_paterno=@ape_pat,
			ape_materno=@ape_mat,tipo_pension=@tipo_pension,fecha_nacimiento=@fec_nac,nacionalidad=@nacion,
			tipo_genero=@tip_ge,direccion=@direccion,telefono=@telefono,numero_documento=@num_doc,
			estado=@estado ,id_afp=@id_afp, id_documento=@id_documento,id_cargo=@id_cargo,
			id_em_maestra=@id_empresa_maestra
			WHERE id_empleado=@id_empleado
		END;
END 
GO

--ELIMINAR EMPLEADO
CREATE PROC SP_ELIM_EMPL
(@id_emp int)
AS BEGIN 
UPDATE dbo.Empleado SET eliminado_estado='ANULADO' WHERE id_empleado=@id_emp;
END
GO

--MOSTRAR EMPLEADO 

ALTER PROC SP_SHOW_EMP
@codigo_empresa int
AS BEGIN 
SELECT top(200) e.id_empleado, e.nombre_empleado, e.ape_paterno, e.ape_materno,e.fecha_nacimiento,
e.nacionalidad,e.tipo_genero,e.direccion,e.telefono,e.numero_documento,e.estado,a.id_afp,e.tipo_pension ,a.nombre_afp as 'Tipo de AFP',
t.id_documento,t.nombre as 'DOCUMENTO',c.id_cargo,c.nombre_cargo AS 'CARGO',em.id_em_maestra ,em.razon_social AS 'EMPRESA' FROM Empleado e INNER JOIN Tipo_documento t 
on(t.id_documento=e.id_documento)
left JOIN Afp a
ON(a.id_afp=e.id_afp)
INNER JOIN Cargo c
ON(c.id_cargo=e.id_cargo)
INNER JOIN Empresa_maestra em
ON(em.id_em_maestra=e.id_em_maestra)
WHERE e.eliminado_estado='NO ANULADO' and 
e.id_em_maestra=@codigo_empresa 
/*(e.nombre_empleado like @search+'%'
or e.ape_paterno 
like @search+'%') */
ORDER BY e.id_empleado DESC
END
GO

CREATE VIEW vista_empleado
As(
SELECT top(200) e.id_empleado, e.nombre_empleado, e.ape_paterno, e.ape_materno,e.fecha_nacimiento,
e.nacionalidad,e.tipo_genero,e.direccion,e.telefono,e.numero_documento,e.estado,a.id_afp,e.tipo_pension ,a.nombre_afp as 'Tipo de AFP',
t.id_documento,t.nombre as 'DOCUMENTO',c.id_cargo,c.nombre_cargo AS 'CARGO',em.id_em_maestra ,em.razon_social AS 'EMPRESA' FROM Empleado e INNER JOIN Tipo_documento t 
on(t.id_documento=e.id_documento)
left JOIN Afp a
ON(a.id_afp=e.id_afp)
INNER JOIN Cargo c
ON(c.id_cargo=e.id_cargo)
INNER JOIN Empresa_maestra em
ON(em.id_em_maestra=e.id_em_maestra)
WHERE e.eliminado_estado='NO ANULADO' 
)
go

alter proc SP_SHOW_EMP_DNI
@codigo_empresa int,
@dni varchar(20),
@nom varchar(50)
AS BEGIN
	select * from vista_empleado where id_em_maestra=@codigo_empresa and numero_documento like @dni +'%' and
	nombre_empleado like @nom +'%'
END
GO


EXEC SP_SHOW_EMP_DNI 6,'P',''

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
		set @mesage='¡Codigo Empresa Ya Exite!'
	END
ELSE IF(EXISTS(SELECT codigo_sucursal FROM Sucursal WHERE codigo_sucursal=@cod_empresa_validar))
	BEGIN
		set @mesage='¡Codigo Sucursal Ya Exite!'
	END
ELSE
	BEGIN
		INSERT INTO dbo.Empresa_maestra(razon_social,direccion,domicilio_fiscal,ruc,regimen,estado_eliminado,localidad)
		VALUES(@razon_social,@direccion,@domicilio,@ruc,@regimen,'NO ANULADO', @localidad)
		set @mesage='¡Registro Exitosamente!'
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
CREATE PROC SP_SHOW_EMPRESA
@search varchar(50)
AS BEGIN
SELECT TOP(200) em.id_em_maestra, em.estado_eliminado, u.id_usuario, e.id_em_maestra,e.id_empresa, e.codigo_empresa, em.razon_social,em.localidad,
direccion, domicilio_fiscal, em.ruc, em.regimen, u.referencia
FROM dbo.Empresa_maestra em right join dbo.Empresa e on em.id_em_maestra=e.id_em_maestra join dbo.Usuario u 
on e.id_usuario=u.id_usuario WHERE em.estado_eliminado ='NO ANULADO' AND (em.razon_social like @search+'%' or e.codigo_empresa like @search+'%')
ORDER BY e.id_empresa DESC
END
GO

--PROCEDIMIENTO MOSTRAR SUCURSAL
CREATE PROC SP_SHOW_SUCURSAL
@search varchar(50)
AS BEGIN
SELECT TOP(200) em.estado_eliminado,s.id_em_maestra, e.id_empresa, s.codigo_sucursal, em.razon_social AS SUCURSAL, em.localidad,
direccion, domicilio_fiscal, em.ruc, em.regimen, usu.referencia AS USUARIO,
(SELECT ema.razon_social FROM dbo.Empresa_maestra ema WHERE ema.id_em_maestra=e.id_em_maestra) AS EMPRESA 
FROM dbo.Empresa_maestra em join dbo.Sucursal s on em.id_em_maestra=s.id_em_maestra join 
dbo.Empresa e on e.id_empresa=s.id_empresa join dbo.Usuario usu on e.id_usuario=usu.id_usuario
WHERE em.estado_eliminado='NO ANULADO' AND (em.razon_social like @search+'%' or s.codigo_sucursal like @search+'%') 
ORDER BY S.id_sucursal DESC 
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

<<<<<<< HEAD
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

--GENERAR CODIGO PERIODO
CREATE PROC SP_GENERAR_Periodo
(@periodo int output)
AS BEGIN
SET @periodo=(SELECT count(pe.id_periodo) FROM dbo.Periodo pe)
IF(@periodo=0)
	BEGIN
		SET @periodo=1		
	END
ELSE
	BEGIN
		SET @periodo=(SELECT MAX(pe.id_periodo)+1 FROM dbo.Periodo pe)
	END
END
GO

--GENERAR CODIGO MES
CREATE PROC SP_GENERAR_Mes
(@Mes int output)
AS BEGIN
SET @Mes=(SELECT count(mes.id_mes) FROM dbo.Mes mes)
IF(@Mes=0)
	BEGIN
		SET @Mes=1		
	END
ELSE
	BEGIN
		SET @Mes=(SELECT MAX(mes.id_mes)+1 FROM dbo.Mes mes)
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
=======
>>>>>>> MCarlos


--LISTAR POR EMPRESA
ALTER PROC SP_LISTEMP_POR_USU
(@codigo_usuario VARCHAR(20))
AS BEGIN
SELECT em.id_em_maestra,em.razon_social from Empresa_maestra em
INNER JOIN Empresa e
on(e.id_em_maestra=em.id_em_maestra)
INNER JOIN Usuario u
on(e.id_usuario=u.id_usuario)
WHERE u.codigo_usuario=@codigo_usuario
END
GO
/*
EXEC SP_LISTEMP_POR_USU 'US001'
--INICIAR SESION 
GO
Create Proc IniciarSesion
@codigo_usuario Varchar(20),
@Contraseña Varchar(12),
@Mensaje Varchar(50) Out
As Begin
	Declare @Empleado Varchar(50)
	If(Not Exists(SELECT u.codigo_usuario 
	from Usuario u
	WHERE u.codigo_usuario=@codigo_usuario))
		Set @Mensaje='El Nombre de Usuario no Existe.'
		Else Begin
			If(Not Exists(Select contrasena From Usuario Where contrasena=@Contraseña))
				Set @Mensaje='Su Contraseña es Incorrecta.'
				Else Begin
					Set @Empleado=(Select E.Nombres+', '+E.Apellidos From Usuario E Inner Join Usuario U 
								   On E.IdEmpleado=U.IdEmpleado Where U.Usuario=@Usuario)
					    Begin
					Select Usuario,Contraseña From Usuario Where Usuario=@Usuario And Contraseña=@Contraseña
							Set @Mensaje='Bienvenido Sr(a): '+@Empleado+'.'
						End
				  End
		   End
   End
Go
*/
----	PROCEDIMIENTOS PARA LLENAR COMBOMBOX
CREATE PROC SP_LLENAR_CARGO_EMPLEADO
AS BEGIN
SELECT id_cargo, nombre_cargo FROM Cargo
END
GO

create PROC SP_LLENAR_DOCUMENTO_EMPLEADO
AS BEGIN
SELECT id_documento,nombre, descripcion FROM tipo_documento
END
GO

CREATE PROC SP_LLEN_AFP
AS BEGIN 
SELECT  a.id_afp,a.nombre_afp,a.comision,a.comision_anual,a.prima_seguros,a.aportes_fondo_pensiones,a.remu_maxi_asegurable
FROM Afp a
END
GO

CREATE PROC SP_EMPR
AS BEGIN
SELECT e.id_em_maestra,em.razon_social
FROM Empresa e
INNER JOIN Empresa_maestra em
on(em.id_em_maestra=e.id_em_maestra)
END
GO

CREATE PROC SP_LLENAR_BANCO
AS BEGIN
SELECT id_banco, nombre_banco FROM Banco
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
alter PROC SP_SHOW_BANCO
AS BEGIN 
SELECT b.id_banco,b.nombre_banco from Banco b; 
END;
GO

--EXEC SP_SHOW_BANCO 'B';

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
CREATE PROC SP_UPDATE_TIP_CONT(
@id_tip_cont int,
@tiempo_contrato varchar(30)
)
AS BEGIN 
UPDATE Tipo_contrato SET tiempo_contrato=@tiempo_contrato where id_tipo_contrato=@id_tip_cont
END;
GO

--PROCEDIMIENTO PARA ELIMINAR TIPO CONTRATO
--CREATE PROC SP_DEL_TIP_CONT(
--@id_tip_cont int,
--@message varchar(100) output
--)
--AS BEGIN
--IF(EXISTS(SELECT t.id_tipo_contrato from Tipo_contrato t join Contrato c on(c.id_banco=t.id_tipo_contrato) where c.id_tipo_contrato=@id_tip_cont))
--	BEGIN
--		DECLARE @tipo_contrato varchar(20);
--		SET @tipo_contrato=(SELECT t.tiempo_contrato from Tipo_contrato t WHERE b.id_banco=@id_banco)
--		SET @message='EL BANCO ('+@cod_banco+') ESTA SIENDO USADO'  
--	END
--ELSE
--DELETE FROM Tipo_contrato WHERE id_tipo_contrato=@id_tip_cont
--END;
--GO

--PROCEDIMIENTO PARA MOSTRAR TIPO CONTRATO 
CREATE PROC SP_SHOW_TIP_CONT
AS BEGIN 
SELECT id_tipo_contrato, tiempo_contrato from Tipo_contrato;
END
GO

--select * from Tipo_contrato
--procedimientos contrato 
CREATE PROCEDURE SP_INSERT_CONTRATO
(@id_contrato int,
@id_empleado int,
@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami money,
@descuento money,
@tipo_modeda varchar(10),
@cts nvarchar(50),
@cussp nvarchar(100))
AS BEGIN
INSERT INTO dbo.Contrato(id_contrato,id_empleado,id_banco,id_tipo_contrato,fecha_inicio,
fecha_fin,numero_cuenta,remuneracion_basica,asignacion_familiar,descuento,tipo_moneda,cts,cussp,estado)
VALUES(@id_contrato,@id_empleado,@id_banco,@id_tcontrato,@fecha_inicio,@fecha_fin, @num_cuenta,
@remu_basica,@asig_fami,@descuento,@tipo_modeda,@cts,@cussp,'NO ANULADO')
END
GO


--UPDATE EMPLEADO.
ALTER PROCEDURE SP_UPDATE_CONTRATO
(@id_empleado int,
@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami money,
@descuento money,
@tipo_modeda varchar(10),
@cts nvarchar(50),
@id_contrato int)
AS BEGIN
UPDATE dbo.Contrato SET id_empleado=@id_empleado, id_banco=@id_banco, 
id_tipo_contrato=@id_tcontrato,fecha_inicio=@fecha_inicio, fecha_fin=@fecha_fin,
numero_cuenta=@num_cuenta, remuneracion_basica=@remu_basica, asignacion_familiar=@asig_fami,
descuento=@descuento,tipo_moneda=@tipo_modeda, cts=@cts WHERE id_contrato=@id_contrato
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
--
 
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
dbo.Empresa e on e.id_empresa=s.id_empresa where e.id_usuario= 3  @codigo_user
END
GO

--PROCEDIMIENTO PARA AGREGAR REGIMEN PENSIONARIO
CREATE PROCEDURE SP_ADD_REGIMEN(
@descripcion_corta varchar(30),
@descripcion varchar(100),
@tipo_regimen varchar(30),
@mensaje varchar(100) output
)
AS BEGIN
INSERT INTO RegimenPensionario(descripcion_corta,descripcion,tipo_regimen)
VALUES(@descripcion,@descripcion_corta,@tipo_regimen)
SET @mensaje= 'REGIMEN REGISTRADO CORRECTAMENTE'
END
GO

alter PROCEDURE SP_SHOW_REGIMEN
AS BEGIN 
SELECT r.descripcion,r.descripcion_corta,r.tipo_regimen from RegimenPensionario r; 
END;
GO

exec sp_show_regimen;


select * from Contrato
select * from Usuario
Select * from Empresa_maestra
select * from Empresa
select * from Sucursal