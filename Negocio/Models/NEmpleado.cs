using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Datos.KeyAutomatic;
namespace Negocio.Models
{
    public class NEmpleado:IDisposable
    {

        public Int32 Id_empleado { get; set; }
        public String Nom_emp { get; set; }
        public String Ape_pat { get; set; }
        public String Ape_mat { get; set; }
        public String Tip_pension { get; set; }
        public DateTime Fec_nac { get; set; }
        public String Nacionalidad { get; set; }
        public String Tipo_genero { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Num_doc { get; set; }
        public String Estado { get; set; }
        public Int32 Id_afp { get; set; }
        public string Nombre_afp { get; set; }
        public Int32 Id_doc { get; set; }
        public string Documento { get; set; }
        public Int32 Id_cargo { get; set; }
        public string Cargo { get; set; }
        public Int32 Id_emp_maestra { get; set; }
        public string Empresa { get; set; }

        public EntityState state{get; set;}

        public IEmpleado Rempleado;

        //List<NEmpleado> listaemp;

        public NEmpleado()
        {
            Rempleado = new REmpleado();
        }

        public String GuardarCambios()
        {
            String mensaje="";

            try
            {
                DEmpleado emp = new DEmpleado();
                emp.Id_empleado = Id_empleado;
                emp.Nom_emp = Nom_emp;
                emp.Ape_pat = Ape_pat;
                emp.Ape_mat = Ape_mat;
                emp.Tip_pension = Tip_pension;
                emp.Fec_nac = Fec_nac;
                emp.Nacionalidad = Nacionalidad;
                emp.Tipo_genero = Tipo_genero;
                emp.Direccion = Direccion;
                emp.Telefono = Telefono;
                emp.Num_doc = Num_doc;
                emp.Estado = Estado;
                emp.Id_afp = Id_afp;
                emp.Id_doc = Id_doc;
                emp.Id_cargo = Id_cargo;
                emp.Id_emp_maestra = Id_emp_maestra;

                switch (state)
                {
                    case EntityState.Guardar:
                        Rempleado.Add(emp);
                        mensaje = emp.mensaje;
                        break;

                    case EntityState.Modificar:
                        Rempleado.Edit(emp);
                        mensaje = "Editado correctamente";
                    break;

                    case EntityState.Remover:
                        Rempleado.Delete(emp);
                        mensaje = "Eliminado correctamente";
                        break;
                    default:
                        mensaje = "Error in Transaction!";
                        break;
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

            return mensaje;
        }

        public DataTable Mostrar_car_empleado()
        {
            return new Kcargo_empleado().Mostrar_car_empleado();
        }

        public DataTable Mostrar_TipoDocumento()
        {
            return new Kdocumento_emp().MostrarDocumentoEmp();
        }

        public DataTable Mostrar_AFP()
        {
            return new KAFP().Mostrar_Afp();
        }

        public DataTable Mostrar_Empresa()
        {
            return new KEmpresa().MostrarEmpresa();
        }

        public int GetCodigo()
        {
            return new KEmpleado().GetCodigo();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        //public List<NEmpleado> listar()
        //{
        //    DEmpleado de = new DEmpleado();
            
        //    de.Nom_emp = Nom_emp;
            
            

        //    using (DataTable dt = Rempleado.GetData(de))
        //    {
        //         listaemp= new List<NEmpleado>();

        //        foreach (DataRow item in dt.Rows)
        //        {
        //            listaemp.Add(new NEmpleado()
        //            {
        //                Id_empleado = Convert.ToInt32(item[0]),
        //                Nom_emp = item[1].ToString(),
        //                Ape_pat = item[2].ToString(),
        //                Ape_mat = item[3].ToString(),
        //                Tip_pension = item[4].ToString(),
        //                Fec_nac = Convert.ToDateTime(item[5].ToString()),
        //            Nacionalidad = item[6].ToString(),
        //            Tipo_genero = item[7].ToString(),
        //            Direccion = item[8].ToString(),
        //            Telefono = item[9].ToString(),
        //            Num_doc = item[10].ToString(),
        //            Estado = item[11].ToString(),

        //            Id_afp= Convert.ToInt32(item[12]),
        //            Nombre_afp=item[13].ToString(),
                    
        //            Id_doc= Convert.ToInt32(item[14]),
        //            Documento = item[15].ToString(),

        //            Id_cargo= Convert.ToInt32(item[16]),
        //            Cargo =item[17].ToString(),

        //            Id_emp = Convert.ToInt32(item[18]),
        //            Empresa =item[19].ToString()
                    
        //             });
        //        }
        //    return listaemp;
        //}
        //}


        //PRUEBA

        public DataTable GetData(String entiti) {
            DEmpleado d = new DEmpleado();
            d.Nom_emp=entiti;
            using (var dt= Rempleado.GetData(d))
            {
                return dt;
            }
            
        }
    }
}
