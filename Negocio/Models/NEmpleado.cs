using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace Negocio.Models
{
    public class NEmpleado : IDisposable
    {
        string mensaje;
        List<NEmpleado> listaemp;        
        public Int32 Id_empleado { get; set; }
        public String Codigo { get; set; }    
        public String Nom_emp { get; set; }
        public String Ape_pat { get; set; }
        public String Ape_mat { get; set; }
        public String Tip_pension { get; set; }
        public DateTime Fec_nac { get; set; }
        public String Nacionalidad { get; set; }
        public String Tipo_genero { get; set; }
        public String Direccion { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "identification number must be only numbers")]
        public String Telefono { get; set; }
        public String Num_doc { get; set; }
        public String Estado { get; set; }       
        public Int32 Codigo_regimen { get; set; }
        public Int32 Id_doc { get; set; }
        public Int32 Id_cargo { get; set; }
        public Int32 Id_emp_maestra { get; set; }//
        public String Empresa { get; set; }//

        //METODOS SET AND GET DE CONTRATO
        public Int32 cid_contrato { get; set; }
        public Int32 cid_empleado { get; set; }
        public Int32 cid_banco { get; set; }
        public Int32 cid_tcontrato { get; set; }
        public DateTime cfecha_inicio { get; set; }
        public DateTime cfecha_fin { get; set; }
        public String cnum_cuenta { get; set; }
        public Decimal cremu_basica { get; set; }
        public Decimal casig_fami { get; set; }
        public String cregimen_salud { get; set; }
        public String ctipo_pago { get; set; }
        public String cperiodicidad { get; set; }
        public String ctipo_moneda { get; set; }
        public String ccts { get; set; }
        public String ccussp { get; set; }

        public EntityState state { get; set; }
        public IEmpleado Rempleado;
        public IContrato rcontrato;

        public NEmpleado()
        {
            Rempleado = new REmpleado();
            rcontrato = new REmpleado();
        }

        public String GuardarCambios()
        {
            mensaje = "";
            try
            {
                DEmpleado emp = new DEmpleado();
                Dcontrato dcon = new Dcontrato();

                emp.Id_empleado = Id_empleado;
                emp.Codigo = Codigo;
                emp.Nom_emp = Nom_emp;
                emp.Ape_pat = Ape_pat;
                emp.Ape_mat = Ape_mat;               
                emp.Fec_nac = Fec_nac;
                emp.Nacionalidad = Nacionalidad;
                emp.Tipo_genero = Tipo_genero;
                emp.Direccion = Direccion;
                emp.Telefono = Telefono;
                emp.Num_doc = Num_doc;
                emp.Estado = Estado;
                emp.Codigo_regimen = Codigo_regimen;
                emp.Id_doc = Id_doc;
                emp.Id_cargo = Id_cargo;
                emp.Id_emp_maestra = Id_emp_maestra;

                //METODOS DE CONTRATO
                dcon.Id_contrato = cid_contrato;
                dcon.Id_banco = cid_banco;
                dcon.Id_tcontrato = cid_tcontrato;
                dcon.Fecha_inicio = cfecha_inicio;
                dcon.Fecha_fin = cfecha_fin;
                dcon.Num_cuenta = cnum_cuenta;
                dcon.Remu_basica = cremu_basica;
                dcon.Asig_fami = casig_fami;
                dcon.Regimen_salud = cregimen_salud;
                dcon.Tipo_pago = ctipo_pago;
                dcon.Tipo_moneda = ctipo_moneda;
                dcon.Periodicidad = cperiodicidad;
                dcon.Cts = ccts;
                dcon.Cussp = ccussp;

                switch (state)
                {
                    case EntityState.Guardar:
                        if(Rempleado.Add(emp) > 0)
                           rcontrato.Add(dcon);                                                                                               
                        
                        mensaje = emp.mensaje;
                        break;

                    case EntityState.Modificar:
                        Rempleado.Edit(emp);
                        mensaje = "¡Editado correctamente!";
                        break;

                    case EntityState.Remover:
                        Rempleado.Delete(emp);
                        mensaje = "¡Eliminado correctamente!";
                        break;

                    default:
                        mensaje = "¡Error in Transaction!";
                        break;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {}

            return mensaje;
        }

        public int GetCodigo_empleado()
        {
            return new KPlanilla().GetCodigo();
        }

        public int Getcodigo_contrato()
        {
            return new Kcontrato().Getcodigo();
        }


        public IEnumerable<NEmpleado> listar_empleado()
        {
            DEmpleado de = new DEmpleado();

            de.Id_emp_maestra = Id_emp_maestra;
            using (DataTable dt = Rempleado.GetData(de))
            {
                listaemp = new List<NEmpleado>();

                foreach (DataRow item in dt.Rows)
                {
                    listaemp.Add(new NEmpleado()
                    {
                        Id_empleado = Convert.ToInt32(item[0]),
                        Nom_emp =(item[1].ToString() +" "+ item[2].ToString() +",  "+ item[3].ToString()),
                        Id_emp_maestra = Convert.ToInt32(item[4]),
                        Empresa = item[5].ToString(),
                    });
                }
                return listaemp;
            }
        }
        
        public IEnumerable<NEmpleado> Search(String filter)
        {
            return listaemp.FindAll(e => e.Nom_emp.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);            

        }

        //CONTRATO
        public DataTable ListaEmple_total(NEmpleado entiti)
        {
            Dcontrato dcon = new Dcontrato();
            dcon.Id_empleado = entiti.Id_empleado;
            return new REmpleado().GetData(dcon);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
