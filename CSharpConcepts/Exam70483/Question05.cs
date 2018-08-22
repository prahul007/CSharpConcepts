using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Exam70483
{
    //You are developing an application.The application converts a Location object to a string by using a method named WriteObject.
    //The WriteObject() method accepts two parameters, a Location object and an XmlObjectSerializer object.
    //The application includes the following code. (Line numbers are included for reference only.)
    //You need to serialize the Location object as XML.
    //Which code segment should you insert at line 20?
    //A.New XmlSerializer(typeof(Location))
    //B.New NetDataContractSerializer()
    //C.New BataContractJsonSerializer(typeof (Location))
    //D.New DataContractSerializer(typeof(Location))
    //Correct Answer: D
    //Section: (none)
    //Explanation
    //Explanation/Reference:
    //Explanation:
    //The code is using [DataContract] attribute here so need to used DataContractSerializer class.

    public enum Compass {
        North,
        South,
        East,
        West
    }

    [DataContract]
    public class Location {
        [DataMember]
        public string Label { get; set; }
        [DataMember]
        public Compass Direction { get; set; }
    }

    public class Question05
    {
        public void DoWork()
        {
            var location = new Location { Label = "Test", Direction = Compass.West };
            //Console.WriteLine(WriteObject(location, new DataContractSerializer(typeof(Location))));
        }
    }
}
