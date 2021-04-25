using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public StoreRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<Store> GetAllStores()
        {
            var Stores = context.Stores;
            return Stores.Select(mapper.Map).ToList();
        }

        public Store GetStoreById(int id)
        {
            var Store = context.Stores.Where(x => x.ID == id).FirstOrDefault();
            if (Store == null)
            {
                return null;
            }
            return mapper.Map(Store);
        }
    }
}
