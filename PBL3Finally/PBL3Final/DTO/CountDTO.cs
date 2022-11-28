
using System;
using System.Data;

namespace DTO
{
    public class CountDTO
    {
        public int Count { get; set; }
        public CountDTO(DataRow row)
        {
            this.Count = Convert.ToInt32(row["count"]);
        }
    }
}
