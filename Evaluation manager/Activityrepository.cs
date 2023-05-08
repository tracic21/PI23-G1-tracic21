using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_manager {
    public static class Activityrepository {
        private Activity CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int.TryParse(reader["Grade"].ToString(), out int grade);
            var aktivnost = new Activity {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };
            return null;

        }

        public Activity GetStudent(int id) {
            Activity student = null;
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM students WHERE Id = {id}");
            DB.OpenConnection();
            if (reader.HasRows) {
                reader.Read();
                //Activity = CreateObject(reader);
                student.Id = Convert.ToInt32(reader["Id"].ToString());
                student.FirstName = reader["FirstName"].ToString();
                student.LastName = reader["LastName"].ToString();
                int.TryParse(reader["Grade"].ToString(), out int grade);
                reader.Close();
            }
            DB.CloseConnection();
            return student;

        }

        public List<Activity> GetStudents() {
            List<Activity> students = new List<Activity>();
            string sql = "SELECT * FROM students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Activity student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }
    }
}
