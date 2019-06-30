using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanySetup.Models;

namespace CompanySetup
{
    public class CompanyRepository
    {
        private string connectionString = @"Server=DESKTOP-1L9A1TR; Database=CompanyUi; Integrated Security=True";
        private SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;


        public int Insert(Company company)
        {
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            commandString = @"INSERT INTO Companys (CompanyName) VALUES ('" + company.CompanyName + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                MessageBox.Show("Save Successfully!");
            }
            else
            {
                MessageBox.Show("Save Faild!");
            }
            sqlConnection.Close();
            return isExecuted;
        }

        public DataTable ShowCompany()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"SELECT * FROM Companys";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

       
    }
}
