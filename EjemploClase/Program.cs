using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using EjemploClase.Enums;

namespace EjemploClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Creamos varias variables tipo objeto!");

            Console.WriteLine(); // Una forma de dejar línea en blanco

            // Puedo tener varios objetos del mismo tipo
            // En un instituto educativo tendré varios alumnos

            Alumno alum = new Alumno();   // Creé un objeto del tipo alumno
                                           // Llamamos al constructor default o por omisión

            alum.dni = 34000000;
            alum.nombre = "Juan";
            alum.apellido = "Perez";
            alum.email = "jperez@gmail.com";
            alum.telefono = "+542214704156";
            alum.fechaNacimiento = Convert.ToDateTime("14/04/1990");

            ////////////////////////////
            //// SOBRECARGA
            ///////////////////////////
            
            Console.WriteLine(alum.mostrarDatos());

            Console.WriteLine(Environment.NewLine); // Otra forma de dejar línea en blanco

            // Llamo al método sobrecargado "OVERLOADED"
            Console.WriteLine(alum.mostrarDatos('A')); // mostrarDatos abreviado
            Console.WriteLine(Environment.NewLine); 
            Console.WriteLine(alum.mostrarDatos('D')); // mostrarDatos detallado

            Console.WriteLine(Environment.NewLine);
            alum.mostrarDatos("Hola"); // llamo a la versión procedimiento

            Console.WriteLine(Environment.NewLine);

            // Crearemos otros objetos alumno, pero la forma de cargarle los atributos
            // será a través de un constructor sobrecargado y la creación quedará encapsulada

            Alumno a = new Alumno("María", "Saez", 32333999, "masa@gmail.com", "2219393939", Convert.ToDateTime("21/07/1987"));

            Console.WriteLine(a.mostrarDatos('D'));


            a.notaPromedio = 8;
            Console.WriteLine($"La nota promedio de {a.apellidoYnombre} es {a.notaPromedio}");
            //Console.WriteLine($"La nota promedio de {a.apellidoYnombre}");

            Console.WriteLine(Environment.NewLine);

            // Creo un objeto profesor
            Profesor prof = new Profesor("Mariano", "Azul", 32333922, "ma@gmail.com", "2219393911", Convert.ToDateTime("21/07/1986"), enumPerfil.Titular);

            Console.WriteLine(prof.mostrarDatos());

            // Otra forma de mostrar los datos del profesor vía método ToString
            Console.WriteLine(prof.ToString());

            Console.ReadKey();
        }
    }
}
