using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserStore.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.BLL.Infrastructure.Tests
{
    [TestClass()]
    public class OperationDetailsTests
    {
        [TestMethod()]
        public void OperationDetailsTest()
        {
            OperationDetails ol = new OperationDetails(true, "mess", "prop");

            Assert.AreEqual<bool>(ol.Succedeed, true);
            Assert.AreEqual(ol.Message, "mess");
            Assert.AreEqual(ol.Property, "prop");
        }
    }
}