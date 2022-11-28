using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodTypeDTO(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.Name = Convert.ToString(row["name"]);
        }
        public FoodTypeDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
