using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using ClasesMet;
using Classalumno;

namespace strategy
{

    /*Strategy
    1)Crear interface
    2)Implementar subclases donde c/u tiene una estrategia distinta
    3)Modificacion de la clase(contexto) - crear composicion(Atributo)/crear estrategia (Constructor)
     mecanismo para cambiar estrategia (setter)
    4)Delegar la responsabilidad a otro objeto (Alumnos a estrategia)
    */
    //EJERCICIO 1
//Paso 1 de Strategy
    public interface EstrategiaComparacion
    {//Ponemos como parametro los dos alumnos que compara
        bool sosIgual(Alumno c, Alumno c1);
        bool sosMenor(Alumno c, Alumno c1);
        bool SosMayor(Alumno c, Alumno c1);
    }
//Paso 2 de strategy
    //Estrategia para comparar por promedio 
    public class EstrategiaPorPromedio: EstrategiaComparacion
    {
        public bool sosIgual(Alumno c, Alumno c1)
        {
            return c.getPromedio() == c1.getPromedio();
        }
        public bool sosMenor(Alumno c, Alumno c1)
        {
            return c.getPromedio() < c1.getPromedio();
        }
        public bool SosMayor(Alumno c, Alumno c1)
        {
            return c.getPromedio() > c1.getPromedio();
        }
    }

    //Estrategia para comparar por Legajo
    public class EstrategiaPorLegajo: EstrategiaComparacion
    {
        public bool sosIgual(Alumno c, Alumno c1)
        {
            return c.getLegajo() == c1.getLegajo();
        }
        public bool sosMenor(Alumno c, Alumno c1)
        {
            return c.getLegajo() < c1.getLegajo();
        }
        public bool SosMayor(Alumno c, Alumno c1)
        {
            return c.getLegajo() > c1.getLegajo();
        }
    }

    //Estrategia de comparacion por DNI
    public class EstrategiaPorDni: EstrategiaComparacion
    {
        public bool sosIgual(Alumno c, Alumno c1)
        {
            return c.getDNI() == c1.getDNI();
        }
        public bool sosMenor(Alumno c, Alumno c1)
        {
            return c.getDNI() < c1.getDNI();
        }
        public bool SosMayor(Alumno c, Alumno c1)
        {
            return c.getDNI() > c1.getDNI();
        }
    }

    //Estrategia de comparacion por Nombre
    //En mayor y menor lo compare por orden alfabetico
    public class EstrategiaPorNombre: EstrategiaComparacion
    {
        public bool sosIgual(Alumno c, Alumno c1)
        {
            return c.getNombre() == c1.getNombre();
        }
        public bool sosMenor(Alumno c, Alumno c1)//Al ser menor da un num neg
        {
            return string.Compare(c.getNombre(), c1.getNombre()) < 0;
        }
        public bool SosMayor(Alumno c, Alumno c1)//Al ser mayor da un num pos
        {
            return string.Compare(c.getNombre(), c1.getNombre()) > 0;
        }
    }

}
