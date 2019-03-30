using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.DataAccessLayer.Concart.EntityFramework.URUN;

namespace Application.DataAccessLayer.Test.EntityFramework.Test.urun
{
    [TestClass]
    public class EntityFrameworkBarkodDALTest
    {
        [TestMethod]
        public void TestMethod5()
        {
            BarkodEntityDAL dal = new BarkodEntityDAL();

            var result = dal.GetAll();

            Assert.AreEqual(2, result.Count);
        }
    }
}
