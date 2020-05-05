using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Ejercicio1_UF2
{
    class Program
    {
        // Aquí tenemos el programa principal Main

        static void Main(string[] args)
        {
            // Declaramos el array de 100 numeros de tipo entero

            int[] arrayEnterosAleatorios = new int[100];

            // Iniciamos la clase Random para generar números aleatorios

            Random numerosAleatorios = new Random();

            // Recorremos el array que hemos creado y en cada posición de i, nos generará un número aleatorio comprendido entre el 0 y el 1000 porque así he decidido

            for (int i = 0; i < arrayEnterosAleatorios.Length; i++)
            {
                arrayEnterosAleatorios[i] = numerosAleatorios.Next(0, 1001);

            }

            // Imprimimos por pantalla el siguiente mensaje y llamamos a la función que hemos creado para calcular el número mayor

            Console.WriteLine("El numero mayor es: " + Mayor(arrayEnterosAleatorios));

            // Inicializo una variable de tipo entero = 0 para poder llamar a la función por referencia (al tener la palabra "ref" debe estar inicializada con algún valor, si fuese "out" no haría falta

            int numeroMenor = 0;

            //Llamo a la función que calcula el número menor con la variable que acabo de crear

            Menor(arrayEnterosAleatorios, ref numeroMenor);

            //Inicializo una variable de tipo double, sin asignarle valor, ya que la voy a utilizar para llamar a la función que me calcula la media; Es una función por referencia de tipo "out", por lo que no necesito que tenga un valor

            double promedio;

            //Llamo a la función que calcula el número promedio con la variable que acabo de crear

            Calcular_media(arrayEnterosAleatorios, out promedio);


            Console.ReadKey();

            // Fin del programa principal 
        }



        // Creamos la función que nos pide el ejercicio con la siguiente cabecera: 

        static int Mayor(int[] array)
        {
            // Inicializo una variable de tipo entero para más tarde poder calcular el número de máximo valor en el array

            int numeroMayor = 0;

            // Recorremos el array

            for (int i = 0; i < array.Length; i++)
            {
                // Si cumple esta condición, entonces la variable tomará el valor del array[i]

                if (array[i] > numeroMayor)
                {
                    numeroMayor = array[i];
                }

            }

            // Como es por valor, debemos poner return, para que nos devuelva algo de tipo entero

            return numeroMayor;

            // Fin de la función que calcula el máximo valor
        }

        // Creamos la función que nos pide el ejercicio con la siguiente cabecera: 

        static void Menor(int[] array, ref int menor)
        {
            // Recurrimos a la función Array.Min() que nos calcula ella directamente el valor mínimo del array

            menor = array.Min();

            // Imprimimos dicho valor por pantalla

            Console.WriteLine("El numero menor es: " + menor);

            // Fin de la función que calcula el mínimo valor

        }

        // Creamos la función que nos pide el ejercicio con la siguiente cabecera: 

        static void Calcular_media(int[] array, out double media)
        {
            // Recurrimos a la función Array.Min() que nos calcula ella directamente el valor promedio del array

            media = array.Average();

            // Imprimimos dicho valor por pantalla

            Console.WriteLine("La media de los números que componen el Array es de: " + media);

            // Fin de la función que calcula el valor promedio
        }



    }
}
