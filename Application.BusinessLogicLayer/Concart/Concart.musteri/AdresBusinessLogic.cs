using Application.BusinessLogicLayer.Abstract;
using Application.Entity.Musteri;
using Application.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.musteri;
using Application.Core.ValidationTools;
using Application.Core.Aspect.postSharp.ValidationAspect;

namespace Application.BusinessLogicLayer.Concart.Concart.musteri
{
    public class AdresBusinessLogic : IServices<Adres>
    {
        private IAdresDAL dal { get; set; }

        public AdresBusinessLogic(IAdresDAL dal)
        {
            this.dal = dal;
        }

        //[FluentValidationAspect(typeof(AdresValidation))]
        public Adres Add(Adres entity)
        {
            //FluentValidationTool.Validate(new AdresValidation(), entity);
            return dal.Add(entity);
        }

        public Adres Delete(Adres entity)
        {
            return dal.Delete(entity);
        }

        public List<Adres> GetAll()
        {
            return dal.GetAll();
        }

        //[FluentValidationAspect(typeof(AdresValidation))]
        public Adres Update(Adres entity)
        {
            //FluentValidationTool.Validate(new AdresValidation(), entity);
            return dal.Update(entity);
        }

    }
}
