using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using Application.DataAccessLayer.Concart.EntityFramework.URUN;
using Application.BusinessLogicLayer.Concart.Concart.urun;
using Application.Entity.Urun;
using Moq;

namespace Application.BusinessLogicLayer.Test.UnitTest.urun
{
    [TestClass]
    public class UrunTest
    {
              
        [ExpectedException(typeof(ValidationException))]
        public void Adding_Test_3()
        {
            Mock<UrunEntityDAL> dal = new Mock<UrunEntityDAL>();

            UrunBusinessLogic logic = new UrunBusinessLogic(dal.Object);

            logic.Add(new Urun());
        }

        [ExpectedException(typeof(ValidationException))]
        public void Updating_Test_3()
        {
            Mock<UrunEntityDAL> dal = new Mock<UrunEntityDAL>();

            UrunBusinessLogic logic = new UrunBusinessLogic(dal.Object);

            logic.Update(new Urun());
        }
     }
  }

