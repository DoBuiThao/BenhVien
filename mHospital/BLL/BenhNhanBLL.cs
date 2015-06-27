using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BLL
{
   public class BenhNhanBLL
    {
       public static DataSet GetBenhNhanList(string _strConnection)
       {
           var ds = new DataSet();
           var helper = new BenhNhanDAL();
           ds = helper.fnGetBenhNhanList(_strConnection);
           return ds;
       }
    }
}
