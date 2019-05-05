using Application.BusinessLogicLayer.Abstract;
using Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.musteri;
using Application.Core.Aspect.postSharp.ValidationAspect;
using Application.Core.ValidationTools;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.Entity.Musteri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogicLayer.Concart.Concart.musteri
{
    public class TelefonBusinessLogic : IServices<Telefon>
    {
        private ITelefonDAL dal { get; set; }

        public TelefonBusinessLogic(ITelefonDAL dal)
        {
            this.dal = dal;
        }

        [FluentValidationAspect(typeof(TelefonValidation))]
        public Telefon Add(Telefon entity)
        {
           //FluentValidationTool.Validate(new TelefonValidation(), entity);
           return dal.Add(entity);
        }

        public Telefon Delete(Telefon entity)
        {
            return dal.Delete(entity);
        }

        public List<Telefon> GetAll()
        {
            return dal.GetAll();
        }

        //[FluentValidationAspect(typeof(TelefonValidation))]
        public Telefon Update(Telefon entity)
        {
            //FluentValidationTool.Validate(new TelefonValidation(), entity);
            return dal.Update(entity);
        }

    }
}
