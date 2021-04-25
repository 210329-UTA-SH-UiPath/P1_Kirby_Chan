using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        private readonly Entities.PizzaBoxContext context;
        IMapper mapper = new Mapper();
        public SizeRepository(Entities.PizzaBoxContext context)
        {
            this.context = context;
        }
        public List<Size> GetAllSizes()
        {
            var Sizes = context.Sizes;
            return Sizes.Select(mapper.Map).ToList();
        }

        public Size GetSizeById(int id)
        {
            var Size = context.Sizes.Where(x => x.ID == id).FirstOrDefault();
            if (Size == null)
            {
                return null;
            }
            return mapper.Map(Size);
        }
    }
}
