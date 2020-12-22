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
tipo_genero varchar(12) not null,
direccion varchar(250)null,
telefono varchar(15)null,
numero_documento varchar(20) not null,
estado varchar (20)not null, -- ACTIVO, CESADO
codigo_regimen int not null,
id_documento int not null,
id_cargo int not null,
id_em_maestra int not null,
jornada_laboral varchar(11) not null,
eliminado_estado varchar(15) --('ANULADO','NO ANULADO'))
)
GO

--ALTER TABLE EMPLEADO DROP CONSTRAINT CHK_elim_estado
--ALTER TABLE dbo.Empleado alter column jornada_laboral varchar(11) not null
--EXECUTE sp_rename 'Empleado.Jornada_laboral', 'jornada_laboral', 'COLUMN';
--select len('PART - TIME')


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
codigo_doc char(2),
nombre varchar(50) not null,
descripcion nvarchar(100) null
)
GO

--alter table Tipo_documento add codigo_doc char(2);

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
idcomision int not null,
codigo_regimen int not null,
comision decimal(6,2) null,
saldo decimal(6,2) null,
seguro decimal(6,2) null,
aporte decimal(6,2) null,
tope  decimal(10,2) null, 
idmes int null,
idperiodo int null
)
GO

/*TABLA EMPRESA MAESTRA: EMPRESA => SUCURSAL*/
CREATE TABLE Empresa_maestra(
id_em_maestra int not null,
razon_social varchar(100) not null,
localidad varchar(50) not null,
direccion nvarchar(250) not null,
domicilio_fiscal nvarchar(250) not null,
ruc char(11) not null,
regimen varchar(80) not null,
estado_eliminado varchar(15) not null
)
GO
--ALTER TABLE dbo.empresa_maestra alter column razon_social varchar(100) not null -- SE CAMBIO EL 17/12/2020
--alter table Empresa_maestra alter column regimen varchar(80) not null
CREATE TABLE Empresa(
id_empresa int not null,
codigo_empresa varchar(8)CONSTRAINT UNQ_cod_em UNIQUE not null,
id_em_maestra int not null,
id_usuario int not null
)
GO

--drop table Empresa, sucursal, Empresa_maestra
CREATE TABLE Sucursal(
id_sucursal int not null,
codigo_sucursal varchar(8)CONSTRAINT UNQ_cod_sucur UNIQUE not null,
id_em_maestra int not null,
id_empresa int not null
)
GO

--TABLA: USUSARIO
CREATE TABLE Usuario (
id_usuario int not null,
codigo_usuario varchar(20)CONSTRAINT UNQ_usuario UNIQUE not null,
nombre_usuario varchar(50)not null,
contrasena varchar(10)not null,
genero char(1) not null,
id_rol int not null
)
GO

--TABLA: ROL PARA EL USUARIO
CREATE TABLE Rol(
id_rol int identity(1,1),
descrip_rol varchar(30)not null
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
asignacion_familiar decimal(5,2) null,
regimen_salud varchar(80)not null,
tipo_pago varchar(30) not null,
periodicidad varchar(70)not null,
tipo_moneda varchar(10) not null,
cuenta_cts nvarchar(50) null,
cussp varchar(70) null,
id_rsalud int 
)

GO
alter table dbo.contrato drop column estado
alter table dbo.contrato alter column [asignacion_familiar] decimal(5,2) null
GO

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
GO

CREATE TABLE Grati_manto(
id_grati int not null,
id_meses int not null,
remuneracion decimal(10,2),
bonificacion decimal(10,2)
)
GO

CREATE TABLE Faltas(
id_falta int not null,
id_meses int not null,
tipo_falta varchar(100)
)
GO

CREATE TABLE cts(
id_cts int not null,
id_periodo int not null,
f_inicial date,
f_final date,
f_pago date
)
GO

CREATE TABLE Gratificaciones(
id_grati int not null,
id_periodo int not null,
f_inicial date,
f_final date,
f_pago date
)
GO

CREATE TABLE cts_manto(
id_cts_manto int not null,
id_meses int not null,
id_periodo int not null
)
GO

CREATE TABLE Descuentos(
id_descuentos int not null,
prestamos decimal(10,2),
renta_quinta decimal(10,2),
desc_judicial decimal(10,2),
otros_descuentos decimal(10,2)
)
GO

CREATE TABLE Periodo(
id_periodo int identity(1,1),
periodo int not null,
)
GO

CREATE TABLE Mes(
id_mes int,
nombre_mes varchar(20) not null,
--id_empresa int
)
GO


CREATE TABLE Planilla(
id_planilla int not null,
id_tipoplanilla int not null,
id_periodo int not null,
idempresa_maestra int not null,
id_mes int not null,
fecha_inicial date,
fecha_final date,
fecha_pago date,
dias_mes int,
horas_mes int,
tope_horario_nocturno decimal(8,2)
)
GO

