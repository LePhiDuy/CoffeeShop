using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class FoodDAL
    {
        private static FoodDAL _Instance;
        public static FoodDAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new FoodDAL();
                return _Instance;
            }
            private set => Instance = value;
        }
        private FoodDAL() { }
        public List<FoodDTO> GetAllFoodsDAL()
        {
            List<FoodDTO> data = new List<FoodDTO>();
            foreach (DataRow i in DatabaseAccess.Instance.ExecuteQuery("usp_get_foods_list").Rows)
            {
                data.Add(new FoodDTO(i));
            }
            return data;
        }
        public int GetPriceFromID(int id)
        {
            return Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar("SELECT price FROM FOOD WHERE id = '" + id + "'"));
        }
        public int GetIdFromName(string name)
        {
            return Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar("SELECT id FROM FOOD WHERE name = '" + name + "'"));
        }
        public int GetIdToAddDAL()
        {
            string query = "SELECT MAX(iD) FROM food";
            int count = Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar(query));
            return count + 1;
        }
        public bool DeleteFoodDAL(int id)
        {
            string query = string.Format("UPDATE food SET isDelete = 1 WHERE id = {0}", id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditFoodDAL(FoodDTO food)
        {
            string query = string.Format("UPDATE food SET name = N'{0}', price = N'{1}', food_type_id = N'{2}' WHERE id = N'{3}'", food.Name, food.Price, food.FoodTypeId, food.Id);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddFoodDAL(FoodDTO food)
        {
            string query = string.Format("INSERT food (name, price, food_type_id) VALUES (N'{0}', N'{1}', N'{2}')", food.Name, food.Price, food.FoodTypeId);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
