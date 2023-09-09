using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi segundo programa");
        Console.ReadKey();

        string Nombre;
        string Edad;
        string Carrera;
        string Carne;

        Console.WriteLine("Escriba su nombre");
        Nombre = Console.ReadLine();

        Console.WriteLine("Escriba su edad");
        Edad = Console.ReadLine();

        Console.WriteLine("Escriba su carrera");
        Carrera = Console.ReadLine();

        Console.WriteLine("Escriba su carne");
        Carne = Console.ReadLine();

        Console.WriteLine("Soy " + Nombre + " tengo " + Edad + " años " + " y estudio la carrera de " + Carrera + " Mi número de carné es " + Carne);
  
       
        Console.ReadKey();


      
    }
}
