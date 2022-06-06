using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion3
{
    class Sumar_Usuarios
    {
        //Sumar Usuarios
        public void Sumar_usuario()
        {
            int num, cant, suma = 0; //Variables para guardar los numeros ingresados, la cantidad de numeros y la suma.
            int mayor = 0, menor = 0; //Variable para el numero mayor y el menor
            
            Console.WriteLine("Cuantos numeros desea introducir: ");
            cant = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= cant; i++) 
            {
                int s = 0;
                s++;

                Console.WriteLine("Ingrese numero: " + s);
                num = int.Parse(Console.ReadLine()); 

                suma += num; //suma = suma + num; 

                if (i == 1) //Si solo se ingresa un numero
                {
                    mayor = num; //Mayor sera el unico que se ingresa
                    menor = num; //Menor sera el unico que se ingresa
                }
                else if (i != 1) //Pero si se ingresa mas de un numero
                {
                    if (num < menor) //El numero menor ingresado
                    {
                        menor = num; //se almacena en la variable menor
                    }

                    if (num > mayor) //El numero mayor ingresado
                    {
                        mayor = num; //Se almacena en la variable mayor
                    }
                }
            }
            Console.WriteLine("La suma de los numeros ingresados es: " + suma); 
            Console.WriteLine("El numero mayor es: " + mayor); 
            Console.WriteLine("El numero menor es: " + menor); 
            Console.ReadKey();
        }
    }
}
