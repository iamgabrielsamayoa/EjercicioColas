using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaCircular//Cambia la forma en como se manejan los punteros
    {
        protected int fin;
        private static int MAXTAMQ = 99; //Constantes con Mayusculas
        protected int frente;

        protected object[] listaCola;

        //Avanza una posicion
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //Constructor
        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new object[MAXTAMQ];
        }

        //Validaciones
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //Operaciones de modificacion de cola
        public void insertar(object elemento)
        {
            if(!colaLlena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la Cola");
            }
        }

        public object quitar()
        {
            if(!colaVacia())
            {
                object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }


        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //obtener el valor de frente

        public object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Capicua = palindromo pero con numeros
    }
}
