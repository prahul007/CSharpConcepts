using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Exam70483
{
    //Question 2
    //You need to ensure that the ConvertToName() method returns the JSON input string as a Name object.
    //Which code segment should you insert at line 10?
    //A.Return ser.Desenalize (json, typeof(Name));
    //B.Return ser.ConvertToType<Name>(json);
    //C.Return ser.Deserialize<Name>(json);
    //D.Return ser.ConvertToType(json, typeof (Name));
    //Correct Answer: C

    public class Name {
        public int[] Values { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Question2
    {
        public static Name ConvertToName(string json)
        {
           var ser = new JavaScriptSerializer();
            return ser.Deserialize<Name>(json);
        }
    }
}
