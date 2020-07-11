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
CREATE PROC SP_SELECT_CARGO 
@nom varchar(40)
AS BEGIN
SELECT * FROM Cargo where nombre_cargo like @nom+'%' order by id_cargo desc
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
EXEC SP_SELECT_DOCUMENTO ''
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

select * from Empleado



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


create table Ejmplo(
id_ej int identity(1,1),
fecha date,
numero varchar(20)
)
go
insert into Ejmplo(fecha,numero)values('12/12/1999','078765456')
select * from Ejmplo

/*     EMPRESA AND SUCURSAL      */
CREATE PROC SP_INSERT_EMPRESA_MAESTRA
@razon_social varchar(50),
@direccion nvarchar(250),
@domicilio nvarchar(250),
@ruc char(11),
@regimen varchar(50),
@localidad varchar(50) 
AS BEGIN
INSERT INTO dbo.Empresa_maestra(razon_social,direccion,domicilio_fiscal,ruc,regimen,estado_eliminado,localidad)
VALUES(@razon_social,@direccion,@domicilio,@ruc,@regimen,'NO ANULADO', @localidad)
END
GO

CREATE PROC SP_EMPRESA
@cod_empresa varchar(8),
@id_usuario int,
@mesage varchar(100) output
AS BEGIN
IF(EXISTS(SELECT e.codigo_empresa FROM dbo.Empresa e WHERE e.codigo_empresa=@cod_empresa))
	BEGIN
		SET @mesage='CODIGO YA EXISTE'
	END
ELSE
	BEGIN
		INSERT INTO dbo.Empresa(codigo_empresa,id_em_maestra,id_usuario)VALUES
		(@cod_empresa,(SELECT TOP(1)id_em_maestra FROM dbo.Empresa_maestra ORDER BY id_em_maestra DESC),@id_usuario)
		SET @mesage='¡GUARDADO CORRECTAMENTE!'
	END
END
GO

--INSERT SUCURSAL
CREATE PROC SP_SUCURSAL
@cod_sucursal varchar(8),
@id_empresa int,
@mesage varchar(100) output
AS BEGIN
IF(EXISTS(SELECT S.codigo_sucursal FROM Sucursal s WHERE S.codigo_sucursal=@cod_sucursal))
	BEGIN
		SET @mesage='CODIGO YA EXITE'
	END
ELSE
	BEGIN
		INSERT INTO dbo.Sucursal(codigo_sucursal,id_em_maestra,id_empresa)VALUES
		(@cod_sucursal,(SELECT TOP(1) id_em_maestra FROM dbo.Empresa_maestra ORDER BY id_em_maestra DESC),@id_empresa)
		SET @mesage='¡SUCCESSFULLY RECORD!'
	END
END
GO
--SELECT * FROM Empresa_maestra
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
select * from Empresa_maestra;
select * from Empresa;
select * from Sucursal

 --UPDATE USUARIO
CREATE PROC SP_UPDATE_USUARIO
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


alter PROC SP_REMOVE_EMPRESAMAESTRA
@id_maestra int
AS BEGIN		/*PREPARA CONDICION PARA ESTE PROCEDIMIENTO CON LA TABLA RELACIONADA*/
UPDATE dbo.Empresa_maestra SET estado_eliminado='ANULADO' WHERE id_em_maestra=@id_maestra
END
GO

exec SP_ELIM_EMPL 1
select * from empleado
--MOSTRAR USUARIO
CREATE PROC SP_SHOW_USER
@search varchar(50)
AS BEGIN	
SELECT u.id_usuario, u.codigo_usuario, u.referencia, u.contrasena, u.id_rol, r.rol FROM 
dbo.Usuario u join Rol r on u.id_rol=r.id_rol WHERE u.referencia like @search+'%' 
ORDER BY u.id_usuario DESC
END
GO

--MOSTRAR EMPLEADO 
ALTER PROC SP_SHOW_EMP
@search varchar(50)
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
(e.nombre_empleado like @search+'%'
or e.ape_paterno 
like @search+'%') 
ORDER BY e.id_empleado DESC
END;
GO

select * from Empleado join Afp on e.id_afp = a.id_afp
truncate  table empleado;




SELECT * FROM Empleado e  left join dbo.Afp a on e.id_afp=a.id_afp
--e.tipo_pension, a.id_afp
GO
exec SP_SHOW_EMP 'j';
--un scrip que muestre el empleado con todos los datos, afp, cargo, tip_documento, empresa

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

alter PROC SP_GENERAR_BANCO
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

exec SP_LLENAR_DOCUMENTO_EMPLEADO
use Planilla_lct
CREATE PROC SP_LLEN_AFP
AS BEGIN 
SELECT  a.id_afp,a.nombre_afp,a.comision,a.comision_anual,a.prima_seguros,a.aportes_fondo_pensiones,a.remu_maxi_asegurable
FROM Afp a
END

