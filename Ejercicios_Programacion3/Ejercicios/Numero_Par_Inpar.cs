using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion3
{
    class Numero_Par_Inpar
    {
        //Determinar numeros par o inpar
        public void Parinpar()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero es Par");
                }
                else
                {
                    Console.WriteLine("El numero es Inpar");
                }
                Console.WriteLine("Ingresar otro numero");

                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El Programa se detuvo");
            Console.ReadKey();
        }
    }
}
