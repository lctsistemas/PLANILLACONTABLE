--PRIMARY KEY
alter table Grati_manto ADD CONSTRAINT Pk_id_grati_manto PRIMARY KEY(id_grati)
alter table Meses_maestra ADD CONSTRAINT pk_id_meses_m PRIMARY KEY(id_meses_maestra)
alter table Faltas ADD CONSTRAINT pk_id_falta PRIMARY KEY(id_falta)
alter table cts ADD CONSTRAINT pk_id_cts PRIMARY KEY(id_cts)
alter table Gratificaciones ADD CONSTRAINT pk_id_grati PRIMARY KEY(id_grati)
alter table cts_manto ADD CONSTRAINT pk_cts_manto PRIMARY KEY(id_cts_manto)
alter table Descuentos ADD CONSTRAINT pk_id_desc PRIMARY KEY(id_descuentos)
alter table Periodo ADD CONSTRAINT pk_id_periodo PRIMARY KEY(id_periodo)
alter table Mes ADD CONSTRAINT pk_id_mes PRIMARY KEY(id_mes)
alter table Planilla ADD CONSTRAINT pk_id_planilla PRIMARY KEY(id_planilla)
alter table tipo_planilla ADD CONSTRAINT pk_idTipo_planilla PRIMARY KEY(id_tipo_planilla)
alter table ComisionesPension ADD CONSTRAINT pk_comision PRIMARY KEY(idcomision)
alter table RegimenPensionario ADD CONSTRAINT pk_idregimen PRIMARY KEY(codigo_regimen)
alter table SUBSIDIOS ADD CONSTRAINT pk_idsubsidios PRIMARY KEY(id_subsidios)

--FOREIGN KEY 
ALTER TABLE Grati_manto ADD CONSTRAINT FK_id_MesGrati FOREIGN KEY(id_meses)REFERENCES Meses_maestra
ALTER TABLE Faltas ADD CONSTRAINT FK_id_MesFalta FOREIGN KEY(id_meses)REFERENCES Meses_maestra
ALTER TABLE cts ADD CONSTRAINT FK_id_PerCts FOREIGN KEY(id_periodo)REFERENCES Periodo
ALTER TABLE Gratificaciones ADD CONSTRAINT FK_id_PerGrati FOREIGN KEY(id_periodo)REFERENCES Periodo
ALTER TABLE cts_manto ADD CONSTRAINT FK_id_MesCts FOREIGN KEY(id_meses)REFERENCES Meses_maestra
--ALTER TABLE Periodo ADD CONSTRAINT fk_id_MesPeriodo FOREIGN KEY(id_meses) REFERENCES Meses_maestra
--ALTER TABLE Periodo ADD CONSTRAINT fk_id_mesper FOREIGN KEY(id_mes) REFERENCES Mes
ALTER TABLE Planilla ADD CONSTRAINT fk_idtipo_planilla FOREIGN KEY(id_tipo_planilla) REFERENCES tipo_planilla
ALTER TABLE Planilla ADD CONSTRAINT Fk_idperiodo FOREIGN KEY(id_periodo) REFERENCES dbo.periodo
ALTER TABLE Planilla ADD CONSTRAINT Fk_idemp_plan FOREIGN KEY(id_empresa) REFERENCES dbo.Empresa
alter table DET_SUBSIDIOS ADD CONSTRAINT Fk_idsub PRIMARY KEY(id_subsidios)


TRUNCATE TABLE ComisionesPension

ALTER TABLE ComisionesPension ADD CONSTRAINT fk_periodo FOREIGN KEY(idperiodo) REFERENCES Periodo(id_periodo)
ALTER TABLE ComisionesPension ADD CONSTRAINT fk_mes FOREIGN KEY(idmes) REFERENCES Mes(id_mes)
ALTER TABLE ComisionesPension ADD CONSTRAINT fk_regpension FOREIGN KEY(codigo_regimen) REFERENCES RegimenPensionario

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

