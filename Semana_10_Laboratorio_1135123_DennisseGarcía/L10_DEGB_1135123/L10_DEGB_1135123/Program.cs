using System;
using System.Diagnostics.Contracts;

// clase principal
class Program
  {
     static void Main(string[] args)
     {
        
        Automovil automovil_1 = new Automovil();
        Console.WriteLine("Modelo:" + automovil_1.modelo);
        Console.WriteLine("Precio:" + automovil_1.precio);
        Console.WriteLine("Marca:" + automovil_1.marca);
        Console.WriteLine("Disponible:" + automovil_1.disponible);
        Console.WriteLine("Cambio dolar:" + automovil_1.tipoCambiodolar);
        Console.WriteLine("Descuento:" + automovil_1.descuentoAplicado);

        Console.ReadKey();
     }
  }
// creacion clase Estudiante
public class Automovil
{
    // Atributos de la clase 
    public int modelo { get; set; }

    public double precio { get; set; }

    public string marca { get; set; }

    public bool disponible { get; set; }

    public double tipoCambiodolar { get; set; }

    public double descuentoAplicado { get; set; }
    // Constructor
    public Automovil()
    {
        // definicion datos por defecto
        this.modelo = 2019;
        this.precio = 10000.00;
        this.marca = "";
        this.disponible = false;
        this.tipoCambiodolar = 7.50;
        this.descuentoAplicado = 0.00;

    }

   



}