EXEC SP_LLEN_AFP

CREATE PROC SP_EMPR
AS BEGIN
SELECT e.id_em_maestra,em.razon_social
FROM Empresa e
INNER JOIN Empresa_maestra em
on(em.id_em_maestra=e.id_em_maestra)
END


CREATE PROC SP_LLENAR_BANCO
AS BEGIN
SELECT id_banco, nombre_banco FROM Banco
END
GO


--PROCEDIMENTO PARA REGISTRAR BANCO
alter PROC SP_INSERT_BANCO(
@id_banco int,
@nombre_banco varchar(25),
@mensaje varchar(100) output
)
AS BEGIN
	INSERT INTO BANCO(id_banco,nombre_banco) VALUES(@id_banco,@nombre_banco)
	SET @mensaje= 'BANCO REGISTRADO CORRECTAMENTE'

END
GO

sp_insert_banco 6,'gnb'

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
ALTER PROC SP_DEL_BANCO(
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
alter PROC SP_SHOW_BANCO(
@search varchar(50)
)
AS BEGIN 
SELECT b.id_banco,b.nombre_banco from Banco b where b.nombre_banco like @search+'%' ; 
END;
GO

EXEC SP_SHOW_BANCO 'B';

--PROCEDIMIENTO PARA REGISTRAR TIPO CONTRATO
CREATE PROC SP_INSERT_TIP_CONT(
@id_tip_cont int,
@tiempo_contrato varchar(30)
)
AS BEGIN
INSERT INTO Tipo_contrato(id_tipo_contrato,tiempo_contrato) VALUES(@id_tip_cont,@tiempo_contrato)
END;
GO

--PROCEDIMIENTO PARA ACTUALIZAR TIPO CONTRATO 
CREATE PROC SP_UPDATE_TIP_CONT(
@id_tip_cont int,
@tiempo_contrato varchar(30)
)
AS BEGIN 
UPDATE Tipo_contrato SET id_tipo_contrato=@id_tip_cont,tiempo_contrato=@tiempo_contrato where id_tipo_contrato=@id_tip_cont
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
CREATE PROC SP_SHOW_TIP_CONT(
@id_tip_cont int,
@tiempo_contrato varchar(30)
)
AS BEGIN 
SELECT id_tipo_contrato,tiempo_contrato  from Tipo_contrato;
END;
GO

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
@tipo_modeda varchar(10),
@cts nvarchar(50))
AS BEGIN
INSERT INTO dbo.Contrato(id_contrato,id_empleado,id_banco,id_tipo_contrato,fecha_inicio,
fecha_fin,numero_cuenta,remuneracion_basica,asignacion_familiar,tipo_moneda,cts,estado)
VALUES(@id_contrato,@id_empleado,@id_banco,@id_tcontrato,@fecha_inicio,@fecha_fin,@num_cuenta,
@remu_basica,@asig_fami,@tipo_modeda,@cts,'NO ANULADO')
END
GO

--UPDATE EMPLEADO.
CREATE PROCEDURE SP_UPDATE_CONTRATO
(@id_empleado int,
@id_banco int,
@id_tcontrato int,
@fecha_inicio date,
@fecha_fin date,
@num_cuenta varchar(30),
@remu_basica money,
@asig_fami money,
@tipo_modeda varchar(10),
@cts nvarchar(50),
@id_contrato int)
AS BEGIN
UPDATE dbo.Contrato SET id_empleado=@id_empleado, id_banco=@id_banco, 
id_tipo_contrato=@id_tcontrato,fecha_inicio=@fecha_inicio, fecha_fin=@fecha_fin,
numero_cuenta=@num_cuenta, remuneracion_basica=@remu_basica, asignacion_familiar=@asig_fami,
tipo_moneda=@tipo_modeda, cts=@cts WHERE id_contrato=@id_contrato
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

--PRACTICA
DECLARE @usuario int
SET @usuario=(SELECT count(u.id_usuario) FROM dbo.Usuario u)
IF(@usuario=0)
	BEGIN
		SET @usuario=1
		insert into Usuario(id_usuario,codigo_usuario,referencia,contrasena,id_rol)
		values(@usuario,'cmamani','cristina mamani','123',1)
		PRINT 'successfully record'
	END
ELSE
	BEGIN
		SET @usuario=(SELECT MAX(u.id_usuario)+1 FROM dbo.Usuario u)
		PRINT @usuario
	END
GO

select * from cargo
select * from dbo.Tipo_documento
SELECT * FROM USUARIO
select * from rol
delete from Usuario