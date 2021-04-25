using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data.Repositories
{
    public class CrustRepository : ICrustRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public CrustRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<Crust> GetAllCrusts()
        {
            var Crusts = context.Crusts;
            return Crusts.Select(mapper.Map).ToList();
        }

        public Crust GetCrustById(int id)
        {
            var Crust = context.Crusts.Where(x => x.ID == id).FirstOrDefault();
            if (Crust == null)
            {
                return null;
            }
            return mapper.Map(Crust);
        }
    }
}
