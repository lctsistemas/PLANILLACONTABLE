﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class DtipoDocumento
    {
        private int _iddocumento;
        private string _nombre_documento;
        private string _descripcion;
        public string message { get; set; }

        //METODOS GET AND SET
        public int Iddocumento
        {
            get { return _iddocumento; }
            set { _iddocumento = value; }
        }

        public string Nombre_documento
        {
            get { return _nombre_documento; }
            set { _nombre_documento = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        //CONSTRUCTORES
        public DtipoDocumento() { }

        public DtipoDocumento(string docu, string des) {
            this.Nombre_documento = docu;
            this.Descripcion = des;
        }
    }
}
