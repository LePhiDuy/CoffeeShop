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
    public class CountBUS
    {
        private static CountBUS _Instance;
        public static CountBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CountBUS();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private CountBUS() { }
        public List<CountDTO> GetAllCountOfFoodBUS(int year, int month)
        {
            List<CountDTO> countList = new List<CountDTO>();
            DataTable data = CountDAL.Instance.GetAllCountOfFoodDAL(year, month);
            foreach (DataRow row in data.Rows)
            {
                CountDTO count = new CountDTO(row);
                countList.Add(count);
            }
            return countList;
        }
        public List<CountDTO> GetAllCountOfRevenueBUS(int year, int month)
        {
            List<CountDTO> countList = new List<CountDTO>();
            DataTable data = CountDAL.Instance.GetAllCountOfRevenueDAL(@year, month);
            foreach (DataRow row in data.Rows)
            {
                CountDTO count = new CountDTO(row);
                countList.Add(count);
            }
            return countList;
        }
        public List<CountDTO> GetAllCountOfBillBUS(int year, int month)
        {
            List<CountDTO> countList = new List<CountDTO>();
            DataTable data = CountDAL.Instance.GetAllCountOfBillDAL(year, month);
            foreach (DataRow row in data.Rows)
            {
                CountDTO count = new CountDTO(row);
                countList.Add(count);
            }
            return countList;
        }
    }
}
