using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RevenueDAL
    {
        private static RevenueDAL _Instance;
        public static RevenueDAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new RevenueDAL();
                return _Instance;
            }
            private set { Instance = value; }
        }
        private RevenueDAL() { }
        public DataTable GetAllRevenueDAL(int year, int month)
        {
            string query = string.Format("EXEC calculate_percentage2 @year = N'{0}' , @month = N'{1}'", year, month);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
