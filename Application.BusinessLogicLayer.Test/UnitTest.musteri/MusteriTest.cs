using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using Moq;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.BusinessLogicLayer.Concart.Concart.musteri;
using Application.Entity.Musteri;

namespace Application.BusinessLogicLayer.Test
{
    [TestClass]
    public class MusteriTest
    {
        [ExpectedException(typeof(ValidationException))]
        public void Adding_Test_2()
        {
            Mock<IMusteriDAL> dal = new Mock<IMusteriDAL>();

            MusteriBusinessLogic logic = new MusteriBusinessLogic(dal.Object);

            logic.Add(new Musteri());
        }

        [ExpectedException(typeof(ValidationException))]
        public void Updating_Test_2()
        {
            Mock<IMusteriDAL> dal = new Mock<IMusteriDAL>();

            MusteriBusinessLogic logic = new MusteriBusinessLogic(dal.Object);

            logic.Update(new Musteri());
        }
    }
}
