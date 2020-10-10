namespace Datos.Entities
{
    public class Dafp
    {
        #region Atributos
        private int id_comision;
        private int codigo_regimen;
        private decimal comision;
        private decimal saldo;
        private decimal seguro;
        private decimal aporte;
        private decimal tope;
        private int idmes;
        private string mes;
        private int idperiodo;
        #endregion

        #region Metodo Set and Get
        public int Id_comision { get { return id_comision; } set { id_comision = value; } }
        public int Codigo_regimen { get { return codigo_regimen; } set { codigo_regimen = value; } }
        public decimal Comision { get { return comision; } set { comision = value; } }
        public decimal Saldo { get { return saldo; } set { saldo = value; } }
        public decimal Seguro { get { return seguro; } set { seguro = value; } }
        public decimal Aporte { get { return aporte; } set { aporte = value; } }
        public decimal Tope { get { return tope; } set { tope = value; } }
        public int Idmes { get { return idmes; } set { idmes = value; } }
        public string Mes { get { return mes; } set { mes = value; } }
        public int Idperiodo { get { return idperiodo; } set { idperiodo = value; } }
        #endregion
    }
}
