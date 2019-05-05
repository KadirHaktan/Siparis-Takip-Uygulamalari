using Application.BusinessLogicLayer.Abstract;
using Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.urun;
using Application.Core.Aspect.postSharp.ValidationAspect;
using Application.Core.ValidationTools;
using Application.DataAccessLayer.Abstract.Ürün;
using Application.Entity.Urun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.Concart.Concart.urun
{
    public class BarkodBusinessLogic : IServices<Barkod>
    {
        private IBarkodDAL dal { get; set; }



        public BarkodBusinessLogic(IBarkodDAL dal)
        {
            this.dal = dal;
        }

        [FluentValidationAspect(typeof(BarkodValidation))]
        public Barkod Add(Barkod entity)
        {
            //FluentValidationTool.Validate(new BarkodValidation(), entity);
            return dal.Add(entity);
        }

        public Barkod Delete(Barkod entity)
        {
            return dal.Delete(entity);
        }

        public List<Barkod> GetAll()
        {
            return dal.GetAll();
        }

        //[FluentValidationAspect(typeof(BarkodValidation))]
        public Barkod Update(Barkod entity)
        {
            //FluentValidationTool.Validate(new BarkodValidation(), entity);
            return dal.Update(entity);
        }
    }
}
