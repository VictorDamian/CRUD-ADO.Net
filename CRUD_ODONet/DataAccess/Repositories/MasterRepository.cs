using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ODONet.DataAccess
{
    public abstract class MasterRepository:Repository
    {
        public bool ExecuteNonQuery()
        {
            using(var conn = GetConnection())
            { 
                try
                {
                    conn.Open();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
        protected DataTable ExecuteReader(string tranSql)
        {
            using(var conn = GetConnection())
            {
                conn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = tranSql;
                    comm.CommandType = CommandType.Text;
                    SqlDataReader reader = comm.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                        
                }
            }
        }
    }
}
