using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core.DataAccessLayer.Concart.Entity_Framework;
using Application.Entity.Urun;
using Application.DataAccessLayer.Abstract.Ürün;

namespace Application.DataAccessLayer.Concart.EntityFramework.URUN
{
    public class BarkodEntityDAL:EntityFrameworkRepository<Barkod,SiparisContext>,IBarkodDAL
    {
    }
}
