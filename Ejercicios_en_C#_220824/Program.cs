using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_en_C__220824
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) 1: Crea un programa en C# que te salude por tu nombre (por ejemplo, "Hola, Nacho").
            Console.WriteLine("\nEjercicio 1:");
            Console.WriteLine("Hola Paz");

            // 2) 15: Crea un programa que calcule la suma de 285 y 1396, usando variables.
            Console.WriteLine("\nEjercicio 15:");
            int num1 = 285;
            int num2 = 1396;
            int resultadoSuma = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + resultadoSuma);

            // 3) 16: Crea un programa que calcule el resto de dividir 3784 entre 16, usando variables.
            Console.WriteLine("\nEjercicio 16");
            int dividendo = 3784;
            int divisor = 16;
            int resto = dividendo % divisor;

            Console.WriteLine("El resto de dividir " + dividendo + " entre " + divisor + " es: " + resto);

            // 4) 23: Crea un programa que calcule el producto de dos números introducidos por el usuario.
            Console.WriteLine("\nEjercicio 23");
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ahora, ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int producto = numero1 * numero2;

            Console.WriteLine("El producto de " + numero1 + " y " + numero2 + " es: " + producto);


            /* 5) 31: Crea una variante del programa anterior, que pide al usuario un número y muestra su tabla de multiplicar. 
               Esta vez no deberás utilizar {0}, {1}, {2}, sino "Write".*/
            Console.WriteLine("\nEjercicio 31");
            Console.Write("Ingrese el número multiplicador con el cual desea obtener la tabla de multiplicar: ");
            int multiplicador = int.Parse(Console.ReadLine());
            int multiplicacion;

            Console.WriteLine("TABLA DE MULTIPLICAR DE " + multiplicador);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " x " + multiplicador + " = ");
                multiplicacion = i * multiplicador;
                Console.WriteLine(multiplicacion);
            }


            /* 6) 32: Crea un programa que convierta de grados Celsius (centígrados) a Kelvin y a Fahrenheit: 
               pedirá al usuario la cantidad de grados centígrados y usará las siguiente tablas de conversión: 
                * kelvin = celsius + 273 ; 
                * fahrenheit = celsius x 18 / 10 + 32. 
               Emplea "Write" en vez de "{0}" cuando debas mostrar varios datos en la misma línea.
.*/
            Console.WriteLine("\nEjercicio 32");
            Console.Write("Por favor, ingrese el número en centígrado para realizar la conversión a Kelvin y Fahrenheit: ");
            Decimal celsius = Decimal.Parse(Console.ReadLine());
            Decimal kelvin = Math.Round(celsius + 273, 2);
            Decimal fahrenheit = Math.Round((celsius * 18 / 10) + 32, 2);
            Console.WriteLine("La temperatura " + celsius + "°C equivale a " + kelvin + "°K y a " + fahrenheit + "°F.");

            /* 7) 33: Crea un programa que pida al usuario un número entero y diga si es par (pista: habrá que comprobar
               si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) ...). */
            Console.WriteLine("\nEjercicio 33");
            Console.Write("Por favor, ingrese un número entero para verificar si es par o impar: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par.");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar");
            }

            /*
             8) 37: Crea un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un primer número entero. 
               Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". 
               Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos.
            */
            Console.WriteLine("\nEjercicio 37");
            Console.Write("Por favor, ingrese un número: ");
            int numA = int.Parse(Console.ReadLine());

            if (numA == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0.");
            }
            else
            {
                Console.Write("Por favor, ingrese otro número: ");
                int numB = int.Parse(Console.ReadLine());
                Console.WriteLine("El producto de ambos números ingresados es: " + (numA * numB));
            }

            /* 
             9) 57: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, 
                usando "switch" (por ejemplo, si introduce "1", el programa escribirá "uno").              
            */
            Console.WriteLine("\nEjercicio 57");
            Console.Write("Por favor, ingrese un número del 1 al 5: ");
            int numeroUsuario = int.Parse(Console.ReadLine());

            switch (numeroUsuario)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Número fuera del rango. Por favor, ingrese un número entre 1 y 5.");
                    break;
            }

            /* 
             10) 75: Crea un programa que pida al usuario su identificador y su contraseña, y no le permita seguir hasta 
                 que introduzca como nombre "Pedro" y como contraseña "Peter".             
            */
            Console.WriteLine("\nEjercicio 75");
            String identificador = "";
            String contrasenia = "";
            Boolean usuarioAceptado = false;

            while (!usuarioAceptado)
            {
                Console.Write("\nPor favor, ingrese su identificador: ");
                identificador = Console.ReadLine();
                Console.Write("\nAhora, ingrese la contraseña: ");
                contrasenia = Console.ReadLine();

                if (identificador == "Pedro" && contrasenia == "Peter")
                {
                    Console.WriteLine("Bienvenido " + identificador);
                    usuarioAceptado = true;
                }
                else
                {
                    Console.WriteLine("Identidicador y/o Contraseña erróneas. Por favor, intente nuevamente.");
                    usuarioAceptado = false;
                }
            }

            /* 
             11) 76: Crea un programa que muestre los números del 10 al 20, ambos incluidos.             
            */
            Console.WriteLine("\nEjercicio 76");

            for (int i = 10; i <= 20; i++)
            {
                Console.Write("[ " + i + " ]");
            }

            Console.WriteLine("");

            /* 
             12) 77: Crea un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3 
                 (pista: habrá que recorrer todos esos números y ver si el resto de la división entre 3 resulta 0).
            */
            Console.WriteLine("\nEjercicio 77");
            Console.WriteLine("Los números múltiplos de 3, desde el 1 hasta el 50, son:");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("El número " + i + " es múltiplo de 3.");
                }
            }

            /* 
             13) 87: Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto (por ejemplo, 3) 
                 y escriba un rectángulo formado por esa cantidad de asteriscos:
                  ****
                  ****
                  ****
            */
            Console.WriteLine("\nEjercicio 87");
            Console.WriteLine("Dibujando un cuadrado o rectángulo :) ");
            Console.Write("Ingrese el ancho: ");
            int ancho = int.Parse(Console.ReadLine());
            Console.Write("Ahora, ingrese el alto: ");
            int alto = int.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado:");
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /* 
             14) 101: Crea un programa que cuente cuántas veces aparece la letra 'a' en una frase que teclee el usuario, utilizando "foreach".
            */
            Console.WriteLine("\nEjercicio 101");
            Console.Write("Por favor, ingrese una frase aleatoria: ");
            string frase = Console.ReadLine();
            int contador = 0;

            foreach (char letra in frase)
            {
                if (letra == 'a')
                {
                    contador++;
                }
            }

            Console.WriteLine($"La letra 'a' aparece {contador} veces en la frase.");

            /* 
             15) 102: Crear un programa que dé al usuario la oportunidad de adivinar un número del 1 al 100 
                 (prefijado en el programa) en un máximo de 6 intentos. En cada pasada deberá avisar de si se ha 
                 pasado o se ha quedado corto.
            */
            Console.WriteLine("\nEjercicio 102");
            Console.WriteLine("Adivinando el número del 1 al 100. Tendrá 6 oportunidades!");
            int numSecreto = 11;
            int intentos = 6;

            for (int i = 1; i <= intentos; i++)
            {
                Console.Write($"Intento n° {i}, ingrese el número secreto: ");
                int numUsuario = int.Parse(Console.ReadLine());

                if (numUsuario == numSecreto)
                {
                    Console.WriteLine("¡¡¡Felicidades!!!, ¡¡¡has adivinado el número!!!");
                    break;
                }
                else if (numUsuario < numSecreto)
                {
                    Console.WriteLine("Te quedaste corto corazón...");
                }
                else
                {
                    Console.WriteLine("Te has pasado mi ciela!!...");
                }

                if (i == intentos)
                {
                    Console.WriteLine($"Lo lamento, agotaste tus {intentos} intentos. El número secreto era {numSecreto}.");
                }
            }

            /* 
             16) 106: Crea un programa que "dibuje" un triángulo decreciente, con la altura que indique el usuario. 
                 Por ejemplo, si el usuario dice que desea 4 caracteres de alto, el triángulo sería así:
                 ****
                 ***
                 **
                 *
            */
            Console.WriteLine("\nEjercicio 106");
            Console.Write("Ingrese la altura que desea que tenga el triángulo descendente: ");
            int altura = int.Parse(Console.ReadLine());

            for (int i = altura; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /* 
             17) 107: Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una fila (o columna) de asteriscos 
                 y cuyo interior esté formado por espacios en blanco, con el ancho y el alto que indique el usuario.
                 Por ejemplo, si desea anchura 4 y altura 3, el rectángulo sería así:
                  ****
                  *  *
                  ****
            */
            Console.WriteLine("\nEjercicio 107");
            Console.Write("Ingrese el ancho que desea que tenga el rectángulo o cuadrado hueco: ");
            int anchoCuadrado = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el alto que desea que tenga el rectángulo o cuadrado hueco: ");
            int altoCuadrado = int.Parse(Console.ReadLine());

            for (int f = 1; f <= altoCuadrado; f++)
            {
                for (int c = 1; c <= anchoCuadrado; c++)
                {
                    if (f == 1 || f == altoCuadrado || c == 1 || c == anchoCuadrado)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
