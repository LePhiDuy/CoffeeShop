using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PercentageDTO
    {
        public string Name { get; set; }
        public double Percentage { get; set; }
        public PercentageDTO(DataRow row)
        {
            this.Name = Convert.ToString(row["name"]);
            this.Percentage = Convert.ToDouble(row["count"]);
        }
    }
}
