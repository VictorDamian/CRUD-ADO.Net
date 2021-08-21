using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_ODONet.DataAccess.Repositories;
using CRUD_ODONet.DataAccess.Contracts;
using CRUD_ODONet.DataAccess.Entities;

namespace CRUD_ODONet.Domain
{
    public class StudentModel:IDisposable
    {
        
        private List<StudentModel> listStudents;

        private int id;
        private string name;
        private string lastName;
        private string cellPhone;

        public int _Id { get => id; set => id = value; }
        public string _Name { get => name; set => name = value; }
        public string _LastName { get => lastName; set => lastName = value; }
        public string _CellPhone { get => cellPhone; set => cellPhone = value; }

        private IStudentRepository studentRepository;
        public StudentModel()
        {
            studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAll()
        {
            var studentModel = studentRepository.GetAll();
            listStudents = new List<StudentModel>();
            foreach(Students item in studentModel)
            {
                listStudents.Add(new StudentModel
                {
                    _Id = item.id,
                    _Name = item.name,
                    _LastName = item.lastname,
                    _CellPhone = item.cellphone
                });
            }
            return listStudents;
        }
        public void Dispose()
        {

        }
    }
}
