using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIDemo.DbComponet
{
    public class SqlBulk
    {


        #region 方式二
        public static void InsertTwo()
            {
                Console.WriteLine("使用Bulk插入的实现方式");
                DataTable dt = GetTableSchema();

                using (SqlConnection conn = new SqlConnection(AppSetting.GetConfig("ConnectionStrings:JingWuTong")))
                {
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
                    bulkCopy.DestinationTableName = "Users";
                    bulkCopy.BatchSize = dt.Rows.Count;
                    conn.Open();

                    for (int i = 0; i < 50000; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] =i;
                        dr[1] ="username"+i;
                        dr[2] = string.Format("商品", i);
                        dr[3] = "address"+i;
                        dt.Rows.Add(dr);
                    }
                    if (dt != null && dt.Rows.Count != 0)
                    {
                        bulkCopy.WriteToServer(dt);
                    }
                }
            }
             static   DataTable GetTableSchema()
                {
                    DataTable dt = new DataTable();
                    dt.Columns.AddRange(new DataColumn[] {
                    new DataColumn("UserID",typeof(int)),
                    new DataColumn("UserName",typeof(string)),
                    new DataColumn("Email",typeof(string)),
                    new DataColumn("Address",typeof(string))});
                    return dt;
                }
            #endregion



   

    }
}
