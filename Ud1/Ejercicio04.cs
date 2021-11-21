using System;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            double nMes;
            double meses = 12;

            Console.WriteLine("Numero del mes: ");
            nMes = Convert.ToDouble(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                Console.WriteLine("El mes" + nMes + " es enero. "+ "El " + nMes/meses +" del año");
                    break;
                case 2:
                Console.WriteLine("El mes" + nMes + " es febrero. " + "El "+ nMes/meses +" del año");
                    break;
                case 3:
                Console.WriteLine("El mes" + nMes + " es marzo. " + "El " + nMes/meses +" del año");
                    break;
                case 4:
                Console.WriteLine("El mes" + nMes + " es abril. " + "El "+ nMes/meses +" del año");
                    break;
                case 5:
                Console.WriteLine("El mes" + nMes + " es mayo. "+ "El "+ nMes/meses +" del año");
                    break;
                case 6:
                Console.WriteLine("El mes" + nMes + " es junio. " + "El "+ nMes/meses +" del año");
                    break;
                case 7:
                Console.WriteLine("El mes" + nMes + " es julio. "+ "El "+ nMes/meses +" del año");
                    break;
                case 8:
                Console.WriteLine("El mes" + nMes + " es agosto. "+ "El "+ nMes/meses +" del año");
                    break;
                case 9:
                Console.WriteLine("El mes" + nMes + " es septiembre. "+ "El "+ nMes/meses +" del año");
                    break;
                case 10:
                Console.WriteLine("El mes" + nMes + " es octubre. "+ "El "+ nMes/meses +" del año");
                    break;
                case 11:
                Console.WriteLine("El mes" + nMes + " es noviembre. "+ "El "+ nMes/meses +" del año");
                    break;
                case 12:
                Console.WriteLine("El mes" + nMes + " es diciembre. "+ "El "+ nMes/meses +" del año");
                    break;

                default:
                Console.WriteLine("No valido");
                    break;
            }
        }
    }
}