using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        //abstract klasöründe tanımladığım bileşenler generic birer service olacaklar. Bu servisler businness tarafında crud operasyonları için gerekli olan metodların çağrılmadan önce imzasını taşıyacak
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);

    }
}
