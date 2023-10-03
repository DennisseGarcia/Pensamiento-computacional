using System;


 internal class Program
 {
    static void Main(string[] args)
    {
        ////// variable 
        ////int num;
        ////string sum = "";

        ////Console.WriteLine("Ingrese un número mayor a cero: ");
        ////num = int.Parse(Console.ReadLine());
        ////int contador = 1;
        ////int sumatoria = 0;

        ////while(contador <= num)
        ////{
        ////    sumatoria = sumatoria + contador;
        ////    contador++;
        ////    sum = sum + contador; 
        ////} 
        ////Console.WriteLine("La suma de los números es: " + sumatoria);
        ////Console.WriteLine("Los números fueron: " + sum);
        ////Console.ReadKey();

        string tabla1 = "";
        string tabla2 = "";
        string tabla3 = "";
        string tabla4 = "";
        string tabla5 = "";
        string tabla6 = "";
        string tabla7 = "";
        string tabla8 = "";
        string tabla9 = "";
        string tabla10 = "";
        int multiplicación = 0;
        int i;
        

        for(i = 1; i <=10; i++) 
        {
            multiplicación = (1 * i);
            tabla1 = tabla1 + multiplicación + " ";

            for(int j = 1; j<=10; j++) 
            {
                multiplicación = (2 * j);
                tabla2 = tabla2 + multiplicación + " ";
            }

            for (int k = 1; k <= 10; k++) 
            {
                multiplicación = (3 * k);
                tabla3 = tabla3 + multiplicación + " ";
            }
            for(int l = 1; l<=10; l++) 
            {
                multiplicación = (4 * l);
                tabla4 = tabla4 + multiplicación + " ";
            }
            for(int m = 1; m <= 10; m++) 
            {
                multiplicación = (5 * m);
                tabla5 = tabla5 + multiplicación + " ";
            }
            for (int n = 1; n <= 10; n++)
            {
                multiplicación = (6 * n);
                tabla6 = tabla6 + multiplicación + " ";
            }
            for (int p = 1; p <= 10; p++)
            {
                multiplicación = (7 * p);
                tabla7 = tabla7 + multiplicación + " ";
            }
            for (int t = 1; t <= 10; t++)
            {
                multiplicación = (8 * t);
                tabla8 = tabla8 + multiplicación + " ";
            }
            for (int y = 1; y <= 10; y++)
            {
                multiplicación = (9 * y);
                tabla9 = tabla9 + multiplicación + " ";
            }
            for (int r = 1; r <= 10; r++)
            {
                multiplicación = (10 * r);
                tabla10 = tabla10 + multiplicación + " ";
            }
        }
        Console.WriteLine("Tabla del 1: " + tabla1);
        Console.WriteLine("Tabla del 2: " + tabla2);
        Console.WriteLine("Tabla del 3: " + tabla3);
        Console.WriteLine("Tabla del 4: " + tabla4);
        Console.WriteLine("Tabla del 5: " + tabla5);
        Console.WriteLine("Tabla del 6: " + tabla6);
        Console.WriteLine("Tabla del 7: " + tabla7);
        Console.WriteLine("Tabla del 8: " + tabla8);
        Console.WriteLine("Tabla del 9: " + tabla9);
        Console.WriteLine("Tabla del 10: " + tabla10);
        Console.ReadKey();
        
    }
    
 }

