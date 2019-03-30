using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core.DataAccessLayer.Concart.Entity_Framework;
using Application.Entity.Musteri;
using Application.DataAccessLayer.Abstract.Müsteri;

namespace Application.DataAccessLayer.Concart.EntityFramework.MUSTERİ
{
    public class EntityAdresDAL:EntityFrameworkRepository<Adres,SiparisContext>,IAdresDAL
    {
    }
}
