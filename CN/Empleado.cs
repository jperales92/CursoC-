using System;


namespace CN
{
   public  class Empleado : Persona
    {
        public string usuario { get; set; }

        public int idEmpleado { get; set; }
        public Empleado(string _usuario,
                        int _idEmpleado,
                        string _nombreCompleto, 
                        string _direccion,
                        DateTime _fechaDenacimiento)
            : base(_nombreCompleto, _direccion, _fechaDenacimiento)
        {
            this.usuario = _usuario;
            this.idEmpleado = _idEmpleado;
        }

        public override string descripcion()
        {
            string resultado = string.Format("Usuario: {0} - ID Empleado: {1} - {2}",
                                              usuario,idEmpleado,base.descripcion());
            return resultado;
        }

    }
}
