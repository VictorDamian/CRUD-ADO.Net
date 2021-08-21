using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ODONet.DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        IEnumerable<Entity> GetAll();
    }
}
