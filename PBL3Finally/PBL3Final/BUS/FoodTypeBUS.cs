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
    public class FoodTypeBUS
    {
        private static FoodTypeBUS _Instance;
        public static FoodTypeBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FoodTypeBUS();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private FoodTypeBUS() { }
        public List<FoodTypeDTO> GetAllFoodTypeBUS(string txtSearch = "")
        {
            List<FoodTypeDTO> data = new List<FoodTypeDTO>();
            foreach (FoodTypeDTO foodType in FoodTypeDAL.Instance.GetAllFoodTypeDAL())
            {
                if (foodType.Name.ToLower().Contains(txtSearch.ToLower()))
                {
                    data.Add(foodType);
                }
            }
            return data;
        }
        public DataTable ConvertToDataTableFoodType(string txtSearch = "")
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]{
                new DataColumn { ColumnName = "STT",DataType = typeof(int)},
                new DataColumn { ColumnName = "ID",DataType = typeof(int)},
                new DataColumn { ColumnName = "Tên loại món ăn", DataType = typeof(string) },
            });
            int index = 1;
            foreach (FoodTypeDTO foodType in GetAllFoodTypeBUS(txtSearch))
            {
                data.Rows.Add(index, foodType.Id, foodType.Name);
                index++;
            }
            return data;
        }
        public bool DeleteFoodTypeBUS(List<int> del)
        {
            foreach (int i in del)
            {
                if (!FoodTypeDAL.Instance.DeleteFoodTypeDAL(i))
                {
                    return false;
                }
            }
            return true;
        }
        public bool isAddOrEdit(int id)
        {
            bool isAdd = true;
            foreach (FoodTypeDTO foodType in GetAllFoodTypeBUS())
            {
                if (foodType.Id == id)
                {
                    isAdd = false;
                    break;
                }
            }
            return isAdd;
        }
        public string ExecuteDB(FoodTypeDTO foodType)
        {
            if (isAddOrEdit(foodType.Id))
            {
                if (AddFoodTypeBUS(foodType))
                {
                    return "Bạn đã thêm thành công loại món:  " + foodType.Name + "!";
                }
                else
                {
                    return "Lỗi! Thêm không thành công!";
                }

            }
            else
            {
                if (EditFoodTypeBUS(foodType))
                {
                    return "Bạn đã thay đổi thông tin loại món " + foodType.Name + " thành công!";
                }
                else
                {
                    return "Lỗi! Chỉnh sửa bàn không thành công!";
                }
            }
        }
        public bool EditFoodTypeBUS(FoodTypeDTO foodType)
        {
            return FoodTypeDAL.Instance.EditFoodTypeDAL(foodType);
        }
        public bool AddFoodTypeBUS(FoodTypeDTO foodType)
        {
            return FoodTypeDAL.Instance.AddFoodTypeDAL(foodType);
        }
        public int GetIdToAddBUS()
        {
            return FoodTypeDAL.Instance.GetIdToAddDAL();
        }
        public List<CBBItem> GetAllCBBItem()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (FoodTypeDTO foodTypeDTO in FoodTypeDAL.Instance.GetAllFoodTypeDAL())
            {
                data.Add(new CBBItem
                {
                    Value = foodTypeDTO.Id,
                    Text = foodTypeDTO.Name
                });
            }
            return data;
        }
    }
}
