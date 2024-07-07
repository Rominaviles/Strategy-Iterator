using System;
using System.Collections.Generic;  
using Interfaces;
using classClaveValor;
using Interfaces2;
using ClassListaIterador;

namespace classdiccionario
{
//EJERCICIO 4
    public class Diccionario: Coleccionable, Iterable
    {
        private List<Clavevalor> elementos;

        public Diccionario()
        {
            elementos= new List<Clavevalor>();
        }

        //Metodos
        public void agregar (Comparable c) //Metodo de diccionario tambien valido para la interface coleccionable
        {
            foreach (var cv in elementos)
            {
                if(cv.getClave().Equals(c))
                {
                    cv.setValor(c); 
                }
            }
            Clavevalor clavevalor = new Clavevalor(0, c);
            elementos.Add(clavevalor); 
        }

        public Object? ValorDe (Comparable clave)
        {
            foreach (Clavevalor cv in elementos)
            {
                if(cv.getClave().Equals(clave))
                {
                    return cv.getValor();
                }
            }
            return null;
        }

        //Metodos coleccionable Ejercicio 5
        public int cuantos()
        {
            return this.elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable masChico = (Interfaces.Comparable)elementos[0].getValor();
            foreach (Clavevalor cv in elementos)
            {
                if (((Interfaces.Comparable)cv.getValor()).sosMenor(masChico))
                {
                    masChico = (Interfaces.Comparable)cv.getValor();
                }
            }
            return masChico;
        }
        public Comparable maximo()
        {
            Comparable masGrande = (Interfaces.Comparable)elementos[0].getValor();
            foreach (Clavevalor cv in elementos)
            {
                if (((Interfaces.Comparable)cv.getValor()).sosMenor(masGrande))
                {
                    masGrande = (Interfaces.Comparable)cv.getValor();
                }
            }
            return masGrande;
        }

        public bool contiene (Comparable c)
        {
            foreach(Clavevalor cv in this.elementos){
                if(((Interfaces.Comparable)cv.getValor()).sosIgual(c)){
                    return true;
                }
            }
            return false;           
        }

        //Metodos de la interface iterable, ejercicio 6
        public Iterador crearIterador()
        {
            List<Interfaces.Comparable> comparables = new List<Interfaces.Comparable>();
            foreach (Clavevalor cv in elementos)
            {
                Interfaces.Comparable comparable = (Interfaces.Comparable)cv.getValor();
                comparables.Add(comparable);
            }
            Iterador iterador = new ListaIterador(comparables);
            return iterador;
        }


    }
}