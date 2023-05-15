using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Evaluation_manager {
    public static class TeacherRepository {
        public static Teacher GetTeacher (string username) {
            string sql = $"SELECT * FROM Teachers WHERE = '{username}'";
            return FetchTeacher(sql);
        }

        public static Teacher FetchTeacher(string sql) {
            Teacher teacher = null;
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM Teacher WHERE  = '{sql}'");
            DB.OpenConnection();
            if (reader.HasRows) {
                reader.Read();
                teacher.Id = Convert.ToInt32(reader["Id"].ToString());
                teacher.FirstName = reader["FirstName"].ToString();
                teacher.LastName = reader["LastName"].ToString();
                teacher.Username = reader["Username"].ToString();
                teacher.Password = reader["Password"].ToString();
                reader.Close();
            }
            DB.CloseConnection();
            return teacher;
        }
        private static Teacher CreateObject(SqlDataReader reader) {
            Teacher teacher = new Teacher();
            teacher.Id = Convert.ToInt32(reader["Id"].ToString());
            teacher.FirstName = reader["FirstName"].ToString();
            teacher.LastName = reader["LastName"].ToString();
            teacher.Username = reader["Username"].ToString();
            teacher.Password = reader["Password"].ToString();
            reader.Close();
        }
    }
}
