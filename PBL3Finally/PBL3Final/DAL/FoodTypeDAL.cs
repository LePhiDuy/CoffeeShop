using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodTypeDAL
    {
        private static FoodTypeDAL _Instance;
        public static FoodTypeDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FoodTypeDAL();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }
        private FoodTypeDAL() { }
        public List<FoodTypeDTO> GetAllFoodTypeDAL()
        {
            List<FoodTypeDTO> data = new List<FoodTypeDTO>();
            foreach (DataRow i in DatabaseAccess.Instance.ExecuteQuery("usp_get_food_type_list").Rows)
            {
                data.Add(new FoodTypeDTO(i));
            }
            return data;
        }
        // trả về id của loại món ăn được thêm mới vào
        public int GetIdToAddDAL()
        {
            string query = "SELECT MAX(id) FROM food_type";
            int count = Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar(query));
            return count + 1;
        }
        public bool DeleteFoodTypeDAL(int id)
        {
            string query = string.Format("UPDATE food_type SET isDelete = 1 WHERE id = {0}", id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditFoodTypeDAL(FoodTypeDTO foodType)
        {
            string query = string.Format("UPDATE food_type SET name = N'{0}' WHERE ID = {1}", foodType.Name, foodType.Id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddFoodTypeDAL(FoodTypeDTO foodType)
        {
            string query = string.Format("INSERT food_type(name) VALUES (N'{0}')", foodType.Name);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
