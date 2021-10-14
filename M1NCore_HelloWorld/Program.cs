using M1NCore_HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace M1NCore_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = ".NET Core Web Con C#";
            int edad = 30;
            double monto = 340.50;

            string salario = "Tres mil dólares americanos (USD)";

            var listado = new List<Persona>();

            var per1 = new Persona();
            per1.dni = "477737323";
            per1.nombre = "Jose Basilio";
            per1.telefono = 82338288;

            var per2 = new Persona()
            {
                dni = "22112211",
                nombre = "Luis Aguero",
                telefono = 9999992
            };

            var per3 = new Persona("33443311", "Cristiano Ronaldo", 3323322);

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(per3);

            Console.WriteLine("Cantidad de personas: " + listado.Count);

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " +
                                    item.nombre + " " +
                                    item.telefono);
            }

            var busqueda = listado.Where(luis => luis.dni == "33443311").FirstOrDefault();

            Console.WriteLine("La persona encontrada es: " + busqueda.nombre);
            Console.WriteLine("********************************");

            Console.WriteLine("Esta es una modificación");

        }
    }
}