--PRIMARY KEY TABLA: EMPLEADO, CARGO, TIPO DOCUMENTO, AFP
ALTER TABLE Empleado ADD CONSTRAINT PK_idempleado PRIMARY KEY(id_empleado)
ALTER TABLE Cargo ADD CONSTRAINT PK_idcargo PRIMARY KEY(id_cargo)
ALTER TABLE Tipo_documento ADD CONSTRAINT PK_tdocumento PRIMARY KEY(id_documento)
ALTER TABLE Afp ADD CONSTRAINT PK_idafp PRIMARY KEY(id_afp)
TRUNCATE TABLE TIPO_DOCUMENTO
--FOREIGN KEY: EMPLEADO CON  CARGO, TIPO DOCUMENTO, AFP, EMPRESA, 
ALTER TABLE Empleado ADD CONSTRAINT FK_EempresaM FOREIGN KEY(id_em_maestra)REFERENCES Empresa_maestra
Alter TABLE	Empleado ADD CONSTRAINT FK_Eidcargo FOREIGN KEY(id_cargo)REFERENCES Cargo
Alter TABLE	Empleado ADD CONSTRAINT FK_Eiddocumento FOREIGN KEY(id_documento)REFERENCES Tipo_documento
Alter TABLE	Empleado ADD CONSTRAINT FK_EregiPension FOREIGN KEY(codigo_regimen)REFERENCES RegimenPensionario
GO

--TABLA: Contrato, Banco y Tipo_contrato 
ALTER TABLE Contrato ADD CONSTRAINT PK_idcontrato PRIMARY KEY(id_contrato)
ALTER TABLE Banco ADD CONSTRAINT PK_idbanco PRIMARY KEY(id_banco)
ALTER TABLE Tipo_Contrato ADD CONSTRAINT PK_idtcontrato PRIMARY KEY(id_tipocontrato)

--FOREIGN KEY CONTRATO CON BANCO, TIPO_CONTRATO, EMPLEADO
ALTER TABLE Contrato ADD CONSTRAINT FK_Cbanco FOREIGN KEY(id_banco) REFERENCES Banco
ALTER TABLE Contrato ADD CONSTRAINT FK_CEmpleado FOREIGN KEY(id_empleado) REFERENCES Empleado

--FOREIGN KEY DELETE EN CASCADA
ALTER TABLE Contrato  WITH CHECK ADD  CONSTRAINT [FK_CEmpleado] FOREIGN KEY(id_empleado)
REFERENCES Empleado
ON DELETE CASCADE
GO

--ALTER TABLE Contrato ADD CONSTRAINT FK_CBanco FOREIGN KEY(id_banco) REFERENCES Banco
ALTER TABLE Contrato ADD CONSTRAINT Fk_CTipo_Contrato FOREIGN KEY(id_tipocontrato) REFERENCES Tipo_Contrato 

--DIAGRAMA
ALTER AUTHORIZATION ON DATABASE::Planilla_lct TO[SA]
GO

--INSERTAR REGISTRO EN LAS TABLAS

INSERT INTO RegimenPensionario(descripcion_corta, descripcion,tipo_regimen) VALUES
('HM','HABITAT MIXTA','SPP'),('HF','HABITAT FLUJO','SPP'),
('IM','INTEGRA MIXTA','SPP'),('IF','INTEGRA FLUJO','SPP'),
('PM','PRIMA MIXTA','SPP'),('PF','PRIMA FLUJO','SPP'),
('PRM','PROFUTURO MIXTA','SPP'),('PRF','PROFUTURO FLUJO','SPP'),
('O.N.P','DECRETO LEY 19990-ONP','SNP')
GO

-- INSERTAR COMISIONES PENSIONES
INSERT INTO ComisionesPension(codigo_regimen, comision, saldo, seguro, aporte, tope, idmes, idperiodo)VALUES
(1, 0.38, 1.25, 1.35, 10.00, 9792.61,9, 2),(2, 1.47, 1.25, 1.35, 10.00, 9792.61,9, 2),--HABITAT
(3, 0.00, 0.82, 1.35, 10.00, 9792.61,9,2),(4, 1.55, 0.82, 1.35, 10.00, 9792.61,9,2),--INTEGRA
(5, 0.18, 1.25, 1.35, 10.00, 9792.61, 9, 2),(6, 1.60, 1.25, 1.35, 10.00, 9792.61, 9, 2),--PRIMA
(7, 0.67, 1.20, 1.35, 10.00, 9792.61,9, 2),(8, 1.69, 1.20, 1.35, 10.00, 9792.61,9, 2)--PROFUTURO

GO




