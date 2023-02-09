using System;
using System.Collections.Generic;
using static System.Console;

namespace practica
{

    class program
    {
        public static void Main(string[] args)
        {


            Menu.menuPrin();
        }
        class Menu
        {
            public static void menuPrin()
            {
                int opcion;
                Console.WriteLine("------------- Programa Multi-Funcional -------------\n");
                Console.WriteLine("Menu De Opciones\n " +
                    "\n1- Calculadora." +
                    "\n2- ....." +
                    "\n3- ....." +
                    "\n4- ....." +
                    "\n5- Salir.\n");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        calculadora.submenu();

                        break;
                    case 2:

                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Selecione una Opcion.");
                        break;


                }

            }

        }
        class calculadora
        {
            public static void submenu()
            {
                int submen;
                Clear();

                Console.WriteLine("----------- Calculadora ------------ \n");
                Console.WriteLine("Menu De Opciones\n" +
                    "\n1- Suma." +
                    "\n2- Resta." +
                    "\n3- Multiplicacion." +
                    "\n4- Division." +
                    "\n5- Atras.\n");
                submen = int.Parse(Console.ReadLine());

                switch (submen)
                {
                    case 1:
                        suma();
                        break;
                    case 2:
                        resta();
                        break;
                    case 5:
                        Clear();
                        Menu.menuPrin();
                        break;

                    default:
                        Console.WriteLine("Seleccione una de las opciones. ");
                        submenu();
                        break;

                }

            }

            public static void suma()
            {
                Clear();
                int opcion;
                int Numero1, numero2;
                int sumatotal;

                Console.WriteLine("Ingrese el primer numero");
                Numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                numero2 = int.Parse(Console.ReadLine());

                sumatotal = Numero1 + numero2;

                Console.WriteLine("El resultado final es:   " + sumatotal);
                Console.WriteLine("\n--------------------------------\n");
                Console.WriteLine("Si desea continuar ingrese 1, si quieres ir al menu ingrese 2 y si quieres salir precione Enter.");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1) { suma(); }
                if (opcion == 2) { submenu(); }
                else
                {
                    Console.WriteLine("Gracias por usar la APP");
                    Console.ReadKey();
                }


            }

            public static void resta()
            {
                Clear();
                int opcion;
                int Numero1, numero2;
                int restotal;

                Console.WriteLine("Ingrese el primer numero");
                Numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                numero2 = int.Parse(Console.ReadLine());

                restotal = Numero1 - numero2;

                Console.WriteLine("El resultado final es:  "+ restotal);
                Console.WriteLine("\n-------------------------------\n");
                Console.WriteLine("Si desea continuar ingrese 1, si quieres ir al menu ingrese 2 y si quieres salir precione Enter.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1) { resta(); }
                if (opcion == 2) { submenu(); }
                else
                {
                    Console.WriteLine("Gracias por usar la APP");
                    Console.ReadKey();
                }

            }


        }
    }       

}    