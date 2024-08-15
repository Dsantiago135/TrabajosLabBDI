using System.Collections.Generic;

namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var varListPeople = new List<clsPerson>();
            varListPeople = clsReader.opReadPerson("C: \\Users\\mestr\\Downloads\\facultades\\facultades\\personas.txt");
            varListPeople[2].opShowPerson();
        }
    }
}