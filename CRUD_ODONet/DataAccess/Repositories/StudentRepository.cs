using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_ODONet.DataAccess.Entities;
using CRUD_ODONet.DataAccess.Contracts;

namespace CRUD_ODONet.DataAccess.Repositories
{
    public class StudentRepository:MasterRepository, IStudentRepository
    {
        private string selectAll;
        public StudentRepository()
        {
            selectAll = "select * from STUDENTS";
        }
        public IEnumerable<Students> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listStudents = new List<Students>();
            foreach(DataRow item in tableResult.Rows)
            {
                listStudents.Add(new Students
                {
                    id = Convert.ToInt32(item[0]),
                    name = item[1].ToString(),
                    lastname = item[2].ToString(),
                    cellphone = item[3].ToString(),
                });
            }
            return listStudents;
        }
    }
}
