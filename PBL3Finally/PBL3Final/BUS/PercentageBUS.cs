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
    public class PercentageBUS
    {
        private static PercentageBUS _Instance;
        public static PercentageBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new PercentageBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private PercentageBUS() { }
        public List<PercentageDTO> GetAllPercentagesBUS()
        {
            List<PercentageDTO> percentageList = new List<PercentageDTO>();
            DataTable data = PercentageDAL.Instance.GetAllPercentagesDAL();
            foreach (DataRow row in data.Rows)
            {
                PercentageDTO percentage = new PercentageDTO(row);
                percentageList.Add(percentage);
            }
            return percentageList;
        }
        public List<PercentageDTO> GetAllPercentages2BUS(int year, int month)
        {
            List<PercentageDTO> percentageList = new List<PercentageDTO>();
            DataTable data = PercentageDAL.Instance.GetAllPercentages2DAL(year, month);
            foreach (DataRow row in data.Rows)
            {
                PercentageDTO percentage = new PercentageDTO(row);
                percentageList.Add(percentage);
            }
            return percentageList;
        }
    }
}
