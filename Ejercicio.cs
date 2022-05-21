using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscelanea_Diego_Berdugo
{
    class Ejercicios
    {

        public double AreaTriangulo(double numero1, double numero2)

        {

            Console.WriteLine("Escriba numeros enteros: ");

            Console.WriteLine("Ingresar la base del triangulo: ");

            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("los valores que esta ingresando no son numericos");

            Console.WriteLine("Ingresar la altura del triangulo: ");

            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("los valores que esta ingresando no son numericos");

            Console.WriteLine("El area del triangulo es: " + (numero1 * numero2) / 2);
            return 0.0;
        }



        public double SumaNumero(double numero1, double numero2)

        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingrese el primer entero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo entero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma es: " + (numero1 + numero2));
            return 0.0;

        }

        public double NumeroCuadrado(double numero1, double numero2)
        {

            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingrese el numero que quiere elevar al cuadrado: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el numero " + numero1 + " elevado al cuadrado es: " + (numero1 * 2));

            return 0.0;
        }

        public double ConversorEuros(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese la cantidad en Euros que desea convertir a dolares: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(numero1 + " Euros equivalen a: " + (numero1 * 1.06) + " dolares ");


            return 0.0;
        }

        public double AreaPerimetro(double numero1)

        {

            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar el lado del cuadrado: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es: " + (numero1 * numero1) + " cm2");
            Console.WriteLine("El perimetro del cuadrado es: " + (numero1 * 4));
            return 0.0;
        }
        public double AreaVolumen(double numero1, double numero2)
        {
            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar el radio del cilindro: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar la altura del cilindro: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del cilindro es: " + (2 * Math.PI * numero1 * numero2));
            Console.WriteLine("El Volumen del cilindro es: " + (Math.PI * numero1 * numero1 * numero2));
            return 0.0;
        }
        public double RadioLongitud(double numero1)
        {
            Console.WriteLine("Ingresar el diametro de la circunferencia: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El radio de la circunferencia es: " + (numero1 / 2));
            Console.WriteLine("La longitud de la circunferencia es: " + (Math.PI * numero1));
            Console.WriteLine("El area de la circunferencia es: " + (Math.PI * (numero1 * 2)));
            return 0.0;

        }

        public double PromerdioNumeros(double numero1, double numero2, double numero3)
        {

            Console.WriteLine("Escriba numeros enteros: ");
            Console.WriteLine("Ingresar el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar el tercer numero ");
            numero3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El promedio de los 3 numeros ingresados es: " + (numero1 + numero2 + numero3) / 3);

            return 0.0;
        }

        public double PositivoNegativo(double numero1)
        {
            Console.WriteLine("Digite un numero por favor");
            numero1 = Convert.ToDouble(Console.ReadLine());
            if (numero1 > 0)
            {
                Console.WriteLine("el numero que digito es positivo");
            }
            else
            {
                Console.WriteLine("el numero que digito es negativo");
            };

            return 0.0;
        }

        public double MayorMenor(double numero1, double numero2)
        {
            Console.WriteLine("Digite el primer numero  por favor");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero  por favor");
            numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("el primer numero " + numero1 + " es el numero mayor    " + "    " + "el segundo numero  " + numero2 + " es el numero menor \n");
            }
            else
            {
                if (numero1 < numero2)
                {
                    Console.WriteLine("el segundo numero  " + numero2 + " es el numero mayor   " + "    " + "el segundo numero  " + numero1 + " es el numero menor       \n ");
                }
            };

            return 0.0;
        }

        public double MenoryMayor(double numero1, double numero2, double numero3)
        {
            Console.WriteLine("Ingresa el primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer numero");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                if (numero2 < numero3)
                {
                    Console.WriteLine("el numero " + numero3 + " es mayor y el numero " + numero1 + " es menor");
                }
                else
                    Console.WriteLine("el numero " + numero2 + " es mayor y el numero " + numero1 + " es menor");
            }
            else if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("el numero " + numero1 + " es mayor y el numero " + numero3 + " es menor");
                }
                else
                    Console.WriteLine("el numero " + numero2 + " es mayor y el numero " + numero3 + " es menor");
            }
            Console.ReadKey();
            return 0.0;
        }

        public double SumaoResta(double numero1, double numero2)
        {


            Console.WriteLine("digite por favor el numero A");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite por favor el numero B");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine("La suma entre los numero A y B  es: " + (numero1 + numero2));
            }
            else
            {
                Console.WriteLine("La resta entre los numero A y B  es: " + (numero1 - numero2));
            }

            return 0.0;
        }
        public double CocienteNumero(double numero1, double numero2)
        {
            Console.WriteLine("digite por favor el numero A");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite por favor el numero B");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == 0)
            {
                Console.WriteLine("la division por 0 no es posible");

            }
            else
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("la division por 0 no es posible");
                }
                else
                {
                    Console.WriteLine("el cociente entre el numero A y B es " + (numero1 / numero2));
                }
            }

            return 0.0;
        }

        public double NegativoyMultiplicacion(double numero1, double numero2)
        {

            Console.WriteLine("digite por favor el numero A");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite por favor el numero B");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < 0)
            {
                Console.WriteLine("la suma entre A Y B  es : " + (numero1 + numero2));

            }
            else
            {
                if (numero2 < 0)
                {
                    Console.WriteLine("la suma entre A Y B  es : " + (numero1 + numero2));
                }
                else
                {
                    Console.WriteLine("la multiplicacion entre A Y B  es : " + (numero1 * numero2));

                }

            }

            return 0.0;
        }

        public double AñoBisiesto(double numero1)
        {

            Console.WriteLine("calcular bisiestos \n");
            Console.WriteLine("año a calcular \n");

            numero1 = Convert.ToDouble(Console.ReadLine());
            if (numero1 % 4 == 0 && (numero1) % 100 != 0 || (numero1) % 400 == 0)
            {
                Console.WriteLine("Es bisiesto {0}\n", numero1);
            }
            else
            {
                Console.WriteLine("no es bisiesto {0} \n", numero1);
            }
            return 0.0;
        }

        public double MultiplosDe3(double numero1, double numero2)
        {

            do
            {
                Console.WriteLine("Los múltiplos de tres del cero al cien son:   " + numero1);
                numero1 = numero1 + 3;
                numero2 = numero2 + 1;
            }
            while (numero1 < 100);

            /*Console.WriteLine("El número de múltiplos de tres encontrados es de:  ", contadorMultiploTres);*/
            return 0.0;
        }
        public double Impares(double numero1)
        {
            numero1 = 1;
            /*int limite = 0;*/

            do
            {
                Console.WriteLine("los numeros impares del 1 al 100 son  " + numero1);
                numero1 = numero1 + 2;
                /* limite = limite + 1;*/

            } while (numero1 < 100);

            /*Console.WriteLine(" el numero de impares del 1 al 100 es " + limite );*/

            return 0.0;
        }
        public double pares(double numero1)
        {
            do
            {
                Console.WriteLine("los numeros pares del 1 al 100 son  " + numero1);
                numero1 = numero1 + 2;


            } while (numero1 < 100);
            return 0.0;
        } 
        public double Cuadrados30(double numero1, double numero2)
        {

            /*int limitec = 0;*/

            do
            {
                Console.WriteLine("los cuadrados  del 1 al 30 son  " + (numero1) + "*" + (numero1) + " = " + numero2);
                numero1 = numero1 + 1;
                numero2 = numero1 * numero1;
                /*limitec = limitec + 1;*/

            } while (numero1 <= 30);
            return 0.0;
        }
        public double SumaCuadrados(double numero1, double numero2, double numero3)
        {

            for (double i = numero1; numero1 <= 100; numero1++)
            {

                /*Console.WriteLine("los cuadrados  del 1 al 100 son  " + (numero1) + "*" + (numero1) + " = " + nu);*/

                numero2 = numero1 * numero1;


                numero3 = numero3 + numero2;

            }
            Console.WriteLine(" la suma de los cuadrados del numero 1 al 100  es  " + numero3);

            return 0.0;
        }
        public double NumeroAscendentes(double numero1, double numero2)
        {

            Console.WriteLine("digite por favor el numero A");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite por favor el numero B");
            numero2 = Convert.ToInt32(Console.ReadLine());

            for (double i = numero1; i < numero2; i++)
            {
                while (numero1 == numero2) ;
                Console.WriteLine("los numero ascendentes hasta llegar a " + numero2 + " son  " + i);

            }
            return 0.0;


        }

        public double SumaTeclado(double numero1, double numero2, double numero3)
        {
            do
            {
                Console.WriteLine("Introduce un numero: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                if (numero1 != 0)
                {
                    numero2 += numero1;
                    numero3++;
                }
            } while (numero1 != 0);
            if (numero3 == 0)
            {
                Console.WriteLine("No se puede realizar la suma");
            }
            else
            {
                Console.WriteLine("La suma de todos los numeros introducidos es: " + numero2);
            }

            return 0.0;

        }
    }

}

