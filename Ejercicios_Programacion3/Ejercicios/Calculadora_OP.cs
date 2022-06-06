using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion3
{
    class Calculadora_OP
    {
        public void Calculadora()
        {
            int num1, num2;
            int suma, resta, mult;
            double div;
            int s;

            do
            {
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("1: Suma");
                Console.WriteLine("2: Resta");
                Console.WriteLine("3: Multiplicacion");
                Console.WriteLine("4: Division\n");

                string op;
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Ingresar numero 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar numero 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        suma = num1 + num2;

                        Console.WriteLine("La suma es: " + suma);
                        break;

                    case "2":
                        Console.WriteLine("Ingrese numero 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar numero 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        resta = num1 - num2;

                        Console.WriteLine("La resta es: " + resta);
                        break;

                    case "3":
                        Console.WriteLine("Ingrese numero 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar numero 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        mult = num1 * num2;

                        Console.WriteLine("La multiplicacion es: " + mult);
                        break;

                    case "4":
                        Console.WriteLine("Ingrese numero 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese numero 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        while (num2 == 0)
                        {
                            Console.WriteLine("Ingrese otro numero diferente a 0: ");
                            num2 = int.Parse(Console.ReadLine());
                        }

                        div = (double)num1 / (double)num2;
                        Console.WriteLine("La division es: " + div);
                        break;
                    default:
                        Console.WriteLine("No exite esta opcion: ");
                        break;
                }
                Console.WriteLine("¿Desea hacer otra operacion?\n 1 (si) o 2 (no)\n");
                s = int.Parse(Console.ReadLine());
            } while (s == 1);
            Console.ReadKey();
        }
    }
}