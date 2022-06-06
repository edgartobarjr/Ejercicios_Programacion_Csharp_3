using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion3
{
    class Sum_Sueldos
    {
        //Sumar los sueldos e indicar cuales son mayores a 1000
        public void Sueldos()
        {
            int sueldo = 0, suma = 0, contador, mayores = 0;
            
            Console.WriteLine("Sueldos para ingresar: ");
            contador = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contador; i++) //la inicializacion empieza en 1 y debe ser menor o igual al contador (10)
            {
                int s = 0;
                s++;

                Console.WriteLine("Ingrese el sueldo: " + s);
                sueldo = int.Parse(Console.ReadLine()); //Se almacena cantidad de un sueldo

                if (sueldo > 1000) //Si sueldo es mayor a 1000
                {
                    mayores++; //Suma un valor
                }
                if (sueldo == 0) //Si sueldo sigue en 0 (No se ingreso cantidad mayor a 1000)
                {
                    Console.WriteLine("No hay sueldos mayores de 1000"); //Imprime que no hay sueldos mayores
                }
                suma += sueldo; //Se suman todos los sueldos ingresados
            }
            Console.WriteLine("La suma total es: " + suma); //Muestra el total de la suma
            Console.WriteLine("Sueldos mayores a 1000: " + mayores); //Muestra el total de sueldos mayores a 1000
            Console.ReadKey();
        }
    }
}
