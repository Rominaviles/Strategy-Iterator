using System;
using System.Collections.Generic;  
using Interfaces;

namespace classClaveValor
{
    //Clase clavevalor
    public class Clavevalor
    {
        private int clave;
        private Comparable valor;

        public Clavevalor(int clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public int getClave()
        {
            return this.clave;
        }

        public object getValor()
        {
            return this.valor;
        }

        public void setValor(Comparable valor) 
        {
            this.valor = valor;
        }



    }
}
