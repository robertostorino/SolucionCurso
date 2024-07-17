using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploClase.Enums;

namespace EjemploClase
{
    public class Profesor : Persona
    {
        #region CONSTRUCTOR

        // Constructor default
        public Profesor() { }

        // Constructor sobrecargado
        public Profesor(string nom, string ape, int DNI, string mail, string tel, DateTime fechaNac, enumPerfil per)
        {
            nombre = nom;
            apellido = ape;
            dni = DNI;
            email = mail;
            telefono = tel;
            fechaNacimiento = fechaNac;
            perfil = per;
        }

        #endregion CONSTRUCTOR

        #region ATRIBUTO

        // Defino sólo para el profesor el atributo perfil del tipo enumeración enumPerfil
        public enumPerfil perfil {  get; set; }

        #endregion ATRIBUTO


        #region MÉTODOS

        public new string mostrarDatos()
            // NOTA: con el new oculto el mostrarDatos de Persona
        {
            string resultado = "";

            // base es la referencia a la clase padre en este caso Persona
            resultado = base.mostrarDatos() + $" Perfil: {perfil} ";
            //resultado = $"{base.mostrarDatos()} + perfil {perfil}";  

            return resultado;
        }

        // todas las clases del framework .NET y las creamos en nuestros modelados,
        // heredan de system.object. Herencia implícita.

        // El ToString es un método del objeto System.Object
        // https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-object
        public override string ToString()
        {
            return ( base.mostrarDatos() + $" Perfil: {perfil} ");
        }

        #endregion MÉTODOS
    }
}
