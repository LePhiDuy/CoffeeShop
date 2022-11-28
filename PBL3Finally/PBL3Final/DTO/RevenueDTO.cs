using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RevenueDTO
    {
        public int Day { get; set; }
        public double Revenue { get; set; }
        public RevenueDTO(DataRow row)
        {
            this.Day = Convert.ToInt32(row["day"]);
            this.Revenue = Convert.ToDouble(row["count"]);
        }
    }
}
