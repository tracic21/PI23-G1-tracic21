using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_manager {
    public class StudentRepository {
        private student CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int.TryParse(reader["Grade"].ToString(), out int grade);
            var student = new student {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };
            return student;

        }

        public student GetStudent(int id) {
            student student = null;
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM students WHERE Id = {id}");
            DB.OpenConnection();
            if (reader.HasRows) {
                reader.Read();
                //student = CreateObject(reader);
                student.Id = Convert.ToInt32(reader["Id"].ToString());
                student.FirstName = reader["FirstName"].ToString();
                student.LastName = reader["LastName"].ToString();
                int.TryParse(reader["Grade"].ToString(), out int grade);
                reader.Close();
            }
            DB.CloseConnection();
            return student;

        }

        public List<student> GetStudents() {
            List<student> students = new List<student>();
            string sql = "SELECT * FROM students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }
    }
}
