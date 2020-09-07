CREATE DATABASE Planilla_lct
use master
drop database Planilla_lct
GO

--TABLA: EMPLEADO
CREATE TABLE Empleado(
id_empleado int not null,
codigo varchar(20) not null,
nombre_empleado varchar(50) not null,
ape_paterno varchar(50) not null,
ape_materno varchar(50) not null,
fecha_nacimiento date not null,
nacionalidad varchar(30) not null,
tipo_genero varchar(12) CONSTRAINT CHK_genero CHECK(tipo_genero in ('Femenino','Masculino')),
direccion varchar(250)null,
telefono varchar(15)null,
numero_documento varchar(20) CONSTRAINT UNQ_docu UNIQUE not null,
estado varchar (20)not null,
codigo_regimen int not null,
id_documento int not null,
id_cargo int not null,
id_em_maestra int not null,
eliminado_estado varchar(15) CONSTRAINT CHK_elim_estado check(eliminado_estado in ('ANULADO','NO ANULADO')),
)
GO

--TABLA: CARGO
CREATE TABLE Cargo(
id_cargo int identity(1,1),
nombre_cargo varchar(40) not null,
descripcion nvarchar(100) null
)
GO

--TABLA: TIPO DE DOCUMENTO
CREATE TABLE Tipo_documento(
id_documento int identity(1,1),
nombre varchar(50) not null,
descripcion nvarchar(100) null
)
GO

--TABLA: REGIMEN PENSIONARIO
CREATE TABLE RegimenPensionario(
codigo_regimen int identity(1,1),
descripcion_corta varchar(30) null,
descripcion varchar(100) not null,
tipo_regimen varchar(10)not null
)
GO

--TABLA: COMISION AFP
CREATE TABLE ComisionesPension(
idcomision int identity(1,1),
codigo_regimen int not null,
comision decimal(4,2) null,
saldo decimal(4,2) null,
seguro decimal(4,2) null,
aporte decimal(4,2) null,
tope  decimal(8,2) null, 
idmes int not null,
idperiodo int not null
)
GO


/*TABLA EMPRESA MAESTRA: EMPRESA => SUCURSAL*/
CREATE TABLE Empresa_maestra(
id_em_maestra int identity(1,1),
razon_social varchar(50) not null,
localidad varchar(50) not null,
direccion nvarchar(250) not null,
domicilio_fiscal nvarchar(250) not null,
ruc char(11) not null,
regimen varchar(80) not null,
estado_eliminado varchar(15) not null
)
GO
--alter table Empresa_maestra alter column regimen varchar(80) not null

CREATE TABLE Empresa(
id_empresa int identity(1,1),
codigo_empresa varchar(8)CONSTRAINT UNQ_cod_em UNIQUE not null,
id_em_maestra int not null,
id_usuario int not null
)
GO


CREATE TABLE Sucursal(
id_sucursal int identity(1,1),
codigo_sucursal varchar(8)CONSTRAINT UNQ_cod_sucur UNIQUE not null,
id_em_maestra int not null,
id_empresa int not null
)
GO
--TABLA: USUSARIO
CREATE TABLE Usuario (
id_usuario int not null,--SERA AUTO INCREMENTABLE, PERO MANUALMENTE
codigo_usuario varchar(20)CONSTRAINT UNQ_usuario UNIQUE not null,
referencia varchar(50)not null,
contrasena varchar(10)not null,
id_rol int not null
)
GO

--TABLA: ROL PARA EL USUARIO
CREATE TABLE Rol(
id_rol int identity(1,1),
rol varchar(30)not null
)
GO

--BANCO
CREATE TABLE Banco(
id_banco int not null, 
nombre_banco varchar(25) not null
)
GO

delete from banco
INSERT INTO Banco VALUES(1,'Sin banco');
INSERT INTO Banco VALUES(2,'Banco Continental');
INSERT INTO Banco VALUES(3,'Bcp');
INSERT INTO Banco VALUES(4,'Scotiabank');
INSERT INTO Banco VALUES(5,'Interbank');

