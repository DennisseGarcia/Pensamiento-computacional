using System;


 internal class Program
 {
    static void Main(string[] args)
    {
       // instrucciones
        Console.WriteLine("Las reglas del juego son las siguientes: ");
        Console.WriteLine("1. Si la suma de los dados es 12 o 6, el jugador gana 12 puntos");
        Console.WriteLine("2. Si la suma da 4, 6 o 10; la casa gana 12 puntos");
        Console.WriteLine("3. Si la suma da 2, 3, 5, 7, 8 o 9; la suma es el punteo del jugador o casa");
        Console.WriteLine("4. El jugador pierde si la suma da 11 y no lleva ningún punto, la casa gana 6 puntos");

        Console.WriteLine("¿Cuántas partidas desea jugar?");
        int partidas = int.Parse(Console.ReadLine());
        Console.WriteLine("¿De cuántos tiros desea cada partidad?");
        int tiros = int.Parse(Console.ReadLine());
        Random random = new Random();

        int pGanadasJ = 0; //´partidas gandas jugador
        int pGanadasC = 0; // partidas ganadas casa 

        // procesos
        for (int i = 0; i < partidas; i++)
        {
            int pJugador = 0; // puntos del jugador
            int pCasa = 0; // puntos de la casa

            for (int j = 0; j < tiros; j++)
            {
                int d1 = random.Next(1, 7);
                int d2 = random.Next(1, 7);
                int suma = d1 + d2;

                if (j == 0)
                {
                    Console.WriteLine("Tiro primer dado: " + d1);
                    Console.WriteLine("Tiro segundo dado: " + d2);
                    Console.WriteLine("La suma da: " + suma);

                    if (suma == 12 || suma == 6)
                    {
                        pJugador = 12;
                        pCasa = 0;
                    }
                    else if (suma == 4 || suma == 10)
                    {
                        pCasa = 12;
                        pJugador = 0;
                    }
                    else if (suma == 2 || suma == 3 || suma == 5 || suma == 7 || suma == 8 || suma == 9)
                    {
                        pJugador = suma;
                        pCasa = suma;
                    }
                    else if (suma == 11 && pJugador == 0)
                    {
                        pCasa = 6;
                    }
                    if (suma % 2 == 0)
                    {
                        Console.WriteLine("El tiro es par");
                    }
                    else
                    {
                        Console.WriteLine("El tiro es impar");
                    }

                }
            }

            if (pJugador > pCasa)
            {
                Console.WriteLine("El ganador de la partida es el jugador");
                pGanadasJ++;
            }
            else if (pJugador < pCasa)
            {
                Console.WriteLine("El ganador de la partida es la casa");
                pGanadasC++;
            }
            else if (pJugador == pCasa)
            {
                Console.WriteLine("No hay ganadores, es un empate");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

        }
        int pTotalJ = pGanadasJ * 10;
        int pTotalC = pGanadasC * 10;
        double pGanar1 = 0.25; // segun las posibles combinaciones que sería 9/36 
        double pGanar2 = 0.50; // sería 18/36
        double probabilidad = (pGanar1 + pGanar2);

        Console.WriteLine("El jugador ganó " + pGanadasJ + " tiros");
        Console.WriteLine("La casa ganó " + pGanadasC + " tiros");
        if (pTotalJ > pTotalC)
        {
            Console.WriteLine("El ganador del juego es el jugador");
        }
        else
        {
            Console.WriteLine("El ganador del juego es la casa");
        }
        Console.WriteLine("El puntaje final del jugador es: " + pTotalJ);
        Console.WriteLine("El puntaje final de la casa es: " + pTotalC);
        Console.WriteLine("La probabilidad que gane es: " + probabilidad);
        Console.ReadKey();

    }
 }

