using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ;

namespace Application.DataAccessLayer.Test.EntityFramework.Test.musteri
{
    [TestClass]
    public class EntityFrameworkAdresDALTest
    {
        [TestMethod]
        public void TestMethod3()
        {
            EntityAdresDAL dal = new EntityAdresDAL();

            var result = dal.GetAll();

            Assert.AreEqual(0, result.Count);
        }
    }
}
