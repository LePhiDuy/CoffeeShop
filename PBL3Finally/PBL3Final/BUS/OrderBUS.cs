using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class OrderBUS
    {
        private static OrderBUS _Instance = new OrderBUS();
        public static OrderBUS Instance
        {
            get
            {
                if (_Instance == null) _Instance = new OrderBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private OrderBUS() { }
        public List<OrderDTO> GetBillInfoBUS(int tableId)
        {
            List<OrderDTO> list = new List<OrderDTO>();
            DataTable data = OrderDAL.Instance.GetBillInfo(tableId);
            foreach (DataRow row in data.Rows)
            {
                OrderDTO o = new OrderDTO(row);
                list.Add(o);
            }
            return list;
        }
        public void AddNewOrderBUS(int tableId, int accountId,int discount = 0)
        {
            OrderDAL.Instance.AddNewOrder(tableId, accountId, discount);
        }
        public void AddFoodIntoOrderBUS(int tableId, int foodId)
        {
            OrderDAL.Instance.AddFoodIntoOrder(tableId, foodId);
        }
        public void AdjustAmountFood(int tableId,int foodId,string adjust)
        {
            OrderDAL.Instance.AdjustAmountFood(tableId, foodId, adjust);
        }
        public void DelFood(int tableId, int foodId)
        {
            OrderDAL.Instance.DelFood(tableId,foodId);
        }
    }
}
