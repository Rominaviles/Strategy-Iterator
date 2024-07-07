using System;
using System.Collections.Generic;
using Interfaces;
using Classpila;
using Classcola;

namespace Classcoleccion
{//Actividad 1, ejercicio 8
    public class ColeccionMultiple: Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila= p;
            this.cola= c;
        }

        //Metodo interface coleccionable

        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();

        }
        public Comparable minimo()
        {
            Comparable minimoPila= pila.minimo();
            Comparable minimoCola= cola.minimo();
            if(minimoPila.sosMenor(minimoCola))
            {
                return minimoPila;
            }
            else
            {
                return minimoCola;
            }
        }
        public Comparable maximo()
        {
            Comparable minimoPila= pila.minimo();
            Comparable minimoCola= cola.minimo();
            if(minimoPila.SosMayor(minimoCola))
            {
                return minimoPila;
            }
            else
            {
                return minimoCola;
            }
        }
        public void agregar(Comparable c)
        {

        }
        public bool contiene (Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }


}