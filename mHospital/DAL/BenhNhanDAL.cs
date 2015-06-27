using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class BenhNhanDAL
    {
        public DataSet fnGetBenhNhanList(string _strConn)
        {
            var conn = new ConnectionDB(_strConn);
            try
            {
                conn.CallStoredProcedureFromDB("spGetBenhNhanList");
                conn.Reader = conn.Command.ExecuteReader();

                var myTable = new DataTable("GetBenhNhanListTable");
                myTable.Columns.Add("MaBenhNhan", typeof(string));
                myTable.Columns.Add("TenBenhNhan", typeof(string));
                myTable.Columns.Add("CMND", typeof(string));
                myTable.Columns.Add("NgaySinh", typeof(string));
                myTable.Columns.Add("DiaChi", typeof(string));
                myTable.Columns.Add("SDT", typeof(string));
                myTable.Columns.Add("MaPhongKham", typeof(string));

                while (conn.Reader.Read())
                {
                    myTable.Rows.Add(new[]
                                     {
                                         conn.Reader["MaBenhNhan"].ToString(),
                                         conn.Reader["TenBenhNhan"].ToString(),
                                         conn.Reader["CMND"].ToString(),
                                         conn.Reader["NgaySinh"].ToString(),
                                         conn.Reader["DiaChi"].ToString(),
                                         conn.Reader["SDT"].ToString(),
                                         conn.Reader["MaPhongKham"].ToString()
                                     });
                }
                myTable.AcceptChanges();
                var ds = new DataSet();
                ds.Tables.Add(myTable);
                ds.AcceptChanges();
                return ds;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.Connection.Close();
            }
        }

    }
}
