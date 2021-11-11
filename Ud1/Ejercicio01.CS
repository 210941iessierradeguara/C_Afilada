//Escribe un programa que lea dos números enteros y aplique sobre ellos todos los operadores aritméticos
//(suma, resta, producto, división, módulo, postincremento y preincremento del primero de ellos,
//postdecremento y predecremento del segundo), visualizando todas las operaciones con sus resultados.

using System;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
            Console.WriteLine(a++);
            Console.WriteLine(b--);
        }
    }
}