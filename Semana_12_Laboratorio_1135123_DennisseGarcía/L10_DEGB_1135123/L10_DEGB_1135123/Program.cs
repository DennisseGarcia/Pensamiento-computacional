using System;

 internal class Program
 {
   static void Main(string[] args)
   {
        Circulo objCirculo = new Circulo(radio);
        Console.WriteLine("Semana 12 - Funciones y procedimientos");
        Console.WriteLine("Ingrese el valor del radio: ");
        double radio = double.Parse(Console.ReadLine());
        double perimetro = 0;
        double area = 0;
        double volumen = 0;
        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perimetro: " + perimetro);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Volumen: " + volumen);
       
        Console.ReadKey();
   }
 }

public class Circulo 
{
    // atributos de la clase 
    public double radio { get; set; }

    // constructor 
    public Circulo(double radio) 
    {
        // definiendo datos por defecto 
        this.radio = radio;
    }
    // Funcion para perimetro
    private double ObtenerPerimetro()
    {
        double pi = 3.1416;
        double perimetro = (2 * pi * radio);
        return perimetro;
    }
    // Procedimiento para area
    private double ObtenerArea()
    {
        double pi = 3.1416;
        double area = pi * (Math.Pow(radio, 2));
        return area;
    }
    private double ObtenerVolumen() 
    {
        double pi = 3.1416;
        double volumen = (4 * pi * Math.Pow(radio, 3)) / 3;
        return volumen;
    }

    public void CalcularGeometria(ref double UnPerimetro, ref double UnArea, ref double UnVolumen) 
    {
        UnPerimetro = ObtenerPerimetro();
        UnArea = ObtenerArea();
        UnVolumen = ObtenerVolumen();
    }
    

}

