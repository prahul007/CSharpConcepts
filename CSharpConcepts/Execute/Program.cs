using System;
using Exam70483;


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
            var json = @"{""FirstName"":""David"",""LastName"":""Jones"",""Values"":[0, 1, 2]}";
            Name name = Question2.ConvertToName(json);
            Console.WriteLine(name.FirstName + " " + name.LastName);
            Console.Read();
        }
    }
}
