using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;

namespace Negocio.Models
{
    public class NContrato : IDisposable

    {
        String mensaje;
        //List<NContrato> list_contract;
        private Int32 id_contrato { get; set; }
        private Int32 id_empleado { get; set; }
        private Int32 id_banco { get; set; }
        private Int32 id_tcontrato { get; set; }
        private DateTime fecha_inicio { get; set; }
        private DateTime fecha_fin { get; set; }
        private String num_cuenta { get; set; }
        private Decimal remu_basica { get; set; }
        private Decimal asig_fami { get; set; }
        private Decimal descuento { get; set; }
        private String tipo_moneda { get; set; }
        private String cts { get; set; }

        public EntityState state { get; set; }
        private IContrato contract_repository;

        public NContrato()
        {
            contract_repository = new RContrato();
        }


        //METODO GUARDAR CAMBIOS
        public string SaveChanges()
        {
            try
            {
                Dcontrato dc = new Dcontrato();
                id_contrato = dc.Id_contrato;
                id_empleado = dc.Id_empleado;
                id_banco = dc.Id_banco;
                id_tcontrato = dc.Id_tcontrato;
                fecha_inicio = dc.Fecha_inicio;
                num_cuenta = dc.Num_cuenta;
                remu_basica = dc.Remu_basica;
                asig_fami = dc.Asig_fami;
                descuento = dc.Descuento;
                tipo_moneda = dc.Tipo_moneda;
                cts = dc.Cts;

                switch (state)
                {
                    case EntityState.Guardar:
                        contract_repository.Add(dc);
                        mensaje = "¡Registro Exitosamente!";
                        break;
                    case EntityState.Modificar:
                        contract_repository.Edit(dc);
                        mensaje = "¡Modificado Exitosamente!";
                        break;
                    case EntityState.Remover:
                        contract_repository.Delete(dc);
                        mensaje = "Eliminado";
                        break;
                    default:
                        mensaje = "Error in Transaction";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally { }
            return mensaje;

        }

        public DataTable MostrarBanco()
        {
            return new Kcontrato().MostrarBanco();
        }

        public void Dispose()
        {
            //  throw new NotImplementedException();
        }
    }
}
