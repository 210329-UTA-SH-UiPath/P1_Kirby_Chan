using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface IStoreRepository
    {
        List<Models.Store> GetAllStores();
        Models.Store GetStoreById(int id);
    }

}
