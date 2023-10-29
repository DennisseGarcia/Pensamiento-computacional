using System;

public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    private double ObtenerPerimetro()
    {
        double pi = 3.1416;
        return 2 * pi * radio;
    }

    private double ObtenerArea()
    {
        double pi = 3.1416;
        return pi * Math.Pow(radio, 2);
    }

    private double ObtenerVolumen()
    {
        double pi = 3.1416;
        return (4 / 3) * pi * Math.Pow(radio, 3);
    }

    public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
    {
        unPerimetro = ObtenerPerimetro();
        unArea = ObtenerArea();
        unVolumen = ObtenerVolumen();
    }
}
class TrianguloRectangulo
{
    public double catetoA;
    public double anguloOpuestoA;

    public double ObtenerCatetoA()
    {
        return catetoA;
    }

    public double ObtenerCatetoB()
    {
        double anguloRadianes = Math.PI * anguloOpuestoA / 180.0;
        double catetoB = catetoA * Math.Tan(anguloRadianes);
        return catetoB;
    }

    public double ObtenerHipotenusa()
    {
        double catetoB = ObtenerCatetoB();
        double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
        return hipotenusa;
    }

    public double ObtenerAnguloOpuestoA()
    {
        return anguloOpuestoA;
    }

    public double ObtenerAnguloOpuestoB()
    {
        double anguloOpuestoB = 90 - anguloOpuestoA;
        return anguloOpuestoB;
    }

    public double ObtenerArea()
    {
        double catetoB = ObtenerCatetoB();
        double area = 0.5 * catetoA * catetoB;
        return Math.Round(area, 3);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        double radio;

        Console.Write("Ingrese el radio del círculo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        Circulo objCirculo = new Circulo(radio);
        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perímetro: " + perimetro);
        Console.WriteLine("Área: " + area);
        Console.WriteLine("Volumen: " + volumen);

        TrianguloRectangulo objTriangulo = new TrianguloRectangulo();

        Console.WriteLine("Ingrese la longitud del cateto A en metros:");
        double catetoA = double.Parse(Console.ReadLine());
        objTriangulo.catetoA = catetoA;

        Console.WriteLine("Ingrese la amplitud del ángulo opuesto al cateto A en grados:");
        double anguloOpuestoA = double.Parse(Console.ReadLine());
        objTriangulo.anguloOpuestoA = anguloOpuestoA;

        Console.WriteLine("Valor de cateto A: " + objTriangulo.ObtenerCatetoA() + " metros");
        Console.WriteLine("Valor de cateto B: " + objTriangulo.ObtenerCatetoB() + " metros");
        Console.WriteLine("Valor de hipotenusa: " + objTriangulo.ObtenerHipotenusa() + " metros");
        Console.WriteLine("Valor de ángulo opuesto de A: " + objTriangulo.ObtenerAnguloOpuestoA() + " grados");
        Console.WriteLine("Valor de ángulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + " grados");
        Console.WriteLine("Valor de área: " + objTriangulo.ObtenerArea() + " metros cuadrados");
        Console.ReadKey();
    }
}

