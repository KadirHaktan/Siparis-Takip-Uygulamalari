using Application.BusinessLogicLayer.Abstract;
using Application.BusinessLogicLayer.ValidationRules.FluentValidation.FluentValidation.musteri;
using Application.Core.ValidationTools;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.Entity.Musteri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core.Aspect.postSharp.ValidationAspect;

namespace Application.BusinessLogicLayer.Concart.Concart.musteri
{
    public class MusteriBusinessLogic : IServices<Musteri>
    {
        private IMusteriDAL dal { get; set; }


        public MusteriBusinessLogic(IMusteriDAL dal)
        {
            this.dal = dal;
        }

       

        public Musteri Add(Musteri entity)
        {
            FluentValidationTool.Validate(new MusteriValidation(), entity);
            return dal.Add(entity);
            
        }

        public Musteri Delete(Musteri entity)
        {
            return dal.Delete(entity);
        }

        public List<Musteri> GetAll()
        {
            return dal.GetAll();
        }

        //[FluentValidationAspect(typeof(MusteriValidation))]
        public Musteri Update(Musteri entity)
        {
            //FluentValidationTool.Validate(new MusteriValidation(), entity);
            return dal.Update(entity);
        }

    }
}
