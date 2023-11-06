using System;


 internal class Program
 {
    static void Main(string[] args)
    {
        int[] numeros = new int[7];
        
        for(int i=0; i<7; i++)
        {
            numeros[i] = i;
            Console.WriteLine("Ingrese un número para el índice " + i);
            numeros[i]=int.Parse(Console.ReadLine());
        }
        int numMayor = numeros[0];
        int numMenor = numeros[0];
        for (int i =1; i<numeros.Length; i++)
        {
            if (numeros[i] > numMayor)
            {
                numMayor = numeros[i];
            }
            else
            {
                numMenor = numeros[i];
            }
        }

        Console.WriteLine("El número mayor es: "+ numMayor);
        Console.WriteLine("El número menor es: " + numMenor);
        Console.ReadKey();

    }
 }

