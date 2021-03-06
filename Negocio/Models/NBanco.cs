﻿using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Negocio.Models
{
    public class NBanco : IDisposable
    {
        String mensaje;
        public Int32 IdBanco { get; set; }       
        public String Nom_banco { get; set; }

        public EntityState state { get; set; }
        private IBanco RBanco;
        private List<NBanco> list_banco;

        public NBanco()
        {
            RBanco = new RBanco();
        }

        public String GuardarCambios()
        {
            DBanco ban = new DBanco();
            ban.IdBanco = IdBanco;
            ban.Nom_banco = Nom_banco;

            switch (state)
            {
                case EntityState.Guardar:
                    RBanco.Add(ban);
                    mensaje = ban.mensaje;
                    break;

                case EntityState.Modificar:
                    RBanco.Edit(ban);
                    mensaje = "¡Modificado!";
                    break;

                case EntityState.Remover:
                    RBanco.Delete(ban);
                    mensaje = ban.mensaje;
                    break;
            }
            return mensaje;
        }

       
        public void Dispose()
        {
            // throw new NotImplementedException();
        }


        public IEnumerable<NBanco> Getall()
        {
            using (DataTable dt = RBanco.GetData(null))
            {
                list_banco = new List<NBanco>();
                foreach (DataRow item in dt.Rows)
                {
                    list_banco.Add(new NBanco()
                    {
                        IdBanco = Convert.ToInt32(item[0]),
                        Nom_banco = item[1].ToString()
                    });
                }                
            }
            return list_banco;
        }
        
        //public IEnumerable<NBanco> Search(string filter)
        //{
        //    return list_banco.FindAll(e => e.Nom_banco.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        //}
    }
}
