using System;
using System.Diagnostics.Eventing.Reader;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: operaciones aritméticas");

        Console.WriteLine("Ingrese un número: ");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);

        Console.WriteLine("Ingrese un número: ");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        Console.WriteLine("Ingrese un número: ");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicación = num1 * num2;
        int división = num1 / num2;
        int residuo = num1 % num2;

        Console.WriteLine("Suma: " + num1 + "+" + num2 + "=" + suma);
        Console.ReadLine();
        Console.WriteLine("Resta: " + num1 + "-" + num2 + "=" + resta);
        Console.ReadLine();
        Console.WriteLine("Multiplicación: " + num1 + "*" + num2 + "=" + multiplicación);
        Console.ReadLine();
        Console.WriteLine("División: " + num1 + "/" + num2 + "=" + división);
        Console.ReadLine();
        Console.WriteLine("Residuo: " + num1 + "%" + num2 + "=" + residuo);
        Console.ReadLine();

        Console.WriteLine("Ejercicio 2: operaciones booleanas");
        if (num1 > num2)
        {
            Console.WriteLine(num1 + "es mayor que" + num2);
        }
        else if(num1 < num2)
        {
            Console.WriteLine(num1 + "es menor que" + num2);
        }
        else 
        {
            Console.WriteLine("Los números son iguales");
        }

       
        Console.WriteLine("Ejercicio 3: jerarquía de operaicones");
        
        Console.WriteLine("Operación 1" + "=" + num1*num2+num3);
        Console.WriteLine("Operación 2" + "=" + num1 * (num2 + num3));
        Console.WriteLine("Operación 3" + "=" + num1 / num2 * num3);
        

        Console.ReadKey();
    }
}