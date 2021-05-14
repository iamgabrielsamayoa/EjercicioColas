using Colas.Clases.ColaArreglo;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Program
    {

        public static void PruebaQueue()
        {
            Queue qt = new Queue();
            qt.Enqueue("Hola");
            qt.Enqueue("Esta");
            qt.Enqueue("es");
            qt.Enqueue("una");
            qt.Enqueue("prueba");

            Console.WriteLine($"La cola tiene {qt.Count} elementos");

            qt.Dequeue();//quita el primer elemento
            Console.WriteLine($"La cola tiene {qt.Count} elementos");

            qt.Dequeue();//quita el primer elemento
            Console.WriteLine($"La cola tiene {qt.Count} elementos");

            qt.Dequeue();//quita el primer elemento
            Console.WriteLine($"La cola tiene {qt.Count} elementos");

            qt.Dequeue();//quita el primer elemento
            Console.WriteLine($"La cola tiene {qt.Count} elementos");

            qt.Dequeue();//quita el primer elemento
            Console.WriteLine($"La cola tiene {qt.Count} elementos");
        }

        //Adapte el código visto en clase a lo solicitado
        static void Capicua()
        {

            bool capicua;
            String numero;
            Stack pila = new Stack(); //Stack
            Queue cola_circular = new Queue();
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("Teclea un número");
                        numero = Console.ReadLine();
                    } while (!valid(numero));
                    //Pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        char c;
                        c = numero[i];
                        cola_circular.Enqueue(c);
                        pila.Push(c);
                    }
                    //Desencolar, se retira la cola y pila para comparar
                    do
                    {
                        char d;
                        d = (Char)cola_circular.Dequeue();
                        capicua = d.Equals(pila.Pop());//Compara la igualdad
                    } while (capicua && cola_circular.Count != 0);
                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numero} no es capicua");
                        Console.WriteLine("Intente otro :)");
                    }
                    cola_circular.Clear();
                    pila.Clear();
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en{errores.Message} ");
            }
        }

        private static bool valid(string numero)//if its a number
        {
            bool sw = true;
            int i = 0;
            while(sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }
        static void Main(string[] args)
        {
            Capicua();
            //PruebaQueue();
            //Stack s = new Stack();

            //Programa Capicua
            //bool capicua;
            //string numero;

            //PilaLista pila = new PilaLista();
            //ColaCircular circular_Cola = new ColaCircular();

            //try
            //{
            //    capicua = false;
            //    while (!capicua)
            //    {
            //        do
            //        {
            //            Console.WriteLine("\n Teclea un numero:");
            //            numero = Console.ReadLine();
            //        } while (!valid(numero));


            //        //Pone en la cola y pila cada digito

            //        for (int i = 0; i < numero.Length; i++)
            //        {
            //            char c;
            //            c = numero[i];
            //            circular_Cola.insertar(c);
            //            pila.insertar(c);
            //        }

            //        //Se retira de la cola y pila para comparar
            //        do
            //        {
            //            char d;
            //            d = (char)circular_Cola.quitar();
            //            capicua = d.Equals(pila.quitar()); //Compara igualdad
            //            if (capicua)
            //            {
            //                Console.WriteLine($"Numero {numero} es capicua");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Numero {numero} no es capicua \n intente otro");

            //            }
            //        } while (true);
            //    }
            //}
            //catch (Exception errores)
            //{
            //    Console.WriteLine($"Error en {errores.Message}");
               
            //}

            Console.ReadLine();

        }
    }
}
