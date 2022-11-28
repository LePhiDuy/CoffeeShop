using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PercentageDAL
    {
        private static PercentageDAL _Instance;
        public static PercentageDAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new PercentageDAL();
                return _Instance;
            }
            private set => Instance = value;
        }
        private PercentageDAL() { }
        public DataTable GetAllPercentagesDAL()
        {
            DataTable data = DatabaseAccess.Instance.ExecuteQuery("EXEC calculate_percentage");
            return data;
        }
        public DataTable GetAllPercentages2DAL(int year, int month)
        {
            string query = string.Format("EXEC calculate_percentage1 @year = N'{0}' , @month = N'{1}'", year, month);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
