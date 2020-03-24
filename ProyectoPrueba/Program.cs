﻿using System;

namespace Calculadora
{
    class Programa
    {
        static void Main(string[] args)
        {
            //declaro variables y las inicializo
            double numero1 = 0;
            double numero2 = 0;

            //muestro el titulo de la aplicacion
            Console.WriteLine("Calculadora \r");
            Console.WriteLine("\n");

            //Pido el primero numero
            Console.WriteLine("Ingrese el primer numero y luego ENTER:");
            numero1 = Convert.ToDouble(Console.ReadLine());

            //Pido el segundo numero
            Console.WriteLine("Ingrese el segudo numero y luego ENTER:");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //pedir opciones
            Console.WriteLine("Elija una opcion:\n");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Cual opcion elige?");

            //uso un switch
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Resultado: {numero1} + {numero2} = " + (numero1 + numero2));
                    break;
                case "r":
                    Console.WriteLine($"Resultado: {numero1} - {numero2} = " + (numero1 - numero2));
                    break;
                case "m":
                    Console.WriteLine($"Resultado: {numero1} * {numero2} = " + (numero1 * numero2));
                    break;
                case "d":
                    while(numero2 == 0)
                    {
                        Console.WriteLine("Error, la division por cero no se puede realizar.\nIngrese un divisor distinto de cero:");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Resultado: {numero1} / {numero2} = " + (numero1 / numero2));
                    break;
            }

            Console.WriteLine("\nPresione enter para terminar el programa");
        }
    }
}