﻿using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace Negocio.Models
{
    public class NEmpleado : IDisposable
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
        [RegularExpression("([0-9]+)", ErrorMessage = "identification number must be only numbers")]
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

        public EntityState state { get; set; }

        public IEmpleado Rempleado;

        //List<NEmpleado> listaemp;

        public NEmpleado()
        {
            Rempleado = new REmpleado();
        }

        public String GuardarCambios()
        {
            String mensaje = "";

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
            catch (Exception ex)
            {
                ex.ToString();
            }

            return mensaje;
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

        public DataTable GetData(Int32 entiti,String search, String nombre_empleado) 
        {
            DEmpleado d = new DEmpleado();
            d.Id_emp_maestra = entiti;
            d.Num_doc = search;
            d.Nom_emp = nombre_empleado;
            using (var dt = Rempleado.GetData(d))
            {
                return dt;
            }

        }

        public bool ListaEmpleado(List<object> list, NEmpleado entity)
        {
            DEmpleado de = new DEmpleado();
            de.Id_emp_maestra = entity.Id_emp_maestra; 
            de.Num_doc = entity.Num_doc;
            de.Nom_emp = entity.Nom_emp;
            
            return new REmpleado().ListaEmpleado(list, de);
        }

        /*public IEnumerable<NEmpleado> Search(String filter)
        {
            return listaemp.FindAll(e => e.Num_doc.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 || e.Nom_emp.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }*/

        //public List<NEmpleado> GetAll(Int32 entiti, String search, String nombre_empleado)
        //{
        //    DEmpleado de = new DEmpleado();
        //    de.Id_emp_maestra = entiti;
        //    de.Num_doc = search;
        //    de.Nom_emp = nombre_empleado;

        //    using (DataTable dt = Rempleado.GetData(de))
        //    {

        //    }
        //}
    }
}
