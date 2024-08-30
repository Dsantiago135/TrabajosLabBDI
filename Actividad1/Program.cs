using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var varListPeople = new List<clsPerson>();
            varListPeople = clsSeparateFunctions.opReadPerson("C:\\Users\\mestr\\OneDrive\\Documents\\Santi\\Repositorios\\TrabajosLabBDI\\Actividad1\\facultades\\personas.txt");
            Console.WriteLine("\nBusqueda arreglo sin ordenar ");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            clsSeparateFunctions.opSequentialShearchById(varListPeople, 2708826453);
            stopwatch.Stop();
            TimeSpan elapsedTime1 = stopwatch.Elapsed;
            Console.WriteLine($"El tiempo de ejecución fue: {elapsedTime1.TotalMilliseconds} milisegundos.");

            varListPeople.Sort((a, b) => a.opGetId().CompareTo(b.opGetId()));

            Console.WriteLine("\nBusqueda arreglo ordenado ");
            stopwatch.Reset();
            stopwatch.Start();
            clsSeparateFunctions.opBinarySearchById(varListPeople, 9999927604);
            stopwatch.Stop();
            TimeSpan elapsedTime2 = stopwatch.Elapsed;
            Console.WriteLine($"El tiempo de ejecución fue: {elapsedTime2.TotalMilliseconds} milisegundos.");

            Console.ReadLine();
        }
    }
}