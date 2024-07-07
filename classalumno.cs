using System;
using System.Collections.Generic;
using Interfaces;
using Classpersona;
using ClasesMet;
using strategy;

namespace Classalumno
{//Actividad 1, ejercicio 15
    public class Alumno : Persona  
    {
        private int legajo;
        private int promedio;
//Agregacion Strategy
        private EstrategiaComparacion estrategia;

        public Alumno(string n, int d, int l, int p) : base (n, d)
        {
//Estrategia por defecto
            estrategia= new EstrategiaPorDni();
            this.legajo=l;
            this.promedio=p;
        }
//Estrategia setter
        public void setEstrategia(EstrategiaComparacion c)
        {
            estrategia = c;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        public override string ToString()
        {
            return "Nombre: "+ getNombre() + ", Dni: " + getDNI() + ", Legajo: " + getLegajo() + ", Promedio: " + getPromedio();
        }

        //EJERCICIO 18 (Implementacion de la interface comparable)
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, ((Alumno)c)); //this con referencia a Alumno que se invoca de sosIgual
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, ((Alumno)c));
        }

        public override bool SosMayor(Comparable c)
        {
            return estrategia.SosMayor(this, ((Alumno)c));
        }

    }

}