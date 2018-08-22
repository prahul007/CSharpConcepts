using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Exam70483
{
    //The GetCustomers() method must meet the following requirements:
    //Connect to a Microsoft SQL Server database.
    //Populate Customer objects with data from the database.Return an IEnumerable<Customer> collection 
    //that contains the populated Customer objects.
    //You need to meet the requirements.
    //Which two actions should you perform? (Each correct answer presents part of the solution.
    //Choose two.)
    //A.Insert the following code segment at line 17:
    //  while (sqlDataReader.GetValues())
    //B.Insert the following code segment at line 14:
    //  sqlConnection.Open();
    //C.Insert the following code segment at line 14:
    //  sqlConnection.BeginTransaction();
    //D.Insert the following code segment at line 17:
    //  while (sqlDataReader.Read())
    //E.Insert the following code segment at line 17:
    //  while (sqlDataReader.NextResult())
    //Correct Answer: BD

    public class Company
    {
        public string CompanyName { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return "Company Id: "+ Id + " Company Name: " + CompanyName;
        }
    }

    public class Question03
    {
        const string sqlSelectCustomers = "SELECT TOP 10 company_id, company_name FROM tblCompanies";

        public static IEnumerable<Company> GetCustomers(string sqlConnectionString)
        {
            List<Company> customers = new List<Company>();
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelectCustomers, sqlConnection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while(sqlDataReader.Read())
                    {
                        Company customer = new Company();
                        customer.Id = (int)sqlDataReader["company_id"];
                        customer.CompanyName = (string)sqlDataReader["company_name"];
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }
    }
}
