using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace AutoUpdateDashboards
{
    class Program
    {
        static void Main(string[] args)
        {
            const string source = @"C:\Users\Stratton\Downloads\";
            printListValues(addListValues(getFilesFromDownloads(source)));
        }

        static FileInfo[] getFilesFromDownloads(string source)
        {
            DirectoryInfo di = new DirectoryInfo(source);
            FileInfo[] fi = di.GetFiles();
            return fi;
        }

        static List<FileInfo> addListValues(FileInfo[] x)
        {
            List<FileInfo> t = new List<FileInfo>();
            foreach (FileInfo v in x)
            {
                t.Add(v);
            }
            return t;
        }
        static void printListValues(List<FileInfo> w)
        {
            foreach (FileInfo s in w)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
