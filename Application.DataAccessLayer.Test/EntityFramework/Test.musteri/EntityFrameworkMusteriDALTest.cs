using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ;

namespace Application.DataAccessLayer.Test
{
    [TestClass]
    public class EntityFrameworkMusteriDALTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            EntityMusteriDAL dal = new EntityMusteriDAL();

            var result = dal.GetAll();
            Assert.AreEqual(0, result.Count);                     
        }

    }
}
