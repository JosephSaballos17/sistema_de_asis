// Trabajo Realizado por Joseph Saballos 1M2-S

using System;
namespace sistema_de_asis
{
    class program
    {

        public void Main(string[] args)
        {

            double asistenciasTotales = 0;

            // Bienvenida al sistema 


            Console.WriteLine("Bienvenido al Sistema de Asistencias de la Universidad Nacional de Ingenieria ");
            Console.WriteLine();


            Console.WriteLine("Ingrese la Cantidad de Estudiantes");
            int estudiante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();




            // Bucle para pedir  las asistencias totales
            do
            {
                Console.WriteLine("Ingrese la Asistencia Total: ");
                asistenciasTotales = Convert.ToInt32(Console.ReadLine());
                if (asistenciasTotales < 0)
                {
                    Console.WriteLine("Dato erroneo, Ingrese un numero Positivo Por favor");
                }

            } while (asistenciasTotales < 0);





        }


    }





}