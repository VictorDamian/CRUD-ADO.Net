using CRUD_ODONet.DataAccess;
using CRUD_ODONet.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ODONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private StudentModel students = new StudentModel();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListStudents();
        }
        private void ListStudents()
        {
            try
            {
                dataGridView1.DataSource = students.getAll();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
