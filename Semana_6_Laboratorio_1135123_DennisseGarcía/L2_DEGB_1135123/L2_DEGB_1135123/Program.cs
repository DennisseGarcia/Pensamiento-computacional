
using System;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("ejercicio no 2");
        int numero; // variable tipo entero
        string entrada; //variable tipo cadena de texto

        Console.WriteLine("Ingrese un numero del 1 al 7: ");
        entrada = Console.ReadLine();
        numero = Int32.Parse(entrada);

        if (numero >= 1 && numero <= 7)
        {
            if (numero == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Miercoles");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Domingo");
            }
            else if (numero >= 8)
            {

                Console.WriteLine("Numero inválido");
      
            }
            Console.ReadKey();
        }
    }

}

