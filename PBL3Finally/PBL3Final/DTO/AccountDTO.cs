using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool AccountType { get; set; }
        public int Id { get; set; }
        public AccountDTO(int id, string username, string password, bool accountType)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.AccountType = accountType;
        }

        public AccountDTO(string userName, string passWord)
        {
            this.Username = userName;
            this.Password = passWord;
        }
        public AccountDTO(DataRow dr)
        {
            this.Id = Convert.ToInt32(dr["id"]);
            this.Username = dr["user_name"].ToString();
            this.Password = dr["pass_word"].ToString();
            this.AccountType = Convert.ToBoolean(dr["account_type"]);
        }
    }
}
