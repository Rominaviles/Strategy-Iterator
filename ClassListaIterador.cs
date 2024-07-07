using System;
using System.Collections.Generic;
using Interfaces;
using Interfaces2;


namespace ClassListaIterador 
{
    public class ListaIterador : Iterador
    {
        private List<Comparable> elementos;

        private int index;

        public ListaIterador(List<Comparable> elem)
        {
            elementos = elem;
            index = 0;
        }

        public void primero()
        {
            this.index=0;
        }
        public void siguiente()
        {
            this.index++;
        }
        public Boolean fin()
        {
            return index == elementos.Count;
        }
        public Comparable actual()
        {
            return elementos[index];
        }

    }
}