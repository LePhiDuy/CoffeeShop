using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoodTypeId { get; set; }
        public double Price { get; set; }
        public FoodDTO(int id, string name, int foodTypeId, double price)
        {
            this.Id = id;
            this.Name = name;
            this.FoodTypeId = foodTypeId;
            this.Price = price;
        }
        public FoodDTO(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.Name = Convert.ToString(row["name"]);
            this.Price = Convert.ToInt32(row["price"]);
            this.FoodTypeId = Convert.ToInt32(row["food_type_id"]);
        }
    }
}
