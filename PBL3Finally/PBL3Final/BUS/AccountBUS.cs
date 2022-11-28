using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS _Instance;
        public static AccountBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AccountBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private AccountBUS() { }
        public bool CheckLoginBUS(AccountDTO account)
        {
            return AccountDAL.Instance.CheckLoginDAL(account);
        }
        public bool ForgetPasswordBUS(string email)
        {
            return AccountDAL.Instance.ForgetPasswordDAL(email);
        }
        public bool CheckRoleBUS(AccountDTO account)
        {
            return AccountDAL.Instance.CheckRoleDAL(account);
        }
        public List<AccountDTO> GetAllAccount(string txtSearch = "")
        {
            List<AccountDTO> data = new List<AccountDTO>();
            foreach (AccountDTO account in AccountDAL.Instance.GetAllAccountDAL())
            {
                if (account.Username.ToLower().Contains(txtSearch.ToLower()))
                {
                    data.Add(account);
                }
            }
            return data;
        }
        public DataTable ConvertToDataTable(string txtSearch = "")
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]{
                new DataColumn { ColumnName = "STT",DataType = typeof(int)},
                new DataColumn { ColumnName = "ID",DataType = typeof(int)},
                new DataColumn { ColumnName = "Tài khoản", DataType = typeof(string) },
                new DataColumn { ColumnName = "Email", DataType = typeof(string) },
                new DataColumn { ColumnName = "Chức vụ", DataType = typeof(bool) },
                new DataColumn { ColumnName = "Tên", DataType = typeof(string) },
                new DataColumn { ColumnName = "Giới tính", DataType = typeof(bool) },
                new DataColumn { ColumnName = "Địa chỉ", DataType = typeof(string) },
                new DataColumn { ColumnName = "Số điện thoại", DataType = typeof(string) },
            });
            int index = 1;
            foreach (AccountDTO account in AccountBUS.Instance.GetAllAccount(txtSearch))
            {
                foreach (PEOPLE_INFODTO peopleinfo in PEOPLE_INFOBUS.Instance.GetAllPeopleInfoBUS())
                {
                    if (account.Id == peopleinfo.AccountId)
                    {
                        data.Rows.Add(index, account.Id, account.Username, peopleinfo.Email, account.AccountType,
                                      peopleinfo.FullName, peopleinfo.Gender, peopleinfo.Address, peopleinfo.Phone);
                        index++;
                    }
                }
            }
            return data;
        }
        public List<AccountDTO> GetAllAccountByUsernameBUS(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            DataTable data = AccountDAL.Instance.GetAllAccountByUsernameDAL(username);
            foreach (DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                accountList.Add(account);
            }
            return accountList;
        }
        public bool DeleteAccountBUS(List<int> del)
        {
            foreach (int i in del)
            {
                if (!AccountDAL.Instance.DeleteAcountDAL(i))
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckAccountInDatabase(string username)
        {
            foreach (AccountDTO account in GetAllAccount())
            {
                if (account.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public string GenerateNewPassword(string email)
        {
            return AccountDAL.Instance.GenerateNewPassword(email);
        }
        public bool AddAccountBUS(AccountDTO account)
        {
            return AccountDAL.Instance.AddAccountDAL(account);
        }
        public bool EditAccountBUS(AccountDTO account)
        {
            return AccountDAL.Instance.EditAccountDAL(account);
        }
        public string EncryptPassword(string password, string salt = "coffee")
        {
            return AccountDAL.Instance.EncryptPassword(password, salt);
        }
        public bool ChangePassWordAccountBUS(AccountDTO account)
        {
            return AccountDAL.Instance.ChangePassWordAccountDAL(account);
        }
        public string GenerateNewCode(string email)
        {
            return AccountDAL.Instance.GenerateNewCode(email);
        }
        public int getIdToAddBUS()
        {
            return AccountDAL.Instance.GetIdToAddDAL();
        }
    }
}
