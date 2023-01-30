using System;                       ///using statatemen if faded it is not being use
using System.IO;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/using System.Net;
using static System.Net.Mime.MediaTypeNames;


////site:microsoft.com write to a text file c# ---search at URL bing.com
//msdn(microsoft development network)--primary source of info. for software devs for ms platform.
namespace AssembliesAndNamespaces           ///"namespace" - class like a surname
{
    class Program
    {
        static void Main(string[] args)
        {
          // string text =           ///file path creation of this text
            //"A class is the most powerful data type in C#. Like a structure, " +
            //"a class defines the data and behavior of the data type. ";
            //"We want to write this to our file.";

            //site:microsoft.com c# download html string

            //await File.WriteAllTextAsync("WriteText.txt", text);
           // File.WriteAllText(@"C:\Lesson17\WriteText.txt", text);

            WebClient client = new WebClient(); ///for auto download to file path
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Lesson17\WriteText.txt", reply);
            // Console.WriteLine("Hello world!"); //System.Console class is the fullname of Console
            Console.ReadLine();
        }
    }
}