using System;
using System.Data;
namespace DTO
{
    public class TableDTO
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }
        public TableDTO() { }
        public TableDTO(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;   
            this.Status = status; 
        }
        public TableDTO(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.Name = Convert.ToString(row["name"]);
            this.Status = Convert.ToString(row["status"]);
        }
    }
}
