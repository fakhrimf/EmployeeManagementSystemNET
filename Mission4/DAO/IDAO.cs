using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4.DAO
{
    public interface IDAO<T>
    {
        T Get(int id);
        List<T> GetAll();
        int Add(T t);
        int Delete(int id);
        int Update(T t);
    }
}
