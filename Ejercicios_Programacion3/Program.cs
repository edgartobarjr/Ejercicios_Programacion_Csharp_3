using System;

namespace Ejercicios_Programacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu Programa
            Menu:
            Console.Clear();
            Console.WriteLine("Examen de Programacion\n" + "\nA continuacion se muestra un listado de los ejercicios, para comprobarlos escribe el numero correlativo de cada uno\n");
            Console.WriteLine("1er. Hacer una calculadora con los operadores basicos.");
            Console.WriteLine("2do. Hacer un ejercicio en el cual se pedira n sueldos, mostrar su suma y cuantos hay mayores de 1000.");
            Console.WriteLine("3er. Identificar si un numero es par o inpar hasta que de digite 0");
            Console.WriteLine("4ta. Pedirle al usuario cuantos numeros desea ingresar, sumarlos e imprimir el numero mayor y menor ingresado.");
            Console.WriteLine("5ta. Identificar si es positivo o negativo hasta que se digite 0");
            Console.WriteLine("6ta. Salir.");

            Console.WriteLine("\nDigite la Opcion del Ejercicio: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Clear();
                    Calculadora_OP cop = new Calculadora_OP();
                    cop.Calculadora();
                    goto Menu;

                case 2:
                    Console.Clear();
                    Sum_Sueldos ss = new Sum_Sueldos();
                    ss.Sueldos();
                    goto Menu;

                case 3:
                    Console.Clear();
                    Numero_Par_Inpar npi = new Numero_Par_Inpar();
                    npi.Parinpar();
                    goto Menu;

                case 4:
                    Console.Clear();
                    Sumar_Usuarios su = new Sumar_Usuarios();
                    su.Sumar_usuario();
                    goto Menu;

                case 5:
                    Console.Clear();
                    Negativo_Positivo np = new Negativo_Positivo();
                    np.Pos_neg();
                    goto Menu;

                case 6:
                    break;

                default:
                    goto Menu;
            }
        }
    }
}
