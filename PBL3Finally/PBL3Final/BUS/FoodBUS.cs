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
    public class FoodBUS
    {
        private static FoodBUS _Instance;
        public static FoodBUS Instance
        {
            get
            {
                if (_Instance == null) _Instance = new FoodBUS();
                return _Instance;
            }
            private set => Instance = value;
        }
        private FoodBUS() { }
        public List<FoodDTO> GetAllFoodsBUS(int Food_Type_ID, string txtSearch = "")
        {
            List<FoodDTO> data = new List<FoodDTO>();
            if (Food_Type_ID == 0)
            {
                foreach (FoodDTO foodTDO in FoodDAL.Instance.GetAllFoodsDAL())
                {
                    if (foodTDO.Name.ToLower().Contains(txtSearch.ToLower()))
                    {
                        data.Add(foodTDO);
                    }
                }
            }
            else
            {
                foreach (FoodDTO foodTDO in FoodDAL.Instance.GetAllFoodsDAL())
                {
                    if (foodTDO.FoodTypeId == Food_Type_ID &&
                        foodTDO.Name.ToLower().Contains(txtSearch.ToLower()))
                    {
                        data.Add(foodTDO);
                    }
                }
            }
            return data;
        }

        public DataTable ConvertToDataTable(int Food_Type_ID, string txtSearch = "")
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]{
                new DataColumn { ColumnName = "STT",DataType = typeof(int)},
                new DataColumn { ColumnName = "ID",DataType = typeof(int)},
                new DataColumn { ColumnName = "Tên món", DataType = typeof(string) },
                new DataColumn { ColumnName = "Giá tiền", DataType = typeof(double) },
                new DataColumn { ColumnName = "Loại món", DataType = typeof(string) },
            });
            int index = 1;
            foreach (FoodDTO food in FoodBUS.Instance.GetAllFoodsBUS(Food_Type_ID, txtSearch))
            {
                bool isAdd = false;
                foreach (FoodTypeDTO foodType in FoodTypeBUS.Instance.GetAllFoodTypeBUS())
                {
                    if (food.FoodTypeId == foodType.Id)
                    {
                        data.Rows.Add(index, food.Id, food.Name, food.Price, foodType.Name);
                        isAdd = true;
                        index++;
                        break;
                    }
                }
                if (!isAdd)
                {
                    data.Rows.Add(index, food.Id, food.Name, food.Price, "Chua phan loai");
                    index++;
                }
            }
            return data;
        }
        public List<FoodDTO> GetAllFoodsBUS()
        {
            return FoodDAL.Instance.GetAllFoodsDAL();
        }
        // trả về id của món được thêm mới vào
        public int getIdToAddBUS()
        {
            return FoodDAL.Instance.GetIdToAddDAL();
        }
        public int GetIdFromName(string name)
        {
            return FoodDAL.Instance.GetIdFromName(name);
        }
        public bool DeleteFoodBUS(List<int> del)
        {
            foreach (int i in del)
            {
                if (!FoodDAL.Instance.DeleteFoodDAL(i))
                {
                    return false;
                }
            }
            return true;
        }
        public bool EditFoodBUS(FoodDTO food)
        {
            return FoodDAL.Instance.EditFoodDAL(food);
        }

        public bool AddFoodBUS(FoodDTO food)
        {
            return FoodDAL.Instance.AddFoodDAL(food);
        }
        public bool isAddOrEdit(int id)
        {
            bool isAdd = true;
            foreach (FoodDTO food in GetAllFoodsBUS())
            {
                if (food.Id == id)
                {
                    isAdd = false;
                    break;
                }
            }
            return isAdd;
        }
        public string ExecuteDB(FoodDTO food)
        {
            if (isAddOrEdit(food.Id))
            {
                if (AddFoodBUS(food))
                {
                    return "Bạn đã thêm thành công món " + food.Name + "!";
                }
                else
                {
                    return "Lỗi! Thêm không thành công!";
                }
            }
            else
            {
                if (EditFoodBUS(food))
                {
                    return "Bạn đã thay đổi thông tin món " + food.Name + " thành công!";
                }
                else
                {
                    return "Lỗi! Chỉnh sửa bàn không thành công!";
                }
            }
        }

    }
}
