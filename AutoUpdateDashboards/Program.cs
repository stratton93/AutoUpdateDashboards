using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AutoUpdateDashboards
{
    class Program
    {

        static void printListValues(FileInfo[] w)
        {
            foreach (FileInfo s in w)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }

        static void Main(string[] args)
        {
            //The source stays the same no matter what. Unless dir is changed this needs to change.
            const string source = @"C:\Users\Stratton\Downloads\";
            string date = DateTime.Today.ToString("MM-dd-yyyy");
            //The dest var won't be constant because this needs to happen everday.
            string dest = Path.Combine(@"C:\Users\Stratton\Desktop\Dashboards\", date + @"\");
        }
    }
}
