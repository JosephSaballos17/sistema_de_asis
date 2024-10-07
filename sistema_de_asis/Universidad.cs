using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_asis
{
    public class Universidad
    {
        // Variables para el estudiante 

        public string nombre { get; set; }
        public double numerosesionesTotales { get; set; }
        public double numerosesionesAsistidas { get; set; }

        public class Asistencia
        {

            //Metodo para mostrar la asistencia 
            public static double MostrarPorcentaje(double sesionesAsistidas, double sesionesTotales)
            {

                return (double)sesionesAsistidas / sesionesTotales * 100;

                if (sesionesTotales == 0)
                {
                    return 0;
                }




            }






        }
    }
}
