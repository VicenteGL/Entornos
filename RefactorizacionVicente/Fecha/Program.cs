using System;
namespace Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();//Fecha correcta, año bisiesto

            test2();//Fecha correcta, año no bisiesto

            test3();//Fecha con valores incorrectos

            test4();//Fecha con asignación incorrecta de valores erroneos
        }

        /// <summary>
        /// Fecha correcta, año bisiesto
        /// </summary>
        static void test1()
        {
            Fecha fecha1 = new Fecha(12, 2012, 4, false);
            Console.WriteLine("Fecha 1: " + fecha1.ToString());
            if (fecha1.EsBisiesto())
                Console.WriteLine("El año " + fecha1.year + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha1.year + " no es bisiesto");
        }

        /// <summary>
        /// Fecha correcta, año no bisiesto
        /// </summary>
        static void test2()
        {
            Fecha fecha2 = new Fecha(10, 2013, 4, false);
            Console.WriteLine("Fecha 2: " + fecha2.ToString());
            if (fecha2.EsBisiesto())
                Console.WriteLine("El año " + fecha2.year + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha2.year + " no es bisiesto");
        }

        /// <summary>
        /// Fecha con valores incorrectos
        /// </summary>
        static void test3()
        {
            Fecha fecha3 = new Fecha(13, -4, 4, false);
            Console.WriteLine("Fecha 3: " + fecha3.ToString());
        }

        /// <summary>
        /// Fecha con asignación incorrecta de valores erroneos
        /// </summary>
        static void test4()
        {
            Fecha fecha4 = new Fecha();
            fecha4.day = 67;
            fecha4.month = 80;
            fecha4.year = 3678;
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
        }
    }
}
//MAL!!