using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PEOPLE_INFODAL
    {
        private static PEOPLE_INFODAL _Instance;
        public static PEOPLE_INFODAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PEOPLE_INFODAL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private PEOPLE_INFODAL() { }
        public DataTable GetAllPeopleInfoDAL()
        {
            DataTable data = DatabaseAccess.Instance.ExecuteQuery("EXEC get_all_people_info");
            return data;
        }
        public bool DeletePeopleInfoDAL(int accountId)
        {
            string query = string.Format("EXEC delete_people_info @account_id = N'{0}' ", accountId);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddPeopleInfoDAL(PEOPLE_INFODTO peopleInfo)
        {
            string query = string.Format("EXEC add_people_info @name = N'{0}', @gender = N'{1}' , @address = N'{2}', @phone_number = N'{3}', @email = N'{4}'", peopleInfo.FullName, peopleInfo.Gender, peopleInfo.Address, peopleInfo.Phone, peopleInfo.Email);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditPeopleInfoDAL(PEOPLE_INFODTO peopleInfo)
        {
            string query = string.Format("EXEC edit_people_info @account_id = N'{0}', @name = N'{1}', @gender = N'{2}' , @address = N'{3}', @phone_number = N'{4}', @email = N'{5}'", peopleInfo.AccountId, peopleInfo.FullName, peopleInfo.Gender, peopleInfo.Address, peopleInfo.Phone, peopleInfo.Email);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetPeopleInfoByIdAccountDAL(int accountId)
        {
            string query = string.Format("EXEC get_people_info_by_account_id @account_id = N'{0}'", accountId);
            DataTable data = DatabaseAccess.Instance.ExecuteQuery(query);
            return data;
        }
        public bool ChangeEmailDAL(PEOPLE_INFODTO peopleInfo)
        {
            string query = string.Format("EXEC change_email_people_info @ID = N'{0}', @EM = N'{1}' ", peopleInfo.Id, peopleInfo.Email);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
