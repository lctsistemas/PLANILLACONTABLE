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
        public Int32 id_contrato { get; set; }
        public Int32 id_empleado { get; set; }
        public Int32 id_banco { get; set; }
        public Int32 id_tcontrato { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public String num_cuenta { get; set; }
        public Decimal remu_basica { get; set; }
        public Decimal asig_fami { get; set; }
        public Decimal descuento { get; set; }
        public String tipo_moneda { get; set; }
        public String cts { get; set; }
        public String cussp { get; set; }

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
                dc.Id_contrato = id_contrato;
                dc.Id_empleado = id_empleado;
                dc.Id_banco = id_banco;
                dc.Id_tcontrato = id_tcontrato;
                dc.Fecha_inicio = fecha_inicio;
                dc.Fecha_fin = fecha_fin;
                dc.Num_cuenta = num_cuenta;
                dc.Remu_basica = remu_basica;
                dc.Asig_fami = asig_fami;
                dc.Descuento = descuento;
                dc.Tipo_moneda = tipo_moneda;
                dc.Cts = cts;
                dc.Cussp = cussp;

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

        //CODIGO AUTO GENERADO
        public int Getcodigo()
        {
            return new Kcontrato().Getcodigo();
        }
        public void Dispose()
        {
            //  throw new NotImplementedException();
        }
    }
}
