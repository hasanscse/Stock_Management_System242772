using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Repository
{
   public class StockRepository
    {

        private string connectionString = @"Server=PC-301-24\SQLEXPRESS; Database=StockManagementDB; Integrated Security= True;";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private string commandString;
        //sqlConnection = new SqlConnection(connectionString);

        public bool Insert(Stock stock)
        {
            bool IsInsert = false;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"INSERT INTO [dbo].[StockManagement]
           ([name])
     VALUES
           ('" + CategoryName.Name + "')";

            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                IsInsert = true;
            }

            return IsInsert;
        }

        public bool IsExists(string IMEI)
        {
            bool IsInsert = false;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"select * from mobiles where IMEI =  '" + IMEI + "'  ";

            sqlCommand = new SqlCommand(commandString, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            if (dataTable.Rows.Count > 0)
            {
                IsInsert = true;
            }
            else
            {
                IsInsert = false;
            }


            return IsInsert;


        }
        public DataTable SearchByPrice(double lowRange, double highRange)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"select * from mobiles where price between " + lowRange + " and " + highRange + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            if (dataTable.Rows.Count > 0)
            {

                return dataTable;
            }

            return dataTable;
        }


    }
}
