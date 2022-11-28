using System;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class OrderDAL
    {
        private static OrderDAL _Instance;
        public static OrderDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new OrderDAL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private OrderDAL() { }
        public DataTable GetBillInfo(int tableId)
        {
            int idBill = GetIDFromTableID(tableId);
            string query = string.Format("EXEC get_bill_info @ID = {0}", idBill);
            return DatabaseAccess.Instance.ExecuteQuery(query);
        }
        public int GetIDFromTableID(int tableId)
        {
            return Convert.ToInt32(DatabaseAccess.Instance.ExecuteScalar("SELECT id FROM bill WHERE table_id = '" + tableId + "'ORDER BY id DESC"));
        }
        public void AddNewOrder(int tableId, int accountId, int discount = 0)
        {
            string query = string.Format("INSERT bill (table_id, account_id, bill_date,discount) VALUES ({0}, {1}, '{2}',{3})", tableId, accountId, DateTime.Now, discount);
            DatabaseAccess.Instance.ExecuteNonQuery(query);
        }
        public void AddFoodIntoOrder(int tableId, int foodId)
        {
            int idBill = GetIDFromTableID(tableId);
            int price = FoodDAL.Instance.GetPriceFromID(foodId);
            if (DatabaseAccess.Instance.ExecuteScalar("SELECT * FROM bill_info WHERE bill_id = '" + idBill + "' AND food_id ='" + foodId + "'") == null)
            {
                string queryInsert = string.Format("INSERT INTO bill_info (bill_id, food_id, amount, total) VALUES (N'{0}', N'{1}', N'{2}', N'{3}')", idBill, foodId, 1, price);
                DatabaseAccess.Instance.ExecuteNonQuery(queryInsert);
            }
            else
            {
                string queryAEdit = string.Format("UPDATE bill_info SET amount = amount + 1, total = total + N'{0}' WHERE bill_id = N'{1}' AND food_id = N'{2}'", price, idBill, foodId);
                DatabaseAccess.Instance.ExecuteNonQuery(queryAEdit);
            }
        }
        public void AdjustAmountFood(int tableId, int foodId, string adjust)
        {
            int idBill = GetIDFromTableID(tableId);
            int price = FoodDAL.Instance.GetPriceFromID(foodId);
            if (adjust == "+")
            {
                string queryUpdateIncrease = string.Format("UPDATE bill_info SET amount = amount + 1, total = total + N'{0}' WHERE bill_id = N'{1}' AND food_id = N'{2}'", price, idBill, foodId);
                DatabaseAccess.Instance.ExecuteNonQuery(queryUpdateIncrease);
            }
            else
            {
                string queryUpdateDisincrease = string.Format("UPDATE bill_info SET amount = amount - 1, total = total - N'{0}' WHERE bill_id = N'{1}' AND food_id = N'{2}'", price, idBill, foodId);
                DatabaseAccess.Instance.ExecuteNonQuery(queryUpdateDisincrease);
            }
        }
        public void DelFood(int tableId, int foodId)
        {
            int idBill = GetIDFromTableID(tableId);
            string query = "DELETE FROM bill_info WHERE bill_id = '" + idBill + "' and food_id = '" + foodId + "'";
            DatabaseAccess.Instance.ExecuteNonQuery(query);
        }
    }
}