--alter table Planilla add id_tipoplanilla int null; --se agrego id_tipoplanilla

CREATE TABLE tipo_planilla(
idtipo_planilla int not null,
nombre_planilla varchar(30)not null
)
GO


CREATE TABLE Regimen_salud( --falta modificar el procedi.. add modi delet
id_regimen_salud int not null,
cod_regi_salud char(2) not null,
descripcion_rsalud nvarchar(100) not null
)
GO

insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(1,00,'ESSALUD REGULAR');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(2,21,'SIS - MICROEMPRESA');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(3,04,'ESSALUD AGRARIO/ACUICOLA');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(4,05,'ESSALUD PENSIONISTAS');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(5,01,'ESSALUD REGULAR Y EPS/SERV. PROPIOS');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(6,02,'ESSALUD TRABAJADORES PESQUEROS');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(7,03,'ESSALUD TRABAJADORES PESQUEROS Y EPS(SERV.PROPIOS)');
insert into REGIMEN_SALUD(id_regimen_salud,cod_regi_salud,descripcion_rsalud) VALUES(8,20,'SANIDAD DE FFAA Y POLICIALES');

GO


CREATE TABLE Subsidios(
id_subsidios int not null,
cod_subsidio char(2) not null,
tipo_suspencion varchar(10)not null, -- S.P. AND S.I.
descripcion_corta nvarchar(70) not null,
descripcion_subsidio nvarchar(130) not null,
tipo_subsidio varchar(30) not null, --SUBSIADOS Y NO SUBSIDIADOS-- ESTADO
descuento bit not null
)
GO

--SELECT len('LICENCIA PARA DESEMPEÑAR CARGO CÍVICO Y PARA CUMPLIR CON EL SERVICIO MILITAR OBLIGATORIO')
--ALTER TABLE SUBSIDIOS ALTER COLUMN cod_subsidio char(2) not null
--ALTER TABLE SUBSIDIOS add  descripcion_corta nvarchar(70) not null
--ALTER TABLE SUBSIDIOS ALTER COLUMN descripcion_subsidio nvarchar(130) not null

CREATE TABLE Det_subsidios(
id_det_subsidios int not null,
id_subsidios int not null,
id_empleado int not null,
id_mes int not null,
id_periodo int not null,
dias int not null
)
GO


insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(1, '01', 'S.P.', 'SANCION DISCIPLINARIA', 'SANCION DISCIPLINARIA','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(2, '02', 'S.P.', 'EJERCICIO DERECHO HUELGA', 'EJERCICIO DEL DERECHO DE HUELGA','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(3, '03', 'S.P.', 'DETENCION DEL TRABAJADOR', 'DETENCION DEL TRABAJADOR, SALVO EL CASO DE CONDENA PRIVATIVA DE LA LIBERTAD','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(4, '04', 'S.P.', 'INHAB. ADMINIST. JUDI. O PENAL PRIVATIVA', 'INHABILITACION ADMINISTRATIVA O JUDICIAL POR PERIODO NO SUPERIOR A TRES MESES','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(5, '05', 'S.P.', 'LICENCIA U OTROS SIN GOCE DE HABER', 'PERMISO O LICENCIA CONCEDIDOS POR EL EMPLEADOR SIN GOCE DE HABER','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(6, '06', 'S.P.', 'CASO FORTUITO O FUERZA MAYOR', 'CASO FORTUITO O FUERZA MAYOR','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(7, '07', 'S.P.', 'FALTA NO JUSTIFICADA', 'FALTA NO JUSTIFICADA','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(8, '08', 'S.P.', 'POR TEMPORADA O INTERMITENTE', 'POR TEMPORADA O INTERMITENTE','NO SUBSIDIADOS', 1);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(9, '20', 'S.I.', 'ENFERM/ACCIDENTE (20 PRIMEROS DIAS)', 'ENFERMEDAD O ACCIDENTE (PRIMEROS VEINTE DÍAS)','NO SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(10, '21', 'S.I.', 'INCAP TEMPORAL (SUBSIDIADO)', 'INCAPACIDAD TEMPORAL (INVALIDEZ, ENFERMEDAD Y ACCIDENTES)', 'SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(11, '22', 'S.I.', 'MATERNIDAD - PRE Y POST NATAL', 'MATERNIDAD DURANTE EL DESCANSO PRE Y POST NATAL','SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(12, '23', 'S.I.', 'DESCANSO VACACIONAL', 'DESCANSO VACACIONAL','NO SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(13, '24', 'S.I.', 'LIC DESEMP CARGO CIVICO Y PARA SMO', 'LICENCIA PARA DESEMPEÑAR CARGO CÍVICO Y PARA CUMPLIR CON EL SERVICIO MILITAR OBLIGATORIO','NO SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(14, '25', 'S.I.', 'LIC DESEMPEÑO CARGOS SINDICALES', 'PERMISO Y LICENCIA PARA EL DESEMPEÑO DE CARGOS SINDICALES','NO SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(15, '26', 'S.I.', 'LICENCIA CON GOCE DE HABER', 'LICENCIA Y OTROS MOTIVOS CON GOCE DE HABER','NO SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(16, '27', 'S.I.', 'DIAS COMPENS POR HORAS DE SOBRETIEMPO', 'DÍAS COMPENSADOS POR HORAS TRABAJADAS EN SOBRETIEMPO','NO SUBSIDIADOS', 0);

insert into SUBSIDIOS(id_subsidios,cod_subsidio, tipo_suspencion, descripcion_corta, descripcion_subsidio, tipo_subsidio, descuento)
VALUES(17, '28', 'S.I.', 'DIAS LICENCIA POR PATERNIDAD','DIAS LICENCIA POR PATERNIDAD','NO SUBSIDIADOS', 0);

GO


--TABLA PLANILLA MANTO, AUNA FANTAN MAS CAMPOS QUE TENGO QUE PONER.
CREATE TABLE PlanillaManto(
idplanilla_manto int not null,
id_contrato int not null,
id_planilla int not null,
id_tipo_planilla int not null,--es foreing key
jornadalaboral varchar(11) not null,--exite en empleado
basico money not null,--exite en empleado
dias int null,
dia_dominical int null,
horas_diarias int null,
sueldo_basico money null,
asig_familiar decimal(5,2),--exite en empleado
--horas diurnas 25%
hora_dvc int null,
minuto_dvc int null,
monto_dvc decimal(5,2) null,
--hora diurna 35%
hora_dtc int null,
minuto_dtc int null,
monto_dtc decimal(5,2) null,
--hora nocturna 25%
hora_nvc int null,
minuto_nvc int null,
monto_nvc decimal(5,2) null,
--hora nocturna 35%
hora_ntc int null,
minuto_ntc int null,
monto_ntc decimal(5,2) null,
--feriado
hora_feriado int null,
minuto_feriado int null,
monto_feriado decimal(5,2) null,
--boni nocturna
hora_boni int null,
monto_boni decimal(5,2) null,
--primero de mayo
uno_mayo decimal(5,2)null,
--tardanzas
hora_tarde int null,
minuto_tarde int null,
monto_tarde decimal(5,2) null,
--subsidio
dia_sub int null,
monto_sub decimal (6,2) null,
--no subsidiados no laborados
dia_subnegativo int null,
monto_subnegativo decimal(6,2) null,
dia_subpositivo int null,
monto_subpositivo decimal(6,2) null,
--otros
total_horaex decimal(7,2) null,
reintegro decimal(6,2) null,
otro_reintegro decimal(6,2)null,
pre_alimentaria decimal(6,2)null, --prestacion alimentaria
gratiex decimal(7,2)null, --gratificacion extraordinaria
boniex decimal(7,2) null, --bonificacion 9%
vacaciones decimal(7,2) null,
--truncas
vaca_trunca decimal(7,2) null,
grati_trunca decimal(7,2) null,
boni_trunca decimal(7,2) null,
cts_trunca decimal(7,2) null,
--tota remu, onp y afp
total_remuneracion decimal(8, 2),
descuento_onp decimal (8,2) null,
des_comision decimal(8,2)null,
des_seguro decimal (8,2)null,
des_spp decimal(8,2) null,
--descuentos
essalud_vida decimal(6,2) null,
adelanto decimal(6,2) null,
prestamo decimal(6,2) null,
renta_quinta decimal(7,2) null,
retencion_judicial decimal(6,2) null,
otro_des decimal(6,2) null,
total_desc decimal(7,2)null,
total_pagar decimal(8,2) null,
aporte_essalud decimal(7,2) null,
transporte decimal(6,2) null,
recargo_consumo decimal(6,2)null,
reintegro_grati decimal(7,2)null,
reintegro_boni decimal(7,2)null
)
GO
--ALTER TABLE dbo.PlanillaManto ADD jornadalaboral varchar(11) not null


GO
-- CONCEPTOS PARA PLANILLA
CREATE TABLE Conceptos(
id_conceptos int not null,
id_mes int,
id_planilla int,
hextraDiurna bit not null,
hextraNocturna bit not null,
feriadoDomi bit not null,
boniNocturna bit not null,
primeroMayo bit not null,
tarda bit not null, -- tardanza
subsi bit not null,--subsidios
thoraex bit not null, --total horas extras
otroreinte bit not null, --otro reintegro
prest_aliment bit not null, --prestacion alimentaria
gratif bit not null, --gratificacion
vaca bit not null, --vacaciones
truncas bit not null,
reinte_gratiboni bit not null, --reintegro grati y boni
essa_vida bit not null, --essalud vida
adela bit not null, --adelanto
presta bit not null, --prestamo
rentquinta bit not null, --renta de quinta categoria
reten_judici bit not null, --retencion judicial
otrodescu bit not null, --otro descuento
recarg_consu bit not null --recargo consumo
)
GO


