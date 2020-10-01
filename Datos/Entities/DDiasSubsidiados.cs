using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DDiasSubsidiados
    {
        Int32 id_det_subsidios;
        Int32 id_subsidios;
        Int32 id_empleado;
        Int32 id_mes;
        Int32 id_periodo;
        Int32 dias;

        public DDiasSubsidiados(int id_det_subsidios, int id_subsidios, int id_empleado, int id_mes, int id_periodo, int dias)
        {
            this.id_det_subsidios = id_det_subsidios;
            this.id_subsidios = id_subsidios;
            this.id_empleado = id_empleado;
            this.id_mes = id_mes;
            this.id_periodo = id_periodo;
            this.dias = dias;
        }

        public DDiasSubsidiados()
        {

        }
        public String mensaje { get; set; }
        public int Id_det_subsidios { get => id_det_subsidios; set => id_det_subsidios = value; }
        public int Id_subsidios { get => id_subsidios; set => id_subsidios = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_mes { get => id_mes; set => id_mes = value; }
        public int Id_periodo { get => id_periodo; set => id_periodo = value; }
        public int Dias { get => dias; set => dias = value; }
    }
}
