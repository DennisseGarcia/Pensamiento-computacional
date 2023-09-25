using System;

  internal class Program
  {
      static void Main(string[] args)
      {
        //Console.WriteLine("Laboratorio semana 8");
        //Console.WriteLine("\nIngrese un número");

        //int num = Convert.ToInt32(Console.ReadLine());

        //while(num != 0) 
        //{
        //    Console.WriteLine("El número ingresado es: " + num);
        //    if (num > 0) 
        //    {
        //        Console.WriteLine("\nPositivo");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("\nNegativo");
        //    }
        //    Console.WriteLine("\nIngrese otro número");

        //    num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIngrese un número");
        int N = Convert.ToInt32(Console.ReadLine());
        int A = 0, B = 1, C = 0, i = 2;
        string resultados = "";
        resultados = A.ToString();

        if (N > 0) 
        {
            resultados = A.ToString();
        
          if(N > 1)
          {
            resultados = B.ToString();

            while (i < N) 
            {
                C = A + B;
                resultados = C.ToString();
                A = B;
                B = C;
                i++;
            }
                Console.WriteLine("Resultados " + resultados);
          }
          else 
          {
                Console.WriteLine("Resultados " + resultados);
          }
        }

        else 
        {
            Console.WriteLine("Resultados " + resultados); 
        }
        Console.ReadKey();

       

      }
  }

