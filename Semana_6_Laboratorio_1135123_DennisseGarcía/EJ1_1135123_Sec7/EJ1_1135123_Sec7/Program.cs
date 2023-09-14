using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1");
        int numero; // EnvironmentVariableTarget tipo entero
        string mes; //variable tipo cadena 

        Console.WriteLine("Ingrese un numero del uno al doce:  ");
        mes = Console.ReadLine();
        numero = Int32.Parse(mes);

        if (numero >= 1 && numero <= 12)
        {
            if (numero == 1)
            {
                Console.WriteLine("Enero");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Febrero");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Marzo");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Mayo");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Junio");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Julio");
            }
            else if (numero == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (numero == 9)
            {
                Console.WriteLine("Septiembre");
            }
            else if (numero == 10)
            {
                Console.WriteLine("Octubre");
            }
            else if (numero == 11)
            {
                Console.WriteLine("Noviembre");
            }
            else if (numero == 12)
            {
                Console.WriteLine("Diembre");
            }
            else if (numero >= 13)
            {
                Console.WriteLine("Numero Invalido");
            }
            Console.ReadKey();
        }
    }

}