using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core.DataAccessLayer.Concart.Entity_Framework;
using Application.DataAccessLayer.Abstract.Müsteri;
using Application.Entity.Musteri;

namespace Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ
{
   public class EntityMusteriDAL:EntityFrameworkRepository<Musteri,SiparisContext>,IMusteriDAL
    {

    }
}
