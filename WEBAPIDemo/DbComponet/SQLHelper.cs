using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIDemo.DbComponet
{
    public class SQLHelper
    {
      static  IDbConnection connection = new SqlConnection(AppSetting.GetConfig("ConnectionStrings:JingWuTong"));


        public static int Insert()
        {
            

            var result = connection.Execute("Insert into Users values (@UserName, @Email, @Address)",
                                  new { UserName = "jack", Email = "380234234@qq.com", Address = "上海" });

            return 0;
        }
        public static int Insert(string sql)
        {
            var result = connection.Execute(sql);

            return 0;
        }
        public static int InsertBulk()
        {
            var usersList = Enumerable.Range(0, 10).Select(i => new 
            {
                Email = i + "qq.com",
                Address = "安徽",
                UserName = i + "jack"
            });

            var result = connection.Execute("Insert into Users values (@UserName, @Email, @Address)", usersList);
            return 0;
        }



    }
}
