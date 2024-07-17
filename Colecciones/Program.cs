namespace Colecciones
{
    internal class Program
    {


        // Buenos ejemplos
        // https://www.tutorialsteacher.com/csharp/csharp-collection
        // https://www.tutorialsteacher.com/articles/difference-between-array-and-arraylist-in-csharp

        static void Main(string[] args)
        {
            Console.WriteLine("Vemos distintas colecciones genéricas!");
            Console.WriteLine("");

            /*
             
            //Crear una lista de Strings 
            var artesMarciales = new List<string>(); // tipado implícito, el runtime define el tipo
            // List<string> artesMarciales = new List<string>(); // tipado explícito

            artesMarciales.Add("Taekwondo");
            artesMarciales.Add("KungFu");
            artesMarciales.Add("Karate");
            artesMarciales.Add("Aikido");

            // Iterar cada elemento de la lista.
            foreach (var arte in artesMarciales)
            {
                Console.Write(arte + " ");
            }
            // Ver cantidad de elementos
            Console.WriteLine($"La cantidad de elementos de la lista es {artesMarciales.Count}");

            // vaciar la lista
            artesMarciales.Clear();

            */

            ////////////////////////////////////////////////////////////////
            ///

            // Ejemplo parecido al anterior pero la lista la creo y cargo en la misma instrucción

            /*
             
            var artesMarciales = new List<string> { "Taekwondo", "KungFu", "Karate", "Aikido" };

            // Iterar cada elemento de la lista.
            foreach (var arte in artesMarciales)
            {
                Console.Write(arte + " ");
            }

            // Borrar el elemento de la lista indicando el objeto.
            artesMarciales.Remove("KungFu");

            Console.WriteLine("");
            Console.WriteLine(">> Elimino a KungFu de la Lista");

            // Luego de eliminar vuelvo a mostrar los elementos de la lista.
            foreach (var arte in artesMarciales)
            {
                Console.Write(arte + " ");
            }


            Console.WriteLine("");
            Console.WriteLine(">> Lista ordenada");

            var listaOrdenada = new List<string>();

            // Ordeno la lista original, el resultado vía expresión lambda lo convierto nuevamente
            // a tipo lista y lo asigno a otra variable que tendrá la lista ordenada
            listaOrdenada = artesMarciales.OrderBy(arte => arte).ToList();  // Utilizo expresión Lambda (arroy function en JS)

            foreach (var arte in listaOrdenada)
            {
                Console.Write(arte + " ");
            }

            */

            /////////////////////////////////////////////////////////
            //

            /*

            // Creamos una lista de objetos tipo Galaxia, y en la misma instrucción cargamos los valores
            var lasGalaxias = new List<Galaxia>
                                  {
                                  new Galaxia() { Nombre="Tadpole", MegaAniosLuz=400},
                                  new Galaxia() { Nombre="Pinwheel", MegaAniosLuz=25},
                                  new Galaxia() { Nombre="Milky Way", MegaAniosLuz=0},
                                  new Galaxia() { Nombre="Andromeda", MegaAniosLuz=3}
                                  };

            foreach (Galaxia laGalaxia in lasGalaxias)
            {
                Console.WriteLine(laGalaxia.Nombre + " " + laGalaxia.MegaAniosLuz);
            }

            Console.WriteLine("");

            Galaxia nuevaGalac = new Galaxia("NuevaGalac", 100);  // Creo objeto Galaxia
            lasGalaxias.Add(nuevaGalac);  // Agrego nueva galaxia

            foreach (Galaxia laGalaxia in lasGalaxias)
            {
                Console.WriteLine(laGalaxia.Nombre + " " + laGalaxia.MegaAniosLuz);
            }

            Console.WriteLine("");

            // Autorecorrerse con método ForEach y digo: para cada elemento representado
            // por la variable laGalaxia ejecuto la instrucción que sigue el => mostrarse en consola
            lasGalaxias.ForEach(laGalaxia => Console.WriteLine(laGalaxia.Nombre + " " + laGalaxia.MegaAniosLuz));

            */

            ///////////////////////////////////////////////////////////////
            ////
            //// Tipo DICTIONARY son pares clave-valor (key-value pair)
            ////
            ///////////////////////////////////////////////////////////////

            Console.WriteLine("");

            //clave tipo int y valor tipo string  
            Dictionary<int, string> nrosYnombres = new Dictionary<int, string>();
            nrosYnombres.Add(1, "Uno"); //agrego con método Add()
            nrosYnombres.Add(2, "Dos");
            nrosYnombres.Add(3, "Tres");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in nrosYnombres)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
            }

            Console.WriteLine("");


            // Clave string, valor string
            var ciudades = new Dictionary<string, string>(){
                                 {"UK", "London, Manchester, Birmingham"},
                                 {"USA", "Chicago, New York, Washington"},
                                 {"India", "Mumbai, New Delhi, Pune"}
                             };

            foreach (KeyValuePair<string, string> kvp in ciudades)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
            }





            Console.ReadKey();
        }
    }
}
