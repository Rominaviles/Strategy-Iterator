using System;
using System.Collections.Generic;
using Interfaces;
using Interfaces2;
using ClassListaIterador;

namespace classconjunto
{
//EJERCICIO 3
  public class Conjunto: Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        //Metodos
        public void agregar(Comparable c)
        {
            if(!elementos.Contains(c))
            {
                elementos.Add(c);
            }
        }
        public bool pertenece(Comparable c)
        {
            if (elementos.Contains(c))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        //Metodos coleccionable Ejercicio 5
        public int cuantos()
        {
            return this.elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable masChico = elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.sosMenor(masChico))
                {
                    masChico = e;
                }
            }return masChico;
        }
        public Comparable maximo()
        {
            Comparable masGrande = elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.sosMenor(masGrande))
                {
                    masGrande = e;
                }
            }return masGrande;            
        }

        //Metodo agregar de la interface ya implementado en la clase
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