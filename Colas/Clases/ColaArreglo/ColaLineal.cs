using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        //Array para llevar nuestra información
        protected int fin;
        private static int MAXTAMQ = 39; //Constantes con Mayusculas
        protected int frente;

        protected object[] ListaCola;//A cambiar para tipo de estructura

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            ListaCola = new object[MAXTAMQ];
        }


        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }
        //Operaciones para trabajar con datos en la cola
        public void insertar (object elemento)
        {
            if (!colaLlena())
            {
                ListaCola[++fin] = elemento; //Primero imprime valor y luego aumenta
                //fin = 10
                // fin  = fin +1
                
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //Quitar elementos de la cola
        public object quitar()
        {
            if (!colaVacia())
            {
                return ListaCola[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiar toda la cola
        //Repetimos la parte del constructor
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }


        //Acceder al valor frente de la cola

        public object frenteCola()
        {
            if (!colaVacia())
            {
                return ListaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }



    }//end class
}
