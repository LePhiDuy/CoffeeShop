using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int AccountId { get; set; }
        public DateTime BillDate { get; set; }  
        public BillDTO(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.TableId = Convert.ToInt32(row["table_id"]);
            this.AccountId = Convert.ToInt32(row["account_id"]);
            this.BillDate = Convert.ToDateTime(row["bill_date"]);
        } 
    }
}
