using System;

namespace Actividad1
{
    internal class clsPerson
    {
        #region Attributes
        long attId;
        string attName;
        string attBirthdate;
        string attPhone;
        string attMail;
        string attSalary;
        string attFaculty;
        #endregion
        #region Operations
        #region Setters
        public void opSetId(long prmId)
        {
            this.attId = prmId;
        }
        public void opSetName(string prmName)
        {
            this.attName = prmName;
        }
        public void opSetBirthdate(string prmBirthdate)
        {
            this.attBirthdate = prmBirthdate;
        }
        public void opSetPhone(string prmPhone)
        {
            this.attPhone = prmPhone;
        }
        public void opSetMail(string prmMail)
        {
            this.attMail = prmMail;
        }
        public void opSetSalary(string prmSalary)
        {
            this.attSalary = prmSalary;
        }
        public void opSetFaculty(string prmFaculty)
        {
            this.attFaculty = prmFaculty;
        }
        #endregion
        #region Getters
        public long opGetId()
        {
            return attId;
        }
        public string opGetName()
        {
            return attName;
        }
        public string opGetBirthdate()
        {
            return attBirthdate;
        }
        public string opGetPhone()
        {
            return attPhone;
        }
        public string opGetMail()
        {
            return attMail;
        }
        public string opGetSalary()
        {
            return attSalary;
        }
        public string opGetFaculty()
        {
            return attFaculty;
        }
        #endregion
        #region Utilities
        public void opShowPerson()
        {
            Console.WriteLine("\nDatos  de la persona");
            Console.WriteLine("Cedula:" + opGetId());
            Console.WriteLine("Nombre:" + opGetName());
            Console.WriteLine("Fecha de nacimiento:" + opGetBirthdate());
            Console.WriteLine("Celular:" + opGetPhone());
            Console.WriteLine("Correo:" + opGetMail());
            Console.WriteLine("Salario:" + opGetSalary());
            Console.WriteLine("Facultad:" + opGetFaculty());
        }
        #endregion
        #endregion
    }
}