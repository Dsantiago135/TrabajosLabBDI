using System;
using System.Collections.Generic;
using System.IO;

namespace Actividad1
{
    internal class clsReader
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
                        varPerson.opSetId(float.Parse(vecValues[0]));
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
    }
}