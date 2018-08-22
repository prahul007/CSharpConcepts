using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483
{
    //Question 1
    //The DoWork() method must throw an InvalidCastException exception if the obj object is not of type IDataContainer when accessing the Data property.
    //You need to meet the requirements.Which code segment should you insert at line 29?
    //A.var dataContainer = (IDataContainer)obj;
    //B.var dataContainer = obj as IDataContainer;
    //C.var dataContainer = obj is IDataContainer;
    //D.dynamic dataContainer = obj;
    //Correct Answer: A
    


    public interface IDataContainer
    {
        string Data { get; set; }
    }

    public class Question01
    {
        public void DoWork(object obj)
        {
            //var dataContainer = (IDataContainer)obj;
            var dataContainer = (IDataContainer)obj;
            if (dataContainer != null)
            {
                Console.WriteLine(dataContainer.Data);
            }
        }
    }
}
