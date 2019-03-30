using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ;

namespace Application.DataAccessLayer.Test.EntityFramework.Test.musteri
{
    [TestClass]
    public class EntityFrameworkTelefonDALTest
    {
        [TestMethod]
        public void TestMethod2()
        {
            EntityTelefonDAL dal = new EntityTelefonDAL();

            var result = dal.GetAll();

            Assert.AreEqual(0, result.Count);           
        }
    }
}
