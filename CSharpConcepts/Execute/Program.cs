using System;
using Exam70483;
using System.Collections.Generic;


namespace Execute
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Question1 Q1 = new Question1();
            //Q1.DoWork("Hello");
            //Console.Read();

            //Question 2
            //var json = @"{""FirstName"":""David"",""LastName"":""Jones"",""Values"":[0, 1, 2]}";
            //Name name = Question02.ConvertToName(json);
            //Console.WriteLine(name.FirstName + " " + name.LastName);

            //Question 3
            string sqlConnectionString = @"Data Source=MSDBUAT01\DBServer1;Initial Catalog=euler;user id=webuser;password=perturbed;Connection Lifetime=20; persist security info=true";
            List<Company> lstCompanies = (List<Company>)Question03.GetCustomers(sqlConnectionString);
            lstCompanies.ForEach(c => Console.WriteLine(c.ToString()));
            Console.Read();
        }
    }
}
