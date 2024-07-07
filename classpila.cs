using System;
using System.Collections.Generic;
using Interfaces;
using Interfaces2;
using ClassListaIterador;

namespace Classpila
{//Actividad 1, ejercicio 4
    public class Pila : Coleccionable, Iterable
    {
        private List<Comparable> elementos;
        public Pila()
        {
            this.elementos= new List<Comparable>();
        }

        public void apilar(Comparable c)
        {
            this.elementos.Add(c);
        }

        public Comparable desapilar()
        {
            Comparable e= this.elementos[this.elementos.Count -1];
            this.elementos.RemoveAt(this.elementos.Count -1); 
            return e;
        }


        //Metodos de la interface coleccionable clase 1
        public int cuantos()
        {
            return this.elementos.Count;
        }

         public Comparable minimo()
         {
             Comparable masChico = this.elementos[0];
             foreach (Comparable e in elementos)
             {
                 if (e.sosMenor(masChico))
                 {
                     masChico = e;
                 }
             }
             return masChico;
         }

        public Comparable maximo()
        {
            Comparable masGrande = this.elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.SosMayor(masGrande))
                {
                    masGrande = e;
                }
            }return masGrande;

        }
        public void agregar(Comparable c)
        {
            this.apilar(c);
        }
        public bool contiene (Comparable c)
        {
            foreach(Comparable e in this.elementos){
                if(e.sosIgual(c)){
                    return true;
                }
            }
            return false;           
        }

        //Metodos de la interface iterable, ejercicio 6
        public Iterador crearIterador()
        {
            return new ListaIterador(elementos);
        }


    }

}