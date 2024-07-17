using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    // Clase que representa la info básica de una galaxia
    public class Galaxia
    {
        // Atributos
        public string Nombre { get; set; }
        public int MegaAniosLuz { get; set; }

        
        public Galaxia() { }
        
        // Constructor sobrecargado
        public Galaxia(string nom, int aniosLuz)
        {
            Nombre = nom;
            MegaAniosLuz = aniosLuz;
        }
    }
}
