using System;
using System.Data;

namespace DTO
{
    public class OrderDTO
    {
        public string Food { get; set; }
        public int Amount { get; set; }
        public int Total { get; set; }
        public OrderDTO(string foodId, int amount, int total)
        {
            this.Food = foodId;
            this.Amount = amount;
            this.Total = total;
        }
        public OrderDTO(DataRow r)
        {
            Food = r["name"].ToString();
            Amount = Convert.ToInt32(r["amount"]);
            Total = Convert.ToInt32(r["total"]);
        }
    }
}
