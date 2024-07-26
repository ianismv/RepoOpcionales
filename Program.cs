//.NET - C# - Ejercicios
//Built - In Value Types. Estructuras Condicionales y Repetitivas.
//Realizar los siguientes ejercicios en una aplicación de consola.
//Para cada uno de ellos debe identificar las entradas, salidas y restricciones, y escribir el programa respectivo.
//En algunos casos quizás sea necesario buscar más información en internet para elaborar el algoritmo.

//EJERCICIOS

//1.Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición.
//2. Pedir un número entero por teclado y calcular si es par o impar.
//3. Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición.
//4. Dada un número del 1 al 10, devolver su “versión” en números romanos. 
//5. Leer el nombre y las edades de dos personas y devolver el nombre del menor. En caso de que tengan la misma edad también debe indicarse. Devolver también la diferencia de edad en caso de corresponder.
//6. Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.
//7. Desarrolle un programa que calcule el desglose de una cantidad dada, en billetes y monedas tal que se minimice la cantidad de monedas y billetes.
//  Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1, donde los últimos tres son monedas.
//  (Por ejemplo, para $1,723 se debe imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de $20, 1 moneda de $2, 1 moneda de $1).
//  Obviar los signos de billete ($) y tratar todos los valores como números, para los cálculos.
//8. Pide un número N, y muestra todos los números del 1 al N.
//9. Pedir 15 números y escribir la suma total.
//10. Pide 5 números e indica si alguno es múltiplo de 3.
//11. Escriba un programa que solicite una contraseña (el texto de la contraseña no es importante) y la vuelva a solicitar hasta que las dos contraseñas coincidan.
//12. Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres peticiones no debe solicitar más la contraseña y terminar el programa.
//13. Proponer al usuario que adivine un número a base de intentarlo.
//14. Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor».
//15. Crea un programa que permita sumar N números. El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’.
//16. Crea un programa que solicite al usuario una cadena de texto y que verifique si es o no un palíndromo
//17. Pide al usuario un número x y calcula su factorial
//18. Crea un programa que convierta una temperatura en grados Celsius a Fahrenheit o viceversa según la elección del usuario
//19. Solicita al usuario un número entero positivo y muestra los primeros 50 números de la secuencia de Fibonacci 
//20. Desarrolla un juego en el que el programa elija una palabra y el usuario tenga que adivinarla letra por letra, con un límite de intentos
//21 (EXTRA). Adaptar el programa anterior para que a medida que el usuario falle, la aplicación autocomplete  la palabra letra a letra a modo de pistas para el usuario.
//El numero de intentos estará dado por la cantidad de letras restantes que el usuario tenga que adivinar.
//Ejemplo: La palabra ADIVINAR tendrá 8 intentos. Si la forma de la palabra es AD_V_NA_ son 3 intentos

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la resolucion de ejercicios opcionales del Bootcamp 3.0!");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("MENÚ DE EJERCICIOS:");
            Console.WriteLine();
            Console.WriteLine("EJERCICIO 1: VALOR MAYOR A 100");
            Console.WriteLine("EJERCICIO 2: PAR O IMPAR");
            Console.WriteLine("EJERCICIO 3: DOBLE DE UN IMPAR");
            Console.WriteLine("EJERCICIO 4: NÚMEROS ROMANOS");
            Console.WriteLine("EJERCICIO 5: EDADES DE PERSONAS");
            Console.WriteLine("EJERCICIO 6: TIPO DE TRIANGULO");
            Console.WriteLine("EJERCICIO 7: BILLETES $$$$");
            Console.WriteLine("EJERCICIO 8: ENUMERACIÓN");
            Console.WriteLine("EJERCICIO 9: SUMA TOTAL");
            Console.WriteLine("EJERCICIO 10:MULTIPLO DE 3");
            Console.WriteLine("EJERCICIO 11: CONTRASEÑA");
            Console.WriteLine("EJERCICIO 12: CONTRASEÑA VARIACION");
            Console.WriteLine("EJERCICIO 13: ADIVINAR NUMERO");
            Console.WriteLine("EJERCICIO 14: ADIVINAR NUMERO CON PISTAS");
            Console.WriteLine("EJERCICIO 15: SUMAR HASTA EL FIN");
            Console.WriteLine("EJERCICIO 16: PALINDROMO");
            Console.WriteLine("EJERCICIO 17: FACTORIAL");
            Console.WriteLine("EJERCICIO 18: TEMPERATURA");
            Console.WriteLine("EJERCICIO 19: FIBONACCI");
            Console.WriteLine("EJERCICIO 20: JUEGO ADIVINAR PALABRA");
            Console.WriteLine("EJERCICIO 21: JUEGO ADIVINAR PALABRA VARIACION");
            Console.WriteLine();
            Console.WriteLine("Porfavor, seleccione el ejercicio a ejecutar:");
            int numEj = 0;
            bool validacionNumEj = int.TryParse(Console.ReadLine(), out numEj);
            while (!validacionNumEj)
            {
                Console.WriteLine();
                Console.WriteLine("Valor incorrecto. Porfavor, ingrese un valor de tipo numérico.");
                validacionNumEj = int.TryParse(Console.ReadLine(), out numEj);
            }
            switch (numEj)
            {
                case 1:
                    Console.WriteLine("Ejercicio 1: Dado un valor, devolver un mensaje que diga");
                    Console.WriteLine("El VALOR ES MAYOR QUE 100");
                    Console.WriteLine("Sólo cuando se cumpla dicha condición.");
                    Console.WriteLine();
                    Console.WriteLine("Inserte un valor:");
                    int valorEj1;
                    bool validacionEj1;
                    bool esnumeroEj1;
                    do
                    {
                        esnumeroEj1 = int.TryParse(Console.ReadLine(), out valorEj1);
                        if (esnumeroEj1)
                        {
                            if (valorEj1 > 100)
                            {
                                validacionEj1 = true;
                                Console.WriteLine();
                                Console.WriteLine("EL VALOR " + valorEj1 + " ES MAYOR QUE 100.");
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                validacionEj1 = false;
                                Console.WriteLine("No se cumplió la condición. Inserte nuevamente un valor:");
                            }
                        }
                        else
                        {
                            validacionEj1 = false;
                            Console.WriteLine("Valor incorrecto. Inserte un valor numérico.");
                        };
                    }
                    while (validacionEj1 == false);
                    break;
                case 2:
                    Console.WriteLine("Ejercicio 2.Pedir un número entero por teclado y calcular si es par o impar.");
                    Console.WriteLine();
                    Console.WriteLine("Inserte un número entero:");
                    Console.WriteLine();
                    int valorEj2 = 0;
                    bool esnumeroEj2 = true;
                    while (true)
                    {
                        esnumeroEj2 = int.TryParse(Console.ReadLine(), out valorEj2);
                        if (esnumeroEj2)
                        {
                            if (valorEj2 % 2 == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"El número {valorEj2} es par.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"El número {valorEj2} es impar.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Valor incorrecto. Porfavor, inserte de nuevo un número entero.");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Ejercicio 3: Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar");
                    Console.WriteLine("Por ejemplo, 14 cumple con esta condición.");
                    Console.WriteLine();
                    Console.WriteLine("Porfavor, ingrese un valor numérico:");
                    int valorEj3 = 0;
                    bool esnumeroEj3 = true;
                    while (true)
                    {
                        esnumeroEj3 = int.TryParse(Console.ReadLine(), out valorEj3);
                        if (esnumeroEj3)
                        {
                            if (valorEj3 % 2 == 0)
                            {
                                int mitad = valorEj3 / 2;
                                if (mitad % 2 == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"La mitad del número {valorEj3} es {mitad} y es PAR.");
                                    Console.WriteLine("No se cumplió la condición. Porfavor, ingrese otro valor numérico:");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"La mitad del número {valorEj3} es {mitad} y es IMPAR. Por lo tanto se cumplió la condición!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"El número {valorEj3} es impar, por lo tanto es imposible que su doble sea par.");
                                Console.WriteLine("No se cumplió la condición. Porfavor, ingrese otro valor numérico:");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Valor incorrecto. Porfavor, inserte de nuevo un número entero.");
                        }
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                default:
                    break;
            }
            Console.WriteLine("Desea realizar otro ejercicio?(sí/no)");
            string respuesta = Console.ReadLine();
            while (respuesta != "sí" && respuesta != "si" && respuesta != "no")
            {
                Console.WriteLine("Respuesta incorrecta. Por favor, ingrese una respuesta correcta (sí/no)");
                respuesta = Console.ReadLine().ToLower();
            }
            if (respuesta == "no")
            {
                Console.WriteLine();
                Console.WriteLine("¡MUCHAS GRACIAS POR UTILIZAR NUESTRA APLICACIÓN DE EJERCICIOS OPCIONALES! ¡HASTA LUEGO!");
                Console.WriteLine();
                break;
            }
        }
    }
}