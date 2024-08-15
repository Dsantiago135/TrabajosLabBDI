using System;
using System.Collections.Generic;
using System.IO;

namespace Actividad1
{
    internal class clsSeparateFunctions
    {
        public static List<clsPerson> opReadPerson(string prmfilepath)
        {
            var ListPeople = new List<clsPerson>();

            try
            {
                using (StreamReader varReader = new StreamReader(prmfilepath))
                {
                    string varLine;

                    while ((varLine = varReader.ReadLine()) != null)
                    {
                    string[] vecValues = varLine.Split(',');
                    clsPerson varPerson = new clsPerson();
                    varPerson.opSetId(long.Parse(vecValues[0]));
                    varPerson.opSetName(vecValues[1]);
                    varPerson.opSetBirthdate(vecValues[2]);
                    varPerson.opSetPhone(vecValues[3]);
                    varPerson.opSetMail(vecValues[4]);
                    varPerson.opSetSalary(vecValues[5]);
                    varPerson.opSetFaculty(vecValues[6]);
                    ListPeople.Add(varPerson);
                    }
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("Archivo no encontrado");
            }
            catch (IOException)
            {
                Console.WriteLine("Ocurrió un problema al leer el archivo");
            }
            return ListPeople;
        }
        public static clsPerson opBinarySearchById(List<clsPerson> prmList, long prmId)
        {
            int varLeft = 0;
            int varRight = prmList.Count - 1;

            while (varLeft <= varRight)
            {
                int mid = varLeft + (varRight - varLeft) / 2;
                clsPerson midPerson = prmList[mid];

                if (midPerson.opGetId() == prmId)
                {
                    Console.WriteLine("\nPersona encontrada");
                    return midPerson;
                }
                else if (midPerson.opGetId() < prmId)
                {
                    varLeft = mid + 1;
                }
                else
                {
                    varRight = mid - 1;
                }
            }
            // Si no se encuentra, devolver null o un valor por defecto
            Console.WriteLine("\nPersona no encontrada");
            return null;
        }
    }
}