GO
--TIPO DE CONTRATO 
CREATE TABLE Tipo_contrato(
id_tipocontrato int not null,
tiempo_contrato varchar(30) not null
)
GO

--INSERTAR TIPO CONTRATO
INSERT INTO dbo.Tipo_contrato(id_tipocontrato,tiempo_contrato)
VALUES(1,'Contrato Indefinido'),(2,'Contrato a Tiempo Parcial'),
(3,'Contrato Temporal')
GO

--CONTRATO 
CREATE TABLE Contrato(
id_contrato int not null,
id_empleado int not null,
id_banco int null,
id_tipocontrato int not null,
fecha_inicio date not null,
fecha_fin date null,
numero_cuenta varchar(30) null,
remuneracion_basica money not null,
asignacion_familiar money default (0.00) null,
regimen_salud varchar(80)not null,
tipo_pago varchar(30) not null,
periodicidad varchar(70)not null,
tipo_moneda varchar(10) not null,
cuenta_cts nvarchar(50) null,
cussp varchar(70) null
)
GO
--alter table dbo.contrato drop column estado

--Meses_maestra
CREATE TABLE Meses_maestra(
id_meses_maestra int not null,
id_periodo int not null,
Enero decimal(10,2) null,
Febrero decimal(10,2)null,
Marzo decimal(10,2)null,
Abril decimal(10,2)null,
Mayo decimal(10,2)null,
Junio decimal(10,2)null,
Julio decimal(10,2)null,
Agosto decimal(10,2)null,
Septiembre decimal(10,2)null,
Octubre decimal(10,2)null,
Noviembre decimal(10,2)null,
Diciembre decimal(10,2)null,
num_meses int null,
num_dias int null
)
--drop table Meses_maestra
CREATE TABLE Grati_manto(
id_grati int not null,
id_meses int not null,
remuneracion decimal(10,2),
bonificacion decimal(10,2)
)

CREATE TABLE Faltas(
id_falta int not null,
id_meses int not null,
tipo_falta varchar(100)
)

CREATE TABLE cts(
id_cts int not null,
id_periodo int not null,
f_inicial date,
f_final date,
f_pago date
)

CREATE TABLE Gratificaciones(
id_grati int not null,
id_periodo int not null,
f_inicial date,
f_final date,
f_pago date
)

CREATE TABLE cts_manto(
id_cts_manto int not null,
id_meses int not null,
id_periodo int not null
)

CREATE TABLE Descuentos(
id_descuentos int not null,
prestamos decimal(10,2),
renta_quinta decimal(10,2),
desc_judicial decimal(10,2),
otros_descuentos decimal(10,2)
)

CREATE TABLE Periodo(
id_periodo int identity(1,1),
periodo int not null,
)

INSERT INTO Periodo(periodo) values('2018',1);
INSERT INTO Periodo(periodo) values('2018',2);


INSERT INTO Periodo(periodo) values('2019',1);
INSERT INTO Periodo(periodo) values('2019',2);


INSERT INTO Periodo(periodo) values('2020',1);


CREATE TABLE Mes(
id_mes int,
nombre_mes varchar(20) not null,
--id_empresa int
)

INSERT INTO Mes(nombre_mes) values('Enero');1
INSERT INTO Mes(nombre_mes) values('Febrero');2

GO
--enero
/*
diciembre
*/
select * from mes
/*
INSERT INTO Mes(nombre_mes,id_periodo) values('Julio',1);
INSERT INTO Mes(nombre_mes,id_periodo) values('Julio',2);
*/

CREATE TABLE Planilla(
id_planilla int not null,
--id_tipo_planilla int not null, ver si ira id_tipo_planilla
id_periodo int not null,
--id_mes int not null,
fecha_inicial date,
fecha_final date,
fecha_pago date,
dias_mes int,
horas_mes int,
remu_basica decimal(10,2),
asig_familiar decimal(10,2),
tope_horario_nocturno int

)

CREATE TABLE tipo_planilla(
id_tipo_planilla int not null,
nombre_planilla varchar(30) 
)

