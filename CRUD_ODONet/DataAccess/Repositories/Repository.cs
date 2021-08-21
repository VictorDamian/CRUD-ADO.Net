using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ODONet.DataAccess
{
    public abstract class Repository
    {
        private readonly string connectionString;
        public Repository()
        {
            connectionString = "Server = DANTES; database = SCHOOL; Integrated Security = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
