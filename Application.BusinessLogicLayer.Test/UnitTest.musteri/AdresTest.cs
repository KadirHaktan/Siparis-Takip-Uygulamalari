using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using Moq;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.BusinessLogicLayer.Concart.Concart.musteri;
using Application.Entity.Musteri;

namespace Application.BusinessLogicLayer.Test.UnitTest.musteri
{
    [TestClass]
    public class AdresTest
    {
        [ExpectedException(typeof(ValidationException))]
        public void Adding_Test()
        {
            Mock<IAdresDAL> dal = new Mock<IAdresDAL>();

            AdresBusinessLogic logic = new AdresBusinessLogic(dal.Object);

            logic.Add(new Adres());
        }

        [ExpectedException(typeof(ValidationException))]
        public void Updating_Test()
        {
            Mock<IAdresDAL> dal = new Mock<IAdresDAL>();

            AdresBusinessLogic logic = new AdresBusinessLogic(dal.Object);


            logic.Update(new Adres());

            
        }
    }
}
