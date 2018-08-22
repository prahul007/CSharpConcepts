using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483
{
    //An application will upload data by using HTML form-based encoding.The application uses a method named SendMessage.
    //The SendMessage() method includes the following code. (Line numbers are included for reference only.)
    //The receiving URL accepts parameters as form-encoded values.
    //You need to send the values intA and intB as form-encoded values named aand b, respectively.
    //Which code segment should you insert at line 04?
    //A.    var data = string.Format("a={0}&b={1}", intA, intB);
    //      return client.UploadStringTaskAsync(new Uri(url), data);
    //B.    var data = string.Format("a={0}&b={1}", intA, intB);
    //      return client.UploadFileTaskAsync(new Uri(url), data);
    //C.    var data = string.Format("a={0}&b={1}", intA, intB);
    //      return client.UploadDataTaskAsync(new Uri(url), Encoding.UTF8.GetBytes(data));
    //D.    var nvc = new NameValueCollection() {{"a", intA.ToString()}, {"b", intB.ToString()}};
    //      return client.UploadValuesTaskAsync(new Uri(url), nvc);
    //A.Option A
    //B.Option B
    //C.Option C
    //D.Option D
    //Correct Answer: D
    //Explanation/Reference:
    //Explanation:
    //WebClient.UploadValuesTaskAsync - Uploads the specified name/value collection to the resource identified by the specified URI as an asynchronous operation
    //using a task object. These methods do not block the calling thread.
    //http://msdn.microsoft.com/en-us/library/system.net.webclient.uploadvaluestaskasync.aspx

    public class Question04
    {
        public Task<byte[]> SendMessage(string url, int intA, int intB)
        {
            var client = new WebClient();

            var nvc = new NameValueCollection() { { "a", intA.ToString() }, { "b", intB.ToString() } };
            return client.UploadValuesTaskAsync(new Uri(url), nvc);
        }
    }
}
