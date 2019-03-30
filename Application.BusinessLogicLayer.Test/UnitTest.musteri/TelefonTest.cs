using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using Moq;
using Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ;
using Application.BusinessLogicLayer.Concart.Concart.musteri;
using Application.Entity.Musteri;

namespace Application.BusinessLogicLayer.Test.UnitTest.musteri
{
    [TestClass]
    public class TelefonTest
    {
        [ExpectedException(typeof(ValidationException))]
        public void Adding_Test_1()
        {
            Mock<EntityTelefonDAL> dal = new Mock<EntityTelefonDAL>();

            TelefonBusinessLogic logic = new TelefonBusinessLogic(dal.Object);

            logic.Add(new Telefon());
        }

        [ExpectedException(typeof(ValidationException))]
        public void Updating_Test_1()
        {
            Mock<EntityTelefonDAL> dal = new Mock<EntityTelefonDAL>();

            TelefonBusinessLogic logic = new TelefonBusinessLogic(dal.Object);

            logic.Update(new Telefon());
        }
    }
}
