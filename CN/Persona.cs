using System;

namespace CN
{
    public class Persona
    {
        #region Propiedades 

        private string _nomreCompleto;
        public string nombreCompleto
        {
            get { return _nomreCompleto; }
            // set { _nomreCompleto = value; }
        }

        private DateTime _fechaNacimiento;
        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public int edad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - fechaNacimiento.Year;
                if (hoy < fechaNacimiento.AddYears(edad))
                {
                    edad--;
                }
                return edad;
            }
        }
        public string Direccion { get; set; }
        #endregion

        #region Constructores

        public  Persona(string _nombreCompleto, string _direccion, DateTime _fechaDenacimiento)
        {
            this._nomreCompleto = _nombreCompleto;
            this.Direccion = _direccion;
            this._fechaNacimiento = _fechaDenacimiento;
        }

        #endregion

        #region Metodos
        public virtual string descripcion()
        {
            string resultado = string.Format("Nombre: {0} - Dirrecion: {1} - Fecha Denacieminto :{2} - Edad : {3}",
                                              nombreCompleto, Direccion, fechaNacimiento, edad);
            return resultado;
        }


        #endregion

    }
}
