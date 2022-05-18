using System;
namespace Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fecha correcta, año bisiesto
            ComprobarBisiesto(12, 2012, 4, 1);

            //Fecha correcta, año no bisiesto
            ComprobarBisiesto(10, 2013, 4, 2);

            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha(13, -4, 4, false);
            Console.WriteLine("Fecha 3: " + fecha3.ToString());

            //Fecha con asignación incorrecta de valores erroneos
            Fecha fecha4 = new Fecha();
            fecha4.day = 67;
            fecha4.month = 80;
            fecha4.year = 3678;
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
        }

        /// <summary>
        /// Imprime por consola el número de fecha con el valor de numerofecha seguido de
        /// una indicación sobre si la fecha es bisiesta o no.
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        /// <param name="dia"></param>
        /// <param name="numerofecha"></param>
        public static void ComprobarBisiesto(int mes, int anyo, int dia, int numerofecha)
        {
            Fecha fecha = new Fecha(mes, anyo, dia, false);
            Console.WriteLine("Fecha " + numerofecha + ": " + fecha.ToString());
            if (fecha.EsBisiesto())
                Console.WriteLine("El año " + fecha.year + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha.year + " no es bisiesto");
        }

    }
}