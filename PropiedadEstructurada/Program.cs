namespace PropiedadEstructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PeriodoDeTiempo t = new PeriodoDeTiempo();

            // La asignación de la propiedad Horas provoca la llamada del descriptor de acceso 'set'.
            t.Horas = 24;

            // La evaluación de la propiedad Horas provoca la llamada del descriptor de acceso 'get'.

            Console.WriteLine($"Tiempo en horas: {t.Horas}");

            Console.ReadKey();
        }
    }
}
