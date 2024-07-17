

namespace Parametros
{
    internal class Program
    {
        
        static void ModificarValor(int i)
        {
            // Recibo el entero por VALOR (un entero es tipo ValueType), es decir es una copia de la variable original
            i = 30;
            Console.WriteLine("En ModificarValor, el valor del parámetro i es = {0}", i);
        }
        
        static void Main(string[] args)
        {
            //// Pasar parámetros por VALOR

            //int valor = 20;
            //Console.WriteLine("En el Main, valor tiene = {0}", valor);

            //ModificarValor(valor);

            //Console.WriteLine("Volviendo al Main, valor tiene = {0}", valor);  // Es otra forma de escribir los template string

            //// Pasar parámetros por REFERENCIA.
            // Los objetos siempre pasan por referencia, es el mismo área de memoria
            var rt = new EjemploRefType();  // es tipado implicito. Como es un objeto, lo debo instanciar con new

            rt.value = 44;

            ModificarObjeto(rt);

            Console.WriteLine($"Valor: {rt.value}");


            //// Pasar parámetros por REFERENCIA de tipos de datos simples: int, string, double, char, bool
            int valorN = 20;
            Console.WriteLine($"En el Main, valor tiene = {valorN}");
            ModificarValorPorRef(ref valorN);
            Console.WriteLine($"Volviendo al Main, valor tiene = {valorN}");

            Console.ReadKey();

        }

        private static void ModificarValorPorRef(ref int valorN)
        {
            // Recibe el entero por referencia o dirección, es decir es el mismo espacio de memoria
            valorN = 30;
            Console.WriteLine($"En ModificarValorPorRef, el valor del parámetro i es = {valorN}");
        }

        private static void ModificarObjeto(EjemploRefType rt)
        {
            rt.value = 33;
        }
    }
}


/*
    Parámetros

    Un parámetro es un dato que ingresa a un método a través de su llamada. Todos los tipos 
    de C# son tipos de valor o tipos de referencia (para más detalles consulte el siguiente link
    Tipos y variables). De forma predeterminada, los tipos de valor y los tipos de referencia se 
    pasan a un método por valor.

    Pasar parámetros por valor
    ---------------------------
    Cuando un tipo de valor se pasa a un método por valor, se pasa una copia del objeto y no el 
    propio objeto. Por lo tanto, los cambios realizados en el objeto en el método llamado no 
    tienen ningún efecto en el objeto original cuando el control vuelve al autor de la llamada.
                
    Pasar parámetros por referencia
    -------------------------------
    Pase un parámetro por referencia cuando quiera cambiar el valor de un argumento en un 
    método y reflejar ese cambio cuando el control vuelva al método de llamada. Para pasar un 
    parámetro por referencia, use la palabra clave ref o out. También puede pasar un valor por 
    referencia para evitar la copia, pero impedir modificaciones igualmente usando la palabra 
    clave in.

*/
