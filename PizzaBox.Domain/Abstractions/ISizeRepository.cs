using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Domain.Abstractions
{
    public interface ISizeRepository
    {
        List<Models.Size> GetAllSizes();
        Models.Size GetSizeById(int id);
    }
}
