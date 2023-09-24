using System;

  internal class Program
  {
       static void Main(string[] args)
       {
        
        

        Console.WriteLine("Ingrese los valores");
        
        Console.WriteLine("Ingresar velocidad final");
        double vf = 0;
        vf = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese velocidad inicial");
        double vo = 0;
        vo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese tiempo");
        double t = 0;
        t = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese aceleracion");
        double a = 0;
        a = double.Parse(Console.ReadLine());

        // Ingresar "0" si en cuyo caso no se quiera agrefar un valor o variable 

        if(vf == 0 && vo == 0 && a == 0 && t == 0) 
        {
            Console.WriteLine("Error, números incorrectos");
        }
        else if(vo == 0) 
        {
            vo = (vf / t) - a;
            Console.WriteLine("Su velocidad inicial es de: " + vo + "m/s");
        }
        else if(t == 0) 
        {
            t = (vf - vo)/ a;
            Console.WriteLine("El tiempo es de: " + t + "s");
        }
        else if(vf == 0) 
        {
            vf = vo + a * t;
            Console.WriteLine("La velocidad final es de: " + vf + "m/s");
        }
        else if(a == 0)
        {
            a = (vf-vo)/ t;
            Console.WriteLine("La aceleración es de: " + a + "m/s");
        }
        else 
        {
            Console.WriteLine("Error al ingresar los datos");
        }
        Console.ReadKey();

       }
  }

