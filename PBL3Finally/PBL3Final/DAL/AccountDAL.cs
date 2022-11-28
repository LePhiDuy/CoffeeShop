using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL _Instance;

        public static AccountDAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AccountDAL();
                return _Instance;
            }
            private set { _Instance = value; }
        }

        private AccountDAL() { }
        public string EncryptPassword(string password, string salt = "coffee")
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = string.Format("{0}{1}", salt, password);
                byte[] saltedPasswordAsBytes = Encoding.UTF8.GetBytes(saltedPassword);
                return Convert.ToBase64String(sha256.ComputeHash(saltedPasswordAsBytes));
            }
        }
        public bool CheckLoginDAL(AccountDTO account)
        {
            string password = EncryptPassword(account.Password);
            string query = "SELECT * FROM account WHERE user_name = '" + account.Username + "' AND pass_word = '" + password + "' AND isDelete = 0";
            DataTable result = DatabaseAccess.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool CheckRoleDAL(AccountDTO account)
        {
            string query = "SELECT account_type FROM account WHERE user_name = '" + account.Username + "' AND isDelete = 0";
            bool result = (bool)DatabaseAccess.Instance.ExecuteScalar(query);
            return result;
        }
        public bool ForgetPasswordDAL(string email)
        {
            bool result = false;
            string query = "SELECT account_id FROM people_info WHERE email = '" + email + "'";
            if (DatabaseAccess.Instance.ExecuteScalar(query) != null)
            {
                int id = (int)DatabaseAccess.Instance.ExecuteScalar(query);
                string NewPassword = Guid.NewGuid().ToString("n").Substring(0, 8);
                string eNewPass = EncryptPassword(NewPassword);
                string queryUpdate = "UPDATE account SET pass_word = '" + eNewPass + "' WHERE id = " + id + "";
                DatabaseAccess.Instance.ExecuteNonQuery(queryUpdate);
                MailMessage mailMessage = new MailMessage("vanfulong@outlook.com", email.Trim());
                mailMessage.Subject = "Password Recovery";
                mailMessage.Body = string.Format("<br /><br />Your new password is {0}.", NewPassword);
                mailMessage.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-mail.outlook.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = "vanfulong@outlook.com";
                NetworkCred.Password = "Vanphulong**";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mailMessage);
                result = true;
            }
            return result;
        }
        public string GenerateNewPassword(string email)
        {
            string newPassword = Guid.NewGuid().ToString("n").Substring(0, 8);
            string eNewPass = EncryptPassword(newPassword);
            MailMessage mailMessage = new MailMessage("vanfulong@outlook.com", email.Trim());
            mailMessage.Subject = "New Password";
            mailMessage.Body = string.Format("<br /><br />Wellcome, your new password is {0}.", newPassword);
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "vanfulong@outlook.com";
            NetworkCred.Password = "Vanphulong**";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mailMessage);
            return eNewPass;
        }
        public string GenerateNewCode(string email)
        {
            string newCode = Guid.NewGuid().ToString("n").Substring(0, 8);
            MailMessage mailMessage = new MailMessage("vanfulong@outlook.com", email.Trim());
            mailMessage.Subject = "Password Recovery";
            mailMessage.Body = string.Format("<br /><br />Your new code is  {0}.", newCode);
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "vanfulong@outlook.com";
            NetworkCred.Password = "Vanphulong**";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mailMessage);
            return newCode;
        }
        public List<AccountDTO> GetAllAccountDAL()
        {
            List<AccountDTO> data = new List<AccountDTO>();
            foreach (DataRow i in DatabaseAccess.Instance.ExecuteQuery("EXEC get_all_account").Rows)
            {
                data.Add(new AccountDTO(i));
            }
            return data;
        }
        public DataTable GetAllAccountByUsernameDAL(string user_name)
        {
            string query = string.Format("EXEC get_all_account_by_user_name @user_name = N'{0}'", user_name);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
        public bool DeleteAcountDAL(int id)
        {
            string query = string.Format("EXEC delete_account @id = N'{0}' ", id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddAccountDAL(AccountDTO account)
        {
            string query = string.Format("EXEC add_account @user_name = N'{0}', @pass_word = N'{1}' , @account_type = N'{2}'", account.Username, account.Password, account.AccountType);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditAccountDAL(AccountDTO account)
        {
            string query = string.Format("EXEC edit_account @id = N'{0}' , @user_name = N'{1}' , @account_type = N'{2}'", account.Id, account.Username, account.AccountType);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ChangePassWordAccountDAL(AccountDTO account)
        {
            string query = string.Format("EXEC change_pass_word_account @id = N'{0}' , @pass_word = N'{1}' ", account.Id, account.Password);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetIdToAddDAL()
        {
            string query = "SELECT MAX(iD) FROM account";
            int count = Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar(query));
            return count + 1;
        }

    }
}
