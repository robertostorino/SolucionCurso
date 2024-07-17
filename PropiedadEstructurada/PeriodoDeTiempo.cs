using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadEstructurada
{
    public class PeriodoDeTiempo
    {
        private double segundos;    //Representa el valor del atributo Horas en segundos
        public double Horas
        {
            get
            {
                return segundos / 3600;
            }
            set
            {
                segundos = value * 3600;
            }
        }
    }
}
