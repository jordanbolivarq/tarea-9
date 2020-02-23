using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            string continuarJuego = "s";
            while (continuarJuego == "s")
            {
                string jugador1 = "", jugador2 = "", jugador3 = "", jugador4 = "", jugador5 = "", jugador6 = "", jugador7 = "", ganador = "";
                int jugador1P = 0, jugador2P = 0, jugador3P = 0, jugador4P = 0, jugador5P = 0, jugador6P = 0, jugador7P = 0, mayor = 0, contadorNombre = 1, contadorJugadores = 0;
                Console.WriteLine("Dijite la cantidad de juagdores (minimo 2, maximo 7)");
                int n = int.Parse(Console.ReadLine());
                while (n <= 1 || n > 8)
                {
                    Console.WriteLine("Es imposible jugar con " + n + " jugador(es). Dijite nuevamente la cantidad de juagdores");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nEl jugador que llegue lo mas cerca de 21 gana, si se pasa de 21 perdera");
                while (contadorNombre <= n)
                {
                    if (contadorNombre == 1)
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador1 = Console.ReadLine();
                        contadorNombre++;
                    }
                    else if (contadorNombre == 2)
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador2 = Console.ReadLine();
                        contadorNombre++;
                    }
                    else if (contadorNombre == 3)
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador3 = Console.ReadLine();
                        contadorNombre++;
                    }
                    else if (contadorNombre == 4)
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador4 = Console.ReadLine();
                        contadorNombre++;
                    }
                    else if (contadorNombre == 5)
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador5 = Console.ReadLine();
                        contadorNombre++;
                    }
                    else if (contadorNombre == 6)
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador6 = Console.ReadLine();
                        contadorNombre++;
                    }
                    else
                    {
                        Console.Write("\nJugador " + contadorNombre + " dijite su nombre: ");
                        jugador7 = Console.ReadLine();
                        contadorNombre++;
                    }
                }
                while (contadorJugadores < n)
                    {
                    Random aleatorio = new Random();
                    int carta1 = 0 , carta2 = 0 , total = 0 , contador = 0;

                    if (contadorJugadores == 0)
                        Console.WriteLine("\n" + jugador1 + ", dijite 's' para empezar su turno");
                    else if (contadorJugadores == 1)
                        Console.WriteLine("\n" + jugador2 + ", dijite 's' para empezar su turno");
                    else if (contadorJugadores == 2)
                        Console.WriteLine("\n" + jugador3 + ", dijite 's' para empezar su turno");
                    else if (contadorJugadores == 3)
                        Console.WriteLine("\n" + jugador4 + ", dijite 's' para empezar su turno");
                    else if (contadorJugadores == 4)
                        Console.WriteLine("\n" + jugador5 + ", dijite 's' para empezar su turno");
                    else if (contadorJugadores == 5)
                        Console.WriteLine("\n" + jugador6 + ", dijite 's' para empezar su turno");
                    else
                        Console.WriteLine("\n" + jugador7 + ", dijite 's' para empezar su turno");
                    string continuar = Console.ReadLine();

                    while (continuar == "s" && total < 21)
                    {
                        if (contador == 0)
                        {
                            carta1 = aleatorio.Next(1, 11);
                            carta2 = aleatorio.Next(1, 11);
                            contador += 2;
                            Console.WriteLine("Carta 1: " + carta1);
                            Console.WriteLine("Carta 2: " + carta2);
                            total += carta1 + carta2;
                            Console.WriteLine("Total: " + total);
                        }
                        else
                        {
                            carta1 = aleatorio.Next(1, 11);
                            contador++;
                            Console.WriteLine("Carta " + (contador) + ": " + carta1);
                            total += carta1;
                            Console.WriteLine("Total: " + total);
                        }
                        if (total >= 21)
                            continuar = "f";
                        else
                        {
                            Console.WriteLine("Dijite 's' para obtenter otra carta o 'f' para retirarse");
                            continuar = Console.ReadLine();
                        }
                    }

                    if (total == 21)
                        Console.WriteLine("BlackJack");
                    else if (total > 21)
                    {
                        Console.WriteLine("Perdió");
                        total = 0;
                    }

                    if (contadorJugadores == 0)
                    {
                        jugador1P = total;
                        if (total > mayor)
                        {
                            ganador = jugador1;
                            mayor = jugador1P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador1;
                        Console.WriteLine("\n" + jugador1 + " obtuvo un total de: " + jugador1P);
                    }
                    else if (contadorJugadores == 1)
                    {
                        jugador2P = total;
                        if (total > mayor)
                        {
                            ganador = jugador2;
                            mayor = jugador2P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador2;
                        Console.WriteLine("\n" + jugador2 + " obtuvo un total de: " + jugador2P);
                    }
                    else if (contadorJugadores == 2)
                    {
                        jugador3P = total;
                        if (total > mayor)
                        {
                            ganador = jugador3;
                            mayor = jugador3P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador3;
                        Console.WriteLine("\n" + jugador3 + " obtuvo un total de: " + jugador3P);
                    }
                    else if (contadorJugadores == 3)
                    {
                        jugador4P = total;
                        if (total > mayor)
                        {
                            ganador = jugador4;
                            mayor = jugador4P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador4;
                        Console.WriteLine("\n" + jugador4 + " obtuvo un total de: " + jugador4P);
                    }
                    else if (contadorJugadores == 4)
                    {
                        jugador5P = total;
                        if (total > mayor)
                        {
                            ganador = jugador5;
                            mayor = jugador5P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador5;
                        Console.WriteLine("\n" + jugador5 + " obtuvo un total de: " + jugador5P);
                    }
                    else if (contadorJugadores == 5)
                    {
                        jugador6P = total;
                        if (total > mayor)
                        {
                            ganador = jugador6;
                            mayor = jugador6P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador6;
                        Console.WriteLine("\n" + jugador6 + " obtuvo un total de: " + jugador6P);
                    }
                    else
                    {
                        jugador7P = total;
                        if (total > mayor)
                        {
                            ganador = jugador7;
                            mayor = jugador7P;
                        }
                        else if (total == mayor)
                            ganador += " y " + jugador7;
                        Console.WriteLine("\n" + jugador7 + " obtuvo un total de: " + jugador7P);
                    }

                    contadorJugadores++;
                }
                if (mayor == 0)
                    Console.WriteLine("\nTodos perdieron");
                else
                    Console.WriteLine("\nGano: " + ganador + " con " + mayor + " puntos.");

                Console.WriteLine("\n¿Desea jugar otra vez? (digite 's' para si o 'n' para no)");
                continuarJuego = Console.ReadLine();
            }
        }
    }
}
