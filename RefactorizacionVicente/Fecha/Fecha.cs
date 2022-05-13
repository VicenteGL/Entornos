using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    public class Fecha
    {
        public int day;
        public int month;
        public int year;
        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            day = 1;
            month = 1;
            year = 1;
        }
        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        /// <param name="bi">Indica si es bisiesto</param>
        public Fecha(int mes, int anyo, int dia, bool bi)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                this.year = anyo;
            }
            else
            {
                this.year = 1;
            }
            bool bisiesto = EsBisiesto();
            
            if (mes >= 1 && mes <= 12)
                this.month = mes;
            else
                this.month = 1;
            int diasMes = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasMes = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;
                case 2: // verificación de año bisiesto
                    if (bisiesto)
                        diasMes = 29;
                    else
                        diasMes = 28;
                    break;
            }

            if (dia >= 1 && dia <= diasMes)
                this.day = dia;
            else
                this.day = 1;
        }

        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            return bisiesto;
        }
        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se sobreescribe el
        //metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns>
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}