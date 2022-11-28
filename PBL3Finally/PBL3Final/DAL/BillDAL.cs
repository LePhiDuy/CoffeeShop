using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {

        private static BillDAL _Instance;
        public static BillDAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BillDAL();
                return _Instance;
            }
            private set => Instance = value;
        }
        private BillDAL() { }
        public DataTable GetAllBillsDAL()
        {
            DataTable data = DatabaseAccess.Instance.ExecuteQuery("EXEC get_bill");
            return data;
        }
    }
}
