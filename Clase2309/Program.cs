using System;
using System.Collections.Generic;

namespace Clase2309
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración (alt+enter)
            List<int> misNumeros;
            //inicialización
            misNumeros = new List<int>();

            //vemos el nombre de la lista(interno)
            Console.WriteLine(misNumeros);
            //contando elementos dentro de la lista
            Console.WriteLine(misNumeros.Count);

            //todo junto
            List<int> misNumerosv2 = new List<int>();

            //declaramos algunos números
            int numeroUno = 50;
            int numeroDos = 102;

            //Añadiendo elementos a la lista(List)
            misNumeros.Add(numeroUno);
            misNumeros.Add(numeroDos);
            misNumeros.Add(99);

            //Ingresamos a posiciones de List(Coleccion) (ver /obtener)
            Console.WriteLine(misNumeros[0]);
            Console.WriteLine(misNumeros[1]);
            Console.WriteLine(misNumeros[2]);
            Console.WriteLine("*****************");
            Console.WriteLine($"La lista en este momento tiene {misNumeros.Count} elementos.");

            //recorremos con foreach
            recorrerNumeros(misNumeros);

            //probamos si podemos cambiar un elemento por índice (satisfactorio)
            misNumeros[0] = 5000;

            //volvemos recorrer.
            recorrerNumeros(misNumeros);

            Console.WriteLine($"La lista contiene el número {numeroDos}?: {misNumeros.Contains(numeroDos)}");

            //probando algunos métodos como insert, donde en el index 2, agrego un 5
            misNumeros.Insert(2, 5);

            recorrerNumeros(misNumeros);
            misNumeros.Add(5000);
            recorrerNumeros(misNumeros);
            misNumeros.RemoveAll(quitarTodosLos5000);
            Console.WriteLine("Usé RemoveAll para quitar todos los 5000");
            recorrerNumeros(misNumeros);

            Console.WriteLine("================");

            Console.WriteLine($"El primer número de la lista es el {misNumeros[0]}");
            Console.WriteLine("El primer número de la lista es el {0}", misNumeros[0]);

            Console.WriteLine("================");

            //Analizamos el comportamiento de las colas (Queue)
            Queue<string> colaDePersonas = new Queue<string>(); //declaramos e inicializamos
            //declaramos un array con el que llenaremos la cola
            string[] nombres = new string[] { "Carlos", "Bruno", "Daniela", "Rocío", "Jorge", "Lisa" };
            //llenamos la cola
            foreach(string persona in nombres)
            {
                colaDePersonas.Enqueue(persona);
            }
            //recorremos la cola
            foreach(string persona in colaDePersonas)
            {
                Console.WriteLine(persona);
            }

            //sacamos al primero que entró en la cola
            Console.WriteLine("Uso Dequeue");
            string personaQueSaleDeLaCola = colaDePersonas.Dequeue();

            Console.WriteLine(personaQueSaleDeLaCola);

            Console.WriteLine("***************************");
            foreach (string persona in colaDePersonas)
            {
                Console.WriteLine(persona);
            }
            //Analizamos quien sería el siguiente en salir
            Console.WriteLine("****La siguiente persona en pasar es: {0}", colaDePersonas.Peek());

            Console.WriteLine("****************************************************************");

            //Analizamos las pilas (Stack)
            Stack<string> pilaDeJuegos = new Stack<string>();
            //declaramos un array con el que llenaremos la pila
            string[] juegos = new string[] { "Mario Galaxy", "Zelda Ocarine of Time", "Skyrim", "GTA San Andreas", "Cochino Larry" };
            //llenamos la pila
            foreach(string juego in juegos)
            {
                pilaDeJuegos.Push(juego);
            }
            //recorremos la pila
            foreach(string elementoEnPila in pilaDeJuegos)
            {
                Console.WriteLine(elementoEnPila);
            }
            //Analizamos el siguiente en salr
            Console.WriteLine("Uso método Peek");
            Console.WriteLine(pilaDeJuegos.Peek());

            //Quitamos al que está sobre la pila y lo guardamos
            Console.WriteLine("Usamos método pop");
            string juegoQueSale = pilaDeJuegos.Pop();

            Console.WriteLine("*************************");

            Console.WriteLine("Acabo de sacar de la pila a {0}", juegoQueSale);
            //Analizamos como quedó la pila al recorrerla
            Console.WriteLine("La pila quedó de la siguiente manera: ");
            foreach (string elementoEnPila in pilaDeJuegos)
            {
                Console.WriteLine(elementoEnPila);
            }
            Console.WriteLine();
            //Analizamos quien sería el siguiente en salir
            Console.WriteLine("El elemento que está a la espera de salir de la pila es {0}", pilaDeJuegos.Peek());
        }

        //función donde le entrego una lista de números y las recorre, porque da flojera escribir un foreach a cada rato
        static void recorrerNumeros(List<int> lista)
        {
            Console.WriteLine("*********");
            foreach (int elem in lista)
            {
                Console.WriteLine(elem);
            }
        }

        //función booleana que comprueba si un número es igual a 5000
        static bool quitarTodosLos5000 (int n)
        { 
                if (n == 5000)
                {
                    return true;
                }
                return false;
        }

}
}
