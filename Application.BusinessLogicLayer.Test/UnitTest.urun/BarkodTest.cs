using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using Moq;
using Application.DataAccessLayer.Concart.EntityFramework.URUN;
using Application.BusinessLogicLayer.Concart.Concart.urun;
using Application.Entity.Urun;

namespace Application.BusinessLogicLayer.Test.UnitTest.urun
{
    [TestClass]
    public class BarkodTest
    {
        [ExpectedException(typeof(ValidationException))]
        public void Adding_Test_3()
        {
            Mock<BarkodEntityDAL> dal = new Mock<BarkodEntityDAL>();

            BarkodBusinessLogic logic = new BarkodBusinessLogic(dal.Object);

            logic.Add(new Barkod());
        }

        [ExpectedException(typeof(ValidationException))]
        public void Updating_Test_3()
        {
            Mock<BarkodEntityDAL> dal = new Mock<BarkodEntityDAL>();

            BarkodBusinessLogic logic = new BarkodBusinessLogic(dal.Object);

            logic.Update(new Barkod());
        }

    }
}
