using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjemploClase
{
    // Cuando creo una clase, estoy creando la definición de un tipo de dato propio
    // estoy creando una plantilla, template o molde
    public class Alumno : Persona // Herencia Alumno es una Persona
    {
        #region CONSTRUCTORES
        // Los constructores sirver para crear objetos y admiten sobrecarga

        // Siempre existe el constructor default o por omisión, sin parámetros
        // El CONSTRUCTOR SIEMPRE ESTÁ! aunque no lo haga explícito
        // La misión del Constructor es INICIALIZAR el objeto
        public Alumno() 
        {
            //nombre = "";
            //apellido = "";
            //dni = 0;
            //email = "";
            //telefono = "";
            //fechaNacimiento = DateTime.MinValue;

        }

        // Constructor con sobrecarga
        public Alumno(string nom, string ape, int DNI, string mail, string tel, DateTime fechaNac )
        {
            nombre = nom;
            apellido = ape;
            dni = DNI;
            email = mail;
            telefono = tel;
            fechaNacimiento = fechaNac;
        }


        #endregion CONSTRUCTORES

        #region ATRIBUTOS

        //// Atributos o datos que tendré del alumno

        //// Defino los atributos en forma AUTOIMPLEMENTADA
        //// get y set son ACCESORES para leer y escribir o cambiar el valor del atributo
        //public string nombre { get; set; }
        //public string apellido { get; set; }
        //public int dni {  get; set; }
        //public string email { get; set; }
        //public string telefono { get; set; }
        //public DateTime fechaNacimiento { get; set; }

        // Creo los atributos específicos de alumno
        // public int notaPromedio { get; set; } // forma autoimplementada

        private int np;
        public int notaPromedio     //forma estructurada guardando el valor en variable privada
        {
            get         //cuando se lee el valor del atributo
            {
                //depende de un cálculo e irían varias instrucciones
                // por ejemplo, recuperar el promedio desde un cálculo en la base de datos

                return np;
            }
            set         //cuando se asigna el valor del atributo
            {
                np = value;
            }
        }

        // Propiedad de sólo lectura solo get en forma estructurada
        // el valor del atributo lo fabrica la clase, desde afuera NADIE lo cambiará
        public string apellidoYnombre
        {
            get
            {
                return $"{apellido}, {nombre}";
            }
        }

        // Otra forma de definir un atributo read only con una expresión lambda
        public string NombreCompleto => nombre + " " + apellido; 

        #endregion ATRIBUTOS

        #region METODOS
        // Métodos, funcionalidad del alumno

        //public string mostrarDatos()
        //{

        //    string resultado;

        //    resultado = $" Nombre y Apellido: {nombre} {apellido} DNI: {dni} Email: {email} Teléfono: {telefono} " +
        //                $" Edad: {calcularEdad()} años";

        //    return resultado;

        //}

        public string mostrarDatos(char Estilo)
        {
            // Esta versión del MostrarDatos, si recibe un D lo mostrará detallado, 
            // y si recibe un A lo mostrará abreviado
            string resultado;

            if (Estilo == 'D')
            {
                //resultado = $" {nombre} {apellido} DNI: {dni} Email: {email} Teléfono: {telefono} " +
                //$" Edad: {calcularEdad()} años";
                resultado = mostrarDatos(); // Llamo a la otra sobrecarga
            }
            else
            {
                resultado = $" {nombre} {apellido}  Email: {email}";
            }
            return resultado;
        }

        public void mostrarDatos(string Saludo)
        {   // estilo procedimiento pues void no devuelve valor
            Console.WriteLine($" {Saludo}, {nombre} {apellido}!!");
        }
        // Si bien esta sobrecarga funciona, en buena práctica de programación de componentes de clase
        // no deberían tener instrucciones de entrada/salida con interacción del usuario


        //private int calcularEdad()
        //{
        //    // https://www.dotnetperls.com/datetime //
        //    int iAnios;
        //    iAnios = DateTime.Today.AddTicks(- fechaNacimiento.Ticks).Year - 1;
        //    return iAnios;
        //}

        #endregion METODOS
    }

}
