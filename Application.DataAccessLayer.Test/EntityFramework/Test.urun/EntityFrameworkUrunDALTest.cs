using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.DataAccessLayer.Concart.EntityFramework.URUN;

namespace Application.DataAccessLayer.Test.EntityFramework.Test.urun
{
    [TestClass]
    public class EntityFrameworkUrunDALTest
    {
        [TestMethod]
        public void TestMethod4()
        {
            UrunEntityDAL dal = new UrunEntityDAL();

            var result = dal.GetAll();

            Assert.AreEqual(0, result.Count);
        }
    }
}
