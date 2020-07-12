CREATE DATABASE Planilla_lct
use Planilla_lct

GO

--TABLA: EMPLEADO
CREATE TABLE Empleado(
id_empleado int not null,
nombre_empleado varchar(50) not null,
ape_paterno varchar(50) not null,
ape_materno varchar(50) not null,
tipo_pension varchar(30)not null,--ONP AFP
fecha_nacimiento date not null,
nacionalidad varchar(30) not null,
tipo_genero varchar(12) CONSTRAINT CHK_genero CHECK(tipo_genero in ('Femenino','Masculino')) not null,
direccion varchar(250)null,
telefono varchar(15)null,
numero_documento varchar(20) CONSTRAINT UNQ_docu UNIQUE not null,
estado varchar (20)not null,
id_afp int,
id_documento int not null,
id_cargo int not null,
id_em_maestra int not null,
eliminado_estado varchar(15) CONSTRAINT CHK_elim_estado check(eliminado_estado in ('ANULADO','NO ANULADO')) not null
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

--TABLA: AFP
CREATE TABLE Afp(
id_afp int identity(1,1),
nombre_afp varchar(30) not null,
comision decimal(4,2)not null,
comision_anual decimal(4,2)not null,
prima_seguros decimal(4,2)not null,
aportes_fondo_pensiones decimal(4,2)not null,
remu_maxi_asegurable decimal(8,2)           
)
GO

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('HABITAT FLUJO',1.47,1.25,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('HABITAT MIXTA',0.38,1.25,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('INTEGRA FLUJO',1.47,0.82,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('INTEGRA MIXTA',0.00,0.82,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('PRIMA FLUJO',1.60,1.25,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('PRIMA MIXTA',0.18,1.25,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('PROFUTURO FLUJO',1.69,1.20,1.35,10.0,9707.03)

INSERT INTO Afp(nombre_afp,comision,comision_anual,prima_seguros,aportes_fondo_pensiones,remu_maxi_asegurable)
VALUES('PROFUTURO MIXTA',0.67,1.20,1.35,10.0,9707.03)
GO

/*TABLA EMPRESA MAESTRA: EMPRESA => SUCURSAL*/
CREATE TABLE Empresa_maestra(
id_em_maestra int identity(1,1),
razon_social varchar(50) not null,
localidad varchar(50) not null,
direccion nvarchar(250) not null,
domicilio_fiscal nvarchar(250) not null,
ruc char(11) not null,
regimen varchar(30) not null,
estado_eliminado varchar(15) not null
)
GO

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

INSERT INTO Banco VALUES(1,'Banco Continental');
INSERT INTO Banco VALUES(2,'Bcp');
INSERT INTO Banco VALUES(3,'Scotiabank');
INSERT INTO Banco VALUES(4,'Interbank');



--TIPO DE CONTRATO 
CREATE TABLE Tipo_contrato(
id_tipo_contrato int not null,
tiempo_contrato varchar(30) not null
)


--CONTRATO 
CREATE TABLE Contrato(
id_contrato int not null,
id_empleado int not null,
id_banco int not null,
id_tipo_contrato int not null,
fecha_inicio date not null,
fecha_fin date null,
numero_cuenta varchar(30) null,
tipo_moneda varchar(10) not null,
cts nvarchar(50) null,
CUSSP varchar(30) null,
estado varchar(30) check(estado in ('ANULADO','NO ANULADO')) 
)
go

--alter table Contrato drop column asignacion_familiar 

CREATE TABLE Remuneraciones(
id_remu int not null,
remuneracion_basica money,
asignacion_familiar money default (0.00)
)
GO
--print year('12/10/2020')

--ALTER TABLE Contrato add CUSSP varchar(30) null;

--alter table Contrato alter column numero_cuenta varchar(30) null;

--ALTER TABLE dbo.contrato add estado varchar(30) check(estado in ('ANULADO','NO ANULADO')) 

--RESTRICCIONES
--TABLA: EMPRESA MAESTRA, EMPRESA, SUCURSAL
	--PRIMARY KEY
ALTER TABLE Empresa_maestra ADD CONSTRAINT PK_id_Emaestra PRIMARY KEY(id_em_maestra)
ALTER TABLE Empresa ADD CONSTRAINT PK_idempresa PRIMARY KEY(id_empresa)
ALTER TABLE Sucursal ADD CONSTRAINT PK_idsucursal PRIMARY KEY(id_sucursal)
go

--ALTER TABLE Usuario drop constraint Fk_idrol 
--FOREIGN KEY
ALTER TABLE Empresa ADD CONSTRAINT FK_id_Emaestra FOREIGN KEY(id_em_maestra)REFERENCES Empresa_maestra
ALTER TABLE Sucursal ADD CONSTRAINT FK_idEmaestra FOREIGN KEY(id_em_maestra)REFERENCES Empresa_maestra
ALTER TABLE Sucursal ADD CONSTRAINT FK_idempresa FOREIGN KEY(id_empresa)REFERENCES Empresa
GO

--TABLA: USUARIO Y ROL
	--PRIMARY KEY USUARIO Y ROL
ALTER TABLE Usuario ADD CONSTRAINT PK_idusuario PRIMARY KEY(id_usuario)
ALTER TABLE Rol ADD CONSTRAINT PK_idrol PRIMARY KEY(id_rol)
	--FOREIGN KEY EN USUARIO Y EMPRESA
ALTER TABLE Empresa ADD CONSTRAINT FK_idusuario FOREIGN KEY(id_usuario)REFERENCES Usuario
	--FOREIGN KEY EN USUARIO Y ROL
ALTER TABLE Usuario ADD CONSTRAINT FK_idrol FOREIGN KEY(id_rol)REFERENCES Rol
GO

--TABLA: EMPLEADO, CARGO, TIPO DOCUMENTO, AFP
ALTER TABLE Empleado ADD CONSTRAINT PK_idempleado PRIMARY KEY(id_empleado)
ALTER TABLE Cargo ADD CONSTRAINT PK_idcargo PRIMARY KEY(id_cargo)
ALTER TABLE Tipo_documento ADD CONSTRAINT PK_tdocumento PRIMARY KEY(id_documento)
ALTER TABLE Afp ADD CONSTRAINT PK_idafp PRIMARY KEY(id_afp)
	--FOREIGN KEY: EMPLEADO CON  CARGO, TIPO DOCUMENTO, AFP, EMPRESA
ALTER TABLE Empleado ADD CONSTRAINT FK_EempresaM FOREIGN KEY(id_em_maestra)REFERENCES Empresa_maestra
Alter TABLE	Empleado ADD CONSTRAINT FK_Eidcargo FOREIGN KEY(id_cargo)REFERENCES Cargo
Alter TABLE	Empleado ADD CONSTRAINT FK_Eiddocumento FOREIGN KEY(id_documento)REFERENCES Tipo_documento
Alter TABLE	Empleado ADD CONSTRAINT FK_Eidafp FOREIGN KEY(id_afp)REFERENCES Afp
GO

--TABLA: Contrato, Banco y Tipo_contrato 
ALTER TABLE Contrato ADD CONSTRAINT PK_idcontrato PRIMARY KEY(id_contrato)
ALTER TABLE Banco ADD CONSTRAINT PK_idbanco PRIMARY KEY(id_banco)
ALTER TABLE Tipo_Contrato ADD CONSTRAINT PK_id_tipo_contrato PRIMARY KEY(id_tipo_contrato)


--FOREIGN KEY CONTRATO CON BANCO, TIPO_CONTRATO, EMPLEADO
ALTER TABLE Contrato ADD CONSTRAINT FK_Cbanco FOREIGN KEY(id_banco) REFERENCES Banco
ALTER TABLE Contrato ADD CONSTRAINT FK_CEmpleado FOREIGN KEY(id_empleado) REFERENCES Empleado
ALTER TABLE Contrato ADD CONSTRAINT FK_CBanco FOREIGN KEY(id_banco) REFERENCES Banco
ALTER TABLE Contrato ADD CONSTRAINT Fk_CTipo_Contrato FOREIGN KEY(id_tipo_contrato) REFERENCES Tipo_Contrato 

--DIAGRAMA
ALTER AUTHORIZATION ON DATABASE::Planilla_lct TO[SA]
GO

