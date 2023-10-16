using System;
using System.Runtime.InteropServices;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Transporte público Transmetro");
        // variables 
        double pagoTotal = 0;
        double distanciaTotal = 0; // en km


        Console.WriteLine("Las estaciones poseen sus respectivos códigos:");
        Console.WriteLine("Estación Javier - 51");
        Console.WriteLine("Estación Trébol - 61");
        Console.WriteLine("Estación Don Bosco - 71");
        Console.WriteLine("Estación Plaza Municipal - 82");
        Console.WriteLine("Ingrese código de la estación");
        int estacionPartida = 0;
        bool condicion = false;

    

        while (condicion == false)
        {

            estacionPartida = int.Parse(Console.ReadLine());

            if (estacionPartida == 51 || estacionPartida == 61 || estacionPartida == 71 || estacionPartida == 82)
            {
                condicion = true;
            }
            else
            {
                Console.WriteLine("No se pudo encontrar la estación, por favor ingrese una estación válida");
                condicion = false;
            }

        }

        //Destino

        bool otroViaje = false;
        do
        {
            bool segundaCondicion = false;
            int estacionDestino = 0;
            double distancia = 0;

            while (segundaCondicion == false)
            {
                Console.WriteLine("Ingrese el código de la estación de destino");
                estacionDestino = int.Parse(Console.ReadLine());

                if (estacionPartida == 51)
                {
                    if (estacionDestino == 61)
                    {
                        segundaCondicion = true;
                        distancia = 14;
                        break;
                    }
                    else if (estacionDestino == 72)
                    {
                        segundaCondicion = true;
                        distancia = 28;
                        break;
                    }

                }

                if (estacionPartida == 71)
                {
                    if (estacionDestino == 82)
                    {
                        segundaCondicion = true;
                        distancia = 13;
                        break;
                    }
                }

                if (estacionPartida == 61)
                {
                    if (estacionDestino == 51)
                    {
                        segundaCondicion = true;
                        distancia = 7;
                        break;
                    }
                }

                if (estacionPartida == 82)
                {
                    if (estacionDestino == 51)
                    {
                        segundaCondicion = true;
                        distancia = 21;
                        break;
                    }
                }

                
                if (segundaCondicion == false)
                {
                    Console.WriteLine("El código no es válido, por favor ingrese un código válido");
                }
            }

            //Datos

            bool Pfecha = false;
            bool Pdia = false;
            bool Pmes = false;
            Console.WriteLine("A continuación especificará cuando estará utilizando nuestro servicio: ");
            do
            {

                do
                {
                    Console.WriteLine("Ingrese el dia de su viaje:");
                    int dia = Convert.ToInt32(Console.ReadLine());

                    if (dia > 0 && dia <= 31)
                    {
                        Pdia = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un dia valido");
                    }
                } while (Pdia == false);

                do
                {
                    Console.WriteLine("Ingrese el mes en el que realizará el viaje en forma de numeros, es decir, del 1 al 12");
                    int mes = Convert.ToInt32(Console.ReadLine());

                    if (mes > 0 && mes <= 12)
                    {
                        Pmes = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un mes valido");
                    }
                } while (Pmes == false);

                

                if (Pdia == true && Pmes == true)
                {
                    Pfecha = true;
                   
                }

            } while (Pfecha == false);

            //Edad
            
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());


            //Embarazo
            Console.WriteLine("Indique si se encuentra embarazada, responda si lo estoy o no lo estoy"); 
            string respuesta = Console.ReadLine();
            bool estado = false;
            if (respuesta == "si" && respuesta == "si lo estoy")
            {
                estado = true;
            }

            //con niño < a 3 años
            Console.WriteLine("Indique si viajará con un niño menor a 3 años, responda con un si o no");
            respuesta = Console.ReadLine();
            bool niño = false;
            if (respuesta == "si")
            {
                niño = true;
            }

            

            //Descuentos
            bool Gratis = false;
            if (estado == true && niño == true)
            {
                Gratis = true;
            }

            //Precios

            double precio = 0;
            double descuento = 1;

            bool Pcálculo = false;
            while (Pcálculo == false)
            {
                if (Gratis == true)
                {
                    precio = 0;
                    break;
                }

                if (edad >= 15 && edad <= 25)
                {
                    descuento = 0.79;
                }

                //Operaciones
                if (distancia <= 10)
                {
                    precio = 0.07 * descuento;
                    Pcálculo = true;
                }
                else
                {
                    precio = descuento * (0.02 * ((distancia - 10) + 0.07));
                    Pcálculo = true;
                }
                // costo total
                pagoTotal += precio;
            }

            //recorridos 
            distanciaTotal += distancia;
            
            // tiempo
            double tiempo = distancia / 40;
            

            //Estaciones 
            string partida = "";
            if (estacionPartida == 51)
            {
                partida = "Estación Javier";
            }
            else if (estacionPartida == 61)
            {
                partida = "Estación Trébol";
            }
            else if (estacionPartida == 71)
            {
                partida = "Estación Don Bosco";
            }
            else if (estacionPartida == 82)
            {
                partida = "Estación Plaza Municipal";
            }

            //Nombre estaciones
            string destino = "";
            if (estacionDestino == 61)
            {
                destino = "Estación Trébol";
            }
            else if (estacionDestino == 72) 
            {
                destino = "Estación Don Bosco";
            }
            else if (estacionDestino == 82)
            {
                destino = "Estación Plaza Municipal";
            }
            else if (estacionDestino == 51)
            {
                destino = "Estación Javier";
            }

           
            Console.WriteLine("Ha realizado la compra de su boleto");
            Console.WriteLine($"La ruta que tomara sera de la {partida}  a la {destino}");
            Console.WriteLine("El tiempo estimado de viaje será: " + tiempo + " horas");
            Console.WriteLine("El precio de su boleto es: Q." + precio);

            
            Console.WriteLine("¿Desea realizar otro viaje?, por favor responda con un si para poder escoger el siguiente destino. De lo contrario responda con un no:"); 
            string masViajes = Console.ReadLine();

            if (masViajes == "si")
            {
                otroViaje = true;
                estacionPartida = estacionDestino;
                
            }
            else
            {
                otroViaje = false;
            }
                

        } while (otroViaje == true);
        

        // final
        Console.WriteLine("El tiempo total que viajó es:" + distanciaTotal + "km");
        Console.WriteLine("Su total a pagar por los boletos es: Q." + pagoTotal);
        Console.ReadKey();
    }
}


    


