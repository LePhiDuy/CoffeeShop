using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS _Instance;
        public static TableBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TableBUS();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private TableBUS() { }
        public List<TableDTO> GetAllTableBUS(string name = "")
        {
            List<TableDTO> tableList = new List<TableDTO>();
            foreach (TableDTO table in TableDAL.Instance.GetAllTableDAL())
            {
                if (table.Name.ToLower().Contains(name.ToLower()))
                {
                    tableList.Add(table);

                }
            }
            return tableList;
        }
        public int GetIdTableByName(string name)
        {
            return TableDAL.Instance.GetIdTableByName(name);
        }
        public DataTable ConvertToDataTable(string txtNameTable = "")
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]{
                new DataColumn { ColumnName = "STT",DataType = typeof(int)},
                new DataColumn { ColumnName = "Mã bàn ",DataType = typeof(int)},
                new DataColumn { ColumnName = "Tên bàn", DataType = typeof(string) },
                new DataColumn { ColumnName = "Trạng thái", DataType = typeof(string) }
            });
            int index = 1;
            foreach (TableDTO table in GetAllTableBUS(txtNameTable))
            {
                data.Rows.Add(index, table.Id, table.Name, table.Status);
                index++;
            }
            return data;
        }
        public bool EditTableBUS(TableDTO table)
        {
            return TableDAL.Instance.EditTableDAL(table);
        }
        public bool AddTableBUS(TableDTO table)
        {
            return TableDAL.Instance.AddTableDAL(table);
        }
        public bool IsAddOrEdit(int id)
        {
            bool isAdd = true;
            foreach (TableDTO table in GetAllTableBUS())
            {
                if (table.Id == id)
                {
                    isAdd = false;
                    break;
                }
            }
            return isAdd;
        }
        public string ExecuteDB(TableDTO table)
        {
            if (IsAddOrEdit(table.Id))
            {
                if (AddTableBUS(table))
                {
                    return "Bạn đã thêm thành công bàn có tên là " + table.Name + "!";
                }
                else
                {
                    return "Lỗi! Thêm không thành công!";
                }
            }
            else
            {
                if (EditTableBUS(table))
                {
                    return "Bạn đã thay đổi thông tin bàn có tên là " + table.Name + " thành công!";
                }
                else
                {
                    return "Lỗi! Chỉnh sửa bàn không thành công!";
                }
            }
        }
        // trả về id của bàn được thêm mới vào
        public int GetIdToAddBUS()
        {
            return TableDAL.Instance.GetIdToAddDAL();
        }
        public bool DeleteTableBUS(List<int> del)
        {
            foreach (int i in del)
            {
                if (!TableDAL.Instance.DeleteTableDAL(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
