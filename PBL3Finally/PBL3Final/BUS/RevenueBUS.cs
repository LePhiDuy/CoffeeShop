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
    public class RevenueBUS
    {
        private static RevenueBUS _Instance;
        public static RevenueBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new RevenueBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private RevenueBUS() { }
        public List<RevenueDTO> GetAllRevenueBUS(int year, int month)
        {
            List<RevenueDTO> revenueList = new List<RevenueDTO>();
            DataTable data = RevenueDAL.Instance.GetAllRevenueDAL(year, month);
            foreach (DataRow row in data.Rows)
            {
                RevenueDTO revenue = new RevenueDTO(row);
                revenueList.Add(revenue);
            }
            return revenueList;
        }
    }
}
