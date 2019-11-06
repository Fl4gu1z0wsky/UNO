using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO.Tests
{
    /// <summary>
    /// Unit test to see if every cards are selected for the game
    /// </summary>
    [TestClass()]
    public class DBConnectionTests
    {
        
        [TestMethod()]
        public void GetIdCards_GetAllTheDataOfDataBase_Result_108()
        {
            DBConnection test = new DBConnection();

            int valueExpected = 108;

            int valueCalculated = test.GetIdCards().Count;

            Assert.AreEqual(valueExpected, valueCalculated);
        }

    }
}