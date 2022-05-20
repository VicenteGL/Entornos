
namespace proyecto.documentacion
{
    
    public class Trabajador
    {
        private const int EdadJubilacionDefecto = 67;
        
        private string nombre;        
        private int edad;
        
        /// <summary>
        /// Simple property for name
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }        
       
        /// <summary>
        /// 
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set 
            {
                if (value >= 1 && value <= 150)
                    edad = value;
            }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CalculoAnyosJubilacion()
        {
            return EdadJubilacionDefecto - edad;
        }
       
        /// <summary>
        /// It calculates 
        /// </summary>
        /// <param name="edadJubilacion"></param>
        /// <returns></returns>
        public int CalculoAnyosJubilacion(int edadJubilacion)
        {
            if (edadJubilacion < EdadJubilacionDefecto && edadJubilacion >= edad)
                return edadJubilacion - edad;
            else
                return EdadJubilacionDefecto - edad;
        }

    }
}
