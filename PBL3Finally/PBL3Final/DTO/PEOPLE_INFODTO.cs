using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PEOPLE_INFODTO
    {
        public int Id { get; set; } 
        public int AccountId{ get; set; }  
        public string FullName { get; set; }    
        public bool Gender { get; set; }    
        public string Address { get; set; } 
        public string Phone { get; set; } 
        public string Email { get; set; }   
        public PEOPLE_INFODTO(int id, int accountId, string fullName, bool Gender, string Address, string phone, string email)
        {
            this.Id = id;
            this.AccountId = accountId;
            this.Email = email; 
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = phone;
            this.Email = email;
            this.FullName = fullName;
        }
        public PEOPLE_INFODTO(DataRow dr)
        {
            this.Id =Convert.ToInt32(dr[0]);   
            this.AccountId = Convert.ToInt32(dr[1]);
            this.FullName = dr[2].ToString();    
            this.Gender = Convert.ToBoolean(dr[3]);  
            this.Address = dr[4].ToString();
            this.Phone = dr[5].ToString();  
            this.Email = dr[6].ToString();    
        }
        public PEOPLE_INFODTO() { }
    }
}
