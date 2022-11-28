using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class TableDAL
    {
        private static TableDAL _Instance;

        public static TableDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TableDAL();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }
        private TableDAL() { }
        public List<TableDTO> GetAllTableDAL()
        {
            List<TableDTO> data = new List<TableDTO>();
            foreach (DataRow i in DatabaseAccess.Instance.ExecuteQuery("usp_get_table_list").Rows)
            {
                data.Add(new TableDTO(i));
            }
            return data;
        }
        public int GetIdTableByName(string name)
        {
            return Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar("SELECT id FROM coffee_table WHERE name = '" + name + "'"));
        }
        public bool EditTableDAL(TableDTO table)
        {
            string query = string.Format("UPDATE coffee_table SET name = N'{0}', status = N'{1}' where id = {2}", table.Name, table.Status, table.Id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddTableDAL(TableDTO table)
        {
            string query = string.Format("INSERT coffee_table (name, status) VALUES (N'{0}', N'{1}')", table.Name, table.Status);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // trả về id của bàn được thêm mới vào
        public int GetIdToAddDAL()
        {
            string query = "SELECT MAX(id) FROM coffee_table";
            int count = Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar(query));
            return count + 1;
        }
        public bool DeleteTableDAL(int id)
        {
            string query = string.Format("UPDATE coffee_table SET isDelete = 1 WHERE id = {0}", id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
