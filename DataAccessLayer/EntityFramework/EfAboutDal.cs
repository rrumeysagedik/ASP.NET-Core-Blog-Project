using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal:GenericRepository<About>, IAboutDal
    {
        //ilerleyen zamanlarda temel crud operasyonları dışında sadece bu entity'e ait işlemlerin yapılacağı interface burası olacak.
    }
}
