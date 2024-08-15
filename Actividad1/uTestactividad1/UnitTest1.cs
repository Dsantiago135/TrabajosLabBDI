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
            varListPeople.Sort();
            #endregion
            #region test & assert

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
