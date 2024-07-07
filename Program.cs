using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using strategy;
using Interfaces;
using Classpersona;
using Classcola;
using Classpila;
using Classalumno;
using Classnumero;
using Classcoleccion;
using Interfaces2;
using Microsoft.VisualBasic;
using classconjunto;
using classdiccionario;
using classClaveValor;

namespace ClasesMet
{
    class Program
//CLASE1
    {
        private static Random rdm = new Random();
        private const int RangoMin= 1;
        private const int RangoMax = 50;
        private const int DNImin= 10000000;
        private const int DNImax= 99999999;
        private const int LegajoMin= 1;
        private const int LegajoMax= 10000;
        private const int PromedioMin= 1;
        private const int PromedioMax= 10;

        public static void informar(Coleccionable c)
        {
            Console.WriteLine("La cantidad de elementos  que contiene son: " + "\n" + c.cuantos());
            Console.WriteLine("El elemento minimo es: " +"\n" + c.minimo());
            Console.WriteLine("El elemento maximo es: " + "\n" + c.maximo());
            Console.WriteLine("Ingrese el siguiente dato para verificar su existencia");
            //Console.Write("Nombre:");
            //string nombre = Console.ReadLine()??"";
            Console.Write("Dni:");
            int dni = int.Parse(Console.ReadLine()??"");
            //Console.Write("Legajo: ");
            //int legajo = int.Parse(Console.ReadLine()??"");


            Comparable num = new Alumno("",dni,0,0);
            //Comparable num= new Alumno("",0,legajo,0);
            //Comparable num= new Alumno(nombre,0,0,0);
            if (c.contiene (num))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }


        }
        //EJERCICIO 12
        public static void llenarPersonas (Coleccionable c)
        {
            int cont=0;
            while (cont<20)
            {
                string nombre= NombreAleatorio();
                int dni= rdm.Next(DNImin,DNImax);                
                c.agregar(new Persona(nombre, dni));
                cont++;
            }           
        }

        public static void llenarAlumnos(Coleccionable c)
        {
            int cont=0;
            while (cont<20)
            {
                string nombre = NombreAleatorio();
                int dni = rdm.Next(DNImin, DNImax);
                int legajo = rdm.Next(LegajoMin, LegajoMax);
                int promedio = rdm.Next(PromedioMin, PromedioMax);
                Alumno alumno= new Alumno(nombre, dni, legajo, promedio);
                c.agregar(alumno);
                cont++;
            }  
        }

        //Funcion adicional para generar nombre aleatorio
        public static string NombreAleatorio()
        {
            List<string> nombre= new List<string>{"Tomas","Ramon","Felipe","Julian","Benjamin","Sam","Sarah","Jazmin","Tamara","Melody","Joel"};
            return nombre[rdm.Next(nombre.Count)];
        }


//CLASE 2
        //EJERCICIO 2
        public static void llenarAlumnos1(Coleccionable c,EstrategiaComparacion s)
        {
            int cont = 0;
            while (cont < 20)
            {
                string nombre = NombreAleatorio();
                int dni = rdm.Next(DNImin, DNImax);
                int legajo = rdm.Next(LegajoMin, LegajoMax);
                int promedio = rdm.Next(PromedioMin, PromedioMax);
                Alumno alumno= new Alumno(nombre, dni, legajo, promedio);
                alumno.setEstrategia(s);
                c.agregar(alumno);
                cont++;
            }
        }

        //EJERCICIO 7

        public static void ImprimirElementos(Iterable c)
        {
            Iterador it = c.crearIterador();
            it.primero();
            while (!it.fin())
            {
                Comparable elem = it.actual();
                Console.WriteLine(elem.ToString());
                it.siguiente();
            }

        }
        
        //Ejercicio 9
        public static void CambiarEstrategia(Iterable c, EstrategiaComparacion s)
        {
            Iterador iterador= c.crearIterador();
            iterador.primero();
            while(!iterador.fin())
            {
                ((Alumno)iterador.actual()).setEstrategia(s);
                iterador.siguiente();
                 
            }
        }

        
        static void Main(string[] args)
        {
            //Ejercicio 8
            Pila pila= new Pila();
            Cola cola= new Cola();
            Conjunto conjunto= new Conjunto();
            Diccionario diccionario= new Diccionario();
            
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            llenarAlumnos(diccionario);

            Console.WriteLine("Elementos de la pila:");
            ImprimirElementos(pila);
            Console.WriteLine("\nElementos de la cola:");
            ImprimirElementos(cola);
            Console.WriteLine("\nElementos del conjunto:");
            ImprimirElementos(conjunto);
            Console.WriteLine("\nElementos del diccionario:");
            ImprimirElementos(diccionario);

            CambiarEstrategia(pila, new EstrategiaPorDni());
            Console.WriteLine("\nMínimo y máximo elemento con estrategia de comparación por DNI:");
            informar(pila);

            //CambiarEstrategia(pila, new EstrategiaPorLegajo());
            //Console.WriteLine("\nMínimo y máximo elemento con estrategia de comparación por legajo:");
            //informar(pila);
            
            //CambiarEstrategia(pila, new EstrategiaPorNombre());
            //Console.WriteLine("\nMínimo y máximo elemento con estrategia de comparación por nombre:");
            //informar(pila);

        }
    }


}