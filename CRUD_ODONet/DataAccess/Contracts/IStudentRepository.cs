using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_ODONet.DataAccess.Entities;

namespace CRUD_ODONet.DataAccess.Contracts
{
    public interface IStudentRepository:IGenericRepository<Students>
    {
    }
}
