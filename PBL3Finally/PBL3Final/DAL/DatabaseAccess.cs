using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        private static DatabaseAccess _Instance;

        public static DatabaseAccess Instance 
        { 
            get
            {
                if (_Instance == null) _Instance = new DatabaseAccess(); 
                return DatabaseAccess._Instance; 
            }
            private set { DatabaseAccess._Instance = value; }
        }

        private DatabaseAccess()
        {

        }
        // @"Data Source=DESKTOP-R461SO8\SQLEXPRESS;Initial Catalog=manage_coffee;Integrated Security=True"
        // Data Source=.;Initial Catalog=MANAGE_COFFEE;Integrated Security=True
        private string connSTR = @"Data Source=DESKTOP-R461SO8\SQLEXPRESS;Initial Catalog=manage_coffee;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connSTR))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
            }    
            return data;
        }
        // trả về số dòng thành công
        public int ExecuteNonQuery(string query, object[] parameter = null) 
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connSTR))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                count = command.ExecuteNonQuery();
                conn.Close();
            }
            return count;
        }
        // đếm số lượng trả ra( vi sduj như select count * ...)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connSTR))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
