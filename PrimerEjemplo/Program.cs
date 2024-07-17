using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimerEjemplo
{
    static class Program
    {
        // IMPORTANTE:   Cuando defomp una clase con alcance o visibilidad STATIC, todos los miembros de la clase
        // (atributos, métodos, eventos, etc.), deben tener mismo alcance STATIC
        
        
        // Función que recibe 2 nros enteros, los suma y retorna el resultado tipo entero
        static int Suma(int a, int b)
        {
            return a + b;
        }

        // Procedimiento que recibe un string y muestra el mensaje en la consola
        // VOID indica que el método no retorna ningún valor desde su nombre
        static void Saludo(string nombre)
        {
            Console.WriteLine($"¡Hola {nombre}!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.BackgroundColor = ConsoleColor.Black; // color de fondo
            Console.ForegroundColor = ConsoleColor.Yellow; // color de texto

            Console.Clear();

            // Declaración de variables con TIPADO EXPLÍCITO

            int edad = 0; // declarar y dar valor inicial
            string nombre;
            bool bandera;


            Console.WriteLine("¿Cómo te llamás?");
            nombre = Console.ReadLine();

            /*Console.WriteLine("Ah! entonces tu nombre es " + texto);*/  // Concatenado común
            Console.WriteLine($"Ah! entonces tu nombre es {nombre} "); // Templete string -> Más recomendado

            // CONVERSIÓN DE TIPO DE DATOS
            Console.WriteLine("¿Cuál es tu edad?");
            /*edad = int.Parse(Console.ReadLine());*/     // Conversión a int
            edad = Convert.ToInt32(Console.ReadLine());   // Otra forma de convertir tipos de datos -> Más recomendado

            //Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine($"Ah! {nombre} entonces tenés {edad} años ");


            // ambas formas dejan una línea
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine();

            // TIPADO EXPLÍCITO o definición de variables con VAR

            var i = 5;                      // i es compilado como un int  -> Asocia al tipo de dato

            var s = "sombrero";             // s se compila como string > Asocia al tipo de dato

            var a = new[] { 0, 1, 2, 3 };   // a se compila como int[] > Asocia al tipo de dato

            i = i + 4;

            Console.WriteLine($"Las variables {i} y {s}");

            // Recorro el array y muestro el valor de cada elemento
            foreach (var elemento in a) {
                Console.WriteLine($"El valor del elemento del arreglo es {elemento}");
            }


            // Buena práctica de escritura de las estructuras de control
            // Se recomienda siempre escribir las { }



            // Ejemplo de arreglo (con librería Generics)
            string[] nombres = { "LORENA", "ESTEBAN", "ARIEL" };
            
            byte K = 0;
            
            //Recorrida del arreglo
            for (K = 0; K <= 2; K++)
            {
                Console.WriteLine(nombres[K]);
            }

            // para operar el arreglo utiliza LINQ (Language Integrated Query

            nombres.Append("MARIA");  // Agrego el nombre MARIA al arreglo.   De esta forma evita usar subíndices para cargar arreglos



             ///////////////////////////////////////////////////
            ////   SUMA como Función y como Procedimiento  ////
           ///////////////////////////////////////////////////

            // Ejemplo de Método SUMA estilo función
            int unNro, otroNro;

            Console.WriteLine("Ingrese un número entero:");
            unNro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro número entero:");
            otroNro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma de {unNro} + {otroNro} da {Suma(unNro,otroNro)}");



            // Ejemplo de Método SUMA estilo procedimiento
            string Nombre1;
            
            Console.WriteLine("¿Cuál es tu nombre?");
            Nombre1 = Console.ReadLine();

            Program.Saludo(Nombre1);


            // Para finalizar espera que apriete alguna tecla
            Console.ReadKey();


        }
    }
}
