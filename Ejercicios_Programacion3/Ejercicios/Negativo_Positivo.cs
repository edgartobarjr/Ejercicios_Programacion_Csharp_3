using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion3
{
    class Negativo_Positivo
    {
        //Determinar si el numero es negativo o positivo
        public void Pos_neg()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero >= 1)
                {
                    Console.WriteLine("El numero es Positivo");
                }
                else if (numero <= -1)
                {
                    Console.WriteLine("El numero es Negativo");
                }
                Console.WriteLine("Ingresar otro numero");

                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El Programa se detuvo");
            Console.ReadKey();
        }
    }
}
