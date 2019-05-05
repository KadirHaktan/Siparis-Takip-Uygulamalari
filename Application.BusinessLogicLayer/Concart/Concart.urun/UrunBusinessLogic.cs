using Application.BusinessLogicLayer.Abstract;
using Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.urun;
using Application.Core.Aspect.postSharp.ValidationAspect;
using Application.DataAccessLayer.Abstract.Ürün;
using Application.Entity.Urun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.Concart.Concart.urun
{
    public class UrunBusinessLogic : IServices<Urun>
    {
        private IUrunDAL dal { get; set; }

        public UrunBusinessLogic(IUrunDAL dal)
        {
            this.dal = dal;
        }

        [FluentValidationAspect(typeof(UrunValidation))]
        public Urun Add(Urun entity)
        {
            return dal.Add(entity);
        }

        public Urun Delete(Urun entity)
        {
            return dal.Delete(entity);
        }

        public List<Urun> GetAll()
        {
            return dal.GetAll();
        }

        //[FluentValidationAspect(typeof(UrunValidation))]
        public Urun Update(Urun entity)
        {
            return dal.Update(entity);
        }
    }
}
