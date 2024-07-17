using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase
{
    public class Persona
    {

        #region CONSTRUCTORES
        public Persona() 
        {
            nombre = "";
            apellido = "";
            dni = 0;
            email = "";
            telefono = "";
            fechaNacimiento = DateTime.MinValue;
        }

        #endregion CONSTRUCTORES

        #region ATRIBUTOS

        // Atributos o datos que tendré del alumno

        // Defino los atributos en forma AUTOIMPLEMENTADA
        // get y set son ACCESORES para leer y escribir o cambiar el valor del atributo
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }

        #endregion ATRIBUTOS

        #region METODOS

        public string mostrarDatos()
        {

            string resultado;

            resultado = $" Nombre y Apellido: {nombre} {apellido} DNI: {dni} Email: {email} Teléfono: {telefono} " +
                        $" Edad: {calcularEdad()} años";

            return resultado;

        }

        private int calcularEdad()
        {
            // https://www.dotnetperls.com/datetime //
            int iAnios;
            iAnios = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
            return iAnios;
        }

        #endregion METODOS


    }
}
