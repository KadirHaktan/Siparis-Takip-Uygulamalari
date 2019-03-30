using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Application.BusinessLogicLayer.Abstract;
using Application.Entity.Musteri;
using Application.BusinessLogicLayer.Concart.Concart.musteri;
using Application.Entity.Urun;
using Application.BusinessLogicLayer.Concart.Concart.urun;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ;
using Application.DataAccessLayer.Abstract.Ürün;
using Application.DataAccessLayer.Concart.EntityFramework.URUN;

namespace Application.BusinessLogicLayer.Depency_Injection_Tools.ninject
{
   public class BusinessModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IServices<Musteri>>().To<MusteriBusinessLogic>();
            Bind<IServices<Adres>>().To<AdresBusinessLogic>();
            Bind<IServices<Telefon>>().To<TelefonBusinessLogic>();


            Bind<IServices<Urun>>().To<UrunBusinessLogic>();
            Bind<IServices<Barkod>>().To<BarkodBusinessLogic>();


            Bind<IMusteriDAL>().To<EntityMusteriDAL>();
            Bind<IAdresDAL>().To<EntityAdresDAL>();
            Bind<ITelefonDAL>().To<EntityTelefonDAL>();

            Bind<IUrunDAL>().To<UrunEntityDAL>();
            Bind<IBarkodDAL>().To<BarkodEntityDAL>();


        }
    }
}
