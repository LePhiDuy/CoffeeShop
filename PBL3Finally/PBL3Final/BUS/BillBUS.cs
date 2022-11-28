using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS _Instance;

        public static BillBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BillBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BillBUS() { }
        public List<BillDTO> GetAllBillsBUS()
        {
            List<BillDTO> listBill = new List<BillDTO>();
            DataTable data = BillDAL.Instance.GetAllBillsDAL();
            foreach (DataRow row in data.Rows)
            {
                BillDTO bill = new BillDTO(row);
                listBill.Add(bill);
            }
            return listBill;
        }
    }
}
