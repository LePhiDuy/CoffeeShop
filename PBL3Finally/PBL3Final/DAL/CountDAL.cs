using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CountDAL
    {
        private static CountDAL _Instance;
        public static CountDAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CountDAL();
                return _Instance;
            }
            private set => Instance = value;
        }
        private CountDAL() { }
        public DataTable GetAllCountOfFoodDAL(int year, int month)
        {
            string query = string.Format("EXEC calculate_percentage3 @year = N'{0}' , @month = N'{1}'", year, month);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetAllCountOfRevenueDAL(int year, int month)
        {
            string query = string.Format("EXEC calculate_percentage4 @year = N'{0}' , @month = N'{1}'", year, month);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetAllCountOfBillDAL(int year, int month)
        {
            string query = string.Format("EXEC calculate_percentage5 @year = N'{0}' , @month = N'{1}'", year, month);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

