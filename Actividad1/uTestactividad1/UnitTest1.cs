using Microsoft.VisualStudio.TestTools.UnitTesting;
using Actividad1;
using System.Collections.Generic;

namespace uTestactividad1
{
    [TestClass]
    public class UnitTest1
    {
        static List<clsPerson> varListPeople;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            varListPeople = clsSeparateFunctions.opReadPerson("C:\\Users\\mestr\\Downloads\\facultades\\facultades\\personas.txt");
        }
        [TestMethod]
        public void testBinarySearhSortedList()
        {
            #region Setup
            clsPerson varPerson = new clsPerson();
            varListPeople.Sort((a, b) => a.opGetId().CompareTo(b.opGetId()));
            varPerson = clsSeparateFunctions.opBinarySearchById(varListPeople, 1306354264);
            #endregion
            #region test & assert
            Assert.AreEqual(1306354264, varPerson.opGetId());
            Assert.AreEqual(" Ignacio Palacios", varPerson.opGetName());
            Assert.AreEqual(" 12/07/1980", varPerson.opGetBirthdate());
            Assert.AreEqual(" 34963777", varPerson.opGetPhone());
            Assert.AreEqual(" ignacio.palacios@gmail.com", varPerson.opGetMail());
            Assert.AreEqual(" 4300000", varPerson.opGetSalary());
            Assert.AreEqual(" 8", varPerson.opGetFaculty());
            #endregion
        }
        [TestMethod]
        public void testBinarySearhNoSortedList()
        {
            #region Setup
            #endregion
            #region test & assert
            #endregion
        }
    }
}
