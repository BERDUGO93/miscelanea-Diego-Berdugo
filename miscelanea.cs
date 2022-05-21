using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscelanea_Diego_Berdugo
{

    class miscelanea
    {



        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            double numero1 = 0.0;
            double numero2 = 0.0;
            double numero3 = 0.0;


            

            while (true)
            {

                try
                {



                    Console.WriteLine(@"                                        *******MENÚ PRINCIPAL *******



                                                 1. Operadores.

                                                 2. Condicionales.

                                                 3. Ciclos.

                                                 4. Arreglos.

                                                 0. Salir.



                                            *******MISCELANEA EN C# *******

                        ");

                    string menu = Console.ReadLine();
                    Console.Clear();

                    int switch_menu = int.Parse(menu);

                    switch (switch_menu)
                    {
                        case 1:
                            Console.WriteLine(@"                    ******* Operadores *******
                        

                        1. Calcular el área de un triángulo..

                        2. Suma de dos numeros.

                        3. Elevar un numero al cuadrado.

                        4. Conversor de Euros a dólares.

                        5. Calculador Area y Perimetro de un cuadrado.

                        6. Area y el volúmen de un cilindro

                        7. Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y
                          el área (pi*r)^2 del círculo inscrito

                        8. Calcular el promedio de tres (3) números

                        0. Salir.
                        ");

                            string submenu = Console.ReadLine();
                            Console.Clear();
                            int switch_submenu = int.Parse(submenu);

                            Ejercicios ejercicios = new Ejercicios();

                            switch (switch_submenu)
                            {


                                case 1:

                                    ejercicios.AreaTriangulo(numero1, numero2);


                                    break;

                                case 2:

                                    ejercicios.SumaNumero(numero1, numero2);

                                    break;

                                case 3:
                                    ejercicios.NumeroCuadrado(numero1, numero2);

                                    break;

                                case 4:
                                    ejercicios.ConversorEuros(numero1, numero2);
                                    break;

                                case 5:
                                    ejercicios.AreaPerimetro(numero1);
                                    break;

                                case 6:
                                    ejercicios.AreaVolumen(numero1, numero2);
                                    break;

                                case 7:
                                    ejercicios.RadioLongitud(numero1);
                                    break;

                                case 8:
                                    ejercicios.PromerdioNumeros(numero1, numero2, numero3);
                                    break;
                            }
                            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");

                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine(@"                    ******* Condicionales ******  
                           

                           
                        1. Escribir un algoritmo para saber si el número ingresado por teclado es positivo o negativo..

                        2. Escribir un algoritmo que reciba dos números por teclado y diga cuál es el mayor y cuál el
                           menor.

                        3. Escriba un programa que lea tres números enteros positivos y que calcule e imprima en
                           pantalla el menor y el mayor de ellos.

                        4. Da  dos números A y B, sumarlos si A es menor que B o sino restarlos.

                        5. Da  dos números A y B encontrar el cociente entre A y B. Recordar que la división por cero
                           no está definida, en ese caso debe aparecer una leyenda anunciando que la división no es
                           posible.

                        6. Da  dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario
                           multiplicarlos.

                        7. Escribir un algoritmo que determine si un año es bisiesto o no.

                        0. Salir.

                        ");

                            string submenu2 = Console.ReadLine();
                            Console.Clear();

                            int switch_submenu2 = int.Parse(submenu2);


                            Ejercicios condiciones = new Ejercicios();


                            switch (switch_submenu2)
                            {
                                case 1:

                                    condiciones.PositivoNegativo(numero1);

                                    break;

                                case 2:

                                    condiciones.MayorMenor(numero1, numero2);

                                    break;

                                case 3:


                                    condiciones.MenoryMayor(numero1, numero2, numero3);
                                    break;

                                case 4:
                                    condiciones.SumaoResta(numero1, numero2);
                                    break;

                                case 5:
                                    condiciones.CocienteNumero(numero1, numero2);

                                    break;

                                case 6:
                                    condiciones.NegativoyMultiplicacion(numero1, numero2);

                                    break;

                                case 7:
                                    condiciones.AñoBisiesto(numero1);
                                    break;


                            }
                            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");

                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine(@"                    ******* Ciclos *******


                        1. Imprimir todos los múltiplos de 3 que hay entre 1 y 100.

                        2. Imprimir los números impares entre 0 y 100.

                        3. Imprimir los números pares del 1 al 100.

                        4. Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30.

                        5. Escribir un programa que sume los cuadrados de los cien primeros números naturales,
                        mostrando el resultado en pantalla.

                        6. Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los
                        números comprendidos entre ellos en secuencia ascendente.

                        7. Sumar todos los números que se digitan por teclado mientras no sea cero.

                         0. Salir.

                         ");

                            string submenu3 = Console.ReadLine();
                            Console.Clear();

                            int switch_submenu3 = int.Parse(submenu3);

                            Ejercicios ciclos = new Ejercicios();

                            switch (switch_submenu3)
                            {

                                case 1:

                                    ciclos.MultiplosDe3(numero1, numero2);

                                    break;

                                case 2:
                                    ciclos.Impares(numero1);

                                    break;

                                case 3:

                                    ciclos.pares(numero1);

                                    break;

                                case 4:
                                    ciclos.Cuadrados30(numero1, numero2);

                                    break;
                                case 5:

                                    ciclos.SumaCuadrados(numero1, numero2, numero3);

                                    break;

                                case 6:


                                    ciclos.NumeroAscendentes(numero1, numero2);

                                    break;

                                case 7:

                                    ciclos.SumaTeclado(numero1, numero2, numero3);


                                    break;
                            }
                            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL ");



                            Console.ReadKey();
                            break;

                        case 4:
                            Console.WriteLine(@"Arreglos");
                            Console.ReadKey();
                            break;

                        case 0:
                            Console.WriteLine("Gracias");
                            Console.WriteLine("Codigo realizado por Diego Berdugo ficha 2450473");
                            Environment.Exit(0);
                            break;
                    }


                }

                catch (Exception)
                {

                    Console.WriteLine(" el valor ingresado no es valido , se regresara al menu principal");
                    Console.ReadLine();
                    
                }
                Console.Clear(); 
            }
        }
    }
}
