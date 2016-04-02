using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;

namespace DBCommunicating
{
    public class DataBaseController
    {
        private SqlConnection connection;
        public DataBaseController ( )
        {
        }
        public void AddOrder ( Orders o )
        {
            using(connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HackCompany"].ConnectionString))
            {
                connection.Open();
                string findIDQuery =
                                @"SELECT *
                                  FROM [Orders]
                                  WHERE Orders.OrderID = " + o.OrderID;
                var commandFind = new SqlCommand(findIDQuery , connection);
                string affectedRows = commandFind.ExecuteScalar().ToString();
                string query = null;
                if(affectedRows !=null)
                {
                    query = string.Format(
                        @"UPDATE Orders
                          SET OrderID = {0},
                          DateOfOrder = {1},
                          TotalPrice = {2},
                          CustomerID = {3}
                          WHERE OrderID = {4}" , o.OrderID , o.DateOfOrder.ToString("yyyy-MM-dd") , o.TotalPrice , o.CustomerID , o.OrderID);
                    var commandUpdate = new SqlCommand(query , connection);
                    Console.WriteLine("Updated {0}" , commandUpdate.ExecuteNonQuery());
                }
                else
                {
                    query = string.Format(
                        @"INSERT INTO Orders
                          VALUES ({0},{1},{2},{3})" , o.OrderID , o.DateOfOrder.ToString("yyyy-MM-dd") , o.TotalPrice , o.CustomerID , o.OrderID);
                    var commandAdd = new SqlCommand(query , connection);
                    Console.WriteLine("Added {0}" , commandAdd.ExecuteNonQuery());
                }
            }

        }
    }
}
