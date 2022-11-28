using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PEOPLE_INFOBUS
    {
        private static PEOPLE_INFOBUS _Instance;
        public static PEOPLE_INFOBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new PEOPLE_INFOBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private PEOPLE_INFOBUS() { }
        public List<PEOPLE_INFODTO> GetAllPeopleInfoBUS()
        {
            List<PEOPLE_INFODTO> peopleinfoList = new List<PEOPLE_INFODTO>();
            DataTable data = PEOPLE_INFODAL.Instance.GetAllPeopleInfoDAL();
            foreach (DataRow row in data.Rows)
            {
                PEOPLE_INFODTO pi = new PEOPLE_INFODTO(row);
                peopleinfoList.Add(pi);
            }
            return peopleinfoList;
        }
        public bool DeletePeopleInfoBUS(int accountID)
        {
            return PEOPLE_INFODAL.Instance.DeletePeopleInfoDAL(accountID);
        }
        public bool AddPeopleInfoBUS(PEOPLE_INFODTO peopleInfo)
        {
            return PEOPLE_INFODAL.Instance.AddPeopleInfoDAL(peopleInfo);
        }
        public bool EditPeopleInfoBUS(PEOPLE_INFODTO peopleInfo)
        {
            return PEOPLE_INFODAL.Instance.EditPeopleInfoDAL(peopleInfo);
        }
        public List<PEOPLE_INFODTO> GetPeopleInfoByIdAccountBUS(int accountId)
        {
            List<PEOPLE_INFODTO> peopleinfoList = new List<PEOPLE_INFODTO>();
            DataTable data = PEOPLE_INFODAL.Instance.GetPeopleInfoByIdAccountDAL(accountId);
            foreach (DataRow row in data.Rows)
            {
                PEOPLE_INFODTO pi = new PEOPLE_INFODTO(row);
                peopleinfoList.Add(pi);
            }
            return peopleinfoList;
        }
        public bool ChangeEmailDAL(PEOPLE_INFODTO peopleInfo)
        {
            return PEOPLE_INFODAL.Instance.ChangeEmailDAL(peopleInfo);
        }
    }
}
